using Microsoft.AspNetCore.Mvc;

namespace RestaurantSignalRWebUI.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
