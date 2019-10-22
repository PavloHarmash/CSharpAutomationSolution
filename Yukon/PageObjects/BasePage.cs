using OpenQA.Selenium;

namespace Yukon.PageObjects
{
    public class BasePage
    {
        protected IWebDriver WebDriver { get; set; }

        public BasePage(IWebDriver webDriwer)
        {
            this.WebDriver = webDriwer;
        }
    }
}
