using NUnit.Framework;
using Yukon.PageObjects.Headers;
using Yukon.PageObjects.Modals.HeaderModals;
using Yukon.TestData.UITests;

namespace Yukon.TestCases.UITests.Smoke
{
    class LogInApplicationRus : UIBaseTest
    {
        public LogInApplicationRus(): base()
        {
        }

        public override void LogIn() { }

        [Test]
        [Description("This test verifies registration in application both as Customer and Supplier English version")]
        [TestCaseSource(typeof(UsersCredentials), "TestCases")]
        public void Log_In_Application_Rus(string login, string password, string messagePassword)
        {
            LogInModal logInModal
                = LoadPage<RegistrationHeader>()
                .ClickOnLogInLink();

            logInModal.ClearLoginTextField();
            logInModal.InputLoginTextfield(login);
            logInModal.InputPasswordTextfield(password);
            logInModal.ClickRememberLoginCheckBox();

            MessageAccessModal messageAccessModal = logInModal.ClickLogInButton();

            messageAccessModal.InputMessageLogPassword(messagePassword);
            messageAccessModal.ClickOnRememberPassword();

            ApplicationHeader appHeader = messageAccessModal.ClickOnAccessButton();
            appHeader.ClickExitButton();
        }
    }
}
