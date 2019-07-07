using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomationFramework;

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
            //Go to posts, get post count, store
            ListPostsPage.GoTo(PostType.Posts);
            ListPostsPage.StoreCount();

            //Add new post
            PostCreator.CreatePost();
  
            //Go to posts, get new posts count
            ListPostsPage.GoTo(PostType.Posts);
            Assert.AreEqual(ListPostsPage.PreviousPostCount + 1, ListPostsPage.CurrentPostCount, "Count of posts did not increase");

            //Check for added post
            Assert.IsTrue(ListPostsPage.DoesPostExistWithTitle(PostCreator.PreviousTitle));

            //Trash post (clean up)
            ListPostsPage.TrashPost(PostCreator.PreviousTitle));
            Assert.AreEqual(ListPostsPage.PreviousPostCount, ListPostsPage.CurrentPostCount, "Cloud not trash post");
        }
        [TestMethod]
        public void CanSearchPosts()
        {
            //Create a new post
            NewPostPage.GoTo();
            NewPostPage.CreatePost("Searching posts, title").WithBody("Searching posts, body").Publish();

            //Go to list post
            ListPostsPage.GoTo(PostType.Posts);

            //Search for the post
            ListPostsPage.SearchForPost("Searching posts, title");

            //Check that post shows up in the results
            Assert.IsTrue(ListPostsPage.DoesPostExistWithTitle("Searching posts, title"));

            //Trash the post
            ListPostsPage.TrashPost("Searching posts, title");
        }
    }
}
