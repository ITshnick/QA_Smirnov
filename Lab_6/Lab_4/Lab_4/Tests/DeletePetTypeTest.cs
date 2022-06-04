using NUnit.Framework;
using Lab_4.PageObjects;
using System.Threading;
using Lab_4.Components;
using Lab_4.Factory;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;

namespace Lab_4
{
    [TestFixture]
    [AllureNUnit]
    public class DeletePetTypeTest : Base
    {
        [Test, Description("This test checks that pet type can be added successfully")]
        [AllureSuite("Pet types")]
        [AllureStory]
        [AllureTag("NUnit")]
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