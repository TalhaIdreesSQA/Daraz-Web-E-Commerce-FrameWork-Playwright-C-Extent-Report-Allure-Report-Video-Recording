using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adactin_Hotel_Playwright
{
    public class AddToCartData : BasePage
    {
        public static string filename = "PlaceOrderJ.json";
        public static JObject? LoginPageJ = ReadJson(@"JsonFiles\PlaceOrderJ.json".ToString());
        public static string Expected = LoginPageJ.SelectToken("expected").Value<string>();
        
        public static JObject ReadJson(string filename)
        {
            string myJsonString = File.ReadAllText(@"..\\..\\..\\" + filename);
            var myOject = JObject.Parse(myJsonString);
            return myOject;
        }
    }
}
