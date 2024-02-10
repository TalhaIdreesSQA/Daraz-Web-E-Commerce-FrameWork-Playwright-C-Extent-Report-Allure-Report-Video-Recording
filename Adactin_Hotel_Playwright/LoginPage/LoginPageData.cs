using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adactin_Hotel_Playwright
{
    public class LoginPageData : BasePage
    {
        public static string filename = "LoginPageJ.json";
        public static JObject? LoginPageJ = ReadJson(@"JsonFiles\LoginPageJ.json".ToString());
        public static string Url = LoginPageJ.SelectToken("url").Value<string>();
        public static string Email = LoginPageJ.SelectToken("email").Value<string>();
        public static string Password = LoginPageJ.SelectToken("password").Value<string>();
        public static JObject ReadJson(string filename)
        {
            string myJsonString = File.ReadAllText(@"..\\..\\..\\" + filename);
            var myOject = JObject.Parse(myJsonString);
            return myOject;
        }
    }
}
