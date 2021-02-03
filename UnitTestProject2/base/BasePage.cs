using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace FirstTestProject
{
    public class BasePage
    {
        public static IWebDriver webDriver;

        protected void Navigate(String url)
        {
            webDriver.Navigate().GoToUrl(url);
        }

        public IWebElement GetWebElement(By locator)
        {
            return webDriver.FindElement(locator);
        }


        protected bool ElementIsDisplayed(By locator)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(20));
            return webDriver.FindElement(locator).Displayed ? true : false;
        }

        public void WaitForDisplayed(By locator)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(20));
            wait.Until((driver) => GetWebElement(locator).Displayed == true);
        }

        public void WaitForEnabled(By locator)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(20));
            wait.Until(driver => GetWebElement(locator).Enabled == true);
        }
    }

}
