using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    public abstract class Base
    {
        public static IWebDriver driver = new ChromeDriver(@"D:\ZTU\4 курс\ІІ семестро\QA\Lab_4\Lab_4\Lab_4\driver");


        [SetUp]
        public void Setup()
        {
            driver.Url = "https://client.sana-commerce.dev/";
            driver.Manage().Window.Size = new System.Drawing.Size(974, 1047);
        }

        [TearDown]
        public void Teardown()
        {
            // Assert.Pass();

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string path = @"D:\ZTU\4 курс\ІІ семестро\QA\Lab_4\results\";
                var imagename = $"results_{DateTime.Now:yyyy-MM-dd_HH-mm-ss.fffff}.png";
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(path + imagename);
            }

            driver.Quit();
        }
    }
}