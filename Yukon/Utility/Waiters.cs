using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using Yukon.PageObjects;

namespace Yukon.Utility
{
    public class Waiters
    {
        private IWebDriver WebDriver { get; set; }
        private WebDriverWait wait;

        private TimeSpan defaultTimeout = TimeSpan.FromSeconds(30);

        public Waiters(IWebDriver webDriver)
        {
            this.WebDriver = webDriver;
            this.wait = new WebDriverWait(this.WebDriver, this.defaultTimeout);
        }

        public bool UntilPageLoaderDisappear() => wait.Until(this.WaitForElementIsDisplayed);

        private Func<IWebDriver, bool> WaitForElementIsDisplayed
            = new Func<IWebDriver, bool>((webDriver) =>
        {
            try
            {
                webDriver.FindElement(BasePage.PageLoader);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        });
    }
}
