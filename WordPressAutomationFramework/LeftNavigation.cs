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
}
