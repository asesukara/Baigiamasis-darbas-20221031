using ClassLibrary1.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ClassLibrary2.Test
{
    public class BaigiamasisDTest
    {
        private static WebDriver chromeDriver;
        //private static BaigiamasisDPage page;?????????????????????


        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            //chromeDriver = CustomDriver.GetChromeDriver();
            chromeDriver = new ChromeDriver();
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        //[OneTimeTearDown]
        //public static void OneTimeTearDown()
        //{
        //    chromeDriver.Quit();
        //}

        [Order(1)]
        [Test]
        public static void PPirmasTestas()
        {
            BaigiamasisDPage page = new BaigiamasisDPage(chromeDriver);

            //IReadOnlyCollection<IWebElement> fivePayMethods => Driver.FindElements(By.CssSelector(".footer-bottom__list"));
            //;

            page.NavigateToPage();
            page.CloseButton();
            page.InsertTextToInputField();
            page.SearchButton();
            page.CloseCookiesButton();
            page.AddToCardFirstButton();
            page.ContinueFirstButton();
            page.AddToCardSecondButton();
            page.ContinueSecondButton();
            page.ContinueCardButton();
            page.CardButton();
            page.PayseraElement();
            page.SebElement();
            page.MasterCardElement();
            page.VisaElement();
            page.SwedbankElement();
            page.AllFiveList();
            page.ResultFivePayMethods();
            page.ResultInputFieldText();
        }

        [Order(2)]
        [Test]
        public static void AAntrasTestas()
        {
            BaigiamasisDPage2 page = new BaigiamasisDPage2(chromeDriver);

            page.NavigateToPage();
            page.CloseButton();
            page.CloseCookiesButton();
            page.ContactsButton();
            page.SelectKaunasButton();
            page.FirstShopElement();
            page.FirstShopWorkTime();
            page.SecondShopElement();
            page.SecondShopWorkTime();
            page.ResultRaudondvaris();
            page.ResultNarsieciu();
        }
        [Order(3)]
        [Test]
        public static void TTreciasTestas()
        {
            BaigiamasisDPage3 page = new BaigiamasisDPage3(chromeDriver);

            page.NavigateToPage();
            page.CloseButton();
            page.CloseCookieButton();
            page.EParduotuveButton();
            page.EShoplistResult();
        }
        [Order(4)]
        [Test]
        public static void KKetvirtasTestas()
        {
            BaigiamasisDPage4 page = new BaigiamasisDPage4(chromeDriver);

            page.NavigateToPage();
            page.CloseButton();
            page.CloseCookiesButton();
            page.InsertTextToInputField();
            page.SearchButton();
            page.ResultKeyElement();
            page.SearchVerifyResult();
        }
        [Order(5)]
        [Test]
        public static void PPenktasTestas()
        {
            BaigiamasisDPage5 page = new BaigiamasisDPage5(chromeDriver);

            page.NavigateToPage();
            page.CloseButton();
            page.InsertTextToInputField();
            page.SearchButton();
            page.CloseCookiesButton();
            page.AddToCardFirstButton();
            page.ContinueFirstButton();
            page.AddToCardSecondButton();
            page.ContinueSecondButton();
            page.ContinueCardButton();
            page.CardButton();
            page.MethylanWoodchip2Button();
            page.MethylanWoodchipElement2();
            page.MethylanVinylAndSpezial1Element();
            page.TwoCountResult();
        }

    }

}




