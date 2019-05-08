using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace WordPressAutomationFramework
{
    public class LoginPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("http://localhost/test/wp-login.php");
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("id") == "user_login");
        }

        public static LoginCommand LoginAs(string UserName)
        {
            return new LoginCommand(UserName);
        }
    }

    public class LoginCommand
    {
        private readonly string UserName;
        private string password;

        public LoginCommand(string UserName)
        {
            this.UserName = UserName;
        }

        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {
            var LoginInput = Driver.Instance.FindElement(By.Id("user_login"));
            LoginInput.SendKeys(UserName);

            var PasswordInput = Driver.Instance.FindElement(By.Id("user_pass"));
            PasswordInput.SendKeys(password);

            var LoginButton = Driver.Instance.FindElement(By.Id("wp-submit"));
            LoginButton.Click();
        }
    }
}
