using System;
using System.Configuration;
using System.Linq;

namespace NMS.Core.Utility
{
    public static class ConfigUtility
    {
        /// <summary>
        /// Gets configurations from App.Config
        /// e.g. <add key="RootPath" value="C:\Nemesysco\" />
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetValue(string key)
        {
            if (ConfigurationManager.AppSettings.AllKeys.Any(s => s == key))
            {
                if (key != null && key != string.Empty)
                {
                    return ConfigurationManager.AppSettings[key].Trim();
                }
            }

            throw new Exception(key + " Key is not defined.");
        }
    }
}
