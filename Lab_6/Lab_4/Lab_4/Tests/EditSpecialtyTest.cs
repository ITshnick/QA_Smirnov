using System.Threading;
using NUnit.Framework;
using Lab_4.PageObjects;
using Lab_4.Components;
using Lab_4.Factory;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;

namespace Lab_4
{
    [TestFixture]
    [AllureNUnit]
    public class EditSpecialtyTest : Base
    {

        [Test, Description("This test checks that specialty can be added successfully")]
        [AllureSuite("Specialties")]
        [AllureStory]
        [AllureTag("NUnit")]
        public void editSpecialtyTest()
        {
            NavigationComponent option = Component.Button;
            SpecialtiesPageObjects pageObjects = new SpecialtiesPageObjects(driver);

            option.OpenSpecialties();

            Thread.Sleep(2000);
            pageObjects.OpenSpecialtyEditPage();
            pageObjects.EditSpecialty("Smirnov");
            Thread.Sleep(2000);
            Assert.True(pageObjects.IsNameCorrect("Smirnov"));
        }
    }
}
