using NUnit.Framework;
using Yukon.Configurations.TestEnvironment;
using Yukon.Configurations.Users;
using Yukon.PageObjects.Headers;

namespace Yukon.TestCases.UITests.Smoke
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
            var supplier = UsersConfigs.Supplier;

            RegisterHeader header = PageLoad<RegisterHeader>();

            LounchBrowser();
            
            RegisterHeader header1 = PageLoad<RegisterHeader>();
        }
    }
}