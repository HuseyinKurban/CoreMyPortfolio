﻿using Microsoft.AspNetCore.Mvc;

namespace CoreMyPortfolio.ViewComponents
{
    public class _NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
