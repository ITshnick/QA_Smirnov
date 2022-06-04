using NUnit.Framework;
using Lab_4.PageObjects;
using System.Threading;
using Lab_4.Components;
using Lab_4.Factory;

namespace Lab_4
{
    [TestFixture]
    public class EditPetTypeTest : Base
    {
        [Test]
        public void editPetTypeTest()
        {
            NavigationComponent option = Component.Button;
            PetTypesPageObjects pageObjects = new PetTypesPageObjects(driver);

            option.OpenPetTypes();

            Thread.Sleep(2000);
            pageObjects.OpenPetTypeEditPage();
            pageObjects.EditPetType("Akita");
            Thread.Sleep(2000);
            Assert.True(pageObjects.IsNameCorrect("Akita"));
        }
    }
}