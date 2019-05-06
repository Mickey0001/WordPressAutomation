using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressAutomationFramework
{
    public class LoginPage
    {
        public static void GoTo()
        {
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://localhost/test/wp-login.php");
        }

        public static LoginCommand LoginAs(string UserName)
        {
            return new LoginCommand(UserName);
        }
    }

    public class LoginCommand
    {
        private readonly string userName;
        private string password;

        public LoginCommand(string userName)
        {
            this.userName = userName;
        }

        public void Login()
        {
            throw new NotImplementedException();
        }

        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }
    }
}
