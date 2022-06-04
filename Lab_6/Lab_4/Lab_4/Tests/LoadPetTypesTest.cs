using NUnit.Framework;
using Lab_4.PageObjects;
using Lab_4.Components;
using Lab_4.Factory;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;

namespace Lab_4
{
    [TestFixture]
    [AllureNUnit]
    public class LoadPetTypesTest : Base
    {
        [Test, Description("This test checks that pet type can be added successfully")]
        [AllureSuite("Pet types")]
        [AllureStory]
        [AllureTag("NUnit")]
        public void loadPetTypesTest()
        {
            NavigationComponent option = Component.Button;
            PetTypesPageObjects pageObjects = new PetTypesPageObjects(driver);

            option.OpenPetTypes();

            Assert.True(pageObjects.GetPetTypePageName() == "Pet Types");
        }
    }
}