// Generated by Selenium IDE
using System.Threading;
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
    public class DeleteSpecialtyTest : Base
    {
        static object[] TestData = { "Test 1", "Test 2", "Test 3", "Test 4", "Test 5" };
        [TestCaseSource(nameof(TestData))]

        [Test, Description("This test checks that specialty can be added successfully")]
        [AllureSuite("Specialties")]
        [AllureStory]
        [AllureTag("NUnit")]
        public void deleteSpecialtyTest()
        {
            NavigationComponent option = Component.Button;
            SpecialtiesPageObjects pageObjects = new SpecialtiesPageObjects(driver);

            option.OpenSpecialties();

            Thread.Sleep(2000);
            pageObjects.DeleteSpecialty();
            Thread.Sleep(2000);
            Assert.True(pageObjects.isCountDescreased());
        }
    }
}