using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyTests.tests
{

    class SmokeTests
    {
        private IWebDriver webDriver;
        private MainPage mainPage;

        [Test]
        public void Initialize()
        {
            mainPage = new MainPage();
            webDriver = new ChromeDriver();
        }

        
        public void SmokeTest()
        {
            mainPage.OpenStartUrl();
            mainPage.EnterSearchRequest(Constants.Request);
            Assert.IsTrue(mainPage.AssertIsElementPresented(mainPage.Result));
        }
        [OneTimeTearDown]
        public void CleanUp()
        {
            webDriver.Quit();
        }



    }
}
