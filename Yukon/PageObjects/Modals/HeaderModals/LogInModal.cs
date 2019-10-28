using NUnit.Framework;
using OpenQA.Selenium;

namespace Yukon.PageObjects.Modals.HeaderModals
{
    public class LogInModal : BaseModal
    {
        public LogInModal(IWebDriver webDriver) : base(webDriver)
        {
            Assert.AreEqual(PageText.LogInModal.LogInHeader, GetModalHeader(),
                            "Log In modal window wasn't downloaded");
        }
        
        private IWebElement LoginTextField
            => base.GetElement(By.XPath("//div[@class='b-modal__body']//input[contains(@class, 't-login__name')]"));


        public void ClearLoginTextField() => Action.Clear(this.LoginTextField);

        public void InputLoginTextfield(string text) => Action.SendKeysTo(this.LoginTextField, text);

        public void InputPasswordTextfield(string text) => base.InputPassword(text);

        public void ClickRememberLoginCheckBox() => base.ClickCheckBox();

        public MessageAccessModal ClickLogInButton()
        {
            base.ClickButton();
            Wait.UntilPageLoaderDisappear();
            return ReturnPage<MessageAccessModal>();
        }
    }
}
