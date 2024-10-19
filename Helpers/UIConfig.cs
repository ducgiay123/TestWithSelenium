using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWithSelenium.Singleton;

namespace TestWithSelenium.Helpers
{
    public class UIConfig
    {
        public static IniFile UISettingManager = new IniFile(PathSingleton.UISettingConfigPath);

        public static int Drivers
        {
            get
            {
                string payload = UISettingManager.Read("drivers");
                if (string.IsNullOrEmpty(payload))
                {
                    return 0;
                }
                return int.Parse(payload);
            }
            set
            {
                UISettingManager.Write("drivers", value.ToString());
            }
        }
        public static int ProxyType
        {
            get
            {
                string payload = UISettingManager.Read("proxytype");
                if (string.IsNullOrEmpty(payload))
                {
                    return 0;
                }
                return int.Parse(payload);
            }
            set
            {
                UISettingManager.Write("proxytype", value.ToString());
            }
        }
        public static bool UseProxy
        {
            get
            {
                string payload = UISettingManager.Read("useproxy");
                if (string.IsNullOrEmpty(payload))
                {
                    return false;
                }
                return bool.Parse(payload);
            }
            set
            {
                UISettingManager.Write("useproxy", value.ToString());
            }
        }
    }
}
