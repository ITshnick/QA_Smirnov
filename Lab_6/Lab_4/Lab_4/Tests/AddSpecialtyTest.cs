using NUnit.Framework;
using Lab_4.PageObjects;
using Lab_4.Components;
using Lab_4.Factory;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using System.Threading;

namespace Lab_4
{
    [TestFixture]
    [AllureNUnit]
    public class AddSpecialtyTest : Base
    {
        [Test, Description("This test checks that specialty can be added successfully")]
        [AllureSuite("Specialties")]
        [AllureStory]
        [AllureTag("NUnit")]
        public void AddSpecialty()
        {
            NavigationComponent option = Component.Button;
            SpecialtiesPageObjects pageObjects = new SpecialtiesPageObjects(driver);

            option.OpenSpecialties();

            pageObjects.OpenSpecialtyAddForm();
            pageObjects.AddSpecialty("Smirnov");
            Thread.Sleep(2000);
            Assert.True(pageObjects.IsNameCorrect("Smirnov"));
        }
    }
}