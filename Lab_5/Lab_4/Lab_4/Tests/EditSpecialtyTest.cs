using System.Threading;
using NUnit.Framework;
using Lab_4.PageObjects;
using Lab_4.Components;
using Lab_4.Factory;

namespace Lab_4
{
    [TestFixture]
    public class EditSpecialtyTest : Base
    {
        
        [Test]
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
