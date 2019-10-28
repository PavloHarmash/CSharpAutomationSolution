using NUnit.Framework;
using System.Collections.Generic;
using static Yukon.Configurations.Users.UsersConfigurations;

namespace Yukon.TestData.UITests
{
    public class UsersCredentials
    {
        public static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(User.Customer.Login,
                                              User.Customer.Password,
                                              User.Customer.MessageLogPassword);
                yield return new TestCaseData(User.Supplier.Login,
                                              User.Supplier.Password,
                                              User.Supplier.MessageLogPassword);
            }
        }
    }
}
