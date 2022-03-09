using System;
using System.Threading;
using System.Windows.Forms;
using NMS.Core.Utility;
using QA7.Desktop.Core.Utility;
using QA7.Desktop.Forms;

namespace QA7.Desktop
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.ThreadException +=
                new ThreadExceptionEventHandler(Application_ThreadException);

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                NmsLogger.Error(ex);
                DialogUtility.ShowErrorMessage("Something went wrong. See log file to get more information");
            }
        }

        public static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            NmsLogger.Error(e.Exception);
            DialogUtility.ShowErrorMessage("Something went wrong. See log file to get more information");
        }
    }
}
