using NUnit.Framework;
using OpenQA.Selenium;
using static Yukon.Libraries.TranslationLibrary.TranslationLibrary;

namespace Yukon.PageObjects.Headers
{
    public class ApplicationHeader : BaseHeader
    {
        public ApplicationHeader(IWebDriver webDriwer) : base(webDriwer)
        {
            Assert.IsTrue(Action.GetText(TaskSearch)
                .Equals(TranslationFor.Breadcrumbs.TaskSearch), "Application Header wasn't downloaded");
        }

        IWebElement TaskSearch
            => GetElement(By.XPath($"//span[text()='{TranslationFor.Breadcrumbs.TaskSearch}']"));

        IWebElement ExitButton
            => GetElement(By.XPath($"//span[@title='{TranslationFor.ApplicationHeader.ExitButton}']"));

        public void ClickExitButton() => Action.Click(ExitButton);
    }
}
