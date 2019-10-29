using NUnit.Framework;
using Yukon.Enums;
using Yukon.PageObjects.Headers;
using Yukon.PageObjects.Headers.Dropdowns;
using Yukon.PageObjects.Tasks;

namespace Yukon.TestCases.UITests.Regression
{
    class CreateTaskEng : UIBaseTest
    {
        public CreateTaskEng() : base(appLanguage: AppLanguage.English)
        {
        }

        [Test]
        [Description("This test verifies Task creation workflow")]
        public void Create_Task_Eng()
        {
            ManageDropDown manageDropDown
                = LoadPage<ApplicationHeader>()
                .DoubleClickOnManageDropDown();

            TasksPage taskPage = manageDropDown.ClickOnTasksMenuItem();
            CreateTaskPage createTask = taskPage.ClickOnCreateTaskFolder();
        }
    }
}
