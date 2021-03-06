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
public class VeterinariansCheckBoxTest {
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
  public void veterinariansCheckBox() {
    // Test name: VeterinariansCheckBox
    // Step # | name | target | value | comment
    // 1 | open | https://client.sana-commerce.dev/ |  | 
    driver.Navigate().GoToUrl("https://client.sana-commerce.dev/");
    // 2 | setWindowSize | 973x1047 |  | 
    driver.Manage().Window.Size = new System.Drawing.Size(973, 1047);
    // 3 | click | css=.vetsTab |  | 
    driver.FindElement(By.CssSelector(".vetsTab")).Click();
    // 4 | click | css=.open li:nth-child(1) > a |  | 
    driver.FindElement(By.CssSelector(".open li:nth-child(1) > a")).Click();
    // 5 | click | xpath=//tr[@id='vet']/td[3]/button |  | 
    driver.FindElement(By.XPath("//tr[@id=\'vet\']/td[3]/button")).Click();
    // 6 | click | css=.mat-select-arrow-wrapper |  | 
    driver.FindElement(By.CssSelector(".mat-select-arrow-wrapper")).Click();
    // 7 | click | css=#mat-option-1 > .mat-option-pseudo-checkbox |  | 
    driver.FindElement(By.CssSelector("#mat-option-1 > .mat-option-pseudo-checkbox")).Click();
    // 8 | click | css=.cdk-overlay-backdrop |  | 
    driver.FindElement(By.CssSelector(".cdk-overlay-backdrop")).Click();
  }
}
