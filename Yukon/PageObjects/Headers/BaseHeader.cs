using OpenQA.Selenium;

namespace Yukon.PageObjects.Headers
{
    public class BaseHeader : BasePage
    {
        public BaseHeader(IWebDriver webDriwer) : base(webDriwer)
        {
        }

        private IWebElement YukonLogo => GetElement(By.XPath("//a[@class='b-header__logo']"));

        protected void ClickOnYoukonLogo() => Action.ClickOn(this.YukonLogo);
    }
}
