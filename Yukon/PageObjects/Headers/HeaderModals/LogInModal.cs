using NUnit.Framework;
using OpenQA.Selenium;

namespace Yukon.PageObjects.Headers.HeaderModals
{
    public class LogInModal : BaseHeaderModal
    {
        public LogInModal(IWebDriver webDriver) : base(webDriver)
        {
            Assert.AreEqual(Text.LogInModal.LogInHeader, GetModalHeader(),
                            "Log In modal window wasn't downloaded");
        }

        private IWebElement LoginTextField
            => GetElement(By.XPath("//div[@class='b-modal__body']//input[contains(@class, 't-login__name')]"));


        public void ClearLoginTextField() => Action.Clear(LoginTextField);

        public void InputLoginTextfield(string text) => Action.SendKeysTo(LoginTextField, text);

        public void InputPasswordTextfield(string text) => InputPassword(text);

        public void ClickRememberLoginCheckBox() => ClickCheckBox();

        public MessageAccessModal ClickLogInButton()
        {
            ClickButton();
            Wait.UntilPageLoaderDisappear();
            return ReturnPage<MessageAccessModal>();
        }
    }
}
