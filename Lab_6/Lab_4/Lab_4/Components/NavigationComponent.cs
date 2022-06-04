using NUnit.Allure.Steps;
using OpenQA.Selenium;

namespace Lab_4.Components
{
    public class NavigationComponent
    {
        private IWebDriver driver;
        public NavigationComponent(IWebDriver driver) => this.driver = driver;
        public IWebElement PetTypeOption() => driver.FindElement(By.CssSelector("li:nth-child(4) span:nth-child(2)"));
        public IWebElement SpecialtyOption() => driver.FindElement(By.CssSelector("li:nth-child(5) span:nth-child(2)"));

        [AllureStep("Open pet types page")]
        public void OpenPetTypes()
        {
            PetTypeOption().Click();
        }

        [AllureStep("Open specialties page")]
        public void OpenSpecialties()
        {
            SpecialtyOption().Click();
        }
    }
}
