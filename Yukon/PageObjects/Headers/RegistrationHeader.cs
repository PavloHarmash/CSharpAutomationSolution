using NUnit.Framework;
using OpenQA.Selenium;
using Yukon.PageObjects.Modals.HeaderModals;
using static Yukon.Libraries.TranslationLibrary.TranslationLibrary;

namespace Yukon.PageObjects.Headers
{
    public class RegistrationHeader : BaseHeader
    {
        public RegistrationHeader(IWebDriver webDriver) : base(webDriver)
        {
            Assert.AreEqual(PageText.RegistrationHeader.LogInButton, Action.GetTextOf(this.LogInLink),
                            "Registration Header wasn't downloaded");
        }

        private IWebElement LogInLink
            => base.GetElement(By.XPath("//div[@class='b-header__inner']//span[contains(@class, 't-login__link')]"));
        private IWebElement RegisterLink
            => base.GetElement(By.XPath("//div[@class='b-header__inner']//span[contains(@class, 't-registration__link')]"));

        public LogInModal ClickOnLogInLink()
        {
            Action.ClickOn(this.LogInLink);
            Wait.UntilPageLoaderDisappear();
            return ReturnPage<LogInModal>();
        }

        public void LogInAs(string login, string password)
        {
            LogInModal loginModal = ClickOnLogInLink();
            loginModal.ClearLoginTextField();
            loginModal.InputLoginTextfield(login);
            loginModal.InputPasswordTextfield(password);
            loginModal.ClickRememberLoginCheckBox();
            loginModal.ClickLogInButton();
        }
    }
}
