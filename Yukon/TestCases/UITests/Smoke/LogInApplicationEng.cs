using NUnit.Framework;
using Yukon.Models.Configs;
using Yukon.PageObjects.Headers;
using Yukon.TestData.UITests;

namespace Yukon.TestCases.UITests.Smoke
{
    public class LogInApplicationEng : UIBaseTest
    {
        public LogInApplicationEng() : base()
        {
        }
                
        public override void LogIn() { }

        [Test]
        [Description("This test verifies registration in application both as Customer and Supplier English version")]
        [TestCaseSource(typeof(UsersCredentials), "TestCases")]
        public void Log_In_Application_Eng(Users client)
        {
            ApplicationHeader appHeader
                = LoadPage<RegistrationHeader>().LogInAs(client);

            appHeader.ClickExitButton();
        }
    }
}