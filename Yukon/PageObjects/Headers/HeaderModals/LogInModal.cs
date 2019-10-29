using NUnit.Framework;
using OpenQA.Selenium;

namespace Yukon.PageObjects.Headers.HeaderModals
{
    public class LogInModal : BaseHeaderModal
    {
        public LogInModal(IWebDriver webDriver) : base(webDriver)
        {
            Assert.AreEqual(Text.LogInModal.LogInHeader, base.GetModalHeader(),
                            "Log In modal window wasn't downloaded");
        }

        private IWebElement LoginTextField
            => GetElement(By.XPath("//div[@class='b-modal__body']//input[contains(@class, 't-login__name')]"));


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
