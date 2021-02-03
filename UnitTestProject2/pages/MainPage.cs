using FirstTestProject;
using OpenQA.Selenium;
using System;

namespace MyTests
{
    public class MainPage : BasePage
    {
        public By SearchField = By.XPath("//div[@class='RNNXgb']//input");
        public By Result = By.XPath("//div[@id='appbar']//div[@id='result-stats']");

        public void OpenStartUrl()
        {
            Navigate(Constants.SITE_URL);
        }
        public void EnterSearchRequest(string request)
        {
            WaitForEnabled(SearchField);
            GetWebElement(SearchField).SendKeys(Constants.Request);
            GetWebElement(SearchField).SendKeys(Keys.Enter);
        }

        public Boolean AssertIsElementPresented(By elementToWait)
        {
            return ElementIsDisplayed(Result);
        }
    }
}
