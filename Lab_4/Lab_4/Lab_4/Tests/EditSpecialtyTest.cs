using System.Threading;
using NUnit.Framework;
using Lab_4.PageObjects;

namespace Lab_4
{
    [TestFixture]
    public class EditSpecialtyTest : Base
    {
        
        [Test]
        public void editSpecialtyTest()
        {
            SpecialtiesPageObjects pageObjects = new SpecialtiesPageObjects(driver);
            pageObjects.OpenSpecialties();
            Thread.Sleep(2000);
            pageObjects.OpenSpecialtyEditPage();
            pageObjects.EditSpecialty("Smirnov");
            Thread.Sleep(2000);
            Assert.True(pageObjects.IsNameCorrect("Smirnov"));
        }
    }
}
