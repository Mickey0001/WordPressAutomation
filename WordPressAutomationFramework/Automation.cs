using System;


namespace WordPressAutomationFramework
{
    public class Automation
    {
        public void Go()
        {
            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://bing.com");
        }
    }
}
