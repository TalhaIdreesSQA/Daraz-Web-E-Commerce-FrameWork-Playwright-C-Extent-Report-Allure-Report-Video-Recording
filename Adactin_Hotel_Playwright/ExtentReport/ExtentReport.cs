using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;

namespace Adactin_Hotel_Playwright
{
    public class ExtentReport
    {
        public static ExtentReports extentReports;
        public static ExtentTest exParentTest;
        public static ExtentTest exChildTest;
        public static string dirpath;

        public static string pathWithFileNameExtension;
        private readonly IPage _page;
        public static void ParentNode(string name)
        {
            exParentTest = extentReports.CreateTest(name);
        }
        public static void ChildNode(string name)
        {
            exChildTest = exParentTest.CreateNode(name);
        }
        public static void LogReport(string testcase)
        {
            extentReports = new ExtentReports();
            dirpath = @"C:\Users\Taha\source\repos\Adactin_Hotel_Playwright\Adactin_Hotel_Playwright\Images\" + "_" + testcase;

            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(dirpath);
            htmlReporter.Config.Theme = Theme.Standard;
            extentReports.AttachReporter(htmlReporter);
        }
        public static async Task TakeScreenshot(IPage page, string stepDetail, Status status = Status.Pass)
        {
            string path = @"C:\Users\Taha\source\repos\Adactin_Hotel_Playwright\Adactin_Hotel_Playwright\Images\" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            pathWithFileNameExtension = @path + ".png";
            await page.Locator("body").ScreenshotAsync(new LocatorScreenshotOptions { Path = pathWithFileNameExtension });
            TestContext.AddTestAttachment(pathWithFileNameExtension);
            exChildTest.Log(status, stepDetail, MediaEntityBuilder
                .CreateScreenCaptureFromPath(path + ".png").Build());
        }
        public static async Task TakeScreenshotfailed(IPage page, string stepDetail, Status status = Status.Fail)
        {
            string path = @"C:\Users\Taha\source\repos\Adactin_Hotel_Playwright\Adactin_Hotel_Playwright\Images\" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            pathWithFileNameExtension = @path + ".png";
            await page.Locator("body").ScreenshotAsync(new LocatorScreenshotOptions { Path = pathWithFileNameExtension });
            TestContext.AddTestAttachment(pathWithFileNameExtension);
            exChildTest.Log(status, stepDetail, MediaEntityBuilder
                .CreateScreenCaptureFromPath(path + ".png").Build());
        }

        public static async Task VideoRecording()
        {
            var playwright = await Playwright.CreateAsync();
            var Browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = false,
                    Channel = "chrome",
                    SlowMo = 50,
                    Timeout = 80000
                });
            var context = await Browser.NewContextAsync(new()
            {
                RecordVideoDir = "video/",
                RecordVideoSize = new RecordVideoSize()
                {
                    Width = 1366,
                    Height = 768
                },
                ViewportSize = new ViewportSize()
                {
                    Width = 1366,
                    Height = 768
                }
            });
            //var page = await context.NewPageAsync();
            

        }
        public static async Task videoclose(IPage page)
        {
            await page.CloseAsync();
        }
    }
}
