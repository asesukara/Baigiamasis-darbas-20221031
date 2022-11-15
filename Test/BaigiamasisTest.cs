using BaigiamasisDarbas.Test;
using ClassLibrary1.Page;
using NUnit.Framework;
using static ClassLibrary1.Page.BaigiamasisDPage3;

namespace ClassLibrary2.Test
{
    public class BaigiamasisDTest : BaseTest
    {

        [Order(1)]
        [Test]
        public static void FivePayMethods()
        {
            BaigiamasisDPage page = new BaigiamasisDPage(chromeDriver);

            page.NavigateToPage();
            page.CloseButton();
            page.InsertTextToInputField("tapetų klijai Metylan 180 g");
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

        }

        [Order(2)]
        [Test]
        public static void TwoKaunasShopWorkSaturday()
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
        public static void ThreeAccountElements()
        {
            BaigiamasisDPage3 page = new BaigiamasisDPage3(chromeDriver);

            page.NavigateToPage();
            page.CloseButton();
            page.CloseCookieButton();
            page.EParduotuveButton();
            page.EShoplistResult();
            page.ArTrysElPaskyroje();
        }
        [Order(4)]
        [Test]
        public static void BlickTenSearch()
        {
            BaigiamasisDPage4 page = new BaigiamasisDPage4(chromeDriver);

            page.NavigateToPage();
            page.CloseButton();
            page.CloseCookiesButton();
            page.InsertTextToInputField("Blick 10");
            page.SearchButton();
            page.ResultKeyElement();
            page.SearchVerifyResult();
        }
        [Order(5)]
        [Test]
        public static void TwoMethylanGlueCount()
        {
            BaigiamasisDPage5 page = new BaigiamasisDPage5(chromeDriver);

            page.NavigateToPage();
            page.CloseButton();
            page.InsertTextToInputField("tapetų klijai Metylan 180 g");
            page.SearchButton();
            page.CloseCookiesButton();
            page.AddToCardFirstButton();
            page.ContinueFirstButton();
            page.AddToCardSecondButton();
            page.ContinueSecondButton();
            page.ContinueCardButton();
            page.CardButton();
            page.MethylanWoodchip2Button();
            page.MethylanWoodchipElement2("2");
            page.MethylanVinylAndSpezial1Element("1");
            page.TwoCountResult();
            page.IntTwoCount();
        }

    }

}




