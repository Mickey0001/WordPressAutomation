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
                }
            }
        }
        public class Pages
        {
            public class AllPages
            {
                public static void Select()
                {
                    MenuSelector.Select("menu-page", "All Pages");
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
