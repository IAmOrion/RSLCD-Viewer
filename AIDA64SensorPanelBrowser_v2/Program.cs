using System;
using System.Drawing;
using System.Windows.Forms;

namespace AIDA64SensorPanelBrowser_v2
{
    internal static class Program
    {
        // Global Variables | Defaults
        public static bool webViewIsInitialised = false;
        public static decimal defaultWidth = 800;
        public static decimal defaultHeight = 480;
        public static string defaultURL = "http://127.0.0.1";
        public static string defaultPort = "80";
        public static string currentURL = Properties.Settings.Default.URL;
        public static bool defaultSnapping = true;
        public static bool defaultRunAtStartup = false;
        public static bool defaultAlwaysOnTop = true;
        public static bool defaultSettingsOnPrimaryMonitor = true;
        public static bool bsod = false;
        public static bool changesMade = true;
        public static bool didResetPosition = false;
        public static bool isWebSiteUp = false;
        public static bool isTaskPaused = false;
        public static int defaultSnappingDistance = 20;
        public static string RSLCDHomeURL = "https://forums.aida64.com/topic/10008-rslcd-viewer-an-app-for-viewing-remotesensor-panels/";
        public static string ForumURL = "https://forums.aida64.com";
        public static string FacebookURL = "https://www.facebook.com/TheMeroving1an";
        public static string GitHubURL = "https://github.com/IAmOrion/RSLCD-Viewer";

        public static bool snappingEnabled = Properties.Settings.Default.Snapping;
        public static bool alwaysOnTop = Properties.Settings.Default.AlwaysOnTop;
        // End Global Variables | Defaults

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (AnotherInstanceExists())
            {
                MessageBox.Show("You cannot run more than one instance of this application.", "Only one instance allowed to run", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        public static bool AnotherInstanceExists()
        {
            System.Diagnostics.Process currentRunningProcess = System.Diagnostics.Process.GetCurrentProcess();
            System.Diagnostics.Process[] listOfProcs = System.Diagnostics.Process.GetProcessesByName(currentRunningProcess.ProcessName);

            foreach (System.Diagnostics.Process proc in listOfProcs)
            {
                if ((proc.MainModule.FileName == currentRunningProcess.MainModule.FileName) && (proc.Id != currentRunningProcess.Id))
                    return true;
            }
            return false;
        }
    }
}
