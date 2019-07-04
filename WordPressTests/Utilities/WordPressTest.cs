using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomationFramework;

namespace WordPressTests
{
    public class WordPressTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            LoginPage.GoTo();
            LoginPage.LoginAs("test").WithPassword("z$olpR5FSaVJU^A#c!").Login();
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
