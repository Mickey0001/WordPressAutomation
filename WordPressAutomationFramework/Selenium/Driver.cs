using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace WordPressAutomationFramework
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }
        public static string BaseAddress
        {
            get { return "http://localhost/test/"; }
        }

        public static void Initialize()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Window.Maximize();
            TurnOnWait();
        }

        public static void Close()
        {
           // Instance.Close();
        }

        public static void Wait(TimeSpan timeSpan)
        {
            Thread.Sleep((int)timeSpan.TotalSeconds * 1000);
        }

        public static void NoWait(Action action)
        {
            TurnOfWait();
            action();
            TurnOnWait();
        }

        private static void TurnOnWait()
        {
            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(25);
        }

        private static void TurnOfWait()
        {
            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(0);
        }
    }
}