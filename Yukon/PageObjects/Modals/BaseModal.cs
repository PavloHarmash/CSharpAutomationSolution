using OpenQA.Selenium;

namespace Yukon.PageObjects.Modals
{
    public class BaseModal : BasePage
    {
        public BaseModal(IWebDriver webDriwer) : base(webDriwer)
        {
        }

        protected IWebElement ModalHeader => base.GetElement(By.XPath("//header[@class='b-modal__header']/h3"));

        private IWebElement PasswordTextField
            => base.GetElement(By.XPath("//div[@class='b-modal__body']//input[@type='password']"));

        private IWebElement CheckBox
            => base.GetElement(By.XPath("//span[@class='b-checkbox__fake-mark']"));

        private IWebElement SubmitButton => base.GetElement(By.XPath("//button[contains(@class, 'btn btn-primary')]"));

        protected string GetModalHeader() => Action.GetTextOf(this.ModalHeader);

        protected void InputPassword(string password) => Action.SendKeysTo(PasswordTextField, password);

        protected void ClickCheckBox() => Action.ClickOn(this.CheckBox);

        protected void ClickButton() => Action.ClickOn(SubmitButton);
    }
}
