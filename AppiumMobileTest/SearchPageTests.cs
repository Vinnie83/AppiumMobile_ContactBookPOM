

using AppiumMobileTests.POM;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.PageObjects;
using System.Runtime.CompilerServices;

namespace AppiumMobileTests
{
    public class AppiumMobileTests
    {

        private AndroidDriver<AndroidElement> driver;
        private AppiumOptions options;
        private const string appiumServer = "http://127.0.0.1:4723/wd/hub";
        private const string appLocation = @"C:\contactbook-androidclient.apk";
        private ConnectionPage connectionPage;    
        private SearchPage searchPage;

        [SetUp]
        
        public void Setup()
        {
            this.options = new AppiumOptions() { PlatformName = "Android" };
            options.AddAdditionalCapability("app", appLocation);
            this.driver = new AndroidDriver<AndroidElement>(new Uri(appiumServer), options);
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            this.connectionPage = new ConnectionPage(this.driver);
            this.searchPage = new SearchPage(this.driver);
        }

        [TearDown]

        public void CloseApp() 
        {

            this.driver.Quit();
        }

        [Test]

        public void FirstContactShouldBeSteveJobs()
        {
            var expectedResult = "Steve Jobs";

            this.connectionPage.ConnectToUrl();

            this.searchPage.SearchInput.SendKeys("steve");
            this.searchPage.SearchButton.Click();   

            var actualResult = this.searchPage.GetActualResult();   

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        
    }
}