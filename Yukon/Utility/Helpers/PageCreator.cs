using OpenQA.Selenium;
using System;
using Yukon.PageObjects;

namespace Yukon.Utility.Helpers
{
    public class PageCreator
    {
        private IWebDriver webDriver { get; set; }

        public PageCreator(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public T CreatePage<T>() where T : BasePage => Activator.CreateInstance(typeof(T), this.webDriver) as T;
    }
}
