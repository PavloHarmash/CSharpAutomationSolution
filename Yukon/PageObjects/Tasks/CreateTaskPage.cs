using NUnit.Framework;
using OpenQA.Selenium;

namespace Yukon.PageObjects.Tasks
{
    public class CreateTaskPage : BasePage
    {
        public CreateTaskPage(IWebDriver webDriwer) : base(webDriwer)
        {
            Assert.AreEqual(Text.CreateTaskPage.HeaderTitle, Action.GetTextOf(this.Header),
                "Create Task page was not downloaded");
        }

        private IWebElement Header => base.GetElement(By.XPath("//h3"));
        private IWebElement Title => base.GetElement(By.XPath(""));
        private IWebElement DescriptionInput => base.GetElement(By.XPath(""));
        private IWebElement SpecialitiesDropDown => base.GetElement(By.XPath(""));
        private IWebElement CurrencyDropDown => base.GetElement(By.XPath(""));
        private IWebElement BudgetInput => base.GetElement(By.XPath(""));
        private IWebElement RewardTypeDropDown => base.GetElement(By.XPath(""));
        private IWebElement AdditionalInformationLink => base.GetElement(By.XPath(""));
        private IWebElement ContractorsLanguages => base.GetElement(By.XPath(""));
        private IWebElement VisibilityDropDown => base.GetElement(By.XPath(""));
        private IWebElement SkillsDropDown => base.GetElement(By.XPath(""));
        private IWebElement DurationDropDown => base.GetElement(By.XPath(""));
        private IWebElement EmploymentDropDown => base.GetElement(By.XPath(""));
    }
}
