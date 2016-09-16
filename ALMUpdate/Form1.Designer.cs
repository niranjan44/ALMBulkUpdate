namespace ALMUpdate
{
    partial class frmALMRun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbServerName = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbDomain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbProject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbErrorMessage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTestFolder = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblRunStatus = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.cbUpdateStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbReleaseFolder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbIntake = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.rbRapidRegression = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbIOT = new System.Windows.Forms.RadioButton();
            this.rbeCW = new System.Windows.Forms.RadioButton();
            this.rbFullCert = new System.Windows.Forms.RadioButton();
            this.rbPartialCert = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.tbReleaseName = new System.Windows.Forms.TextBox();
            this.tbCycleName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCreateReleseCycle = new System.Windows.Forms.Button();
            this.lblReleaseError = new System.Windows.Forms.Label();
            this.cbUpdateTestset = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbVoice = new System.Windows.Forms.RadioButton();
            this.rbDOCSIS = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server :";
            // 
            // tbServerName
            // 
            this.tbServerName.Location = new System.Drawing.Point(66, 18);
            this.tbServerName.Margin = new System.Windows.Forms.Padding(2);
            this.tbServerName.Name = "tbServerName";
            this.tbServerName.Size = new System.Drawing.Size(342, 20);
            this.tbServerName.TabIndex = 3;
            this.tbServerName.Text = "https://almcomcast.saas.hpe.com/qcbin";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(95, 54);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(154, 20);
            this.tbUsername.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username  :";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(95, 82);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(154, 20);
            this.tbPassword.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password  :";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(454, 55);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(96, 42);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbDomain
            // 
            this.tbDomain.Location = new System.Drawing.Point(326, 55);
            this.tbDomain.Margin = new System.Windows.Forms.Padding(2);
            this.tbDomain.Name = "tbDomain";
            this.tbDomain.Size = new System.Drawing.Size(108, 20);
            this.tbDomain.TabIndex = 10;
            this.tbDomain.Text = "PE_QA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Domain  :";
            // 
            // tbProject
            // 
            this.tbProject.Location = new System.Drawing.Point(326, 78);
            this.tbProject.Margin = new System.Windows.Forms.Padding(2);
            this.tbProject.Name = "tbProject";
            this.tbProject.Size = new System.Drawing.Size(108, 20);
            this.tbProject.TabIndex = 12;
            this.tbProject.Text = "QA_VOICE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Project  :";
            // 
            // lbErrorMessage
            // 
            this.lbErrorMessage.AutoSize = true;
            this.lbErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lbErrorMessage.Location = new System.Drawing.Point(16, 129);
            this.lbErrorMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbErrorMessage.Name = "lbErrorMessage";
            this.lbErrorMessage.Size = new System.Drawing.Size(0, 17);
            this.lbErrorMessage.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Test Folder Path :";
            // 
            // tbTestFolder
            // 
            this.tbTestFolder.Location = new System.Drawing.Point(104, 175);
            this.tbTestFolder.Margin = new System.Windows.Forms.Padding(2);
            this.tbTestFolder.Multiline = true;
            this.tbTestFolder.Name = "tbTestFolder";
            this.tbTestFolder.Size = new System.Drawing.Size(428, 36);
            this.tbTestFolder.TabIndex = 15;
            this.tbTestFolder.Text = "Root\\Active\\Advanced_CPE\\DOCSIS\\2016_Archive\\RR20160301";
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRun.Enabled = false;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(454, 230);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(96, 42);
            this.btnRun.TabIndex = 16;
            this.btnRun.Text = "Start Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblRunStatus
            // 
            this.lblRunStatus.AutoEllipsis = true;
            this.lblRunStatus.AutoSize = true;
            this.lblRunStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunStatus.ForeColor = System.Drawing.Color.Red;
            this.lblRunStatus.Location = new System.Drawing.Point(17, 279);
            this.lblRunStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRunStatus.Name = "lblRunStatus";
            this.lblRunStatus.Size = new System.Drawing.Size(0, 17);
            this.lblRunStatus.TabIndex = 17;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // cbUpdateStatus
            // 
            this.cbUpdateStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdateStatus.FormattingEnabled = true;
            this.cbUpdateStatus.Items.AddRange(new object[] {
            "Passed",
            "Failed",
            "Blocked"});
            this.cbUpdateStatus.Location = new System.Drawing.Point(66, 227);
            this.cbUpdateStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbUpdateStatus.Name = "cbUpdateStatus";
            this.cbUpdateStatus.Size = new System.Drawing.Size(92, 21);
            this.cbUpdateStatus.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 230);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Status :";
            // 
            // tbReleaseFolder
            // 
            this.tbReleaseFolder.AutoCompleteCustomSource.AddRange(new string[] {
            "Releases",
            "Releases\\Active",
            "Releases\\Active\\Advanced CPE",
            "Releases\\Active\\Advanced CPE\\Vocie\\Managed_Services",
            "Releases\\Active\\Advanced CPE\\Vocie\\FTE_Services",
            "Releases\\Active\\Advanced CPE\\DOCSIS\\Managed_Services",
            "Releases\\Active\\Advanced CPE\\DOCSIS\\Managed_Services\\2016_Certifications"});
            this.tbReleaseFolder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbReleaseFolder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbReleaseFolder.Location = new System.Drawing.Point(134, 355);
            this.tbReleaseFolder.Margin = new System.Windows.Forms.Padding(2);
            this.tbReleaseFolder.Multiline = true;
            this.tbReleaseFolder.Name = "tbReleaseFolder";
            this.tbReleaseFolder.Size = new System.Drawing.Size(428, 36);
            this.tbReleaseFolder.TabIndex = 23;
            this.tbReleaseFolder.Text = "Releases\\Active\\Advanced CPE\\DOCSIS\\Managed_Services\\2016_Certifications";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 363);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Release Folder Path :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 404);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Intake ID: ";
            // 
            // tbIntake
            // 
            this.tbIntake.Location = new System.Drawing.Point(88, 404);
            this.tbIntake.Margin = new System.Windows.Forms.Padding(2);
            this.tbIntake.Name = "tbIntake";
            this.tbIntake.Size = new System.Drawing.Size(152, 20);
            this.tbIntake.TabIndex = 25;
            this.tbIntake.TextChanged += new System.EventHandler(this.tbIntake_TextChanged);
            this.tbIntake.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIntake_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 444);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Start Date: ";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MM-dd-yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(427, 441);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(135, 20);
            this.dtpStartDate.TabIndex = 27;
            this.dtpStartDate.TabStop = false;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "MM-dd-yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(427, 478);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(135, 20);
            this.dtpEndDate.TabIndex = 29;
            this.dtpEndDate.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(360, 482);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "End Date: ";
            // 
            // rbRapidRegression
            // 
            this.rbRapidRegression.AutoSize = true;
            this.rbRapidRegression.Location = new System.Drawing.Point(11, 16);
            this.rbRapidRegression.Margin = new System.Windows.Forms.Padding(2);
            this.rbRapidRegression.Name = "rbRapidRegression";
            this.rbRapidRegression.Size = new System.Drawing.Size(41, 17);
            this.rbRapidRegression.TabIndex = 30;
            this.rbRapidRegression.TabStop = true;
            this.rbRapidRegression.Text = "RR";
            this.rbRapidRegression.UseVisualStyleBackColor = true;
            this.rbRapidRegression.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIOT);
            this.groupBox1.Controls.Add(this.rbeCW);
            this.groupBox1.Controls.Add(this.rbFullCert);
            this.groupBox1.Controls.Add(this.rbPartialCert);
            this.groupBox1.Controls.Add(this.rbRapidRegression);
            this.groupBox1.Location = new System.Drawing.Point(19, 444);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(304, 39);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Certification";
            // 
            // rbIOT
            // 
            this.rbIOT.AutoSize = true;
            this.rbIOT.Location = new System.Drawing.Point(255, 16);
            this.rbIOT.Margin = new System.Windows.Forms.Padding(2);
            this.rbIOT.Name = "rbIOT";
            this.rbIOT.Size = new System.Drawing.Size(43, 17);
            this.rbIOT.TabIndex = 34;
            this.rbIOT.TabStop = true;
            this.rbIOT.Text = "IOT";
            this.rbIOT.UseVisualStyleBackColor = true;
            this.rbIOT.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbeCW
            // 
            this.rbeCW.AutoSize = true;
            this.rbeCW.Location = new System.Drawing.Point(189, 16);
            this.rbeCW.Margin = new System.Windows.Forms.Padding(2);
            this.rbeCW.Name = "rbeCW";
            this.rbeCW.Size = new System.Drawing.Size(49, 17);
            this.rbeCW.TabIndex = 33;
            this.rbeCW.TabStop = true;
            this.rbeCW.Text = "eCW";
            this.rbeCW.UseVisualStyleBackColor = true;
            this.rbeCW.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbFullCert
            // 
            this.rbFullCert.AutoSize = true;
            this.rbFullCert.Location = new System.Drawing.Point(125, 16);
            this.rbFullCert.Margin = new System.Windows.Forms.Padding(2);
            this.rbFullCert.Name = "rbFullCert";
            this.rbFullCert.Size = new System.Drawing.Size(43, 17);
            this.rbFullCert.TabIndex = 32;
            this.rbFullCert.TabStop = true;
            this.rbFullCert.Text = "CW";
            this.rbFullCert.UseVisualStyleBackColor = true;
            this.rbFullCert.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbPartialCert
            // 
            this.rbPartialCert.AutoSize = true;
            this.rbPartialCert.Location = new System.Drawing.Point(69, 16);
            this.rbPartialCert.Margin = new System.Windows.Forms.Padding(2);
            this.rbPartialCert.Name = "rbPartialCert";
            this.rbPartialCert.Size = new System.Drawing.Size(49, 17);
            this.rbPartialCert.TabIndex = 31;
            this.rbPartialCert.TabStop = true;
            this.rbPartialCert.Text = "pCW";
            this.rbPartialCert.UseVisualStyleBackColor = true;
            this.rbPartialCert.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 503);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Release Name: ";
            // 
            // tbReleaseName
            // 
            this.tbReleaseName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbReleaseName.Location = new System.Drawing.Point(102, 501);
            this.tbReleaseName.Margin = new System.Windows.Forms.Padding(2);
            this.tbReleaseName.Name = "tbReleaseName";
            this.tbReleaseName.Size = new System.Drawing.Size(307, 20);
            this.tbReleaseName.TabIndex = 33;
            // 
            // tbCycleName
            // 
            this.tbCycleName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbCycleName.Location = new System.Drawing.Point(102, 536);
            this.tbCycleName.Margin = new System.Windows.Forms.Padding(2);
            this.tbCycleName.Name = "tbCycleName";
            this.tbCycleName.Size = new System.Drawing.Size(307, 20);
            this.tbCycleName.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 538);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Cycle Name: ";
            // 
            // btnCreateReleseCycle
            // 
            this.btnCreateReleseCycle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateReleseCycle.Enabled = false;
            this.btnCreateReleseCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateReleseCycle.Location = new System.Drawing.Point(454, 510);
            this.btnCreateReleseCycle.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateReleseCycle.Name = "btnCreateReleseCycle";
            this.btnCreateReleseCycle.Size = new System.Drawing.Size(96, 42);
            this.btnCreateReleseCycle.TabIndex = 36;
            this.btnCreateReleseCycle.Text = "Create ReleaseCycle";
            this.btnCreateReleseCycle.UseVisualStyleBackColor = false;
            this.btnCreateReleseCycle.Click += new System.EventHandler(this.btnCreateReleseCycle_Click);
            // 
            // lblReleaseError
            // 
            this.lblReleaseError.AutoSize = true;
            this.lblReleaseError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseError.ForeColor = System.Drawing.Color.Green;
            this.lblReleaseError.Location = new System.Drawing.Point(17, 568);
            this.lblReleaseError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReleaseError.Name = "lblReleaseError";
            this.lblReleaseError.Size = new System.Drawing.Size(0, 18);
            this.lblReleaseError.TabIndex = 37;
            // 
            // cbUpdateTestset
            // 
            this.cbUpdateTestset.AutoSize = true;
            this.cbUpdateTestset.Location = new System.Drawing.Point(229, 216);
            this.cbUpdateTestset.Name = "cbUpdateTestset";
            this.cbUpdateTestset.Size = new System.Drawing.Size(101, 17);
            this.cbUpdateTestset.TabIndex = 38;
            this.cbUpdateTestset.Text = "Update TestSet";
            this.cbUpdateTestset.UseVisualStyleBackColor = true;
            this.cbUpdateTestset.CheckedChanged += new System.EventHandler(this.cbUpdateTestset_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(234, 244);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Priority :";
            // 
            // cbPriority
            // 
            this.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "01 Critical",
            "02 High",
            "03 Medium",
            "04 Low"});
            this.cbPriority.Location = new System.Drawing.Point(283, 241);
            this.cbPriority.Margin = new System.Windows.Forms.Padding(2);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(107, 21);
            this.cbPriority.TabIndex = 39;
            this.cbPriority.SelectedIndexChanged += new System.EventHandler(this.cbPriority_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 318);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(266, 18);
            this.label15.TabIndex = 41;
            this.label15.Text = "Create Release - Cycle in HP ALM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbVoice);
            this.groupBox2.Controls.Add(this.rbDOCSIS);
            this.groupBox2.Location = new System.Drawing.Point(258, 395);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(151, 36);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // rbVoice
            // 
            this.rbVoice.AutoSize = true;
            this.rbVoice.Location = new System.Drawing.Point(100, 15);
            this.rbVoice.Margin = new System.Windows.Forms.Padding(2);
            this.rbVoice.Name = "rbVoice";
            this.rbVoice.Size = new System.Drawing.Size(52, 17);
            this.rbVoice.TabIndex = 31;
            this.rbVoice.TabStop = true;
            this.rbVoice.Text = "Voice";
            this.rbVoice.UseVisualStyleBackColor = true;
            // 
            // rbDOCSIS
            // 
            this.rbDOCSIS.AutoSize = true;
            this.rbDOCSIS.Checked = true;
            this.rbDOCSIS.Location = new System.Drawing.Point(17, 15);
            this.rbDOCSIS.Margin = new System.Windows.Forms.Padding(2);
            this.rbDOCSIS.Name = "rbDOCSIS";
            this.rbDOCSIS.Size = new System.Drawing.Size(65, 17);
            this.rbDOCSIS.TabIndex = 30;
            this.rbDOCSIS.TabStop = true;
            this.rbDOCSIS.Text = "DOCSIS";
            this.rbDOCSIS.UseVisualStyleBackColor = true;
            // 
            // frmALMRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.cbUpdateTestset);
            this.Controls.Add(this.lblReleaseError);
            this.Controls.Add(this.btnCreateReleseCycle);
            this.Controls.Add(this.tbCycleName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbReleaseName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbIntake);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbReleaseFolder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbUpdateStatus);
            this.Controls.Add(this.lblRunStatus);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tbTestFolder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbErrorMessage);
            this.Controls.Add(this.tbProject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDomain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbServerName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmALMRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALMRun_v1.9";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmALMRun_FormClosing);
            this.Load += new System.EventHandler(this.frmALMRun_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbServerName;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbDomain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbProject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbErrorMessage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTestFolder;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblRunStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ComboBox cbUpdateStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbReleaseFolder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbIntake;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbRapidRegression;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbIOT;
        private System.Windows.Forms.RadioButton rbeCW;
        private System.Windows.Forms.RadioButton rbFullCert;
        private System.Windows.Forms.RadioButton rbPartialCert;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbReleaseName;
        private System.Windows.Forms.TextBox tbCycleName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCreateReleseCycle;
        private System.Windows.Forms.Label lblReleaseError;
        private System.Windows.Forms.CheckBox cbUpdateTestset;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbVoice;
        private System.Windows.Forms.RadioButton rbDOCSIS;
    }
}

