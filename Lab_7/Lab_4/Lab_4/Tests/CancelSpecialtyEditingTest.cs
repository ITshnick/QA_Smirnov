using NUnit.Framework;
using Lab_4.PageObjects;
using Lab_4.Components;
using Lab_4.Factory;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using System.Threading;

namespace Lab_4
{
    [Parallelizable]
    [TestFixture]
    [AllureNUnit]
    public class CancelSpecialtyEditingTest : Base
    {
        static object[] TestData = { "Test 1", "Test 2", "Test 3", "Test 4", "Test 5" };
        [TestCaseSource(nameof(TestData))]

        [Test, Description("This test checks that specialty can be added successfully")]
        [AllureSuite("Specialties")]
        [AllureStory]
        [AllureTag("NUnit")]
        public void cancelSpecialtyEditingTest()
        {
            NavigationComponent option = Component.Button;
            SpecialtiesPageObjects pageObjects = new SpecialtiesPageObjects(driver);

            option.OpenSpecialties();

            pageObjects.OpenSpecialtyAddForm();
            pageObjects.AddSpecialty("new");
            Thread.Sleep(2000);
            Assert.True(pageObjects.IsNameCorrect("new"));
        }
    }
}