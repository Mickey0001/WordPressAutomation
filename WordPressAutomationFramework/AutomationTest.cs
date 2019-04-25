using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressAutomationFramework
{
    public class AutomationTest
    {
        public void Go()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost/test/wp-login.php");
        }
    }
}
