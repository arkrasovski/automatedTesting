using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainTests.PageObjects
{
    internal class mainPagePageObject
    {
        private IWebDriver _web;
        private readonly By linkToWatches = By.XPath("//div[text()='Наручные часы']");
        private readonly By _isMechanicsCheckBox = By.XPath("//input[@name='arrFilter_9_1842515611']");
        private readonly By _aboutUs = By.XPath("//div[text()='О нас']");
        private readonly By _carWatches = By.XPath("//a[text()='Автомобильные кварцевые часы' and @class='inset__link']");

        public mainPagePageObject(IWebDriver web)
        {
            _web = web;
        }

        public WatchesPageObject GoToWatches()
        {
            _web.FindElement(linkToWatches).Click();
            return new WatchesPageObject(_web);
        }

        public string CheckMaxPriceField()
        {
           WatchesPageObject maxPrice = new WatchesPageObject(_web);
           return maxPrice.GetMaxPriceInputValue();
        }

        public bool IsCheckBoxSelected()
        {
            var isMechanicsCheckBox = _web.FindElement(_isMechanicsCheckBox);
            return isMechanicsCheckBox.Selected;
        }

        public CarWatchesPageObject GoToCarWatches()
        {
            IWebElement elem = _web.FindElement(_aboutUs);
            Actions builder = new Actions(_web);
            builder.MoveToElement(elem).Perform();

            _web.FindElement(_carWatches).Click();
            
            return new CarWatchesPageObject(_web);
        }

        public string CheckSuccesDiv()
        {
            CarWatchesPageObject successDiv = new CarWatchesPageObject(_web);
            return successDiv.GetSuccessDivValue();
        }
    }
}
