using ClassLibrary1.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ClassLibrary2.Test
{
    public class BaigiamasisDTest
    {
        private static IWebDriver chromeDriver;

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
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

            page.NavigateToPage();
            page.InsertTextToInputField();
            page.ClickButton();
            page.ElementField();
            page.VerifyResult();
        }

        [Order(2)]
        [Test]
        public static void AAntrasTestas()
        {
            BaigiamasisDPage2 page = new BaigiamasisDPage2(chromeDriver);

            page.NavigateToPage();
            page.ClickButton();
            page.ElementField();
            page.VerifyResult();
        }

        [Order(3)]
        [Test]
        public static void TTreciasTestas()
        {
            BaigiamasisDPage3 page = new BaigiamasisDPage3(chromeDriver);

            page.NavigateToPage();
            page.ClickButton();
            page.VerifyResult();
        }

        [Order(4)]
        [Test]
        public static void KKetvirtasTestas()
        {
            BaigiamasisDPage4 page = new BaigiamasisDPage4(chromeDriver);

            page.NavigateToPage();
            page.InsertTextToInputField();
            page.ClickButton();
            page.ElementField();
            page.VerifyResult();


        }

        [Order(5)]
        [Test]
        public static void PPenktasTestas()
        {
            BaigiamasisDPage5 page = new BaigiamasisDPage5(chromeDriver);

            page.NavigateToPage();
            page.InsertTextToInputField();
            page.ClickButton();
            page.ElementField();
            page.VerifyResult();


        }

    }

}




