using NUnit.Framework;
using Lab_4.PageObjects;
using System.Threading;

namespace Lab_4
{
    [TestFixture]
    public class DeletePetTypeTest : Base
    {
        [Test]
        public void deletePetTypeTest()
        {
            PetTypesPageObjects pageObjects = new PetTypesPageObjects(driver);
            pageObjects.OpenPetTypes();
            Thread.Sleep(2000);
            pageObjects.DeletePetType();
            Thread.Sleep(2000);
            Assert.True(pageObjects.isCountDescreased());
        }
    }
}