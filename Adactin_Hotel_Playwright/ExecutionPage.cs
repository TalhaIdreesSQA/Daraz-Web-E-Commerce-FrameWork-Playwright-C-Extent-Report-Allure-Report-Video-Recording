using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using System.Text.RegularExpressions;

namespace Adactin_Hotel_Playwright
{
    [TestFixture]
    [AllureNUnit]
    public class Tests : PageTest
    {
        //[OneTimeSetUp]
        //[AllureBefore]
        //public async Task ClassSetup()
        //{
        //    ExtentReport.exParentTest = ExtentReport.extentReports.CreateTest(TestContext.CurrentContext.Test.MethodName);
        //}
        //[OneTimeTearDown]
        //[AllureAfter]
        //public async Task ClassTearDown()
        //{

        //}

        [SetUp]
        [AllureBefore]
        public async Task Setup()
        {
            ExtentReport.LogReport("TestReport");

        }
        
        [TearDown]
        [AllureAfter]
        public async Task TearDown()
        {
            ExtentReport.extentReports.Flush();
        }
        //[Test]
        //[AllureStep]
        //[AllureEpic("Hotel Epic")]
        //[AllureFeature("Booking Hotel User Story")]
        //[AllureOwner("Talha Idrees")]
        //[Category("Allure")]
        //public async Task Test1()
        //{
        //    var playwright = await Playwright.CreateAsync();
        //    var Browser = await playwright.Chromium.LaunchAsync(
        //        new BrowserTypeLaunchOptions { Headless = false, SlowMo = 50, Timeout = 80000 });
        //    var context = await Browser.NewContextAsync();
        //    var page = await context.NewPageAsync();

        //    await page.GotoAsync("https://adactinhotelapp.com/");
        //    await page.FillAsync("#username", "user2here");
        //    await page.FillAsync("#password", "user123");
        //    await page.ClickAsync("#login");

        //    var locator = page.Locator(".welcome_menu").First;
        //    await Assertions.Expect(locator).ToHaveTextAsync(new Regex("Welcome to Adactin Group of Hotels"));

        //    await page.CloseAsync();
        //}

        //[Test]
        //public async Task Test2()
        //{
        //    var playwright = await Playwright.CreateAsync();
        //    var Browser = await playwright.Chromium.LaunchAsync(
        //        new BrowserTypeLaunchOptions
        //        {
        //            Headless = false,
        //            Channel = "chrome",
        //            SlowMo = 50,
        //            Timeout = 80000
        //        });
        //    var context = await Browser.NewContextAsync(new()
        //    {
        //        RecordVideoDir = "video/",
        //        RecordVideoSize = new RecordVideoSize()
        //        {
        //            Width = 1366,
        //            Height = 768
        //        },
        //        ViewportSize = new ViewportSize()
        //        {
        //            Width = 1366,
        //            Height = 768
        //        }
        //    });
        //    var page = await context.NewPageAsync();

        //    await page.GotoAsync("https://adactinhotelapp.com/");
        //    await page.Locator("#username").FillAsync("user2here");
        //    await page.Locator("#password").FillAsync("user123");
        //    await page.Locator("#login").ClickAsync();

        //    var locator = page.Locator(".welcome_menu").First;
        //    await Assertions.Expect(locator).ToHaveTextAsync(new Regex("Welcome to Adactin Group of Hotels"));

        //    await page.TypeAsync("#location", "Sydney");
        //    await page.TypeAsync("#hotels", "Hotel Creek");
        //    await page.TypeAsync("#room_type", "Standard");
        //    await page.TypeAsync("#room_nos", "2 - Two");
        //    await page.TypeAsync("#datepick_in", "25/05/2023");
        //    await page.TypeAsync("#datepick_out", "25/06/2023");
        //    await page.TypeAsync("#adult_room", "2 - Two");
        //    await page.TypeAsync("#child_room", "1 - One");
        //    await page.ClickAsync("#Submit");
        //    await page.ClickAsync("#radiobutton_0");
        //    await page.ClickAsync("#continue");
        //    await page.CloseAsync();
        //}

        //[Test]
        //public async Task Test3()
        //{
        //    var playwright = await Playwright.CreateAsync();
        //    var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        //    {
        //        Headless = false,
        //        Channel = "chrome",
        //        SlowMo = 50,
        //        Timeout = 80000
        //    });
        //    var context = await browser.NewContextAsync();
        //    await context.Tracing.StartAsync(new()
        //    {
        //        Screenshots = true,
        //        Snapshots = true,
        //        Sources = true
        //    });
        //    var page = await context.NewPageAsync();
        //    await page.SetViewportSizeAsync(1366,768);

        //    await page.GotoAsync("https://adactinhotelapp.com/");
        //    await page.Locator("#username").FillAsync("user2here");
        //    await page.Locator("#password").FillAsync("user123");
        //    await page.Locator("#login").ClickAsync();

        //    var locator = page.Locator(".welcome_menu").First;
        //    await Assertions.Expect(locator).ToHaveTextAsync(new Regex("Welcome to Adactin Group of Hotels"));
        //    await page.TypeAsync("#location", "Sydney");
        //    await page.TypeAsync("#hotels", "Hotel Creek");
        //    await page.TypeAsync("#room_type", "Standard");
        //    await page.TypeAsync("#room_nos", "2 - Two");
        //    await page.TypeAsync("#datepick_in", "25/05/2023");
        //    await page.TypeAsync("#datepick_out", "25/06/2023");
        //    await page.TypeAsync("#adult_room", "2 - Two");
        //    await page.TypeAsync("#child_room", "1 - One");
        //    await page.ClickAsync("#Submit");
        //    await page.ClickAsync("#radiobutton_0");
        //    await page.ClickAsync("#continue");
        //    await page.CloseAsync();

        //    await context.Tracing.StopAsync(new()
        //    {
        //        Path = "trace/trace.zip"
        //    });
        //    await context.CloseAsync();
        //    await browser.CloseAsync();

        //}
        //[Test]
        //public async Task SaveState()
        //{
        //    var playwright = await Playwright.CreateAsync();
        //    var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        //    {
        //        Headless = false,
        //        Channel = "chrome",
        //        SlowMo = 50,
        //        Timeout = 80000
        //    });

        //    var context = await browser.NewContextAsync();
        //    var page = await context.NewPageAsync();

        //    await page.GotoAsync("https://adactinhotelapp.com/");
        //    await page.Locator("#username").FillAsync("user2here");
        //    await page.Locator("#password").FillAsync("user123");
        //    await page.Locator("#login").ClickAsync();
        //    var locator = page.Locator(".welcome_menu").First;
        //    await Assertions.Expect(locator).ToHaveTextAsync(new Regex("Welcome to Adactin Group of Hotels"));

        //    //statesave

        //    await context.StorageStateAsync(new()
        //    {
        //        Path = @"state\state_login.json"
        //        //Don't create folder,plz create manually
        //    });

        //    await context.CloseAsync();
        //    await browser.CloseAsync();


        //}
        //[Test]
        //public async Task RetrieveSaveState()
        //{
        //    var playwright = await Playwright.CreateAsync();
        //    var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        //    {
        //        Headless = false,
        //        Channel = "chrome",
        //        SlowMo = 50,
        //        Timeout = 80000
        //    });

        //    var context = await browser.NewContextAsync(new()
        //    {
        //        StorageStatePath = @"state\state_login.json"
        //    });

        //    var page = await context.NewPageAsync();
        //    Thread.Sleep(3000);
        //    await page.GotoAsync("https://adactinhotelapp.com/SearchHotel.php");
        //    await page.TypeAsync("#location", "Sydney");
        //    await page.TypeAsync("#hotels", "Hotel Creek");
        //    await page.TypeAsync("#room_type", "Standard");
        //    await page.TypeAsync("#room_nos", "2 - Two");
        //    await page.TypeAsync("#datepick_in", "25/05/2023");
        //    await page.TypeAsync("#datepick_out", "25/06/2023");
        //    await page.TypeAsync("#adult_room", "2 - Two");
        //    await page.TypeAsync("#child_room", "1 - One");
        //    await page.ClickAsync("#Submit");
        //    await page.ClickAsync("#radiobutton_0");
        //    await page.ClickAsync("#continue");
        //    await page.CloseAsync();

        //    await context.CloseAsync();
        //    await browser.CloseAsync();


        //}

        [Test]
        [Category("Allure")]
        [AllureOwner("Talha Idrees")]
        public async Task LoginPage_001()
        {
            ExtentReport.ParentNode(NUnit.Framework.TestContext.CurrentContext.Test.Name);
            
            LoginPage loginPage = new LoginPage(Page);
            
            
            await loginPage.Login();
            
        }
        [Test]
        [AllureOwner("Talha Idrees")]
        public async Task Mens_fashion()
        {
            ExtentReport.ParentNode(NUnit.Framework.TestContext.CurrentContext.Test.Name);
            
            LoginPage loginPage = new LoginPage(Page);
            Men_s_Fashion mensfaction = new Men_s_Fashion(Page);
            await loginPage.Login();
            
            await mensfaction.Mens_Fashion();
        }
        [Test]
        [AllureOwner("Talha Idrees")]
        public async Task Addtocart()
        {
            ExtentReport.ParentNode(NUnit.Framework.TestContext.CurrentContext.Test.Name);
            LoginPage loginPage = new LoginPage(Page);
            Men_s_Fashion mensfaction = new Men_s_Fashion(Page);
            AddtoCart addtocart = new AddtoCart(Page);
            await loginPage.Login();
            await mensfaction.Mens_Fashion();
            await addtocart.Addcart();
        }
        [Test]
        [AllureOwner("Talha Idrees")]
        public async Task CHechoutt()
        {
            ExtentReport.ParentNode(NUnit.Framework.TestContext.CurrentContext.Test.Name);
            LoginPage loginPage = new LoginPage(Page);
            Men_s_Fashion mensfaction = new Men_s_Fashion(Page);
            AddtoCart addtocart = new AddtoCart(Page);
            Checkout checkout = new Checkout(Page);
            await loginPage.Login();
            await mensfaction.Mens_Fashion();
            await addtocart.Addcart();
            await checkout.CheckOut();
        }
        [Test]
        [AllureOwner("Talha Idrees")]
        public async Task Place_Orderr()
        {
            ExtentReport.ParentNode(NUnit.Framework.TestContext.CurrentContext.Test.Name);
            LoginPage loginPage = new LoginPage(Page);
            Men_s_Fashion mensfaction = new Men_s_Fashion(Page);
            AddtoCart addtocart = new AddtoCart(Page);
            Checkout checkout = new Checkout(Page);
            Place_Order place_Order = new Place_Order(Page);
            await loginPage.Login();
            await mensfaction.Mens_Fashion();
            await addtocart.Addcart();
            await checkout.CheckOut();
            await place_Order.PlaceOrder();
        }
        //[Test]
        //[Category("ExtentReport")]
        //public async Task Extent()
        //{


        //    LoginPage loginPage = new LoginPage(Page);
        //    await loginPage.Login("https://www.daraz.pk/", "talhadogar104@gmail.com", "Talha@12");

        //}

        //[SetUpFixture]
        //public class AssembltInit
        //{
        //    [OneTimeSetUp]
        //    public static void Assemblylevelsetup()
        //    {

        //    }
        //    [OneTimeTearDown]

        //    public static void AssemblylevelTearDown()
        //    {

        //    }
    }
        //}
}