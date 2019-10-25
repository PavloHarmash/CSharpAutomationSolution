using NUnit.Framework;
using System.Collections.Generic;
using Yukon.Enums;
using Yukon.PageObjects.Headers;
using Yukon.PageObjects.Modals.HeaderModals;
using static Yukon.Configurations.Users.UsersConfigurations;

namespace Yukon.TestCases.UITests.Smoke
{
    public class LogInApplication : UIBaseTest
    {
        public LogInApplication() : base(appLanguage: AppLanguage.English)
        {
        }
                
        public override void LogIn() { }

        public class UsersCredentials
        {
            public static IEnumerable<TestCaseData> TestCases
            {
                get
                {
                    yield return new TestCaseData(User.Customer.Login, User.Customer.Password, User.Customer.MessageLogPassword);
                    yield return new TestCaseData(User.Supplier.Login, User.Supplier.Password, User.Supplier.MessageLogPassword);
                }
            }
        }

        [Test]
        [Description("This test verifies registration in application both as Customer and Supplier")]
        [TestCaseSource(typeof(UsersCredentials), "TestCases")]
        public void Log_In_Application(string login, string password, string messagePassword)
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