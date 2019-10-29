using NUnit.Framework;
using System.Collections.Generic;

namespace Yukon.TestData.UITests.CreateTask
{
    public class UsersCredentials
    {
        public static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(new CreateTaskDataClass());
            }
        }
    }
}
