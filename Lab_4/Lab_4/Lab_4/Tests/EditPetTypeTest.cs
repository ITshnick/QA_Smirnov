using NUnit.Framework;
using Lab_4.PageObjects;
using System.Threading;

namespace Lab_4
{
    [TestFixture]
    public class EditPetTypeTest : Base
    {
        [Test]
        public void editPetTypeTest()
        {
            PetTypesPageObjects pageObjects = new PetTypesPageObjects(driver);
            pageObjects.OpenPetTypes();
            Thread.Sleep(2000);
            pageObjects.OpenPetTypeEditPage();
            pageObjects.EditPetType("Akita");
            Thread.Sleep(2000);
            Assert.True(pageObjects.IsNameCorrect("Akita"));
        }
    }
}