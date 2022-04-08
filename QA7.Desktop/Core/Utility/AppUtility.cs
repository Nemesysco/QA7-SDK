using System.Reflection;
using System.Windows.Forms;

namespace QA7.Desktop.Core.Utility
{
    public static class AppUtility
    {
        public static string GetUserAppDataPath()
        {
            return Application.LocalUserAppDataPath;
        }

        public static string GetVersion()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            return string.Format("{0}.{1}.{2}", version.Major, version.Minor, version.Build);
        }
    }
}
