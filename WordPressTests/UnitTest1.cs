﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordPressAutomationFramework;

namespace WordPressTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new AutomationTest();
            c.Go();
        }
    }
}