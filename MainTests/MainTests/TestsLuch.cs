using MainTests;
using MainTests.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ResetProductSelectionSettingsTests
{
    public class Tests
    {
        private IWebDriver _web;

        [SetUp]
        public void Setup()
        {
            var service = ChromeDriverService.CreateDefaultService("E:\\Studies\\automatedTesting\\MainTests\\MainTests");
            service.HideCommandPromptWindow = true;
            _web = new ChromeDriver(service);
            _web.Navigate().GoToUrl("https://luch.by/");
            _web.Manage().Window.Maximize();

        }


        [Test]
        public void TestOrderCarWatches()
        {
            var mainPage = new mainPagePageObject(_web);
            mainPage
                .GoToCarWatches()
                .fillCallForm(DataForTests.name, DataForTests.phoneNumber, DataForTests.message);
            string actualSuccessDiv = mainPage.CheckSuccesDiv();
            Assert.That(actualSuccessDiv, Is.EqualTo("Thank you! Your data has been submitted."), "success div is not correct");
        }

        //test-case #7
        [Test]
        public void TestClearSettingsButton()
        {
            var mainPage = new mainPagePageObject(_web);
            mainPage
                .GoToWatches()
                .AddValuesToFields(DataForTests.maxPrice)
                .Reset();

            bool isCheckboxSelected = mainPage.IsCheckBoxSelected();
            Assert.IsFalse(isCheckboxSelected);

            string actualMaxPrice = mainPage.CheckMaxPriceField();
            Assert.That(actualMaxPrice, Is.EqualTo(""), "max price was not cleared");
        }


        [TearDown]
        public void TearDown()
        {
           _web.Quit();
        }
    }
}