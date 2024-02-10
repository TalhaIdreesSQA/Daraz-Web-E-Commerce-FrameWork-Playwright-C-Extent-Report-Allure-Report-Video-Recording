using Adactin_Hotel_Playwright;
using Microsoft.Playwright;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Adactin_Hotel_Playwright
{
    //public class LoginPage
    //{
    //    private readonly IPage _page;
    //    private readonly ILocator usernametxt;
    //    private readonly ILocator passwordtxt;
    //    private readonly ILocator LoginBtn;

    //    public LoginPage(IPage page)
    //    {
    //        _page = page;
    //        usernametxt = _page.Locator("#username");
    //        passwordtxt = _page.Locator("#password");
    //        LoginBtn = _page.Locator("#login");
    //    }
    //    [AllureStep("Login with url {0} user {1} password {2}")]
    //    public async Task Login(string url, string user, string pass)
    //    {
    //        try
    //        {
    //            await _page.GotoAsync(url);
    //            await usernametxt.FillAsync(user);
    //            await passwordtxt.FillAsync(pass);
    //            await ScreenShot.TakeScreenShot(_page, "Login Button");
    //            await LoginBtn.ClickAsync();
    //            await ScreenShot.TakeScreenShot(_page, "Login Performed Succesfully");
    //        }
    //        catch (Exception)
    //        {
    //            await ScreenShot.TakeScreenShot(_page, "Login Performed Succesfully", Allure.Net.Commons.Status.failed);
    //        }

    //    }
    //}
    //public class LoginPage
    //{
    //    private readonly IPage _page;
    //    private readonly ILocator usernametxt;
    //    private readonly ILocator passwordtxt;
    //    private readonly ILocator loginbtn;

    //    public LoginPage(IPage Page)
    //    {
    //        _page = Page;
    //        usernametxt = _page.GetByPlaceholder("Please enter your Phone Number or Email");
    //        passwordtxt = _page.GetByPlaceholder("Please enter your password");
    //        loginbtn = _page.GetByText("Login");
    //    }

    //    public async Task Login(string url, string email, string pass)
    //    {
    //        await _page.GotoAsync(url);
    //        await _page.GotoAsync("https://member.daraz.pk/user/login?spm=a2a0e.home.header.d5.35e34076deDy9T&redirect=https%3A%2F%2Fwww.daraz.pk%2F");
    //        await usernametxt.FillAsync(email);
    //        await passwordtxt.FillAsync(pass);
    //        await loginbtn.ClickAsync();
    //    }
    //}

    public class LoginPage : LoginPageData
    {
        private readonly IPage _page;
        private readonly ILocator login;
        private readonly ILocator usernametxt;
        private readonly ILocator passwordtxt;
        private readonly ILocator loginBtn;
        private readonly ILocator asserttxt;
        //public static string report = "ententreport";

        public LoginPage(IPage page)
        {
            _page = page;
            login = _page.Locator("#anonLoginNew > span");
            usernametxt = _page.GetByPlaceholder("Please enter your Phone Number or Email");
            passwordtxt = _page.GetByPlaceholder("Please enter your password");
            loginBtn = _page.GetByRole(AriaRole.Button, new()
            {
                NameRegex = new Regex("LOGIN", RegexOptions.IgnoreCase)
            });
            var asserttxt = _page.GetByRole(AriaRole.Heading, new()
            {
                Name = "Flash Sale"
            });
        }
        [AllureStep("Login with valid credentials")]
        public async Task Login()
        {
            
            //ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Login  with valid Credentials");
            ExtentReport.ChildNode("Login With Valid Credentials");
            //await ExtentReport.VideoRecording();
            //var playwright = await Playwright.CreateAsync();
            //var Browser = await playwright.Chromium.LaunchAsync(
            //    new BrowserTypeLaunchOptions
            //    {
            //        Headless = false,
            //        Channel = "chrome",
            //        SlowMo = 50,
            //        Timeout = 80000
            //    });
            //var context = await Browser.NewContextAsync(new()
            //{
            //    RecordVideoDir = "video/",
            //    RecordVideoSize = new RecordVideoSize()
            //    {
            //        Width = 1366,
            //        Height = 768
            //    },
            //    ViewportSize = new ViewportSize()
            //    {
            //        Width = 1366,
            //        Height = 768
            //    }
            //});
            //var _page = await context.NewPageAsync();
            await _page.GotoAsync(Url);
            //await login.ClickAsync();
            //Thread.Sleep(1000);
            //await _page.Locator("#anonLogin").ClickAsync();
            await BasePage.click(_page,report,login,"Click On Login");
            //await ScreenShot.TakeScreenShot(_page,"Click On login");
            await BasePage.write(_page,report, usernametxt,Email,"Enter Email");
            //await ScreenShot.TakeScreenShot(_page, "Enter Email");
            await BasePage.write(_page,report, passwordtxt,Password, "Enter Password");
            //await ScreenShot.TakeScreenShot(_page, "Enter Password");
            await BasePage.click(_page,report, loginBtn,"Login Button");
            //await ScreenShot.TakeScreenShot(_page, "Login Button");
            //await usernametxt.FillAsync(user);
            //await passwordtxt.FillAsync(pass);
            //await loginBtn.ClickAsync();
            //await ScreenShot.TakeScreenShot(_page, "Login Button");
            //await Assertions.Expect(asserttxt).ToBeVisibleAsync();
            //await ScreenShot.TakeScreenShot(_page, "Login Performed Succesfully");
            //await ExtentReport.TakeScreenshot(_page, "LoginPerformed Succesfully");
        }

        [AllureStep("Login with invalid credentials")]
        public async Task InvalidLogin()
        {
            //ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Login with Invalid Credentials");
            ExtentReport.ChildNode("Login With Invalid Credentials");
            await _page.GotoAsync(Url);
                //await login.ClickAsync();
                //await usernametxt.FillAsync(user);
                //await passwordtxt.FillAsync(pass);
               // await loginBtn.ClickAsync();
                //await ScreenShot.TakeScreenShot(_page, "Login Button");
                //await Assertions.Expect(asserttxt).ToBeVisibleAsync();
                //await ScreenShot.TakeScreenShot(_page, "Login Performed Succesfully");

            Thread.Sleep(1000);
            await BasePage.click(_page,report, login, "Click On Login");
            await BasePage.write(_page,report, usernametxt, Email, "Enter valid Email");
            await BasePage.write(_page,report ,passwordtxt, Password, "Enter invalid Password");
            await BasePage.click(_page,report, loginBtn, "Login Button");
            await BasePage.text(_page, report,asserttxt, "Flash Sale", "Assertion");

        }
    }
}
