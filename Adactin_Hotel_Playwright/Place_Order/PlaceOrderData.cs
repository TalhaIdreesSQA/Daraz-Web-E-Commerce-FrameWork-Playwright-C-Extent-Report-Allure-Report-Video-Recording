using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adactin_Hotel_Playwright
{
    public class PlaceOrderData : BasePage
    {
        public static string filename = "PlaceOrderJ.json";
        public static JObject? LoginPageJ = ReadJson(@"JsonFiles\PlaceOrderJ.json".ToString());
        public static string Fullname = LoginPageJ.SelectToken("fullname").Value<string>();
        public static string MobileNo = LoginPageJ.SelectToken("mobileno").Value<string>();
        public static string Address = LoginPageJ.SelectToken("address").Value<string>();
        public static string Assert_email = LoginPageJ.SelectToken("assertion_email").Value<string>();
        public static JObject ReadJson(string filename)
        {
            string myJsonString = File.ReadAllText(@"..\\..\\..\\" + filename);
            var myOject = JObject.Parse(myJsonString);
            return myOject;
        }
    }
}
