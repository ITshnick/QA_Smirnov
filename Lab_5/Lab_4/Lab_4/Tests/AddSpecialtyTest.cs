using NUnit.Framework;
using Lab_4.PageObjects;
using Lab_4.Components;
using Lab_4.Factory;

namespace Lab_4
{
    [TestFixture]
    public class AddSpecialtyTest : Base
    {
        [Test]
        public void AddSpecialty()
        {
            NavigationComponent option = Component.Button;
            SpecialtiesPageObjects pageObjects = new SpecialtiesPageObjects(driver);

            option.OpenSpecialties();

            pageObjects.OpenSpecialtyAddForm();
            pageObjects.AddSpecialty("Smirnov");
            Assert.True(pageObjects.IsNameCorrect("Smirnov"));
        }
    }
}