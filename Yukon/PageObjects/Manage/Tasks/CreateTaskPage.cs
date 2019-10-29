using NUnit.Framework;
using OpenQA.Selenium;

namespace Yukon.PageObjects.Manage.Tasks
{
    public class CreateTaskPage : BasePage
    {
        public CreateTaskPage(IWebDriver webDriwer) : base(webDriwer)
        {
            Assert.AreEqual(Text.CreateTaskPage.HeaderTitle, Action.GetTextOf(Header),
                "Create Task page was not downloaded");
        }

        private IWebElement Header => GetElement(By.XPath("//h3"));
        private IWebElement Title => GetElement(By.XPath($"//div/label[normalize-space()='{Text.CreateTaskPage.TitleInput}']/..//input[@id='title_input']"));
        private IWebElement DescriptionInput
            => GetElement(By.XPath("//div[contains(@class, 'rdw-editor-main')]//div[@role='textbox']"));
        private IWebElement SpecialitiesDropDown
            => GetElement(By.XPath($"//div[contains(@class, 'PrettyInput')]/label[normalize-space()='{Text.CreateTaskPage.SpecialitiesDropDown}']/..//span"));
        private IWebElement CurrencyDropDown => GetElement(By.XPath(""));
        private IWebElement BudgetInput => GetElement(By.XPath(""));
        private IWebElement RewardTypeDropDown => GetElement(By.XPath(""));
        private IWebElement AdditionalInformationLink => GetElement(By.XPath(""));
        private IWebElement ContractorsLanguages => GetElement(By.XPath(""));
        private IWebElement VisibilityDropDown => GetElement(By.XPath(""));
        private IWebElement SkillsDropDown => GetElement(By.XPath(""));
        private IWebElement DurationDropDown => GetElement(By.XPath(""));
        private IWebElement EmploymentDropDown => GetElement(By.XPath(""));

        public void InputTitleTextField(string text) => Action.SendKeysTo(Title, text);
        public void InputDescriptionField(string text) => Action.SendKeysTo(DescriptionInput, text);
        public void ClickOnSpecialitiesDropDown() => Action.ClickOn(SpecialitiesDropDown);
    }
}
