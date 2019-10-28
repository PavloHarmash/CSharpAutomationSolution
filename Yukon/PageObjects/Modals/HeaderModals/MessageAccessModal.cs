using NUnit.Framework;
using OpenQA.Selenium;
using Yukon.PageObjects.Headers;

namespace Yukon.PageObjects.Modals.HeaderModals
{
    public class MessageAccessModal : BaseModal
    {
        public MessageAccessModal(IWebDriver webDriwer) : base(webDriwer)
        {
            Assert.AreEqual(PageText.MessageAccessModal.MessageAccessHeader, GetModalHeader(),
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
