using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Adactin_Hotel_Playwright
{
    [TestFixture]
    [AllureNUnit]
    public class PageTest_Playwright : PageTest
    {
        [Test]
        public async Task LoginPage()
        {
            await Page.GotoAsync("https://adactinhotelapp.com/");
            await Page.FillAsync("#username","user2here");
            await Page.FillAsync("#password","user123");
            await Page.ClickAsync("#login");

            var locator = Page.Locator(".welcome_menu").First;
            await Assertions.Expect(locator).ToHaveTextAsync(new Regex("Welcome to Adactin Group of Hotels"));
            await Page.CloseAsync();
        }

        [Test]
        public async Task GetByPlaceHolder()
        {
            await Page.GotoAsync("https://demoqa.com/text-box");
            await Page.GetByPlaceholder("Full Name").FillAsync("Talha");
            await Page.GetByPlaceholder("name@example.com").FillAsync("Talha12@gmail.com");
            await Page.GetByPlaceholder("Current Address").FillAsync("Zubairy Colony");
            await Page.FillAsync("#permanentAddress","ZUBAIRY cOLONY");

        }
        [Test]
        public async Task GetByTestLinks()
        {
            await Page.GotoAsync("https://demoqa.com/links");
            await Page.GetByText("Created").ClickAsync();
        }
        [Test]
        [AllureStep("Login with url,user,and password")]
        [AllureEpic("Hotel Epic")]
        [AllureFeature("Booking Hotel User Story")]
        [AllureOwner("Talha Idrees")]
        [Category("Allure")]
        public async Task Login_Page()
        {
            LoginPage loginPage = new LoginPage(Page);
           // await loginPage.Login("https://adactinhotelapp.com/", "user2here", "user123");
        }
    }
}
