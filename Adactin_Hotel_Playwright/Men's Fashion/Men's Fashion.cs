using Microsoft.Playwright;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Adactin_Hotel_Playwright
{
    public class Men_s_Fashion : MensFashionData
    {
        private readonly IPage _page;
        private readonly ILocator clickmensfaction;
        private readonly ILocator clickTshirt;
        private readonly ILocator searchtxt;
        private readonly ILocator searchbtn;
        private readonly ILocator Select_tshirt;
        private readonly ILocator SelectTshirt;
        
        public Men_s_Fashion(IPage page)
        {
            _page = page;
            clickmensfaction = _page.Locator("#Level_1_Category_No9");
            clickTshirt = _page.Locator("#J_5022174600 > div > ul > ul.lzd-site-menu-sub.Level_1_Category_No9 > li:nth-child(1)");
            searchtxt = _page.GetByPlaceholder("Search in Daraz");
            searchbtn = _page.Locator("#topActionHeader > div.lzd-header-content > div.lzd-logo-bar > div > div.lzd-nav-search.reduceWidthOfSearchBar > form > div > div.search-box__search--2fC5 > button");
            Select_tshirt = _page.GetByTitle("The Vintage Clothing Pack of 5 basic premium full sleeves T shirts");
            SelectTshirt = _page.GetByText("T-Shirts & Tanks");
        }
        [AllureStep("Mens Fashion")]
        public async Task Mens_Fashion()
        {
            ExtentReport.ChildNode("Mens Fashion");
            //await clickmensfaction.ClickAsync();
            
            await BasePage.click(_page,report,clickmensfaction,"Click On Mens Function");
            //await ScreenShot.TakeScreenShot(_page, "Click MensFashion");
            //await clickTshirt.ClickAsync();
            await BasePage.click(_page, report, clickTshirt.First, "Click On T-Shirt");
            await BasePage.write(_page, report, searchtxt, Writeinsearchbar, "Click On Search_Bar");
            await BasePage.click(_page,report,searchbtn,"Click on Search-Btn");
            //await ScreenShot.TakeScreenShot(_page, "Click T-shirts");
            //await Assertions.Expect(Select_tshirt).ToHaveTextAsync("The Vintage Clothing Pack of 5 plain half sleeves T shirts for men");
            await BasePage.text(_page,report, Select_tshirt.First, Expected,"Assertion");
            //await Select_tshirt.ClickAsync();
            await BasePage.click(_page,report, Select_tshirt.First, "Select T-Shirt");
            //await ScreenShot.TakeScreenShot(_page, "Select T-shirts");

        }
    }
}
