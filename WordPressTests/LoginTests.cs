using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomation;

namespace WordPressTests
{
    [TestClass]
    public class LoginTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void AdminUserCanLogin()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("test").WithPassword("password").Login();

            Assert.IsTrue(DashboardPage.IsAt, "Failed to login as und administrator, ya?");
        }
        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
