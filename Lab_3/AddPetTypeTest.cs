// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class AddPetTypeTestTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void addPetTypeTest() {
    driver.Navigate().GoToUrl("https://client.sana-commerce.dev");
    driver.Manage().Window.Size = new System.Drawing.Size(974, 1047);
    {
      var element = driver.FindElement(By.CssSelector("li:nth-child(4) span:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.CssSelector(".addPet")).Click();
    driver.FindElement(By.Id("name")).Click();
    driver.FindElement(By.Id("name")).SendKeys("Akita");
    driver.FindElement(By.CssSelector(".saveType")).Click();
  }
}