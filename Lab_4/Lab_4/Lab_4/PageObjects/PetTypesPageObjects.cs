using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.PageObjects
{
    internal class PetTypesPageObjects : MainObjects
    {
        public PetTypesPageObjects(IWebDriver driver) : base(driver){}

        private By PetTypeOption = By.CssSelector("li:nth-child(4) span:nth-child(2)");
        private By AddPetTypeButton = By.CssSelector(".addPet");
        private By PetTypeName = By.Id("name");
        private By PetTypeSaveButton = By.CssSelector(".saveType");
        private By PetTypeItems = By.CssSelector("tr input");
        private By PetTypeItemName = By.CssSelector("tr:last-child input");
        private By DeletePetTypeButton = By.CssSelector("tr:last-child .deletePet");
        private By EditPetTypeButton = By.CssSelector("tr:last-child .editPet");
        private By UpdatePetTypeButton = By.CssSelector(".updatePetType");
        private By PetTypePageName = By.CssSelector("h2");

        private int count;

        public void AddPetType(string name)
        {
            driver.FindElement(PetTypeName).Click();
            driver.FindElement(PetTypeName).SendKeys(name);
            driver.FindElement(PetTypeSaveButton).Click();
        }

        public void EditPetType(string name)
        {
            driver.FindElement(PetTypeName).Click();
            driver.FindElement(PetTypeName).Clear();
            driver.FindElement(PetTypeName).SendKeys(name);
            driver.FindElement(UpdatePetTypeButton).Click();
        }

        public bool IsNameCorrect(string name)
        {
            string value = driver.FindElement(PetTypeItemName).GetAttribute("value");
            return value == name;
        }

        private int GetPetTypesCount()
        {
            return driver.FindElements(PetTypeItems).Count;
        }

        public void OpenPetTypes()
        {
            driver.FindElement(PetTypeOption).Click();
        }

        public void OpenPetTypeAddForm()
        {
            driver.FindElement(AddPetTypeButton).Click();
        }

        public void DeletePetType()
        {
            count = GetPetTypesCount();
            driver.FindElement(DeletePetTypeButton).Click();
        }

        public void OpenPetTypeEditPage()
        {
            driver.FindElement(EditPetTypeButton).Click();
        }

        public bool isCountDescreased()
        {
            return GetPetTypesCount() < count;
        }

        public string GetPetTypePageName()
        {
            return driver.FindElement(PetTypePageName).Text;
        }
    }
}
