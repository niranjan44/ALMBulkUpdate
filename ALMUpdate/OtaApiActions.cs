using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TDAPIOLELib;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ALMUpdate
{
    class OtaApiActions
    {

        private TDConnection conn;
        private Dictionary<string, int> folderIdCache = new Dictionary<string, int>();


        /* Create a connection to an ALM server           */
        /* Authenticate the user and log on to a project  */
        public void connectToServer(string serverUrl, string username, string password, string domain, string project)
        {
            try
            {
                conn = new TDConnection();
                conn.InitConnectionEx(serverUrl);

                //Authentication
                conn.Login(username, password);

                //Connect to a project
                conn.Connect(domain, project);

                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

     

        public void disconnect()
        {
            if (conn != null)
            {
                conn.Disconnect();
                conn.ReleaseConnection();
            }
        }


        public void RunTestSet(string testFolder, string status, BackgroundWorker worker, DoWorkEventArgs e)
        {

            try
            {
                int testCaseUpdated=0;
              // string testFolder = @"Root\Active\Advanced_CPE\DOCSIS\2015_Archive\RR20151223\PX013ANC_2.2p3s1";
               // string testSetName = "IPv6";

                //TestSetFactory tsFactory = (TestSetFactory)conn.TestSetFactory;
                TestSetTreeManager tsTreeMgr = (TestSetTreeManager)conn.TestSetTreeManager;
                TestSetFolder tsFolder = (TestSetFolder)tsTreeMgr.get_NodeByPath(testFolder);
                List tsList = tsFolder.FindTestSets("", false, null);

              //  List tsList1 = tsFolder.FindTestSets(testSetName, false, "status=No Run");
              //  List ls2 = tsFolder.FindChildren(testSetName, false, null);




                foreach (TestSet testSet in tsList)
                {
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }

                    TestSetFolder tsFolder1 = (TestSetFolder)testSet.TestSetFolder;
                    TSTestFactory tsTestFactory = (TSTestFactory)testSet.TSTestFactory;
                    List tsTestList = tsTestFactory.NewList("");


                    foreach (TSTest tsTest in tsTestList)
                    {
                        Run lastRun = (Run)tsTest.LastRun;
                                               
                        if (lastRun == null)
                        {
                            RunFactory runFactory = (RunFactory)tsTest.RunFactory;
                            String date = DateTime.Now.ToString("yyyyMMddhhmmss");
                            Run run = (Run)runFactory.AddItem("Run" + date);
                            run.Status = status;
                            run.Post();
                            worker.ReportProgress(++testCaseUpdated);
                        }
                        if (worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return;
                        }
                    } 

                }
                e.Result = testCaseUpdated;
            }
            catch (Exception ex)
            {
                e.Result = ex;
                return;
            }

        }


        public void RunSingleTestSet(string testSetPath, string status, string filter,BackgroundWorker worker, DoWorkEventArgs e)
        {

            try
            {
                int testCaseUpdated = 0;
                TestSet theTestSet=null;
                // string testFolder = @"Root\Active\Advanced_CPE\DOCSIS\2015_Archive\RR20151223\PX013ANC_2.2p3s1";
                // string testSetName = "IPv6";
                TestSetTreeManager tsTreeMgr = (TestSetTreeManager)conn.TestSetTreeManager;
                TestSetFolder tsFolder = null;
                TDFilter tFilter;
                string testFolder = string.Empty;

                testFolder = testSetPath.Substring(0, testSetPath.LastIndexOf("\\"));
              
                int testSetLength = testSetPath.Length - testSetPath.LastIndexOf("\\");
                string testSetName = testSetPath.Substring(testSetPath.LastIndexOf("\\") + 1, testSetLength - 1);


                tsFolder = (TestSetFolder)tsTreeMgr.get_NodeByPath(testFolder);

                // List tsList =  (List)tsTreeMgr.NodeById[244605];

                tsFolder = tsTreeMgr.NodeById[244605];

                // Type t = x.GetType();

                //  List tsList = tsFolder.FindTestSets("OSS", false, null);
                //  List tsList1 = tsFolder.FindTestSets(testSetName, false, "status=No Run");
                //  List ls2 = tsFolder.FindChildren(testSetName, false, null);

                //will retrieve all testsets which has given testset name
                List tsList = tsFolder.FindTestSets(testSetName, true, "");

                int nodeid = tsFolder.NodeID;
                int faterid = tsFolder.FatherID;

               // List tsList = tsFolder.TestSetFactory

              

                //if (tsList == null)
                //{
                //    throw new Exception("TestSet not found");
                //}

                //foreach (TestSet testSet in tsList)
                //{
                //    if (testSet.Name == testSetName)
                //    {
                //        theTestSet = testSet;
                //        break;
                //    }
                //}





                //   string tempStr = theTestSet.ID.ToString();
                // Debug.Print(tempStr);


                //foreach (TestSet testSet in tsList)
                //{
                //    if (worker.CancellationPending)
                //    {
                //        e.Cancel = true;
                //        return;
                //    }


                TSTestFactory tsTestFactory = (TSTestFactory)theTestSet.TSTestFactory;
               // TSTestFactory tsTestFactory = tsFolder.TestSetFactory;

                tFilter = tsTestFactory.Filter;
                //tFilter["TS_USER_17"] = "\"01 Critical\"";
                if(!string.IsNullOrEmpty(filter))
                tFilter["TS_USER_17"] = "\"" + filter +"\"";

                List tsTestList = tFilter.NewList();


                foreach (TSTest tsTest in tsTestList)
                {
                    Run lastRun = (Run)tsTest.LastRun;


                    if (lastRun == null)
                    {
                        RunFactory runFactory = (RunFactory)tsTest.RunFactory;
                        String date = DateTime.Now.ToString("yyyyMMddhhmmss");
                        Run run = (Run)runFactory.AddItem("Run" + date);
                        run.Status = status;
                        run.Post();
                        worker.ReportProgress(++testCaseUpdated);
                    }
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                }


                e.Result = testCaseUpdated;
            }
            catch (Exception ex)
            {
                e.Result = ex;
                return;
            }

        }



        public ReleaseFolder GetReleaseFolder(string testFolder)
        {
            try
            {
              //  string testFolder = @"Releases\Active\Advanced CPE\DOCSIS\Managed_Services\2016_Certifications";
                IReleaseFolderFactory oReleaseFolderFactory = conn.ReleaseFolderFactory;

         

                ReleaseFolder rootReleaseFolder = oReleaseFolderFactory.Root;
                oReleaseFolderFactory = rootReleaseFolder.ReleaseFolderFactory;
            
                ReleaseFolder releaseFolder=null;
                IReleaseFolderFactory releaseFolderFace = oReleaseFolderFactory;

                string[] folders = testFolder.Split('\\');

        


               for(int i =1; i<folders.Length; i++)
                {
                  
                    releaseFolder = FindReleaseFolder(releaseFolderFace, folders[i]);
                    oReleaseFolderFactory = null;
                    releaseFolderFace = null;
                  
                    if (releaseFolder != null)
                    {
                        releaseFolder.Refresh();
                        releaseFolderFace = releaseFolder.ReleaseFolderFactory;
                    }
                   

                }

                if (releaseFolder != null)
                    return releaseFolder;
                else
                    return null;


            }
            catch(Exception ex)
            {
                throw ex;
               // return null;
            }


        }

        public ReleaseFolder FindReleaseFolder(IReleaseFolderFactory folderFact, string name)
        {
           
            TDFilter filter = folderFact.Filter;
            filter.Text = "";
            filter.Refresh();
            //NewList() caches the data for few seconds
            TDAPIOLELib.List listnew = filter.NewList();
            //  [force_refresh]

            foreach (ReleaseFolder rf in listnew)
            {

                               if (rf.Name == name)
                    return rf;
              
            }
            return null;

        }


        public  string  CreateReleaseCycle( string intakeid, string releaseName, string cycleName, DateTime startDate, DateTime endDate, string testFolder, bool docsis)
        {
            try
            {

                IReleaseFolderFactory oReleaseFolderFactory;
                ReleaseFolder relFolder=null;
               ReleaseFolder rootReleaseFolder;
                IReleaseFactory relFac;
                Release rel;
                ICycleFactory cycleFac;
                Cycle cycle;
                string message ="";
                string releaseFolderName = "";
                // ReleaseManagementInfo managementInfo;
              //  testFolder = @"Releases\Active\Advanced CPE\DOCSIS\Managed_Services\2016_Certifications";
              //  testFolder = "releases5";

                oReleaseFolderFactory = conn.ReleaseFolderFactory;
                rootReleaseFolder = oReleaseFolderFactory.Root;
                oReleaseFolderFactory = rootReleaseFolder.ReleaseFolderFactory;



                int folderId = 0;

                if (folderIdCache.ContainsKey(testFolder))
                {
                    folderId = folderIdCache[testFolder];
                }
                else
                {
                    relFolder = GetReleaseFolder(testFolder);
                    if (relFolder != null)
                    {
                        //for future use
                        folderIdCache.Add(testFolder, relFolder.ID);
                    }
                }


                if (relFolder == null && folderId != 0)
                {
                    relFolder = oReleaseFolderFactory[folderId];
                }


                //if releasefolder is not found,break here
                releaseFolderName = relFolder.Name;

                relFac = relFolder.ReleaseFactory;
                    rel = relFac.AddItem(System.DBNull.Value);
                    rel.Name = releaseName;
                    rel.StartDate = startDate;
                    rel.EndDate = endDate;
                    rel.Post();


                    cycleFac = rel.CycleFactory;
                    cycle = cycleFac.AddItem(System.DBNull.Value);
                    cycle.Name = cycleName;
                    cycle.StartDate = startDate;
                    cycle.EndDate = endDate;
                if(docsis)
                    cycle["RCYC_USER_02"] = "C-QA - Advanced CPE DOCSIS Testing - PR012048";
                else
                    cycle["RCYC_USER_02"] = "C-QA - Advanced CPE Voice Device - PR012047";

                cycle["RCYC_USER_04"] = "Voice/Data/Xplat";
                    cycle["RCYC_USER_03"] = "QAINTAKE-"+intakeid;

                 


                    cycle.Post();

                   
                

                message = "Release/Cycle created Successfully for QAINTAKE-" +intakeid +" in Release folder - " + releaseFolderName;
                return message;
                

            }
            catch (Exception ex)
            {
                throw ex;
            }



            


        }




    }
}
