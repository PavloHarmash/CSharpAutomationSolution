using OpenQA.Selenium;
using System.Collections.Generic;

namespace Yukon.PageObjects
{
    public class BasePage
    {
        protected IWebDriver WebDriver { get; set; }

        public BasePage(IWebDriver webDriwer)
        {
            this.WebDriver = webDriwer;
        }

        public IWebElement GetElement(By locator) => this.WebDriver.FindElement(locator);

        public IList<IWebElement> GetElements(By locator) => this.WebDriver.FindElements(locator);
    }
}
