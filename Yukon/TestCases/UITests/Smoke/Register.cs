using NUnit.Framework;
using Yukon.Configurations.TestEnvironment;
using Yukon.Configurations.Users;
using Yukon.TestCases.UITests;

namespace CSharpAutomationSolution.TestCases.UITests.Smoke
{
    public class Register : UIBaseTest
    {
        public Register() : base(downloadFiles: true)
        {
        }

        [Test]
        [Description("This test verifies registration in application")]
        public void Register_In_Application()
        {
            var url = TestEnvConfigs.URL;
            var apiPort = TestEnvConfigs.ApiPort;
            var customer = UsersConfigs.Customer;
            var implementer = UsersConfigs.Implementer;
        }
    }
}