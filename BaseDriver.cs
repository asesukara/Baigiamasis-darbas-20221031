using OpenQA.Selenium;

namespace ClassLibrary1.Page
{
    public class BaseDriver
    {
        protected static IWebDriver Driver;
        private const string pageUrl = "https://www.mokivezi.lt";
        public BaseDriver(IWebDriver webdriver)
        {
            Driver = webdriver;

        }
    }
}
