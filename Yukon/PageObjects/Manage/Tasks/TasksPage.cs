using NUnit.Framework;
using OpenQA.Selenium;

namespace Yukon.PageObjects.Manage.Tasks
{
    public class TasksPage : BasePage
    {
        public TasksPage(IWebDriver webDriwer) : base(webDriwer)
        {
            Assert.AreEqual(Text.TasksPage.SidebarLinkTasks, Action.GetTextOf(SidebarTaskLink),
                "Tasks Page was not downloaded");
        }

        private IWebElement SidebarTaskLink
            => GetElement(By.XPath("//div[@class='manage-sidebar-nav']/a[contains(@class, 'item_active')]"));

        private IWebElement CreateTaskFolder
            => GetElement(By.XPath($"//div[@class=' folder-inner_link']/div[normalize-space()='{Text.TasksPage.CreateTaskFolder}']"));

        public CreateTaskPage ClickOnCreateTaskFolder()
        {
            Action.ClickOn(CreateTaskFolder);
            Wait.UntilPageLoaderDisappear();
            return ReturnPage<CreateTaskPage>();
        }
    }
}
