using NUnit.Framework;
using OpenQA.Selenium;
using Yukon.Models.Configs;
using Yukon.PageObjects.Modals.HeaderModals;

namespace Yukon.PageObjects.Headers
{
    public class RegistrationHeader : BaseHeader
    {
        public RegistrationHeader(IWebDriver webDriver) : base(webDriver)
        {
            Assert.AreEqual(Text.RegistrationHeader.LogInButton, Action.GetTextOf(this.LogInLink),
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

        public ApplicationHeader LogInAs(Users client)
        {
            LogInModal loginModal = ClickOnLogInLink();
            loginModal.ClearLoginTextField();
            loginModal.InputLoginTextfield(client.Login);
            loginModal.InputPasswordTextfield(client.Password);
            loginModal.ClickRememberLoginCheckBox();

            MessageAccessModal messageAccessModal = loginModal.ClickLogInButton();
            messageAccessModal.InputMessageLogPassword(client.MessageLogPassword);
            messageAccessModal.ClickOnRememberPassword();
            return messageAccessModal.ClickOnAccessButton();
        }
    }
}
