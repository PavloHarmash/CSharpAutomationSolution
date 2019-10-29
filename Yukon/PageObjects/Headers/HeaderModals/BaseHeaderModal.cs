using OpenQA.Selenium;

namespace Yukon.PageObjects.Headers.HeaderModals
{
    public class BaseHeaderModal : BasePage
    {
        public BaseHeaderModal(IWebDriver webDriwer) : base(webDriwer)
        {
        }

        protected IWebElement ModalHeader => GetElement(By.XPath("//header[@class='b-modal__header']/h3"));

        private IWebElement PasswordTextField
            => GetElement(By.XPath("//div[@class='b-modal__body']//input[@type='password']"));

        private IWebElement CheckBox
            => GetElement(By.XPath("//span[@class='b-checkbox__fake-mark']"));

        private IWebElement SubmitButton => GetElement(By.XPath("//button[contains(@class, 'btn btn-primary')]"));

        protected string GetModalHeader() => Action.GetTextOf(ModalHeader);

        protected void InputPassword(string password) => Action.SendKeysTo(PasswordTextField, password);

        protected void ClickCheckBox() => Action.ClickOn(CheckBox);

        protected void ClickButton() => Action.ClickOn(SubmitButton);
    }
}
