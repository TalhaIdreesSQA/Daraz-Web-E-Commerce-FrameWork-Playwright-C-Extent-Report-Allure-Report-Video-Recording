using AventStack.ExtentReports.Model;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adactin_Hotel_Playwright
{
    public class BasePage : PageTest
    {
        public static string report = "allurereport";
        //public static ILocator logintxt;
        //public static void click(IPage page,string locator) 
        //{
        //    logintxt = page.Locator(locator);
        //}
        public static async Task click(IPage page, string reportname, ILocator locator, string stepdetails)
        {
            reportname.ToLower();
            if (reportname == "extentreport")
            {
                try
                {
                    await locator.ClickAsync();
                    Thread.Sleep(2000);
                    await ExtentReport.TakeScreenshot(page, stepdetails);
                }
                catch (Exception)
                {
                    Thread.Sleep(2000);
                    await ExtentReport.TakeScreenshotfailed(page, stepdetails);
                    throw;
                }
            }
            else if (reportname == "allurereport")
            {
                try
                {
                    await locator.ClickAsync();
                    Thread.Sleep(2000);
                    await Allurereport.AllurereportPass(page, stepdetails);
                }
                catch (Exception)
                {
                    Thread.Sleep(2000);
                    await Allurereport.AllurereportFail(page, stepdetails);
                    throw;
                }
            }
        }
        public static async Task write(IPage page, string reportname, ILocator locator, string fill, string stepdetails)
        {
            reportname.ToLower();
            if (reportname == "extentreport")
            {
                try
                {
                    await locator.FillAsync(fill);
                    Thread.Sleep(2000);
                    await ExtentReport.TakeScreenshot(page, stepdetails);
                }
                catch (Exception)
                {
                    Thread.Sleep(2000);
                    await ExtentReport.TakeScreenshotfailed(page, stepdetails);
                    throw;
                }
            }
            else if (reportname == "allurereport")
            {
                try
                {
                    await locator.FillAsync(fill);
                    Thread.Sleep(2000);
                    await Allurereport.AllurereportPass(page, stepdetails);
                }
                catch (Exception)
                {
                    Thread.Sleep(2000);
                    await Allurereport.AllurereportFail(page, stepdetails);
                    throw;
                }

            }
        }
        public static async Task text(IPage page, string reportname, ILocator locator, string expect, string stepdetails)
        {
            if (reportname == "extentreport")
            {
                try
                {
                    await Assertions.Expect(locator).ToHaveTextAsync(expect);
                    Thread.Sleep(3000);
                    await ExtentReport.TakeScreenshot(page, stepdetails);
                }
                catch (Exception)
                {
                    Thread.Sleep(2000);
                    await ExtentReport.TakeScreenshotfailed(page, stepdetails);
                    throw;
                }
            }
            else if (reportname == "allurereport")
            {
                try
                {
                    await Assertions.Expect(locator).ToHaveTextAsync(expect);
                    Thread.Sleep(2000);
                    await Allurereport.AllurereportPass(page, stepdetails);
                }
                catch (Exception)
                {
                    Thread.Sleep(2000);
                    await Allurereport.AllurereportFail(page, stepdetails);
                    throw;
                }

            }

        }
        public static async Task press(IPage page, string reportname, ILocator locator, string fill, string stepdetails)
        {
            reportname.ToLower();
            if (reportname == "extentreport")
            {
                try
                {
                    await locator.PressAsync(fill);
                    Thread.Sleep(2000);
                    await ExtentReport.TakeScreenshot(page, stepdetails);
                }
                catch (Exception)
                {
                    Thread.Sleep(2000);
                    await ExtentReport.TakeScreenshotfailed(page, stepdetails);
                    throw;
                }
            }
            else if (reportname == "allurereport")
            {
                try
                {
                    await locator.PressAsync(fill);
                    Thread.Sleep(2000);
                    await Allurereport.AllurereportPass(page, stepdetails);
                }
                catch (Exception)
                {
                    Thread.Sleep(2000);
                    await Allurereport.AllurereportFail(page, stepdetails);
                    throw;
                }

            }
        }
        public static async Task arrow(IPage page, string reportname, string fill, string stepdetails)
        {
            reportname.ToLower();
            if (reportname == "extentreport")
            {
                try
                {
                    await page.Keyboard.DownAsync(fill);
                    //await locator.PressAsync(fill);
                    Thread.Sleep(2000);
                    await ExtentReport.TakeScreenshot(page, stepdetails);
                }
                catch (Exception)
                {
                    Thread.Sleep(2000);
                    await ExtentReport.TakeScreenshotfailed(page, stepdetails);
                    throw;
                }
            }
            else if (reportname == "allurereport")
            {
                try
                {
                    await page.Keyboard.DownAsync(fill);
                    Thread.Sleep(2000);
                    await Allurereport.AllurereportPass(page, stepdetails);
                }
                catch (Exception)
                {
                    Thread.Sleep(2000);
                    await Allurereport.AllurereportFail(page, stepdetails);
                    throw;
                }

            }
        }
        public static async Task Doubleclick(IPage page, string reportname, ILocator locator, string stepdetails)
        {
            reportname.ToLower();
            if (reportname == "extentreport")
            {
                try
                {
                    await locator.DblClickAsync();
                    Thread.Sleep(2000);
                    await ExtentReport.TakeScreenshot(page, stepdetails);
                }
                catch (Exception)
                {
                    Thread.Sleep(2000);
                    await ExtentReport.TakeScreenshotfailed(page, stepdetails);
                    throw;
                }
            }
            else if (reportname == "allurereport")
            {
                try
                {
                    await locator.ClickAsync();
                    Thread.Sleep(2000);
                    await Allurereport.AllurereportPass(page, stepdetails);
                }
                catch (Exception)
                {
                    Thread.Sleep(2000);
                    await Allurereport.AllurereportFail(page, stepdetails);
                    throw;
                }
            }
        }
        public static async Task locQ(IPage page, string reportname, string stepdetails)
        {
            reportname.ToLower();
            if (reportname == "extentreport")
            {
                try
                {
                    var addToCartButton = await page.QuerySelectorAsync("button.pdp-button_theme_orange");
                    await addToCartButton.ClickAsync();
                    Thread.Sleep(2000);
                    await ExtentReport.TakeScreenshot(page, stepdetails);
                }
                catch (Exception)
                {
                    Thread.Sleep(2000);
                    await ExtentReport.TakeScreenshotfailed(page, stepdetails);
                    throw;
                }
            }
            else if (reportname == "allurereport")
            {
                try
                {
                    var addToCartButton = await page.QuerySelectorAsync("button.pdp-button_theme_orange");
                    await addToCartButton.ClickAsync();
                    Thread.Sleep(2000);
                    await Allurereport.AllurereportPass(page, stepdetails);
                }
                catch (Exception)
                {
                    Thread.Sleep(2000);
                    await Allurereport.AllurereportFail(page, stepdetails);
                    throw;
                }
            }
        }

    }
}
