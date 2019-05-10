using OpenQA.Selenium;

namespace WordPressAutomationFramework
{
    public class PostPage
    {
        public static string Title
        {
            get
            {
                var Title = Driver.Instance.FindElement(By.ClassName("entry-title"));
                if (Title != null)
                    return Title.Text;
                return string.Empty;
            }
        }
    }
}
