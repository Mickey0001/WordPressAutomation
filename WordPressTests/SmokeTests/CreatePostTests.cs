using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomationFramework;

namespace WordPressTests
{
    [TestClass]
    public class CreatePostTests : WordPressTest
    {
        [TestMethod]
        public void CanCreateBasicPost()
        {
            NewPostPage.GoTo();
            NewPostPage.CreatePost("Test post title").WithBody("Post body").Publish();

            NewPostPage.GoToNewPost();

            Assert.AreEqual(PostPage.Title, "Test post title", "Title did not match the test post");
        }
    }
}
