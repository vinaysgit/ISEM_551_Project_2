﻿using System.Web;
using System.Web.Mvc;

namespace ISEM_551_Web_Application
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
