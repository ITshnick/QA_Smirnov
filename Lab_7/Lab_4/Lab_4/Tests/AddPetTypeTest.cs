// Generated by Selenium IDE
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
    public class AddPetTypeTest : Base
    {
        static object[] TestData = { "Test 1", "Test 2", "Test 3", "Test 4", "Test 5" };
        [TestCaseSource(nameof(TestData))]

        [Test, Description("This test checks that pet type can be added successfully")]
        [AllureSuite("Pet types")]
        [AllureStory]
        [AllureTag("NUnit")]
        public void AddPetType()
        {
            NavigationComponent option = Component.Button;
            PetTypesPageObjects pageObject = new PetTypesPageObjects(driver);

            option.OpenPetTypes();

            pageObject.OpenPetTypeAddForm();
            pageObject.AddPetType("Akita");
            Assert.True(pageObject.IsNameCorrect("Akita"));
        }
    }
}