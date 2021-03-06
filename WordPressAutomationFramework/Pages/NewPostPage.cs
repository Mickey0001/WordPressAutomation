﻿using System;
using System.Threading;
using OpenQA.Selenium;

namespace WordPressAutomationFramework
{
    public class NewPostPage
    {
        public static void GoTo()
        {
            //Maybe make a general menu navigation
            LeftNavigation.Posts.AddNew.Select();

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

        public static bool IsInEditMode()
        {
            return Driver.Instance.FindElement(By.TagName("h1")) != null;
        }

        public static string Title
        {
            get
            {
                var title = Driver.Instance.FindElement(By.Id("title"));
                if (title != null)
                    return title.GetAttribute("value");
                return string.Empty;
            }
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

            Driver.Wait(TimeSpan.FromSeconds(1));

            Driver.Instance.FindElement(By.Id("publish")).Click();
        }
    }
}
