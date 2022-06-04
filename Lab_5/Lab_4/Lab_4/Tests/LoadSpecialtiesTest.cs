using NUnit.Framework;
using Lab_4.PageObjects;
using Lab_4.Components;
using Lab_4.Factory;

namespace Lab_4
{
    [TestFixture]
    public class LoadSpecialtiesTest : Base
    {

        [Test]
        public void loadSpecialtiesTest()
        {
            NavigationComponent option = Component.Button;
            SpecialtiesPageObjects pageObjects = new SpecialtiesPageObjects(driver);

            option.OpenSpecialties();

            Assert.True(pageObjects.GetSpecialtyPageName() == "Specialties");
        }
    }
}