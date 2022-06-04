using NUnit.Framework;
using Lab_4.PageObjects;

namespace Lab_4
{
    [TestFixture]
    public class AddSpecialtyTest : Base
    {
        [Test]
        public void AddSpecialty()
        {
            SpecialtiesPageObjects pageObjects = new SpecialtiesPageObjects(driver);

            pageObjects.OpenSpecialties();
            pageObjects.OpenSpecialtyAddForm();
            pageObjects.AddSpecialty("Smirnov");
            Assert.True(pageObjects.IsNameCorrect("Smirnov"));
        }
    }
}