﻿using NUnit.Framework;
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
                yield return new TestCaseData(User.Customer);
                yield return new TestCaseData(User.Contractor);
            }
        }
    }
}
