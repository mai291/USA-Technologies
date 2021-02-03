using OpenQA.Selenium;


namespace FirstTestProject
{
    public class Driver
    {
        protected IWebDriver WebDriver;

        public Driver(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
    }

}
