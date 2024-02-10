using Allure.Net.Commons;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adactin_Hotel_Playwright
{
    public class Allurereport
    {
        public static async Task AllurereportPass(IPage page, string stepdetails, Status status = Status.passed)
        {
            byte[] bytes = await page.ScreenshotAsync();
            AllureLifecycle.Instance.AddAttachment(stepdetails, "C:\\Users\\Taha\\source\\repos\\Adactin_Hotel_Playwright\\Adactin_Hotel_Playwright\\Images\\image.png", bytes);
        }
        public static async Task AllurereportFail(IPage page, string stepdetails, Status status = Status.failed)
        {
            byte[] bytes = await page.ScreenshotAsync();
            AllureLifecycle.Instance.AddAttachment(stepdetails, "C:\\Users\\Taha\\source\\repos\\Adactin_Hotel_Playwright\\Adactin_Hotel_Playwright\\Images\\image.png", bytes);
        }
    }
}
