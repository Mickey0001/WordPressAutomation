﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomationFramework;

namespace WordPressTests
{
    [TestClass]
    public class CreatePostTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }


        [TestMethod]
        public void CanCreateBasicPost()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("test").WithPassword("z$olpR5FSaVJU^A#c!").Login();

            NewPostPage.GoTo();
            NewPostPage.CreatePost("Test post title").WithBody("Post body").Publish();

            NewPostPage.GoToNewPost();

            Assert.AreEqual(PostPage.Title, "Test post title", "Title did not match the test post");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
