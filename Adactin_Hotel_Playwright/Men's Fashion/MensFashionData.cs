using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adactin_Hotel_Playwright
{
    public class MensFashionData : BasePage
    {
        public static string filename = "MensFashionJ.json";
        public static JObject? LoginPageJ = ReadJson(@"JsonFiles\MensFashionJ.json".ToString());
        public static string Expected = LoginPageJ.SelectToken("expected").Value<string>();
        public static string Writeinsearchbar = LoginPageJ.SelectToken("writeinsearchbar").Value<string>();
        public static JObject ReadJson(string filename)
        {
            string myJsonString = File.ReadAllText(@"..\\..\\..\\" + filename);
            var myOject = JObject.Parse(myJsonString);
            return myOject;
        }
    }
}
