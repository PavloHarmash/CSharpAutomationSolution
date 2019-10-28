using OpenQA.Selenium;
using System.Collections.Generic;
using Yukon.Enums;
using Yukon.Libraries.TranslationLibrary;
using Yukon.Models.Translation;
using Yukon.Utility;
using Yukon.Utility.Helpers;

namespace Yukon.PageObjects
{
    public class BasePage
    {
        private IWebDriver WebDriver { get; set; }
        protected Actions Action { get; set; }
        protected Waiters Wait { get; set; }
        public static AppLanguage AppLanguage { get; set; }
        protected TranslationLibraryModel PageText { get; set; }

        public BasePage(IWebDriver webDriwer)
        {
            this.WebDriver = webDriwer;
            this.Action = new Actions(this.WebDriver);
            this.Wait = new Waiters(this.WebDriver);
            this.PageText = new TranslationLibrary(BasePage.AppLanguage).Library;
        }

        public static readonly By PageLoader = By.XPath("//div[@class='loader hide']");

        protected T ReturnPage<T>() where T : BasePage
        {
            return new PageCreator(this.WebDriver).CreatePage<T>();
        }

        protected IWebElement GetElement(By locator) => this.WebDriver.FindElement(locator);

        protected IList<IWebElement> GetElements(By locator) => this.WebDriver.FindElements(locator);
    }
}
