﻿using OpenQA.Selenium;

namespace WordPressAutomationFramework
{
    public class DashboardPage
    {
        public static bool IsAt
        {
            get
            {
                //Create generalize IsAt for all pages
                var h1s = Driver.Instance.FindElements(By.TagName("h1"));
                if (h1s.Count > 0)
                    return h1s[0].Text == "Dashboard";
                return false;
            }
        }
    }
}
