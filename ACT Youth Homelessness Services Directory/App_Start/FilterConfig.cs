﻿using System.Web;
using System.Web.Mvc;

namespace ACT_Youth_Homelessness_Services_Directory
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
