using Adactin_Hotel_Playwright;
using Microsoft.Playwright;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Adactin_Hotel_Playwright
{
    public class AddtoCart : AddToCartData
    {
        private readonly IPage _page;
        private readonly ILocator Sizebutton;
        private readonly ILocator quantityadd;
        private readonly ILocator quantitydown;
        private readonly ILocator addtocart;
        private readonly ILocator asserttxt;
        private readonly ILocator GoToCart;
        public AddtoCart(IPage page)
        {
            _page = page;
            asserttxt = _page.Locator(".pdp-mod-product-badge-title");
            Sizebutton = _page.Locator(".sku-variable-size").First;
            quantityadd = _page.Locator(".next-number-picker-handler-up-inner");
            quantitydown = _page.Locator(".next-number-picker-handler-down-inner");
            var addtocart = _page.QuerySelectorAsync("button.pdp-button_theme_orange");
            GoToCart = _page.GetByRole(AriaRole.Button, new()
            {
                NameRegex = new Regex("GO TO CART", RegexOptions.IgnoreCase)
            });

        }
        [AllureStep("Add To Cart")]
        public async Task Addcart()
        {
            ExtentReport.ChildNode("Add to Cart");
            //await Assertions.Expect(asserttxt).ToHaveTextAsync("The Vintage Clothing Pack of 5 plain half sleeves T shirts for men");
            //await BasePage.text(_page,report,asserttxt, Expected,"Assertion");
            //await Assertions.Expect(Sizebutton).ToHaveTextAsync("M");
            await BasePage.click(_page,report,Sizebutton,"Click on Size");
            //await Sizebutton.ClickAsync();
            Thread.Sleep(1000);
            await BasePage.Doubleclick(_page, report, quantityadd, "Quantity_Add");
            //await quantityadd.DblClickAsync();
            Thread.Sleep(1000);
            await BasePage.click(_page, report, quantitydown, "Quantity_Minus");
            //await quantitydown.ClickAsync();
            Thread.Sleep(1000);
            //var addToCartButton = await _page.QuerySelectorAsync("button.pdp-button_theme_orange");
            await BasePage.locQ(_page,report,"Click on Addtocart_Button");
            //await addToCartButton.ClickAsync();
            Thread.Sleep(5000);
            await BasePage.click(_page, report, GoToCart, "Click on GotoCart_Button");
            //await GoToCart.ClickAsync();
            Thread.Sleep(10000);
        }
    }
}
