using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomationFramework;

namespace WordPressTests
{
    [TestClass]
    public class LoginTests : WordPressTest
    {
        [TestMethod]
        public void AdminUserCanLogin()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("test").WithPassword("z$olpR5FSaVJU^A#c!").Login();

            Assert.IsTrue(DashboardPage.IsAt, "Failed to login as admin");
        }
    }
}
