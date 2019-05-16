using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomationFramework;

namespace WordPressTests
{
    [TestClass]
    public class PageTests : WordPressTest
    {
        [TestMethod]
        public void CanEditPage()
        {
            ListPostsPage.GoTo(PostType.Page);
            ListPostsPage.SelectPost("Sampe Page");

            Assert.IsTrue(NewPostPage.IsInEditMode(), "Not in edit mode");
            Assert.AreEqual("Sample Page", NewPostPage.Title, "Title did no match");
        }
    }
}
