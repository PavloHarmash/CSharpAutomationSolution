using NUnit.Framework;
using System.Threading;
using Yukon.Configurations.Users;
using Yukon.PageObjects.Headers;
using Yukon.PageObjects.Modals.HeaderModals;

namespace Yukon.TestCases.UITests.Smoke
{
    public class LogInTestSute : UIBaseTest
    {
        public LogInTestSute() : base()
        {
        }

        [Test]
        [Description("This test verifies registration in application")]
        public void Log_In_Application()
        {
            LogInModal logInModal
                = LoadPage<RegistrationHeader>()
                .ClickOnLogInLink();

            logInModal.ClearLoginTextField();
            logInModal.InputLoginTextfield(UsersConfigs.Customer.Login);
            logInModal.InputPasswordTextfield(UsersConfigs.Customer.Password);
            logInModal.ClickRememberLoginCheckBox();

            ApplicationHeader appHeader = logInModal.ClickLogInButton();

            appHeader.ClickExitButton();
        }
    }
}