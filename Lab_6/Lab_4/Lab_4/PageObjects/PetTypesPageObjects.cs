using NUnit.Allure.Steps;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.PageObjects
{
    public class PetTypesPageObjects : MainObjects
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

        [AllureStep("Add pet type")]
        public void AddPetType(string name)
        {
            driver.FindElement(PetTypeName).Click();
            driver.FindElement(PetTypeName).SendKeys(name);
            driver.FindElement(PetTypeSaveButton).Click();
        }

        [AllureStep("Edit pet type")]
        public void EditPetType(string name)
        {
            driver.FindElement(PetTypeName).Click();
            driver.FindElement(PetTypeName).Clear();
            driver.FindElement(PetTypeName).SendKeys(name);
            driver.FindElement(UpdatePetTypeButton).Click();
        }

        [AllureStep("Is name correct")]
        public bool IsNameCorrect(string name)
        {
            string value = driver.FindElement(PetTypeItemName).GetAttribute("value");
            return value == name;
        }

        [AllureStep("Get pet types count")]
        private int GetPetTypesCount()
        {
            return driver.FindElements(PetTypeItems).Count;
        }

        [AllureStep("Open pet types")]
        public void OpenPetTypes()
        {
            driver.FindElement(PetTypeOption).Click();
        }

        [AllureStep("Open pet type add form")]
        public void OpenPetTypeAddForm()
        {
            driver.FindElement(AddPetTypeButton).Click();
        }

        [AllureStep("Delete pet type")]
        public void DeletePetType()
        {
            count = GetPetTypesCount();
            driver.FindElement(DeletePetTypeButton).Click();
        }

        [AllureStep("Open pet type edit page")]
        public void OpenPetTypeEditPage()
        {
            driver.FindElement(EditPetTypeButton).Click();
        }

        [AllureStep("Is count descreased")]
        public bool isCountDescreased()
        {
            return GetPetTypesCount() < count;
        }

        [AllureStep("Get pet type page name")]
        public string GetPetTypePageName()
        {
            return driver.FindElement(PetTypePageName).Text;
        }
    }
}
