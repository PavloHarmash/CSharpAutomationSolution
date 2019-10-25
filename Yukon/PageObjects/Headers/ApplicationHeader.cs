using NUnit.Framework;
using OpenQA.Selenium;
using static Yukon.Libraries.TranslationLibrary.TranslationLibrary;

namespace Yukon.PageObjects.Headers
{
    public class ApplicationHeader : BaseHeader
    {
        public ApplicationHeader(IWebDriver webDriwer) : base(webDriwer)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(PageText.ApplicationHeader.SearchDropDown, Action.GetTextOf(this.SearchDropDown)
                    , "ApplicationHeader wasn't downloaded: Search drop down is absent");
                Assert.AreEqual(PageText.ApplicationHeader.ManageDropDown, Action.GetTextOf(this.ManageDropDown)
                    , "ApplicationHeader wasn't downloaded: Manage drop down is absent");
                Assert.AreEqual(PageText.ApplicationHeader.ProfileDropDown, Action.GetTextOf(this.ProfileDropDown)
                    , "ApplicationHeader wasn't downloaded: Profile drop down is absent");
            });
        }

        private IWebElement SearchDropDown
            => base.GetElement(By.XPath($"//span[normalize-space()='{PageText.ApplicationHeader.SearchDropDown}']"));
        private IWebElement ManageDropDown
            => base.GetElement(By.XPath($"//span[normalize-space()='{PageText.ApplicationHeader.ManageDropDown}']"));
        private IWebElement ProfileDropDown
            => base.GetElement(By.XPath($"//span[normalize-space()='{PageText.ApplicationHeader.ProfileDropDown}']"));
        private IWebElement ExitButton
            => base.GetElement(By.XPath($"//span[@title='{PageText.ApplicationHeader.ExitButton}']"));

        public void ClickExitButton()
        {
            Action.ClickOn(this.ExitButton);
            Wait.UntilPageLoaderDisappear();
        }
    }
}
