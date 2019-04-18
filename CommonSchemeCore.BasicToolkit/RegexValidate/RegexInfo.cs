using System;
using System.Collections.Generic;
using System.Text;

namespace CommonSchemeCore.BasicToolkit.RegexValidate
{
    public class RegexInfo
    {
        private static Dictionary<string, string> RegexDic;
        private static void serializeJson()
        {

        }
        public static void SerializeJson(bool HeatLoad = false)
        {
            serializeJson();
            if (HeatLoad)
            {
                RegexDic = new Dictionary<string, string>();
            }
        }
        public static string GetRegexInfo(string key)
        {
            if (RegexDic == null)
            {
                serializeJson();
            }
            string info = string.Empty;
            if (RegexDic.ContainsKey(key))
            {
                info = RegexDic[key];
            }
            RegexDic = null;
            return info;
        }
    }
}
