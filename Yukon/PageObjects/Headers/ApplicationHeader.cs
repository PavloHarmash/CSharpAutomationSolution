using NUnit.Framework;
using OpenQA.Selenium;
using Yukon.PageObjects.Headers.Dropdowns;

namespace Yukon.PageObjects.Headers
{
    public class ApplicationHeader : BaseHeader
    {
        public ApplicationHeader(IWebDriver webDriwer) : base(webDriwer)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(Text.ApplicationHeader.SearchDropDown, Action.GetTextOf(this.SearchDropDown),
                    "ApplicationHeader wasn't downloaded: Search drop down is absent");
                Assert.AreEqual(Text.ApplicationHeader.ManageDropDown, Action.GetTextOf(this.ManageDropDown),
                    "ApplicationHeader wasn't downloaded: Manage drop down is absent");
                Assert.AreEqual(Text.ApplicationHeader.ProfileDropDown, Action.GetTextOf(this.ProfileDropDown),
                    "ApplicationHeader wasn't downloaded: Profile drop down is absent");
            });
        }

        private IWebElement SearchDropDown
            => base.GetElement(By.XPath($"//span[normalize-space()='{Text.ApplicationHeader.SearchDropDown}']"));
        private IWebElement ManageDropDown
            => base.GetElement(By.XPath($"//span[normalize-space()='{Text.ApplicationHeader.ManageDropDown}']"));
        private IWebElement ProfileDropDown
            => base.GetElement(By.XPath($"//span[normalize-space()='{Text.ApplicationHeader.ProfileDropDown}']"));
        private IWebElement ExitButton
            => base.GetElement(By.XPath($"//span[@title='{Text.ApplicationHeader.ExitButton}']"));

        public void ClickExitButton()
        {
            Action.ClickOn(this.ExitButton);
            Wait.UntilPageLoaderDisappear();
        }

        public ManageDropDown DoubleClickOnManageDropDown()
        {
            Action.ClickOn(ManageDropDown);
            Action.ClickOn(ManageDropDown);
            return ReturnPage<ManageDropDown>();
        }
    }
}
