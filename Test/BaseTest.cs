using BaigiamasisDarbas.Tools;
using ClassLibrary1.Page;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using static ClassLibrary1.Page.BaigiamasisDPage3;

namespace BaigiamasisDarbas.Test
{
    public class BaseTest
    {
        protected static WebDriver chromeDriver;
        protected static BaigiamasisDPage page;
        protected static BaigiamasisDPage2 page2;
        protected static BaigiamasisDPage3 page3;
        protected static BaigiamasisDPage4 page4;
        protected static BaigiamasisDPage5 page5;

        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            chromeDriver = new ChromeDriver();
            page = new BaigiamasisDPage(chromeDriver);
            page2 = new BaigiamasisDPage2(chromeDriver);
            page3 = new BaigiamasisDPage3(chromeDriver);
            page4 = new BaigiamasisDPage4(chromeDriver);
            page5 = new BaigiamasisDPage5(chromeDriver);
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.TakeScreenshot(chromeDriver);
            }
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            chromeDriver.Quit();
        }

    }
}
