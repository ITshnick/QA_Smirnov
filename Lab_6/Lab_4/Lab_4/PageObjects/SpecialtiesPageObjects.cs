using NUnit.Allure.Steps;
using OpenQA.Selenium;

namespace Lab_4.PageObjects
{
    public class SpecialtiesPageObjects : MainObjects
    {
        public SpecialtiesPageObjects(IWebDriver driver) : base(driver){}

        private By DeleteSpecialtyButton = By.CssSelector("tr:last-child .deleteSpecialty");
        private By SpecialtyOption = By.CssSelector("li:nth-child(5) span:nth-child(2)");
        private By EditSpecialtyButton = By.CssSelector("tr:last-child .editSpecialty");
        private By CancelSpecialtyEditButton = By.CssSelector(".cancelUpdate");
        private By UpdateSpecialtyButton = By.CssSelector(".updateSpecialty");
        private By SpecialtyItemName = By.CssSelector("tr:last-child input");
        private By HomeSpecialtiesButton = By.CssSelector(".returnHome");
        private By SpecialtySaveButton = By.CssSelector(".addSpecialty");
        private By AddSpecialtyButton = By.CssSelector(".addSpecialty");
        private By SpecialtyItems = By.CssSelector("tr input");
        private By SpecialtyPageName = By.CssSelector("h2");
        private By SpecialtyName = By.Id("name");

        private int count;


        [AllureStep("Add specialty")]
        public void AddSpecialty(string name)
        {
            driver.FindElement(SpecialtyName).Click();
            driver.FindElement(SpecialtyName).SendKeys(name);
            driver.FindElement(SpecialtySaveButton).Click();
        }

        [AllureStep("Delete specialty")]
        public void DeleteSpecialty()
        {
            count = GetSpecialtiesCount();
            driver.FindElement(DeleteSpecialtyButton).Click();
        }

        [AllureStep("Edit specialty")]
        public void EditSpecialty(string name)
        {
            driver.FindElement(SpecialtyName).Click();
            driver.FindElement(SpecialtyName).Clear();
            driver.FindElement(SpecialtyName).SendKeys(name);
            driver.FindElement(UpdateSpecialtyButton).Click();
        }

        [AllureStep("Cancel editing")]
        public void CancelEditing(string name)
        {
            driver.FindElement(SpecialtyName).Click();
            driver.FindElement(SpecialtyName).SendKeys(name);
            driver.FindElement(CancelSpecialtyEditButton).Click();
        }

        [AllureStep("Get specialties count")]
        private int GetSpecialtiesCount()
        {
            return driver.FindElements(SpecialtyItems).Count;
        }

        [AllureStep("Open specialties")]
        public void OpenSpecialties()
        {
            driver.FindElement(SpecialtyOption).Click();
        }

        [AllureStep("Open specialty add form")]
        public void OpenSpecialtyAddForm()
        {
            driver.FindElement(AddSpecialtyButton).Click();
        }

        [AllureStep("Open specialty edit page")]
        public void OpenSpecialtyEditPage()
        {
            driver.FindElement(EditSpecialtyButton).Click();
        }

        [AllureStep("Return to home page")]
        public void ReturnToHomePage()
        {
            driver.FindElement(HomeSpecialtiesButton).Click();
        }

        [AllureStep("Is name correct")]
        public bool IsNameCorrect(string name)
        {
            string value = driver.FindElement(SpecialtyItemName).GetAttribute("value");
            return value == name;
        }

        [AllureStep("Is count descreased")]
        public bool isCountDescreased()
        {
            return GetSpecialtiesCount() < count;
        }

        [AllureStep("Get specialty page name")]
        public string GetSpecialtyPageName()
        {
            return driver.FindElement(SpecialtyPageName).Text;
        }

        [AllureStep("Is page name correct")]
        public bool IsPageNameCorrect(string name)
        {
            return driver.FindElement(SpecialtyPageName).Text == name;
        }

    }
}
