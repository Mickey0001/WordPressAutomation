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
            Assert.IsTrue(DashboardPage.IsAt, "Failed to login as admin");
        }
    }
}
