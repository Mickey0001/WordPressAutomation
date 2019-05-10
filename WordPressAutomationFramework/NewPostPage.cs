using System.Threading;
using OpenQA.Selenium;

namespace WordPressAutomationFramework
{
    public class NewPostPage
    {
        public static void GoTo()
        {
            var MenuPosts = Driver.Instance.FindElement(By.Id("menu-posts"));
            MenuPosts.Click();

            var AddNew = Driver.Instance.FindElement(By.LinkText("Add New"));
            AddNew.Click();
        }

        public static CreatePostCommand CreatePost(string Title)
        {
            return new CreatePostCommand(Title);
        }

        public static void GoToNewPost()
        {
            var Message = Driver.Instance.FindElement(By.Id("message"));
            var NewPostLink = Message.FindElements(By.TagName("a"))[0];
            NewPostLink.Click();
        }
    }

    public class CreatePostCommand
    {
        private readonly string Title;
        private string Body;

        public CreatePostCommand(string Title)
        {
            this.Title = Title;
        }

        public CreatePostCommand WithBody(string Body)
        {
            this.Body = Body;
            return this;
        }

        public void Publish()
        {
            Driver.Instance.FindElement(By.Id("title")).SendKeys(Title);

            Driver.Instance.SwitchTo().Frame("content_ifr");
            Driver.Instance.SwitchTo().ActiveElement().SendKeys(Body);
            Driver.Instance.SwitchTo().DefaultContent();

            Thread.Sleep(1000);

            Driver.Instance.FindElement(By.Id("publish")).Click();
        }
    }
}
