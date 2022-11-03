using OpenQA.Selenium;

namespace ClassLibrary1.Page
{
    public class BaseDriver
    {
        protected static IWebDriver Driver;/*atirbutas*/

        public BaseDriver(IWebDriver webdriver)
        {
            Driver = webdriver;/*konstuktorius*/
        }


    }
}

