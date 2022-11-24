using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainTests.PageObjects
{
    internal class CarWatchesPageObject
    {
        private IWebDriver _web;

        private readonly By _inputName = By.XPath("//input[@name='Name']");
        private readonly By _phoneNumber = By.XPath("//input[@name='Phone']");
        private readonly By _message = By.XPath("//textarea[@placeholder='Сообщение']");
        private readonly By _buttonSendForm = By.XPath("//button[text()='Отправить заявку']");
        private readonly By _successDiv = By.CssSelector(".js-successbox");

        public CarWatchesPageObject(IWebDriver web)
        {
            _web = web;
        }

        public void fillCallForm (string name, string phoneNumber, string message)
        {
            _web.FindElement(_inputName).SendKeys(name);
            _web.FindElement(_phoneNumber).SendKeys(phoneNumber);
            _web.FindElement(_message).SendKeys(message);
            _web.FindElement(_buttonSendForm).Click();
            Task.Delay(30000).Wait();
        }

        public string GetSuccessDivValue()
        {
            return _web.FindElement(_successDiv).Text;
        }
    }
}
