using OpenQA.Selenium;
using System.Collections.Generic;

namespace CSharpAutomationSolution.Driver
{
    public class WebDriver
    {
        protected IWebDriver webDriver { get; set; }

        protected IWebElement GetElement(By locator) => this.webDriver.FindElement(locator);

        protected IList<IWebElement> GetElements(By locator) => this.webDriver.FindElements(locator);
    }
}
