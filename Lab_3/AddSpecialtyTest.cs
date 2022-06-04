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
public class AddSpecialtyTestTest {
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
  public void addSpecialtyTest() {
    // Test name: AddSpecialtyTest
    // Step # | name | target | value | comment
    // 1 | open | https://client.sana-commerce.dev/ |  | 
    driver.Navigate().GoToUrl("https://client.sana-commerce.dev/");
    // 2 | setWindowSize | 974x1040 |  | 
    driver.Manage().Window.Size = new System.Drawing.Size(974, 1040);
    // 3 | click | css=li:nth-child(5) > a |  | 
    driver.FindElement(By.CssSelector("li:nth-child(5) > a")).Click();
    // 4 | click | css=.addSpecialty |  | 
    driver.FindElement(By.CssSelector(".addSpecialty")).Click();
    // 5 | mouseOver | css=.addSpecialty |  | 
    {
      var element = driver.FindElement(By.CssSelector(".addSpecialty"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    // 6 | mouseOut | css=.addSpecialty:nth-child(2) |  | 
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    // 7 | click | id=name |  | 
    driver.FindElement(By.Id("name")).Click();
    // 8 | type | id=name | Some | 
    driver.FindElement(By.Id("name")).SendKeys("Some");
    // 9 | click | css=.btn:nth-child(3) |  | 
    driver.FindElement(By.CssSelector(".btn:nth-child(3)")).Click();
  }
}
