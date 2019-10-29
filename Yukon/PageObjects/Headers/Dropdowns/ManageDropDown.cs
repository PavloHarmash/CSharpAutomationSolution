using OpenQA.Selenium;
using Yukon.PageObjects.Manage.Tasks;

namespace Yukon.PageObjects.Headers.Dropdowns
{
    public class ManageDropDown : BaseHeaderDropDown
    {
        public ManageDropDown(IWebDriver webDriwer) : base(webDriwer)
        {
        }

        public TasksPage ClickOnTasksMenuItem()
        {
            base.ClickMenuItem(Text.ManageDropDown.Tasks);
            Wait.UntilPageLoaderDisappear();
            return ReturnPage<TasksPage>();
        }
    }
}
