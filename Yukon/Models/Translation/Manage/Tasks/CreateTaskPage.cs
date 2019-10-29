namespace Yukon.Models.Translation.Manage.Tasks
{
    public class CreateTaskPage
    {
        public string HeaderTitle { get; set; }
        public string TitleInput { get; set; }
        public string DescriptionInput { get; set; }
        public string SpecialitiesDropDown { get; set; }
        public string CurrencyDropDown { get; set; }
        public string BudgetInput { get; set; }
        public string RewardTypeDropDown { get; set; }
        public string AdditionalInformationLink { get; set; }
        public string ContractorsLanguages { get; set; }
        public string VisibilityDropDown { get; set; }
        public string SkillsDropDown { get; set; }
        public string DurationDropDown { get; set; }
        public string EmploymentDropDown { get; set; }
        public SpecialitiesValues SpecialitiesValues { get; set; }
        public CurrencyValues CurrencyValues { get; set; }
        public RewardTypeValues RewardTypeValues { get; set; }
        public Languages Languages { get; set; }
        public VisibilityValues VisibilityValues { get; set; }
        public string Skills { get; set; }
        public Duration Duration { get; set; }
        public Employment Employment { get; set; }
    }

    public class Area
    {
        public string WebMobileAndSoftwareDev { get; set; }
    }

    public class Speciality
    {
        public string QAEngineer { get; set; }
    }

    public class Levels
    {
        public string Junior { get; set; }
        public string Middle { get; set; }
        public string Senior { get; set; }
    }

    public class SpecialitiesValues
    {
        public Area Area { get; set; }
        public Speciality Speciality { get; set; }
        public Levels Levels { get; set; }
    }

    public class CurrencyValues
    {
        public string USDollar { get; set; }
    }

    public class RewardTypeValues
    {
        public string PerMonth { get; set; }
    }

    public class Languages
    {
        public string Russian { get; set; }
        public string English { get; set; }
    }

    public class VisibilityValues
    {
        public string VisibleToAllUsers { get; set; }
    }

    public class Duration
    {
        public string Months { get; set; }
    }

    public class Employment
    {
        public string FullTime { get; set; }
    }
}
