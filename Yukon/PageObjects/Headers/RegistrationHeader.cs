using NUnit.Framework;
using OpenQA.Selenium;
using Yukon.PageObjects.Modals.HeaderModals;
using static Yukon.Libraries.TranslationLibrary.TranslationLibrary;

namespace Yukon.PageObjects.Headers
{
    public class RegistrationHeader : BaseHeader
    {
        public RegistrationHeader(IWebDriver webDriver) : base(webDriver)
        {
            Assert.IsTrue(Action.GetText(LogInLink)
                .Equals(TranslationFor.RegistrationHeader.LogInButton), "Registration Header wasn't downloaded");
        }

        private IWebElement LogInLink => GetElement(By.XPath("//div[@class='b-header__inner']//span[contains(@class, 't-login__link')]"));
        private IWebElement RegisterLink => GetElement(By.XPath("//div[@class='b-header__inner']//span[contains(@class, 't-registration__link')]"));

        public LogInModal ClickOnLogInLink()
        {
            Action.Click(LogInLink);
            Wait.UntilPageLoaderDisappear();
            return ReturnPage<LogInModal>();
        }
    }
}
