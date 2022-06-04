using NUnit.Framework;
using Lab_4.PageObjects;
using Lab_4.Components;
using Lab_4.Factory;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;

namespace Lab_4
{
    [Parallelizable]
    [TestFixture]
    [AllureNUnit]
    public class LoadPetTypesTest : Base
    {
        static object[] TestData = { "Test 1", "Test 2", "Test 3", "Test 4", "Test 5" };
        [TestCaseSource(nameof(TestData))]

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