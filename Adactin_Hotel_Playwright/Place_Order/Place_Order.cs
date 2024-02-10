using AventStack.ExtentReports.Model;
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
    public class Place_Order : PlaceOrderData
    {
        private readonly IPage _page;
        private readonly ILocator new_address;
        private readonly ILocator fullname;
        private readonly ILocator mobileno;
        private readonly ILocator province;
        private readonly ILocator city;
        private readonly ILocator area;
        private readonly ILocator address;
        private readonly ILocator delivery;
        private readonly ILocator savebtn;
        private readonly ILocator confirmbtn;
        private readonly ILocator changebtn;
        private readonly ILocator editbtn;
        private readonly ILocator placeorderbtn;
        private readonly ILocator emaileditbtn;
        private readonly ILocator emaileditconfirmbtn;
        private readonly ILocator assertion_email;
        private readonly ILocator checkbox_shippingaddress;
        private readonly ILocator checkbox_billingaddress;

        public Place_Order(IPage page)
        {
            _page = page;
            emaileditbtn = _page.Locator("#editableText_3_0 > div > span.action-edit");
            emaileditconfirmbtn = _page.GetByText("Confirm");
            changebtn = _page.Locator(".action-edit").First;
            assertion_email = _page.GetByText("talhadogar104@gmail.com");
            //new_address = _page.Locator("#deliveryV2_1");
            //editbtn = _page.GetByRole(AriaRole.Button, new()
            //{
            //    NameRegex = new Regex("EDIT", RegexOptions.IgnoreCase)
            //});
            editbtn = _page.GetByText("Add New Address");
            fullname = _page.GetByPlaceholder("Input full name");
            mobileno = _page.GetByPlaceholder("Input mobile number");
            //province = _page.GetByRole(AriaRole.Heading, new()
            //{
            //    Name = "Please choose your province"
            //});
            province = _page.Locator("#dialog-body-1 > div.mod-address-dialog-content > div > form > div > div.mod-address-form-bd > div.mod-address-form-left > div.mod-select.mod-address-form-select.mod-select-location-tree-1 > span > span");
            city = _page.GetByText("Please choose your city/municipality");
            area = _page.Locator("#dialog-body-1 > div.mod-address-dialog-content > div > div.next-tabs-content > div > div > form > div > div.mod-address-form-bd > div.mod-address-form-left > div.mod-select.disable.mod-address-form-select.mod-select-location-tree-3 > span");
            address = _page.GetByPlaceholder("House no. / building / street / area");
            //delivery = _page.GetByRole(AriaRole.Button, new()
            //{
            //    NameRegex = new Regex("Home", RegexOptions.IgnoreCase)
            //});
            delivery = _page.Locator("#dialog-body-1 > div.mod-address-dialog-content > div > form > div > div.mod-address-form-bd > div.mod-address-form-right > div.mod-address-tag > div > div.mod-address-tag-item.mod-address-tag-home");
            savebtn = _page.GetByRole(AriaRole.Button, new()
            {
                NameRegex = new Regex("Save", RegexOptions.IgnoreCase)
            });
            confirmbtn = _page.GetByRole(AriaRole.Button, new()
            {
                NameRegex = new Regex("Confirm", RegexOptions.IgnoreCase)
            });
            placeorderbtn = _page.GetByRole(AriaRole.Button, new()
            {
                NameRegex = new Regex("Place Order", RegexOptions.IgnoreCase)
            });
            checkbox_shippingaddress = _page.Locator("isDefaultShipping");
            checkbox_billingaddress = _page.Locator("isDefaultBilling");
        }
        [AllureStep("Place Order")]
        public async Task PlaceOrder()
        {
            ExtentReport.ChildNode("Place Order");
            //await new_address.ClickAsync();
            await BasePage.text(_page,report,assertion_email, Assert_email,"Assertion");
            await BasePage.click(_page,report,emaileditbtn,"Click on Email edit btn");
            await BasePage.click(_page,report,emaileditconfirmbtn,"Click on Email confirm btn");
            await BasePage.click(_page, report, changebtn, "Click On Change_Button");
            //await changebtn.ClickAsync();
            await BasePage.click(_page, report, editbtn, "Click On Edit_Button");
            //await editbtn.ClickAsync();
            await BasePage.write(_page, report, fullname, Fullname, "Enter Fullname");
            //await fullname.FillAsync("Talha Idrees");
            await BasePage.write(_page, report, mobileno, MobileNo, "Enter Mobile_No");
            //await mobileno.FillAsync("03139595854");
            Thread.Sleep(2000);
            await BasePage.click(_page, report, province, "Click On Province_Button");
            //await province.ClickAsync();
            Thread.Sleep(2000);
            await BasePage.press(_page, report, province, "s", "Enter Province_Name");
            //await province.PressAsync("s");
            await BasePage.press(_page, report, province, "Enter", "Select Province_Name");
            //await province.PressAsync("Enter");
            Thread.Sleep(2000);
            await BasePage.click(_page, report, city, "Click On City_Button");
            //await city.ClickAsync();
            Thread.Sleep(2000);
            await BasePage.press(_page, report, city, "k", "Enter City_Name");
            //await city.PressAsync("k");
            await BasePage.arrow(_page,report,"ArrowDown","Down");
            //await _page.Keyboard.DownAsync("ArrowDown");
            await BasePage.arrow(_page, report, "ArrowDown", "Down");
            //await _page.Keyboard.DownAsync("ArrowDown");
            await BasePage.arrow(_page, report, "ArrowDown", "Down");
            //await _page.Keyboard.DownAsync("ArrowDown");
            await BasePage.arrow(_page, report, "ArrowDown", "Down");
            //await _page.Keyboard.DownAsync("ArrowDown");
            await BasePage.press(_page, report, province, "Enter", "Select City");
            //await city.PressAsync("Enter");

            Thread.Sleep(4000);
            //await area.ClickAsync();
            //await _page.Keyboard.DownAsync("ArrowDown");
            //Thread.Sleep(2000);
            ////await area.PressAsync("A");
            //await area.PressAsync("Enter");
            //Thread.Sleep(2000);
            await BasePage.write(_page, report, address, Address, "Enter Address");
            //await address.FillAsync("Nazimabad");
            Thread.Sleep(2000);
            await BasePage.click(_page, report, delivery, "Click On Delivery_Button");
            //await delivery.ClickAsync();
            Thread.Sleep(2000);
            await BasePage.click(_page,report,checkbox_shippingaddress,"Click on shipping checkbox ");
            await BasePage.click(_page,report,checkbox_billingaddress,"Click on billing checkbox ");
            await BasePage.click(_page, report, savebtn, "Click On Save_Button");
            //await savebtn.ClickAsync();
            Thread.Sleep(2000);
            await BasePage.click(_page, report, confirmbtn, "Click On Confirmation_Button");
            //await confirmbtn.ClickAsync();
            Thread.Sleep(2000);
            await BasePage.click(_page, report, placeorderbtn, "Click On PlaceOrder_Button");
           // await placeorderbtn.ClickAsync();
            Thread.Sleep(5000);
            
        }
    }
}
