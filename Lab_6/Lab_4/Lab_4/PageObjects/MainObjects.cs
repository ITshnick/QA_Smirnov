using OpenQA.Selenium;
using System.Collections.Generic;

namespace Lab_4.PageObjects
{
    public abstract class MainObjects
    {
        protected IWebDriver driver;
        protected Dictionary<string, object> vars;

        public MainObjects(IWebDriver driver)
        {
            this.driver = driver;
            vars = new Dictionary<string, object>();
        }
    }
}
