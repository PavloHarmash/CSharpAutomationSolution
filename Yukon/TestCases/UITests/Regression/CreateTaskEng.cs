﻿using NUnit.Framework;
using Yukon.PageObjects.Headers;
using Yukon.PageObjects.Headers.Dropdowns;
using Yukon.PageObjects.Manage.Tasks;
using Yukon.TestData.UITests.CreateTask;

namespace Yukon.TestCases.UITests.Regression
{
    class CreateTaskEng : UIBaseTest
    {
        TaskData task;

        public CreateTaskEng() : base()
        {
            this.task = new TaskData();
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
            createTask.InputTitleTextField(this.task.Title);
            createTask.InputDescriptionField(this.task.Description);
            createTask.ClickOnSpecialitiesDropDown();
        }
    }
}
