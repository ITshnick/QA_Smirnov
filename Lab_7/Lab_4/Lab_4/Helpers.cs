using OpenQA.Selenium;

namespace Lab_4
{
    class Helpers
    {
        public static void SendKeys(IWebElement webElement, string text)
        {
            webElement.Click();
            webElement.SendKeys(text);
        }

        public static void ClearSendKeys(IWebElement webElement, string text)
        {
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys(text);  
        }
    }
}
