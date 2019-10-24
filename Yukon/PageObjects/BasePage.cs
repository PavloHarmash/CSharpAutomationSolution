using OpenQA.Selenium;
using System.Collections.Generic;
using Yukon.Utility;
using Yukon.Utility.Helpers;

namespace Yukon.PageObjects
{
    public class BasePage
    {
        private IWebDriver WebDriver { get; set; }
        protected Actions Action { get; set; }
        protected Waiters Wait { get; set; }

        public BasePage(IWebDriver webDriwer)
        {
            this.WebDriver = webDriwer;
            Action = new Actions(this.WebDriver);
            Wait = new Waiters(this.WebDriver);
        }

        protected T ReturnPage<T>() where T : BasePage
        {
            return new PageCreator(this.WebDriver).CreatePage<T>();
        }

        protected IWebElement GetElement(By locator) => this.WebDriver.FindElement(locator);

        protected IList<IWebElement> GetElements(By locator) => this.WebDriver.FindElements(locator);
    }
}
