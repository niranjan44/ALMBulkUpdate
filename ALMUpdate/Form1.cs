using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace ALMUpdate
{
    public partial class frmALMRun : Form
    {
        XMLOperations xmlOpertations;
        public frmALMRun()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            try
            {

                xmlOpertations = new XMLOperations();

                AddAutoComplete2TextBoxes();

            }
            catch (Exception ex)
            {

            }

        }
        OtaApiActions otaObject = null;



        private void LogOut()
        {
            lblRunStatus.Text = string.Empty;
            this.lblRunStatus.ForeColor = System.Drawing.Color.Red;
            lbErrorMessage.Text = "Logging out.Please wait...";
            btnRun.Enabled = false;
            Application.DoEvents();
            if (otaObject != null)
            {
                otaObject.disconnect();
                otaObject = null;
            }
            lbErrorMessage.Text = string.Empty;
            btnLogin.Text = "Login";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                lbErrorMessage.Text = string.Empty;

                if (btnLogin.Text == "Logout")
                {
                    //tbPassword.Text = string.Empty;
                    LogOut();

                    return;
                }


                lbErrorMessage.Text = "Login attempted. Please wait...";
                Application.DoEvents();

                string server = tbServerName.Text.Trim();
                string username = tbUsername.Text.Trim();
                string password = tbPassword.Text.Trim();
                string domain = tbDomain.Text.Trim();
                string project = tbProject.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)
                    || string.IsNullOrEmpty(domain) || string.IsNullOrEmpty(project))
                {
                    lbErrorMessage.Text = "Cannot login. Please provide complete details";
                    return;
                }


                otaObject = new OtaApiActions();
                otaObject.connectToServer(server, username, password, domain, project);
                btnRun.Enabled = true;
                btnCreateReleseCycle.Enabled = true;
                lbErrorMessage.Text = string.Empty;
                btnLogin.Text = "Logout";

            }
            catch (Exception ex)
            {
                btnRun.Enabled = false;
                lbErrorMessage.Text = ex.Message;
            }

        }

        private void frmALMRun_Load(object sender, EventArgs e)
        {
            this.cbUpdateStatus.SelectedIndex = 0;
            this.tbUsername.Select();
        }

        private void frmALMRun_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                LogOut();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnRun.Text == "Cancel Run")
                {
                    btnRun.Enabled = false;
                    backgroundWorker1.CancelAsync();
                    return;
                }

                string testfolder = tbTestFolder.Text.Trim();
                string status = cbUpdateStatus.Text;
                string priority = cbPriority.Text;

                if (string.IsNullOrEmpty(testfolder) ||string.IsNullOrEmpty(status) )
                {
                    lblRunStatus.Text = "Please provide test folder path and status";
                    return;
                }
                else if (testfolder.Contains('/'))
                {
                    lblRunStatus.Text = "Please provide the folder path with back slash";
                    return;
                }
                

                string[] testHierarchy= testfolder.Split('\\');
                if (testHierarchy.Count() <=5)
                {
                    DialogResult result = MessageBox.Show(this,testfolder, "Are you sure the provided folder path is intended", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                   if(result == DialogResult.No||result== DialogResult.Cancel||
                       result==DialogResult.Abort)
                    return;
                }

                lblRunStatus.Text = "Running.......";
                btnRun.Text = "Cancel Run";
                Application.DoEvents();
                

                StringDictionary dictinary = new StringDictionary();
                dictinary.Add("testfolder", testfolder);
                dictinary.Add("status", status);
                dictinary.Add("priority", priority);
                this.lblRunStatus.ForeColor = System.Drawing.Color.Green;
                backgroundWorker1.RunWorkerAsync(dictinary);
                

                // Thread runThread = new Thread(new threadstartotaObject.RunTestSet(testfolder));

                
                //otaObject.RunTestSet(testfolder);
                
            }
            catch (Exception ex)
            {
                lblRunStatus.Text = ex.Message;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker worker = sender as BackgroundWorker;
                StringDictionary arguments = e.Argument as StringDictionary;
                string testfolder = arguments["testfolder"];
                string status = arguments["status"];
                string priority = arguments["priority"];
                if(!cbUpdateTestset.Checked)
                otaObject.RunTestSet(testfolder, status, worker, e);
                else
                    otaObject.RunSingleTestSet(testfolder, status,priority, worker, e);
            }
            catch (Exception)
            {
                e.Cancel = true;
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblRunStatus.Text = e.ProgressPercentage + " tescases updated";
            //Application.DoEvents();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null)
                {
                    this.lblRunStatus.ForeColor = System.Drawing.Color.Red;
                    lblRunStatus.Text = e.Error.ToString();
                }
                else if (e.Cancelled)
                {
                    lblRunStatus.Text = "Run Cancelled.";
                }
                else
                {
                   // lblRunStatus.Text = "Run Completed.";

                    if (e.Result is Exception)
                    {
                        Exception ex = e.Result as Exception;
                        this.lblRunStatus.ForeColor = System.Drawing.Color.Red;
                        lblRunStatus.Text = ex.Message;
                    }
                    else if (e != null && e.Result != null)
                    {
                        int testcasesUpdated = Convert.ToInt32(e.Result);
                        if (testcasesUpdated >= 0)
                            lblRunStatus.Text = "Run Completed " + e.Result.ToString() + " testcases updated";
                    }
                }
                                
            }
            catch (Exception ex)
            {
                this.lblRunStatus.ForeColor = System.Drawing.Color.Red;
                lblRunStatus.Text = ex.Message;
            }
            finally
            {
                btnRun.Enabled = true;
                btnRun.Text = "Start Run";
            }
        }

      

      

        string YY; string MM; string DD; string intake;
        private void btnCreateReleseCycle_Click(object sender, EventArgs e)
        {
            try
            {
                lblReleaseError.Text = "";
                btnCreateReleseCycle.Enabled = false;
                string intakeid = tbIntake.Text.Trim();

                string releaseName = tbReleaseName.Text;
                string cycleName = tbCycleName.Text;
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;
                string testFolder = tbReleaseFolder.Text.Trim();

                

                if (endDate.Date<startDate.Date)
                {
                    lblReleaseError.Text = "End Date cannot be less than Start Date";
                    btnCreateReleseCycle.Enabled = true;
                    return;
                }

              
             
                string message = CreateReleaseCycle(intakeid, releaseName, cycleName, startDate, endDate, testFolder, rbDOCSIS.Checked);
                lblReleaseError.Text = message;

                if (xmlOpertations != null && !string.IsNullOrEmpty(releaseName) && !string.IsNullOrEmpty(cycleName))
                {
                    xmlOpertations.AddToAutoCompleteSource("ReleaseNames", releaseName);
                    xmlOpertations.AddToAutoCompleteSource("CycleNames", cycleName);
                }


            }
            catch(Exception ex)
            {
                lblReleaseError.Text = ex.Message;
                btnCreateReleseCycle.Enabled = true;
            }

        }

        private string  CreateReleaseCycle(string intakeid, string releaseName, string cycleName, DateTime startDate, DateTime endDate, string releaseFolder, bool docsis)
        {
            //Task task = new Task(otaObject.CreateReleaseCycle(intakeids, tbReleaseName.Text, tbCycleName.Text, startDate, endDate, releaseFolder));
           string message = otaObject.CreateReleaseCycle(intakeid, tbReleaseName.Text, tbCycleName.Text, startDate, endDate, releaseFolder, docsis);


            btnCreateReleseCycle.Enabled = true;
            return message;
           

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (!radioButton.Checked)
                return;

            DateTime startDate = dtpStartDate.Value;
            YY = startDate.Year.ToString();
            MM = startDate.Month.ToString();
            DD = startDate.Day.ToString();
            intake = tbIntake.Text.Trim();

            if (DD.ToString().Length == 1)
                DD = "0" + DD;
            if(MM.ToString().Length == 1)
                MM = "0" + MM;

            switch (radioButton.Text)
            {
                case "RR":
                    tbReleaseName.Text = "RR_DOCSIS" + "_" + YY + MM + DD + "_" + intake;
                    tbCycleName.Text = "RR" + "_" + YY + MM + DD + "_" + intake + " DOCSIS";
                    break;

                case "pCW":
                    tbReleaseName.Text = "PC" + "_"+ "DOCSIS" + "_"+YY +MM+DD+"_"+intake;
                    tbCycleName.Text = "pCW" + YY + "-" + MM + "-" + DD + "_" + intake + " DOCSIS";
                    break;

                case "CW":
                    tbReleaseName.Text = "CW" + "_" + "DOCSIS" + "_" + YY + MM + DD + "_" + intake;
                    tbCycleName.Text = "CW" + YY + "-" + MM + "-" + DD + "_" + intake + " DOCSIS";
                    break;

                case "eCW":
                    tbReleaseName.Text = "EC" + "_" + "DOCSIS" + "_" + YY + MM + DD + "_" + intake;
                    tbCycleName.Text = "eCW" + YY + "-" + MM + "-" + DD + "_" + intake + " DOCSIS";
                    break;

                case "IOT":
                    tbReleaseName.Text = "IOTA" + "_" + "DOCSIS" + "_" + YY + MM + DD + "_" + intake;
                    tbCycleName.Text = "IOTA" + YY + "-" + MM + "-" + DD + "_" + intake + " DOCSIS";
                    break;

                default:
                    break;
            }
        }

        private void tbIntake_TextChanged(object sender, EventArgs e)
        {
            RadioButton rb = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r=>r.Checked);
            if(rb!=null)
            radioButton_CheckedChanged(rb, null);
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            RadioButton rb = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r=>r.Checked);
            if (rb != null)
                radioButton_CheckedChanged(rb, null);
        }

        private void tbIntake_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar))
            {
                MessageBox.Show(this,"Please enter only digits","Message");
                e.Handled = true;
            }
        }

        private void cbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!cbUpdateTestset.Checked)
            {
                if(cbPriority.SelectedIndex!=-1)
                {
                    MessageBox.Show("Priority filter only works while updating a TestSet");
                    cbPriority.SelectedIndex = -1;
                }
            }
        }

        private void cbUpdateTestset_CheckedChanged(object sender, EventArgs e)
        {
            if(!cbUpdateTestset.Checked)
            {
                cbPriority.SelectedIndex = -1;
            }
        }

        private void AddAutoComplete2TextBoxes()
        {
            {
                tbReleaseName.AutoCompleteMode = AutoCompleteMode.Suggest;
                tbReleaseName.AutoCompleteSource = AutoCompleteSource.CustomSource;

                var collection = new AutoCompleteStringCollection();
                collection.AddRange(xmlOpertations.ReadAutoSource("ReleaseNames"));

                tbReleaseName.AutoCompleteCustomSource = collection;
            }


            {
                tbCycleName.AutoCompleteMode = AutoCompleteMode.Suggest;
                tbCycleName.AutoCompleteSource = AutoCompleteSource.CustomSource;

                var collection = new AutoCompleteStringCollection();
                collection.AddRange(xmlOpertations.ReadAutoSource("CycleNames"));

                tbCycleName.AutoCompleteCustomSource = collection;
            }
        }


      
    }
}
