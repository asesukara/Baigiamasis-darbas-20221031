
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1.Page
{

    public class BaigiamasisDPage : BaseDriver
    {
        private string pageAddress => "https://www.mokivezi.lt";
        private IWebElement closeButton => Driver.FindElement(By.CssSelector(".omnisend-form-63640f045c27608904321f6e-close-action"));
        private IWebElement inputField => Driver.FindElement(By.Id("search"));
        private IWebElement searchButton => Driver.FindElement(By.CssSelector(".btn.btn-primary.header-search-form__submit-btn.medium-link"));
        private IWebElement closeCookiesButton => Driver.FindElement(By.CssSelector(".cookie-notice__btn.btn.btn-primary"));
        private IWebElement addToCardFirstButton => Driver.FindElement(By.CssSelector("body > div.main-content.container > div > div.col-12.col-md-8.col-lg-9.loadable > div.row.row--small-gutter.mt-5 > div:nth-child(1) > div > div.position-relative > div > form > div.product-quantity > div.pl-xl-0.product-quantity__col-submit > button.btn.btn-block.btn-primary.product-quantity__submit.item-add-to-cart"));
        private IWebElement continueFirstButton => Driver.FindElement(By.CssSelector(".btn.btn-transparent"));
        private IWebElement addToCardSecondButton => Driver.FindElement(By.CssSelector("body > div.main-content.container > div > div.col-12.col-md-8.col-lg-9.loadable > div.row.row--small-gutter.mt-5 > div:nth-child(2) > div > div.position-relative > div > form > div.product-quantity > div.pl-xl-0.product-quantity__col-submit > button.btn.btn-block.btn-primary.product-quantity__submit.item-add-to-cart"));
        private IWebElement continueSecondButton => Driver.FindElement(By.CssSelector(".btn.btn-transparent"));
        private IWebElement continueCardButton => Driver.FindElement(By.CssSelector("body > header > div.header-category-container.mt-4 > div > div > nav > div.col-3.header-categories__side.header-categories__side--right > div > div.mr-2.dropdown-btn-wrapper > div > div.input-style-reset.basket-btn.d-flex.align-items-center.noselect > span.basket-btn__text.medium-link.mx-1.d-none.d-md-block"));
        private IWebElement cardButton => Driver.FindElement(By.CssSelector("body > header > div.header-category-container.mt-4 > div > div > nav > div.col-3.header-categories__side.header-categories__side--right > div > div.mr-2.dropdown-btn-wrapper > div > div.dropdown-menu.dropdown-menu-right.p-0.mini-cart__dropdown.show > div.mini-cart__btn-wrapper > a.btn.btn-primary.btn-block.mini-cart__btn"));
        private IWebElement payseraElement => Driver.FindElement(By.CssSelector("body > div.footer-bottom.mt-4 > div > div > div > div:nth-child(2) > div > img:nth-child(1)"));
        private IWebElement sebElement => Driver.FindElement(By.CssSelector("body > div.footer-bottom.mt-4 > div > div > div > div:nth-child(2) > div > img:nth-child(2)"));
        private IWebElement mastercardElement => Driver.FindElement(By.CssSelector("body > div.footer-bottom.mt-4 > div > div > div > div:nth-child(2) > div > img:nth-child(3)"));
        private IWebElement visaElement => Driver.FindElement(By.CssSelector("body > div.footer-bottom.mt-4 > div > div > div > div:nth-child(2) > div > img:nth-child(4)"));
        private IWebElement swedbankElement => Driver.FindElement(By.CssSelector("body > div.footer-bottom.mt-4 > div > div > div > div:nth-child(2) > div > img:nth-child(5)"));
        IReadOnlyCollection<IWebElement> fivePayMethods => Driver.FindElements(By.CssSelector(".footer-bottom__list__item"));

        public BaigiamasisDPage(WebDriver driver) : base(driver) { }

        public void NavigateToPage()
        {
            Driver.Url = pageAddress;
        }
        public void CloseButton()
        {
            closeButton.Click();

        }
        public void InsertTextToInputField()
        {
            inputField.SendKeys("tapetų klijai Metylan 180 g");
        }
        public void SearchButton()
        {
            searchButton.Click();
        }
        public void CloseCookiesButton()
        {
            closeCookiesButton.Click();
        }
        public void AddToCardFirstButton()
        {
            addToCardFirstButton.Click();
        }
        public void ContinueFirstButton()
        {
            continueFirstButton.Click();
        }
        public void AddToCardSecondButton()
        {
            addToCardSecondButton.Click();
        }
        public void ContinueSecondButton()
        {
            continueSecondButton.Click();
        }
        public void ContinueCardButton()
        {
            continueCardButton.Click();
        }
        public void CardButton()
        {
            cardButton.Click();
        }
        public void PayseraElement()
        {
            payseraElement.Click();
        }
        public void SebElement()
        {
            sebElement.Click();
        }
        public void MasterCardElement()
        {
            mastercardElement.Click();
        }
        public void VisaElement()
        {
            visaElement.Click();
        }
        public void SwedbankElement()
        {
            swedbankElement.Click();
        }
        public void AllFiveList()
        {
            fivePayMethods.Count();
        }
        public void ResultFivePayMethods()
        {
            Assert.AreEqual(5, fivePayMethods.Count, "Mokejimo budu kiekis neatitinka");
        }

    }

    public class BaigiamasisDPage2 : BaseDriver
    {
        private string pageAddress => "https://www.mokivezi.lt";
        private IWebElement closeButton => Driver.FindElement(By.CssSelector(".omnisend-form-63640f045c27608904321f6e-close-action"));
        private IWebElement closeCookiesButton => Driver.FindElement(By.CssSelector(".cookie-notice__btn.btn.btn-primary"));
        private IWebElement contactsButton => Driver.FindElement(By.CssSelector("#footer > div.container.footer__grid > div:nth-child(1) > div.col-12.col-lg-9 > div > div:nth-child(3) > ul > li:nth-child(1) > a"));
        private IWebElement selectKaunasButton => Driver.FindElement(By.CssSelector("#citySelect > option:nth-child(5)"));
        private IWebElement firstShopElement => Driver.FindElement(By.CssSelector("body > div.main-content.container > div.row > div:nth-child(6) > div > div.d-flex.align-items-start.contact-shop__address-wrapper > div.contact-shop__address"));
        private IWebElement firstShopWorkTime => Driver.FindElement(By.CssSelector("body > div.main-content.container > div.row > div:nth-child(6) > div > div:nth-child(8) > div:nth-child(2)"));
        private IWebElement secondShopElement => Driver.FindElement(By.CssSelector("body > div.main-content.container > div.row > div:nth-child(5) > div > div.d-flex.align-items-start.contact-shop__address-wrapper > div.contact-shop__address"));
        private IWebElement secondShopWorkTime => Driver.FindElement(By.CssSelector("body > div.main-content.container > div.row > div:nth-child(5) > div > div:nth-child(8) > div:nth-child(2)"));
        public BaigiamasisDPage2(IWebDriver driver) : base(driver) { }

        public void NavigateToPage()
        {
            Driver.Url = pageAddress;
        }
        public void CloseButton()
        {
            closeButton.Click();
        }
        public void CloseCookiesButton()
        {
            closeCookiesButton.Click();
        }
        public void ContactsButton()
        {
            contactsButton.Click();
        }
        public void SelectKaunasButton()
        {
            selectKaunasButton.Click();
        }
        public void FirstShopElement()
        {
            firstShopElement.Click();
        }
        public void FirstShopWorkTime()
        {
            firstShopWorkTime.Click();
        }
        public void SecondShopElement()
        {
            secondShopElement.Click();
        }
        public void SecondShopWorkTime()
        {
            secondShopWorkTime.Click();
        }
        public void ResultRaudondvaris()
        {
            string KaunoParduotuvePirma = "Kaunas, Raudondvario pl. 205 ";
            string DarboLaikasPirma = "08:00 - 17:00";
            string sum = KaunoParduotuvePirma + DarboLaikasPirma;
            string sum2 = firstShopElement.Text + " " + firstShopWorkTime.Text;
            Assert.AreEqual(sum, sum2, "rasta ne Kauno parduotuve");
        }
        public void ResultNarsieciu()
        {
            string KaunoParduotuveAntra = "Kaunas, Kauno r., Narsiečių k., Vytauto g. 183 ";
            string DarboLaikasAntra = "08:00 - 18:00";
            string sum3 = KaunoParduotuveAntra + DarboLaikasAntra;
            string sum4 = secondShopElement.Text + " " + secondShopWorkTime.Text;
            Assert.AreEqual(sum3, sum4, "Raso, kad nedirba sestadieni");
        }
        /*AR ATITINKA PARDUTUVIU PAVADINIMAI KAUNE,BEI AR ABI PARDUOTUVES KAUNE DIRBA SESTADIENI*/
    }
    public class BaigiamasisDPage3 : BaseDriver
    {
        private string pageAddress => "https://www.mokivezi.lt";
        private IWebElement closeButton => Driver.FindElement(By.CssSelector(".omnisend-form-63640f045c27608904321f6e-close-action"));
        private IWebElement closeCookiesButton => Driver.FindElement(By.CssSelector(".cookie-notice__btn.btn.btn-primary"));
        private IWebElement eParduotuveButton => Driver.FindElement(By.CssSelector(".header-categories__link.header-categories__link--account.link-unstyled.d-inline-block"));
        private IReadOnlyCollection<IWebElement> elementsCollection => Driver.FindElements(By.CssSelector(".btn-block.mini-cart__btn"));

        public BaigiamasisDPage3(WebDriver driver) : base(driver) { }

        public void NavigateToPage()
        {
            Driver.Url = pageAddress;
        }
        public void CloseButton()
        {
            closeButton.Click();
        }
        public void CloseCookieButton()
        {
            closeCookiesButton.Click();
        }
        public void EParduotuveButton()
        {
            eParduotuveButton.Click();
        }
        public void EShoplistResult()
        {
            elementsCollection.Count();
        }
        public void ArTrysElPaskyroje()
        {
            Assert.AreNotEqual(2.Equals(elementsCollection.Count()), "It is not true");
        }

        public class BaigiamasisDPage4 : BaseDriver
        {
            private string pageAddress => "https://www.mokivezi.lt";
            private IWebElement closeButton => Driver.FindElement(By.CssSelector(".omnisend-form-63640f045c27608904321f6e-close-action"));
            private IWebElement closeCookiesButton => Driver.FindElement(By.CssSelector(".cookie-notice__btn.btn.btn-primary"));
            private IWebElement inputField => Driver.FindElement(By.Id("search"));
            private IWebElement searchButton => Driver.FindElement(By.CssSelector(".btn.btn-primary.header-search-form__submit-btn.medium-link"));
            private IWebElement resultKeyElement => Driver.FindElement(By.CssSelector("body > div.main-content.container > div > div:nth-child(1) > h1"));
            public BaigiamasisDPage4(WebDriver driver) : base(driver) { }
            public void NavigateToPage()
            {
                Driver.Url = pageAddress;
            }
            public void CloseButton()
            {
                closeButton.Click();
            }
            public void CloseCookiesButton()
            {
                closeCookiesButton.Click();
            }
            public void InsertTextToInputField()
            {
                inputField.SendKeys("Blick 10");
            }
            public void SearchButton()
            {
                searchButton.Click();
            }
            public void ResultKeyElement()
            {
                resultKeyElement.Click();
            }
            public void SearchVerifyResult()
            {
                string expectedResult = "Rezultatų raktažodžiui: \"Blick 10\" nerasta";
                Assert.AreEqual(expectedResult, resultKeyElement.Text, "Rezultatu nerasta");
            }
        }
        public class BaigiamasisDPage5 : BaseDriver
        {
            private string pageAddress => "https://www.mokivezi.lt";
            private IWebElement closePopUpButton => Driver.FindElement(By.CssSelector(".omnisend-form-63640f045c27608904321f6e-close-action"));
            private IWebElement inputField => Driver.FindElement(By.Id("search"));
            private IWebElement searchButton => Driver.FindElement(By.CssSelector(".btn.btn-primary.header-search-form__submit-btn.medium-link"));
            private IWebElement closeCookiesButton => Driver.FindElement(By.CssSelector(".cookie-notice__btn.btn.btn-primary"));
            private IWebElement addToCardFirstButton => Driver.FindElement(By.CssSelector("body > div.main-content.container > div > div.col-12.col-md-8.col-lg-9.loadable > div.row.row--small-gutter.mt-5 > div:nth-child(1) > div > div.position-relative > div > form > div.product-quantity > div.pl-xl-0.product-quantity__col-submit > button.btn.btn-block.btn-primary.product-quantity__submit.item-add-to-cart"));
            private IWebElement continueFirstButton => Driver.FindElement(By.CssSelector(".btn.btn-transparent"));
            private IWebElement addToCardSecondButton => Driver.FindElement(By.CssSelector("body > div.main-content.container > div > div.col-12.col-md-8.col-lg-9.loadable > div.row.row--small-gutter.mt-5 > div:nth-child(2) > div > div.position-relative > div > form > div.product-quantity > div.pl-xl-0.product-quantity__col-submit > button.btn.btn-block.btn-primary.product-quantity__submit.item-add-to-cart"));
            private IWebElement continueSecondButton => Driver.FindElement(By.CssSelector(".btn.btn-transparent"));
            private IWebElement continueCardButton => Driver.FindElement(By.CssSelector("body > header > div.header-category-container.mt-4 > div > div > nav > div.col-3.header-categories__side.header-categories__side--right > div > div.mr-2.dropdown-btn-wrapper > div > div.input-style-reset.basket-btn.d-flex.align-items-center.noselect > span.basket-btn__text.medium-link.mx-1.d-none.d-md-block"));
            private IWebElement cardButton => Driver.FindElement(By.CssSelector("body > header > div.header-category-container.mt-4 > div > div > nav > div.col-3.header-categories__side.header-categories__side--right > div > div.mr-2.dropdown-btn-wrapper > div > div.dropdown-menu.dropdown-menu-right.p-0.mini-cart__dropdown.show > div.mini-cart__btn-wrapper > a.btn.btn-primary.btn-block.mini-cart__btn"));
            private IWebElement methylanWoodchip2Button => Driver.FindElement(By.CssSelector("body > div.pt-2.pb-5 > div > div > div.col-12.col-lg-8.mb-4 > div.cart-items.js-cart-items > div > form > div:nth-child(3) > div.col-4.col-lg-2.d-flex.justify-content-center.align-items-center > div > div > button.btn.product-quantity__increase"));
            private IWebElement methylanWoodchipElement2 => Driver.FindElement(By.Id("220169"));
            private IWebElement methylanVinylAndSpezial1Element => Driver.FindElement(By.Id("220166"));

            public BaigiamasisDPage5(WebDriver driver) : base(driver) { }
            public void NavigateToPage()
            {
                Driver.Url = pageAddress;
            }
            public void CloseButton()
            {
                closePopUpButton.Click();
            }
            public void InsertTextToInputField()
            {
                inputField.SendKeys("tapetų klijai Metylan 180 g");
            }
            public void SearchButton()
            {
                searchButton.Click();
            }
            public void CloseCookiesButton()
            {
                closeCookiesButton.Click();
            }
            public void AddToCardFirstButton()
            {
                addToCardFirstButton.Click();
            }
            public void ContinueFirstButton()
            {
                continueFirstButton.Click();
            }
            public void AddToCardSecondButton()
            {
                addToCardSecondButton.Click();
            }
            public void ContinueSecondButton()
            {
                continueSecondButton.Click();
            }
            public void ContinueCardButton()
            {
                continueCardButton.Click();
            }
            public void CardButton()
            {
                cardButton.Click();
            }
            public void MethylanWoodchip2Button()
            {
                methylanWoodchip2Button.Click();
            }
            public void MethylanWoodchipElement2()
            {
                methylanWoodchipElement2.Click();
            }
            public void MethylanVinylAndSpezial1Element()
            {
                methylanVinylAndSpezial1Element.Click();
            }
            public void TwoCountResult()
            {
                Assert.AreNotSame(methylanWoodchipElement2, methylanVinylAndSpezial1Element, "are equal");
            }

        }
    }

}









