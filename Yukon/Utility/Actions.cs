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

        public bool IsElementEnabled(IWebElement element) => element.Enabled;

        public bool IsElementDisplayed(IWebElement element) => element.Displayed;

        public bool IsElementSelected(IWebElement element) => element.Selected;

        public string GetTextOf(IWebElement element) => element.Text.Trim();

        public Point GetLocationOf(IWebElement element) => element.Location;

        public void Clear(IWebElement element) => element.Clear();

        public void ClickOn(IWebElement element) => element.Click();

        public void SendKeysTo(IWebElement element, string text) => element.SendKeys(text);

        public IWebElement FindElementFrom(IWebElement element, By by) => element.FindElement(by);

        public IList<IWebElement> FindElementsFrom(IWebElement element, By by) => element.FindElements(by);

        public string GetAttributeOf(IWebElement element, string attributeName) => element.GetAttribute(attributeName);

        public string GetCssValueOf(IWebElement element, string propertyName) => element.GetCssValue(propertyName);

        public string GetPropertyOf(IWebElement element, string propertyName) => element.GetProperty(propertyName);

        public void Submit(IWebElement element) => element.Submit();
    }
}
