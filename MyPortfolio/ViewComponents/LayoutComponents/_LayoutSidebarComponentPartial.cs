﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutComponents
{
    public class _LayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
