using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomationFramework;

namespace WordPressTests
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void AdminUserCanLogin()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("test").WithPassword("password").Login();

            Assert.IsTrue(DashboardPage.IsAt, "Failed to login as admin");
        }
    }
}
