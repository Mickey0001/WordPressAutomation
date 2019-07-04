using System;
using OpenQA.Selenium;

namespace WordPressAutomationFramework
{
    public class LeftNavigation
    {

        public class Posts
        {
            public class AddNew
            {
                public static void Select()
                {
                    MenuSelector.Select("menu-posts", "Add New");

                    var MenuPosts = Driver.Instance.FindElement(By.Id("menu-posts"));
                    MenuPosts.Click();

                    var AddNew = Driver.Instance.FindElement(By.LinkText("Add New"));
                    AddNew.Click();
                }
            }
        }
        public class Pages
        {
            public class AllPages
            {
                public static void Select()
                {
                    Driver.Instance.FindElement(By.Id("menu-pages")).Click();
                    Driver.Instance.FindElement(By.LinkText("All Pages")).Click();
                }
            }
        }
    }

    internal class MenuSelector
    {
        public static void Select(string TopLevelMenuId, string SubMenuLinkText)
        {
            Driver.Instance.FindElement(By.Id(TopLevelMenuId)).Click();
            Driver.Instance.FindElement(By.LinkText(SubMenuLinkText)).Click();
        }
    }
}
