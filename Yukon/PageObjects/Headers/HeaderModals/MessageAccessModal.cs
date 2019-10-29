using NUnit.Framework;
using OpenQA.Selenium;

namespace Yukon.PageObjects.Headers.HeaderModals
{
    public class MessageAccessModal : BaseHeaderModal
    {
        public MessageAccessModal(IWebDriver webDriwer) : base(webDriwer)
        {
            Assert.AreEqual(Text.MessageAccessModal.MessageAccessHeader, base.GetModalHeader(),
                            "Log In modal window wasn't downloaded");
        }

        public void InputMessageLogPassword(string password) => base.InputPassword(password);

        public void ClickOnRememberPassword() => base.ClickCheckBox();

        public ApplicationHeader ClickOnAccessButton()
        {
            base.ClickButton();
            Wait.UntilPageLoaderDisappear();
            return ReturnPage<ApplicationHeader>();
        }
    }
}
