using OpenQA.Selenium;

namespace Lab_4.PageObjects
{
    internal class HomePageObjects : MainObjects
    {
        private By HomePageName = By.CssSelector("h1");

        public HomePageObjects(IWebDriver driver) : base(driver)
        {

        }

        public string GetHomePageName()
        {
            return driver.FindElement(HomePageName).Text;
        }
    }
}
