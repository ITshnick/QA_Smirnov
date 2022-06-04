using NUnit.Framework;
using Lab_4.PageObjects;
using System.Threading;
using Lab_4.Components;
using Lab_4.Factory;

namespace Lab_4
{
    [TestFixture]
    public class DeletePetTypeTest : Base
    {
        [Test]
        public void deletePetTypeTest()
        {
            NavigationComponent option = Component.Button;
            PetTypesPageObjects pageObjects = new PetTypesPageObjects(driver);

            option.OpenPetTypes();

            Thread.Sleep(2000);
            pageObjects.DeletePetType();
            Thread.Sleep(2000);
            Assert.True(pageObjects.isCountDescreased());
        }
    }
}