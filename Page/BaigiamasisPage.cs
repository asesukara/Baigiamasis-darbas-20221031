using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace ClassLibrary1.Page
{

    public class BaigiamasisDPage : BasePage
    {
        private string pageAddress => "https://www.mokivezi.lt";
        private IWebElement button => Driver.FindElement(By.Id("omnisend-form-6357d3f0e5b07c084437c2fe-close-action"));
        private IWebElement inputField => Driver.FindElement(By.Id("search"));
        private IWebElement button2 => Driver.FindElement(By.CssSelector(".btn.btn-primary.header-search-form__submit-btn.medium-link"));
        private IWebElement button3 => Driver.FindElement(By.CssSelector(".cookie-notice__btn.btn.btn-primary"));
        private IWebElement button4 => Driver.FindElement(By.CssSelector("body > div.main-content.container > div > div.col-12.col-md-8.col-lg-9.loadable > div.row.row--small-gutter.mt-5 > div:nth-child(1) > div > div.position-relative > div > form > div.product-quantity > div.pl-xl-0.product-quantity__col-submit > button.btn.btn-block.btn-primary.product-quantity__submit.item-add-to-cart"));
        private IWebElement button5 => Driver.FindElement(By.CssSelector(".btn.btn-transparent"));
        private IWebElement button6 => Driver.FindElement(By.CssSelector("body > div.main-content.container > div > div.col-12.col-md-8.col-lg-9.loadable > div.row.row--small-gutter.mt-5 > div:nth-child(2) > div > div.position-relative > div > form > div.product-quantity > div.pl-xl-0.product-quantity__col-submit > button.btn.btn-block.btn-primary.product-quantity__submit.item-add-to-cart"));
        private IWebElement button7 => Driver.FindElement(By.CssSelector(".btn.btn-transparent"));
        private IWebElement button8 => Driver.FindElement(By.CssSelector("body > header > div.header-category-container.mt-4 > div > div > nav > div.col-3.header-categories__side.header-categories__side--right > div > div.mr-2.dropdown-btn-wrapper > div > div.input-style-reset.basket-btn.d-flex.align-items-center.noselect > span.basket-btn__text.medium-link.mx-1.d-none.d-md-block"));
        private IWebElement button9 => Driver.FindElement(By.CssSelector("body > header > div.header-category-container.mt-4 > div > div > nav > div.col-3.header-categories__side.header-categories__side--right > div > div.mr-2.dropdown-btn-wrapper > div > div.dropdown-menu.dropdown-menu-right.p-0.mini-cart__dropdown.show > div.mini-cart__btn-wrapper > a.btn.btn-primary.btn-block.mini-cart__btn"));
        private IWebElement element => Driver.FindElement(By.CssSelector("body > div.footer-bottom.mt-4 > div > div > div > div:nth-child(2) > div > img:nth-child(1)"));
        private IWebElement element1 => Driver.FindElement(By.CssSelector("body > div.footer-bottom.mt-4 > div > div > div > div:nth-child(2) > div > img:nth-child(2)"));
        private IWebElement element2 => Driver.FindElement(By.CssSelector("body > div.footer-bottom.mt-4 > div > div > div > div:nth-child(2) > div > img:nth-child(3)"));
        private IWebElement element3 => Driver.FindElement(By.CssSelector("body > div.footer-bottom.mt-4 > div > div > div > div:nth-child(2) > div > img:nth-child(4)"));
        private IWebElement element4 => Driver.FindElement(By.CssSelector("body > div.footer-bottom.mt-4 > div > div > div > div:nth-child(2) > div > img:nth-child(5)"));
        IReadOnlyCollection<IWebElement> fivePayMethods => Driver.FindElements(By.CssSelector("body > div.footer-bottom.mt-4 > div > div > div > div:nth-child(2) > div"));

        public BaigiamasisDPage(WebDriver driver) : base(driver) { }

        public void NavigateToPage()
        {
            Driver.Url = pageAddress;
        }
        public void InsertTextToInputField()
        {
            inputField.SendKeys("tapetų klijai Metylan 180 g");
        }
        public void ClickButton()
        {
            button.Click();
            button2.Click();
            button3.Click();
            button4.Click();
            button5.Click();
            button6.Click();
            button7.Click();
            button8.Click();
            button9.Click();
        }
        public void ElementField()
        {
            element1.Click();
            element1.Click();
            element1.Click();
            element1.Click();
        }
        public void VerifyResult()
        {
            //List<int> fiveayMethods = new List<int>();
            //char[] charArray = input.ToCharArray(element, element1, element2, element3, element4);

            //int sum = 0;
            //for (int i = 0; i < charArray.Length; i++)
            //{
            //    int.Parse("" + charArray[i]);
            //}
            //return sum;
            ////int element+int element2 + int element3 + int element4 + int element5 = fivePayMethods.Count
            //Assert.IsTrue(fivePayMethods.Equals(5), "Mokejimo budu kiekis neatitinka");???????????????????
            //Ar tiesa, kad 5 vnt atitinka krepselio apmokejimo budu kieki
        }
    }

    public class BaigiamasisDPage2 : BasePage
    {
        private string pageAddress => "https://www.mokivezi.lt";
        private IWebElement button => Driver.FindElement(By.Id("omnisend-form-6357d3f0e5b07c084437c2fe-close-action"));
        private IWebElement button2 => Driver.FindElement(By.CssSelector(".cookie-notice__btn.btn.btn-primary"));
        private IWebElement button3 => Driver.FindElement(By.CssSelector("#footer > div.container.footer__grid > div:nth-child(1) > div.col-12.col-lg-9 > div > div:nth-child(3) > ul > li:nth-child(1) > a"));
        private IWebElement button4 => Driver.FindElement(By.CssSelector("#citySelect > option:nth-child(5)"));
        private IWebElement element => Driver.FindElement(By.CssSelector("body > div.main-content.container > div.row > div:nth-child(6) > div > div.d-flex.align-items-start.contact-shop__address-wrapper > div.contact-shop__address"));
        private IWebElement element2 => Driver.FindElement(By.CssSelector("body > div.main-content.container > div.row > div:nth-child(6) > div > div:nth-child(8) > div:nth-child(2)"));
        private IWebElement element3 => Driver.FindElement(By.CssSelector("body > div.main-content.container > div.row > div:nth-child(5) > div > div.d-flex.align-items-start.contact-shop__address-wrapper > div.contact-shop__address"));
        private IWebElement element4 => Driver.FindElement(By.CssSelector("body > div.main-content.container > div.row > div:nth-child(5) > div > div:nth-child(8) > div:nth-child(2)"));
        public BaigiamasisDPage2(IWebDriver driver) : base(driver) { }

        public void NavigateToPage()
        {
            Driver.Url = pageAddress;
        }

        public void ClickButton()
        {
            button.Click();
            button2.Click();
            button3.Click();
            button4.Click();
        }
        public void ElementField()
        {
            element.Click();
            element2.Click();
            element3.Click();
            element4.Click();
        }
        public void VerifyResult()
        {
            string KaunoParduotuvePirma = "Kaunas, Raudondvario pl. 205 ";
            string DarboLaikasPirma = "08:00 - 17:00";
            string sum = KaunoParduotuvePirma + DarboLaikasPirma;
            string sum2 = element.Text + " " + element2.Text;

            string KaunoParduotuveAntra = "Kaunas, Kauno r., Narsiečių k., Vytauto g. 183 ";
            string DarboLaikasAntra = "08:00 - 18:00";
            string sum3 = KaunoParduotuveAntra + DarboLaikasAntra;
            string sum4 = element3.Text + " " + element4.Text;

            /*AR ATITINKA PARDUTUVIU PAVADINIMAI KAUNE,BEI AR ABI PARDUOTUVES KAUNE DIRBA SESTADIENI*/
            Assert.AreEqual(sum, sum2, "rasta ne Kauno parduotuve");
            Assert.AreEqual(sum3, sum4, "Raso, kad nedirba sestadieni");
        }


    }

    public class BaigiamasisDPage3 : BasePage
    {
        private string pageAddress => "https://www.mokivezi.lt";
        private IWebElement button => Driver.FindElement(By.Id("omnisend-form-6357d3f0e5b07c084437c2fe-close-action"));
        private IWebElement button2 => Driver.FindElement(By.CssSelector(".cookie-notice__btn.btn.btn-primary"));
        //Thread.Sleep(5000);
        private IWebElement button3 => Driver.FindElement(By.CssSelector("body > header > div.header-category-container.mt-4 > div > div > nav > div.col-9.header-categories__side.header-categories__side--left > div.header-categories__link.header-categories__link--category.link-unstyled.d-inline-block.cursor-pointer.noselect > span"));
        private IReadOnlyCollection<IWebElement> elementsCollection => Driver.FindElements(By.CssSelector("body > header > div.header-category-container.mt-4 > div > div > nav > div.col-9.header-categories__side.header-categories__side--left > div.header-categories__link.header-categories__link--category.link-unstyled.d-inline-block.cursor-pointer.noselect > span > div > div.toplevel-categories"));

        public BaigiamasisDPage3(WebDriver driver) : base(driver) { }

        public void NavigateToPage()
        {
            Driver.Url = pageAddress;
        }

        public void ClickButton()
        {
            button.Click();
            button2.Click();
            button3.Click();

        }
        public void VerifyResult()
        {
            foreach (IWebElement element in elementsCollection)
            {
                element.Click();
                //elementsCollection.Count();
            }
            /*Assert.IsTrue("18".Equals(elementsCollection.Count()), "It is not true");*//*??????????????????????????*/
            //Assert.IsTrue(18.Equals(elementsCollection.Count()));
            //KIEK ELEMENTU YRA E-PARDUOTUVES ISKILUSIIO LANGO ELEMENTU SAUGYKLOJE
        }


    }
    public class BaigiamasisDPage4 : BasePage
    {
        private string pageAddress => "https://www.mokivezi.lt";
        private IWebElement button => Driver.FindElement(By.Id("omnisend-form-6357d3f0e5b07c084437c2fe-close-action"));
        private IWebElement button2 => Driver.FindElement(By.CssSelector(".cookie-notice__btn.btn.btn-primary"));
        private IWebElement inputField => Driver.FindElement(By.Id("search"));
        private IWebElement button3 => Driver.FindElement(By.CssSelector(".btn.btn-primary.header-search-form__submit-btn.medium-link"));
        private IWebElement element => Driver.FindElement(By.CssSelector("body > div.main-content.container > div > div:nth-child(1) > h1"));
        public BaigiamasisDPage4(WebDriver driver) : base(driver) { }
        public void NavigateToPage()
        {
            Driver.Url = pageAddress;
        }

        public void InsertTextToInputField()
        {
            inputField.SendKeys("Blick 10");
        }
        public void ClickButton()
        {
            button.Click();
            button2.Click();
            button3.Click();

        }
        public void ElementField()
        {
            element.Click();
        }
        public void VerifyResult()
        {
            string expectedResult = "Rezultatų raktažodžiui: \"Blick 10\" nerasta";

            Assert.AreEqual(expectedResult, element.Text, "Rezultatu nerasta");
            //PAIESKOJE GAUTI REZULTATAI SUTAMPA SU TAIS, KURIU TIKIMASI 
        }


    }
    public class BaigiamasisDPage5 : BasePage
    {
        private string pageAddress => "https://www.mokivezi.lt";
        private IWebElement button => Driver.FindElement(By.Id("omnisend-form-6357d3f0e5b07c084437c2fe-close-action"));
        private IWebElement inputField => Driver.FindElement(By.Id("search"));
        private IWebElement button2 => Driver.FindElement(By.CssSelector(".btn.btn-primary.header-search-form__submit-btn.medium-link"));
        private IWebElement button3 => Driver.FindElement(By.CssSelector(".cookie-notice__btn.btn.btn-primary"));
        private IWebElement button4 => Driver.FindElement(By.CssSelector("body > div.main-content.container > div > div.col-12.col-md-8.col-lg-9.loadable > div.row.row--small-gutter.mt-5 > div:nth-child(1) > div > div.position-relative > div > form > div.product-quantity > div.pl-xl-0.product-quantity__col-submit > button.btn.btn-block.btn-primary.product-quantity__submit.item-add-to-cart"));
        private IWebElement button5 => Driver.FindElement(By.CssSelector(".btn.btn-transparent"));
        private IWebElement button6 => Driver.FindElement(By.CssSelector("body > div.main-content.container > div > div.col-12.col-md-8.col-lg-9.loadable > div.row.row--small-gutter.mt-5 > div:nth-child(2) > div > div.position-relative > div > form > div.product-quantity > div.pl-xl-0.product-quantity__col-submit > button.btn.btn-block.btn-primary.product-quantity__submit.item-add-to-cart"));
        private IWebElement button7 => Driver.FindElement(By.CssSelector(".btn.btn-transparent"));
        private IWebElement button8 => Driver.FindElement(By.CssSelector("body > header > div.header-category-container.mt-4 > div > div > nav > div.col-3.header-categories__side.header-categories__side--right > div > div.mr-2.dropdown-btn-wrapper > div > div.input-style-reset.basket-btn.d-flex.align-items-center.noselect > span.basket-btn__text.medium-link.mx-1.d-none.d-md-block"));
        private IWebElement button9 => Driver.FindElement(By.CssSelector("body > header > div.header-category-container.mt-4 > div > div > nav > div.col-3.header-categories__side.header-categories__side--right > div > div.mr-2.dropdown-btn-wrapper > div > div.dropdown-menu.dropdown-menu-right.p-0.mini-cart__dropdown.show > div.mini-cart__btn-wrapper > a.btn.btn-primary.btn-block.mini-cart__btn"));
        private IWebElement button10 => Driver.FindElement(By.CssSelector("body > div.pt-2.pb-5 > div > div > div.col-12.col-lg-8.mb-4 > div.cart-items.js-cart-items > div > form > div:nth-child(3) > div.col-4.col-lg-2.d-flex.justify-content-center.align-items-center > div > div > button.btn.product-quantity__increase"));
        private IWebElement element => Driver.FindElement(By.Id("220169"));
        private IWebElement element2 => Driver.FindElement(By.Id("220166"));

        public BaigiamasisDPage5(WebDriver driver) : base(driver) { }
        public void NavigateToPage()
        {
            Driver.Url = pageAddress;
        }
        public void InsertTextToInputField()
        {
            inputField.SendKeys("tapetų klijai Metylan 180 g");
        }
        public void ClickButton()
        {
            button.Click();
            button2.Click();
            button3.Click();
            button.Click();
            button2.Click();
            button3.Click();
            button.Click();
            button2.Click();
            button3.Click();
            button3.Click();

        }
        public void ElementField()
        {
            element.Click();
            element2.Click();

        }
        public void VerifyResult()
        {
            Assert.AreNotSame(element, element2, "are equal");
            //AR KREPSELYJE IDETU VIENU TAPETU KLIJU KIEKIS TOKS PATS KAIP KITU TAPETU KLIJU KIEKIS
        }



    }


}









