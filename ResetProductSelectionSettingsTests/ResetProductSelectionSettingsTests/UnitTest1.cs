using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ResetProductSelectionSettingsTests
{
    public class Tests
    {
        private IWebDriver web;

        private readonly By _maxValueOfPriceInput = By.XPath("//input[@name='arrFilter_P1_MAX']");
        private readonly By _isMechanicsDiv = By.XPath("//div[@data-role='label_arrFilter_9_1842515611']");
        private readonly By _isMechanicsCheckBox = By.XPath("//input[@name='arrFilter_9_1842515611']");
        private readonly By _resetButton = By.Id("del_filter");

        [SetUp]
        public void Setup()
        {
            var service = ChromeDriverService.CreateDefaultService("./chromedriver.exe");
            service.HideCommandPromptWindow = true;
            web = new ChromeDriver(service);
            web.Navigate().GoToUrl("https://luch.by/watches/");
            web.Manage().Window.Maximize();

        }

        //test-case #7
        [Test]
        public void TestClearSettingsButton()
        {
            var maxValueOfPriceInput = web.FindElement(_maxValueOfPriceInput);
            maxValueOfPriceInput.SendKeys("200");

            var isMechanicsBlock = web.FindElement(_isMechanicsDiv);
            isMechanicsBlock.Click();

            Task.Delay(1000).Wait();
            var resetButton = web.FindElement(_resetButton);
            resetButton.Click();

            var isMechanicsCheckBox = web.FindElement(_isMechanicsCheckBox);
            Assert.IsFalse(isMechanicsCheckBox.Selected);

            var actualMaxPrice = web.FindElement(_maxValueOfPriceInput).Text;

            Assert.That(actualMaxPrice, Is.EqualTo(""), "max price was not cleared");
        }

        [TearDown]
        public void TearDown()
        {
            web.Quit();
        }
    }
}