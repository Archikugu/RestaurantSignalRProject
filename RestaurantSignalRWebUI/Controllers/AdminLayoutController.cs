using Microsoft.AspNetCore.Mvc;

namespace RestaurantSignalRWebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
