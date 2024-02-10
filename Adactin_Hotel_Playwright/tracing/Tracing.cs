using AventStack.ExtentReports.Gherkin.Model;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Allure.Core;
using RazorEngine.Compilation.ImpromptuInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Adactin_Hotel_Playwright
{
    [TestFixture]
    public class Tracing
    {
        [Test]
        public async Task Trace()
        {
            var playwright = await Playwright.CreateAsync();
            var Browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = false,
                    Channel = "chrome",
                    SlowMo = 5,
                });
            var context = await Browser.NewContextAsync();
            await context.Tracing.StartAsync(new()
            {
                Screenshots=true,
                Snapshots=true,
                Sources=true,
            });
            var page = await context.NewPageAsync();
            await page.SetViewportSizeAsync(1920,1080);

            await page.GotoAsync("https://www.daraz.pk/");
            await page.Locator("#anonLoginNew > span").ClickAsync();
            await page.GetByPlaceholder("Please enter your Phone Number or Email").FillAsync("talhadogar104@gmail.com");
            await page.GetByPlaceholder("Please enter your password").FillAsync("Talha@12");
            await page.Locator("#container > div > div:nth-child(2) > form > div > div.mod-login-col2 > div.mod-login-btn > button").ClickAsync();
            await page.Locator("#Level_1_Category_No9 > a > span.txt-holder").ClickAsync();
            await page.Locator("#J_5022174600 > div > ul > ul.lzd-site-menu-sub.Level_1_Category_No9 > li:nth-child(1)").First.ClickAsync();
            await page.GetByPlaceholder("Search in Daraz").FillAsync("The Vintage Clothing Pack of 5 basic premium full sleeves T shirts");
            await page.Locator("#topActionHeader > div.lzd-header-content > div.lzd-logo-bar > div > div.lzd-nav-search.reduceWidthOfSearchBar > form > div > div.search-box__search--2fC5 > button").ClickAsync();
            await page.GetByTitle("The Vintage Clothing Pack of 5 basic premium full sleeves T shirts").First.ClickAsync();
            await page.Locator(".sku-variable-size").First.ClickAsync();
            await page.Locator(".next-number-picker-handler-up-inner").DblClickAsync();
            await page.Locator(".next-number-picker-handler-down-inner").ClickAsync(); ;
            await page.Locator("#module_add_to_cart > div > button.add-to-cart-buy-now-btn.pdp-button.pdp-button_type_text.pdp-button_theme_orange.pdp-button_size_xl").ClickAsync();
            var gotocart = page.GetByRole(AriaRole.Button, new()
            {
                NameRegex = new Regex("GO TO CART", RegexOptions.IgnoreCase)
            });
            gotocart.ClickAsync();
            await page.GetByText("Delete").ClickAsync();
            await page.Locator("#listHeader_H > div > div > div.checkbox-wrap > label > input[type=checkbox]").ClickAsync();
            await page.WaitForLoadStateAsync();
            await page.GetByText("PROCEED TO CHECKOUT (1)").ClickAsync();
            var assertion = page.GetByText("talhadogar104@gmail.com");
            await Assertions.Expect(assertion).ToHaveTextAsync("talhadogar104@gmail.com");
            await page.Locator("#editableText_3_0 > div > span.action-edit").ClickAsync();
            await page.GetByText("Confirm").ClickAsync();
            await page.Locator("#addressV2_2_1 > div > span.action-edit").ClickAsync();
            var assertion1 = page.GetByText("My Billing Address");
            await Assertions.Expect(assertion1).ToHaveTextAsync("My Billing Address");
            await page.Locator("#dialog-body-4 > div.mod-address-dialog-content > div > div > div.mod-address-book-content > div > div.mod-address-book-card.mod-address-book-card-active > div.mod-address-book-card-name > button").ClickAsync();
            var assertion2 = page.GetByText("Edit Address");
            await Assertions.Expect(assertion2).ToHaveTextAsync("Edit Address");
            await page.GetByPlaceholder("Input full name").ClickAsync();
            await page.Keyboard.PressAsync("Enter");
            await page.GetByText("Confirm").ClickAsync();
            await context.Tracing.StopAsync(new()
            {
                Path = "trace/trace.zip"
            });
            await context.CloseAsync();
            await page.CloseAsync();
        }
    }
}
