using NUnit.Framework;
using Lab_4.PageObjects;
using Lab_4.Components;
using Lab_4.Factory;

namespace Lab_4
{
    [TestFixture]
    public class LoadPetTypesTest : Base
    {
        [Test]
        public void loadPetTypesTest()
        {
            NavigationComponent option = Component.Button;
            PetTypesPageObjects pageObjects = new PetTypesPageObjects(driver);

            option.OpenPetTypes();

            Assert.True(pageObjects.GetPetTypePageName() == "Pet Types");
        }
    }
}