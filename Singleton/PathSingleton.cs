using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWithSelenium.Singleton
{
    public class PathSingleton
    {
         public static string ConfigPath
        {
            get
            {
                // Define the path to the 'config' folder
                string path = Environment.CurrentDirectory + "\\config";

                // Check if the directory exists
                if (!Directory.Exists(path))
                {
                    // Create the directory if it doesn't exist
                    Directory.CreateDirectory(path);
                }

                return path;
            }
        }
        public static string UISettingConfigPath
        {
            get
            {
                // Define the path to the 'UISettingsConfig.ini' file
                string uiConfigPath = Path.Combine(ConfigPath, "UISettingsConfig.ini");

                // Ensure the UI settings config file exists


                return uiConfigPath;
            }
        }
    }
}
