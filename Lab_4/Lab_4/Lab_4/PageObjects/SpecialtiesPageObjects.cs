using OpenQA.Selenium;

namespace Lab_4.PageObjects
{
    internal class SpecialtiesPageObjects : MainObjects
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

        public void AddSpecialty(string name)
        {
            driver.FindElement(SpecialtyName).Click();
            driver.FindElement(SpecialtyName).SendKeys(name);
            driver.FindElement(SpecialtySaveButton).Click();
        }

        public void DeleteSpecialty()
        {
            count = GetSpecialtiesCount();
            driver.FindElement(DeleteSpecialtyButton).Click();
        }

        public void EditSpecialty(string name)
        {
            driver.FindElement(SpecialtyName).Click();
            driver.FindElement(SpecialtyName).Clear();
            driver.FindElement(SpecialtyName).SendKeys(name);
            driver.FindElement(UpdateSpecialtyButton).Click();
        }

        public void CancelEditing(string name)
        {
            driver.FindElement(SpecialtyName).Click();
            driver.FindElement(SpecialtyName).SendKeys(name);
            driver.FindElement(CancelSpecialtyEditButton).Click();
        }

        private int GetSpecialtiesCount()
        {
            return driver.FindElements(SpecialtyItems).Count;
        }

        public void OpenSpecialties()
        {
            driver.FindElement(SpecialtyOption).Click();
        }

        public void OpenSpecialtyAddForm()
        {
            driver.FindElement(AddSpecialtyButton).Click();
        }

        public void OpenSpecialtyEditPage()
        {
            driver.FindElement(EditSpecialtyButton).Click();
        }

        public void ReturnToHomePage()
        {
            driver.FindElement(HomeSpecialtiesButton).Click();
        }

        public bool IsNameCorrect(string name)
        {
            string value = driver.FindElement(SpecialtyItemName).GetAttribute("value");
            return value == name;
        }

        public bool isCountDescreased()
        {
            return GetSpecialtiesCount() < count;
        }

        public string GetSpecialtyPageName()
        {
            return driver.FindElement(SpecialtyPageName).Text;
        }

        public bool IsPageNameCorrect(string name)
        {
            return driver.FindElement(SpecialtyPageName).Text == name;
        }

    }
}
