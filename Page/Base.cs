using OpenQA.Selenium;

namespace ClassLibrary1.Page
{
    public class BasePage
    {
        protected static IWebDriver Driver;/*atirbutas*/

        public BasePage(IWebDriver webdriver)
        {
            Driver = webdriver;/*konstuktorius*/
        }




    }
}

