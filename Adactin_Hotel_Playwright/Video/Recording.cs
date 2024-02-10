using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Adactin_Hotel_Playwright
{
    public class Recording
    {
        public async Task record(IPage page)
        {
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
            //var page = await context.NewPageAsync();
            await page.GotoAsync("https://www.daraz.pk/");
            await page.Locator("#anonLoginNew").DblClickAsync();
            await page.GetByPlaceholder("Please enter your Phone Number or Email").FillAsync("talhadogar104@gmail.com");
            await page.GetByPlaceholder("Please enter your password").FillAsync("Talha@12");
            //await page.GetByRole(AriaRole.Button, new()
            //{
            //    NameRegex = new Regex("LOGIN", RegexOptions.IgnoreCase)
            //});
            //var locator = page.Locator(".welcome_menu").First;
            //await Assertions.Expect(locator).ToHaveTextAsync(new Regex("Welcome to Adactin Group of Hotels"));
            //await page.GotoAsync("https://adactinhotelapp.com/");
            //await page.Locator("#username").FillAsync("user2here");
            //await page.Locator("#password").FillAsync("user123");
            //await page.Locator("#login").ClickAsync();

            //var locator = page.Locator(".welcome_menu").First;
            //await Assertions.Expect(locator).ToHaveTextAsync(new Regex("Welcome to Adactin Group of Hotels"));

            //await page.TypeAsync("#location", "Sydney");
            //await page.TypeAsync("#hotels", "Hotel Creek");
            //await page.TypeAsync("#room_type", "Standard");
            //await page.TypeAsync("#room_nos", "2 - Two");
            //await page.TypeAsync("#datepick_in", "25/05/2023");
            //await page.TypeAsync("#datepick_out", "25/06/2023");
            //await page.TypeAsync("#adult_room", "2 - Two");
            //await page.TypeAsync("#child_room", "1 - One");
            //await page.ClickAsync("#Submit");
            //await page.ClickAsync("#radiobutton_0");
            //await page.ClickAsync("#continue");
            //await page.CloseAsync();
            //await page.TypeAsync("#location", "Sydney");
            //await page.TypeAsync("#hotels", "Hotel Creek");
            //await page.TypeAsync("#room_type", "Standard");
            //await page.TypeAsync("#room_nos", "2 - Two");
            //await page.TypeAsync("#datepick_in", "25/05/2023");
            //await page.TypeAsync("#datepick_out", "25/06/2023");
            //await page.TypeAsync("#adult_room", "2 - Two");
            //await page.TypeAsync("#child_room", "1 - One");
            //await page.ClickAsync("#Submit");
            //await page.ClickAsync("#radiobutton_0");
            //await page.ClickAsync("#continue");
            //await page.CloseAsync();
        }
    }
}
