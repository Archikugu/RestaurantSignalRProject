using Microsoft.AspNetCore.Mvc;

namespace RestaurantSignalRWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
