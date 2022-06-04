using NUnit.Allure.Steps;
using OpenQA.Selenium;

namespace Lab_4.PageObjects
{
    public class HomePageObjects : MainObjects
    {
        public By HomePageName = By.CssSelector("h1");

        public HomePageObjects(IWebDriver driver) : base(driver){}

        [AllureStep("Home page")]
        public string GetHomePageName()
        {
            return driver.FindElement(HomePageName).Text;
        }
    }
}
