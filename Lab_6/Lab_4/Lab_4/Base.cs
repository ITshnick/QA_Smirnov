using Allure.Commons;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
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
            var chromeOptions = new ChromeOptions();
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), chromeOptions.ToCapabilities());
            driver.Navigate().GoToUrl("https://client.sana-commerce.dev");
            driver.Manage().Window.Size = new System.Drawing.Size(974, 1047);
        }

        [TearDown]
        protected void Teardown()
        {
            // Assert.Pass();

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                var filename = TestContext.CurrentContext.Test.MethodName + "_screenshot_" + DateTime.Now.Ticks + ".png";
                var path = @"D:\\ZTU\\4 курс\\ІІ семестро\\QA\\Lab_6\\TestResults";
                screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
                AllureLifecycle.Instance.AddAttachment(filename, "image/png", path);
            }

            driver.Quit();
        }
    }
}