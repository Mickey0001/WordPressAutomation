using OpenQA.Selenium;

namespace WordPressAutomationFramework
{
    internal class MenuSelector
    {
        public static void Select(string TopLevelMenuId, string SubMenuLinkText)
        {
            Driver.Instance.FindElement(By.Id(TopLevelMenuId)).Click();
            Driver.Instance.FindElement(By.LinkText(SubMenuLinkText)).Click();
        }
    }
}
