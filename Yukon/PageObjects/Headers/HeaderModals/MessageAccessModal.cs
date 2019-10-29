using NUnit.Framework;
using OpenQA.Selenium;
using Yukon.PageObjects.Headers;

namespace Yukon.PageObjects.Headers.HeaderModals
{
    public class MessageAccessModal : BaseHeaderModal
    {
        public MessageAccessModal(IWebDriver webDriwer) : base(webDriwer)
        {
            Assert.AreEqual(Text.MessageAccessModal.MessageAccessHeader, GetModalHeader(),
                            "Log In modal window wasn't downloaded");
        }

        public void InputMessageLogPassword(string password) => InputPassword(password);

        public void ClickOnRememberPassword() => ClickCheckBox();

        public ApplicationHeader ClickOnAccessButton()
        {
            ClickButton();
            Wait.UntilPageLoaderDisappear();
            return ReturnPage<ApplicationHeader>();
        }
    }
}
