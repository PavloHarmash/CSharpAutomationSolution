using OpenQA.Selenium;
using System.Collections.Generic;
using System.Drawing;

namespace Yukon.Utility
{
    public class Actions
    {
        private IWebDriver WebDriver { get; set; }

        public Actions(IWebDriver webDriver)
        {
            this.WebDriver = webDriver;
        }

        public bool IsEnabled(IWebElement element) => element.Enabled;

        public bool IsDisplayed(IWebElement element) => element.Displayed;

        public bool IsSelected(IWebElement element) => element.Selected;

        public string GetText(IWebElement element) => element.Text.Trim();

        public Point GetLocation(IWebElement element) => element.Location;

        public void Clear(IWebElement element) => element.Clear();

        public void Click(IWebElement element) => element.Click();

        public void SendKeys(IWebElement element, string text) => element.SendKeys(text);

        public IWebElement FindElementFrom(IWebElement element, By by) => element.FindElement(by);

        public IList<IWebElement> FindElementsFrom(IWebElement element, By by) => element.FindElements(by);

        public string GetAttribute(IWebElement element, string attributeName) => element.GetAttribute(attributeName);

        public string GetCssValue(IWebElement element, string propertyName) => element.GetCssValue(propertyName);

        public string GetProperty(IWebElement element, string propertyName) => element.GetProperty(propertyName);

        public void Submit(IWebElement element) => element.Submit();
    }
}
