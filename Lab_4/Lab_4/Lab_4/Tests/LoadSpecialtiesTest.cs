using NUnit.Framework;
using Lab_4.PageObjects;

namespace Lab_4
{
    [TestFixture]
    public class LoadSpecialtiesTest : Base
    {

        [Test]
        public void loadSpecialtiesTest()
        {
            SpecialtiesPageObjects pageObjects = new SpecialtiesPageObjects(driver);
            pageObjects.OpenSpecialties();
            Assert.True(pageObjects.GetSpecialtyPageName() == "Specialties");
        }
    }
}