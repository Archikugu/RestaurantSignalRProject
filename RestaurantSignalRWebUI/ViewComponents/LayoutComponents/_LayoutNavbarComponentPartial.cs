﻿using Microsoft.AspNetCore.Mvc;

namespace RestaurantSignalRWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
