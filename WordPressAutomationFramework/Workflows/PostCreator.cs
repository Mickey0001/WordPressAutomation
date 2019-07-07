using System;

namespace WordPressAutomationFramework.Workflows
{
    public class PostCreator
    {
        public static void CreatePost()
        {
            NewPostPage.GoTo();

            PreviousTitle = CreateTitle();
            PreviousBody = CreateBody();

            NewPostPage.CreatePost(PreviousTitle).WithBody(PreviousBody).Publish();
        }

        private static string CreateBody()
        {
            throw new NotImplementedException();
        }

        private static string CreateTitle()
        {
            throw new NotImplementedException();
        }

        public static string PreviousBody { get; set; }

        public static string PreviousTitle { get; set; }
    }
}