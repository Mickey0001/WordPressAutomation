using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressAutomation
{
    public class LoginPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("http://localhost/test/wp-login.php");
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("id") == "user_login");
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
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

        public object WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {
            var LoginInput = Driver.Instance.FindElement(By.Id("user_login"));
            LoginInput.SendKeys(userName);

            var PasswordInput = Driver.Instance.FindElement(By.Id("user_pass"));
            PasswordInput.SendKeys(password);

            var LoginButton = Driver.Instance.FindElement(By.Id("wp-submit"));
            LoginButton.Click();
        }
    }
}
