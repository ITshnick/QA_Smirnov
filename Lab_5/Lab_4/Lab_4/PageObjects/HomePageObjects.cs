using OpenQA.Selenium;

namespace Lab_4.PageObjects
{
    public class HomePageObjects : MainObjects
    {
        public By HomePageName = By.CssSelector("h1");

        public HomePageObjects(IWebDriver driver) : base(driver){}

        public string GetHomePageName()
        {
            return driver.FindElement(HomePageName).Text;
        }
    }
}
