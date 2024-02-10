using Adactin_Hotel_Playwright;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Adactin_Hotel_Playwright
{
    public class Checkout : CheckOutData
    {
        private readonly IPage _page;
        private readonly ILocator checkboxtxt;
        private readonly ILocator checkboxbtn;
        private readonly ILocator deletebtn;
        private readonly ILocator checkbox;
        private readonly ILocator checkout;
        public Checkout(IPage page)
        {
            _page = page;
            deletebtn = _page.GetByText("Delete");
            checkboxbtn = _page.Locator("#listHeader_H > div > div > div.checkbox-wrap > label > input[type=checkbox]");
            checkout = _page.GetByText("PROCEED TO CHECKOUT (1)");
        }
        public async Task CheckOut()
        {
            ExtentReport.ChildNode("Check Out");
            await BasePage.click(_page, report, deletebtn, "Click On Deletebtn ");
            await BasePage.click(_page,report,checkboxbtn,"Click on Checkbox");
            //await checkbox.ClickAsync();
            //Thread.Sleep(5000);
            //await checkbox.PressAsync("Tab");
            //await checkbox.PressAsync("Enter");
            //Thread.Sleep(5000);
            await _page.WaitForLoadStateAsync();
            //Thread.Sleep(5000);
            await BasePage.click(_page, report, checkout, "Click On CheckOut");
            //await checkout.ClickAsync();
            Thread.Sleep(5000);
        }
    }
}
