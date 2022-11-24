using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainTests.PageObjects
{
    internal class WatchesPageObject
    {
        private IWebDriver _web;
        private readonly By _maxValueOfPriceInput = By.XPath("//input[@name='arrFilter_P1_MAX']");
        private readonly By _isMechanicsDiv = By.XPath("//div[@data-role='label_arrFilter_9_1842515611']");
        private readonly By _resetButton = By.Id("del_filter");
        public WatchesPageObject(IWebDriver web)
        {
            _web = web;
        }

        public WatchesPageObject AddValuesToFields(string maxPrice) 
        {
            _web.FindElement(_maxValueOfPriceInput).SendKeys(maxPrice);
            _web.FindElement(_isMechanicsDiv).Click();
            Task.Delay(1000).Wait();
            return new WatchesPageObject(_web);

        }

        public void Reset()
        {
            _web.FindElement(_resetButton).Click();
        }

        public string GetMaxPriceInputValue()
        {
            return _web.FindElement(_maxValueOfPriceInput).Text;

        }
    }
}
