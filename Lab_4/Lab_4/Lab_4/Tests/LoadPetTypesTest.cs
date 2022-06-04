using NUnit.Framework;
using Lab_4.PageObjects;

namespace Lab_4
{
    [TestFixture]
    public class LoadPetTypesTest : Base
    {
        [Test]
        public void loadPetTypesTest()
        {
            PetTypesPageObjects pageObjects = new PetTypesPageObjects(driver);
            pageObjects.OpenPetTypes();
            Assert.True(pageObjects.GetPetTypePageName() == "Pet Types");
        }
    }
}