using NUnit.Framework;
using OpenQA.Selenium;
using Yukon.PageObjects.Headers;
using static Yukon.Libraries.TranslationLibrary.TranslationLibrary;

namespace Yukon.PageObjects.Modals.HeaderModals
{
    public class LogInModal : BaseModal
    {
        public LogInModal(IWebDriver webDriver) : base(webDriver)
        {
            Assert.IsTrue(Action.GetText(ModalHeader)
                .Equals(TranslationFor.LogInModal.LogInHeader), "Log In modal window wasn't downloaded");
        }

        private IWebElement ModalHeader => GetElement(By.XPath("//header[@class='b-modal__header']/h3"));
        private IWebElement LoginTextField => GetElement(By.XPath("//div[@class='b-modal__body']//input[contains(@class, 't-login__name')]"));
        private IWebElement PasswordTextField => GetElement(By.XPath("//div[@class='b-modal__body']//input[contains(@class, 't-login__password')]"));
        private IWebElement RememberLoginCheckBox => GetElement(By.XPath("//span[@class='b-checkbox__fake-mark']"));
        private IWebElement LogInButton => GetElement(By.XPath("//button[contains(@class, 't-login__submit')]"));

        public void ClearLoginTextField() => Action.Clear(LoginTextField);

        public void InputLoginTextfield(string text) => Action.SendKeys(LoginTextField, text);

        public void InputPasswordTextfield(string text) => Action.SendKeys(PasswordTextField, text);

        public void ClickRememberLoginCheckBox() => Action.Click(RememberLoginCheckBox);

        public ApplicationHeader ClickLogInButton()
        {
            Action.Click(LogInButton);
            Wait.UntilPageLoaderDisappear();
            return ReturnPage<ApplicationHeader>();
        }
    }
}
