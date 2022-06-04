using NUnit.Framework;
using Lab_4.PageObjects;

namespace Lab_4
{
    [TestFixture]
    public class CancelSpecialtyEditingTest : Base
    {
        
        [Test]
        public void cancelSpecialtyEditingTest()
        {
            SpecialtiesPageObjects pageObjects = new SpecialtiesPageObjects(driver);

            pageObjects.OpenSpecialties();
            pageObjects.OpenSpecialtyAddForm();
            pageObjects.AddSpecialty("new");
            Assert.True(pageObjects.IsNameCorrect("new"));
        }
    }
}