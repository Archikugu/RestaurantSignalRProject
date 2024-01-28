using Microsoft.AspNetCore.Mvc;

namespace RestaurantSignalRWebUI.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
