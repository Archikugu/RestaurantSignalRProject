﻿using Microsoft.AspNetCore.Mvc;

namespace RestaurantSignalRWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutHeaderPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
