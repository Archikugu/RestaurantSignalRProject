using Microsoft.AspNetCore.Mvc;

namespace RestaurantSignalRWebUI.Controllers
{
    public class ProgressBarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
