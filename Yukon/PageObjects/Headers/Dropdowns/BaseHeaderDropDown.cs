using OpenQA.Selenium;

namespace Yukon.PageObjects.Headers.Dropdowns
{
    public class BaseHeaderDropDown : BasePage
    {
        public BaseHeaderDropDown(IWebDriver webDriwer) : base(webDriwer)
        {
        }

        private IWebElement MenuItem(string item)
            => base.GetElement(By.XPath($"//ul[@class='b-submenu']//a[normalize-space()='{item}']"));

        protected void ClickMenuItem(string item) => this.MenuItem(item);
    }
}
