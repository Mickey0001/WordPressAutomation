﻿using System;

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
}
