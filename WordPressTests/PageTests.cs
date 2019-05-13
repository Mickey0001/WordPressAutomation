using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressAutomationFramework;

namespace WordPressTests
{
    [TestClass]
    public class PageTests : WordPressTest
    {
        [TestMethod]
        public void CanEditPage()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("test").WithPassword("z$olpR5FSaVJU^A#c!").Login();

            ListPostsPage.GoTo(PostType.Page);
            ListPostsPage.SelectPost("Sampe Page");

            Assert.IsTrue(NewPostPage.IsInEditMode(), "Not in edit mode");
            Assert.AreEqual("Sample Page", NewPostPage.Title, "Title did no match");
        }
    }
}
