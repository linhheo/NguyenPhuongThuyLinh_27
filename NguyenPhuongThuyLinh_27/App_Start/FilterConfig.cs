﻿using System.Web;
using System.Web.Mvc;

namespace NguyenPhuongThuyLinh_27
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
