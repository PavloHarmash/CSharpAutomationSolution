﻿using Yukon.PageObjects;

namespace Yukon.TestData.UITests.CreateTask
{
    public class TaskData
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public (string sector, string speciality, string level) Speciality { get; set; }
        public string Currency { get; set; }
        public string Budget { get; set; }
        public string RewardType { get; set; }
        public (string firstLanguage, string additionalLanguage) ContractorsLanguages { get; set; }
        public string Visibility { get; set; }
        public string Skills { get; set; }
        public string Duration { get; set; }

        public TaskData()
        {
            this.Title = "Auto Tester Needed";
            this.Description = string.Concat("We’re working with Booboo, one of the leader on the travel market USA.\n",
                "It’s a technology company that powers leading online and hybrid travel agencies like CheapOair, OneTravel, and Travelong.\n",
                "We use technology to help people take much-needed vacations or get the best deals on travel through our products.\n",
                "We are looking for a highly motivated Automation QA Engineer possessing with 2+ years of experience testing(API),\n",
                "who can take ownership, drive communications, being proactive, manage project goals, contribute to product strategy and help define best practices.");
            this.Speciality
                = (BasePage.Text.CreateTaskPage.SpecialitiesValues.Area.WebMobileAndSoftwareDev,
                   BasePage.Text.CreateTaskPage.SpecialitiesValues.Speciality.QAEngineer,
                   BasePage.Text.CreateTaskPage.SpecialitiesValues.Levels.Middle);
            this.Currency = BasePage.Text.CreateTaskPage.CurrencyValues.USDollar;
            this.Budget = "1500";
            this.RewardType = BasePage.Text.CreateTaskPage.RewardTypeValues.PerMonth;
            this.ContractorsLanguages
                = (BasePage.Text.CreateTaskPage.Languages.Russian,
                   BasePage.Text.CreateTaskPage.Languages.English);
            this.Visibility = BasePage.Text.CreateTaskPage.VisibilityValues.VisibleToAllUsers;
            this.Skills = BasePage.Text.CreateTaskPage.Skills;
            this.Duration = BasePage.Text.CreateTaskPage.Duration.Months;
        }
    }
}
