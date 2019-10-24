using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

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
            this.wait = new WebDriverWait(this.WebDriver, defaultTimeout);
        }

        private static By PageLoader = By.XPath("//div[@class='loader hide']");

        private Func<IWebDriver, bool> WaitForElementIsDisplayed
            = new Func<IWebDriver, bool>((webDriver) =>
        {
            try
            {
                webDriver.FindElement(PageLoader);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        });

        public bool UntilPageLoaderDisappear()
            => wait.Until(WaitForElementIsDisplayed);
    }
}
