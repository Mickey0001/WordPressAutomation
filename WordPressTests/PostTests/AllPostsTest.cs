using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomationFramework;
using WordPressAutomationFramework.Workflows;

namespace WordPressTests.PostTests
{
    [TestClass]
    public class AllPostsTests : WordPressTest
    {
        //Added posts show up in all posts
        //Can activate excerpt mode
        //Can add new post

        //Single post selections

        //Can select a post by title
        //Can select a post by Edit
        //Can select a post by QuickEdit
        //Can trash a post
        //Can view a post
        //Can filter by auther
        //Can filter by category
        //Can filter by tag
        //Can go to post comments

        //Bulk actions

        //Can edit multiple posts
        //Can trash multiple posts
        //Can select all posts

        //Can search posts

        //Added posts show up in all posts
        //Can Trash a post
        //Can search post

        [TestMethod]
        public void AddedPostsShowUp()
        {
            ListPostsPage.GoTo(PostType.Posts);
            ListPostsPage.StoreCount();

            PostCreator.CreatePost();
  
            ListPostsPage.GoTo(PostType.Posts);
            Assert.AreEqual(ListPostsPage.PreviousPostCount + 1, ListPostsPage.CurrentPostCount, "Count of posts did not increase");

            Assert.IsTrue(ListPostsPage.DoesPostExistWithTitle(PostCreator.PreviousTitle));

            ListPostsPage.TrashPost(PostCreator.PreviousTitle);
            Assert.AreEqual(ListPostsPage.PreviousPostCount, ListPostsPage.CurrentPostCount, "Cloud not trash post");
        }
        [TestMethod]
        public void CanSearchPosts()
        {
            PostCreator.CreatePost();

            ListPostsPage.SearchForPost(PostCreator.PreviousTitle);

            Assert.IsTrue(ListPostsPage.DoesPostExistWithTitle(PostCreator.PreviousTitle));
        }
    }
}
