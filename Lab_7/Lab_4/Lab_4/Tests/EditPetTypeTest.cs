using NUnit.Framework;
using Lab_4.PageObjects;
using System.Threading;
using Lab_4.Components;
using Lab_4.Factory;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;

namespace Lab_4
{
    [Parallelizable]
    [TestFixture]
    [AllureNUnit]
    public class EditPetTypeTest : Base
    {
        static object[] TestData = { "Test 1", "Test 2", "Test 3", "Test 4", "Test 5" };
        [TestCaseSource(nameof(TestData))]

        [Test, Description("This test checks that pet type can be added successfully")]
        [AllureSuite("Pet types")]
        [AllureStory]
        [AllureTag("NUnit")]
        public void editPetTypeTest()
        {
            NavigationComponent option = Component.Button;
            PetTypesPageObjects pageObjects = new PetTypesPageObjects(driver);

            option.OpenPetTypes();

            Thread.Sleep(2000);
            pageObjects.OpenPetTypeEditPage();
            pageObjects.EditPetType("Akita");
            Thread.Sleep(2000);
            Assert.True(pageObjects.IsNameCorrect("Akita"));
        }
    }
}