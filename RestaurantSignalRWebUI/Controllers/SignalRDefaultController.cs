using Microsoft.AspNetCore.Mvc;

namespace RestaurantSignalRWebUI.Controllers
{
    public class SignalRDefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //Set İnterval Methodu kullandık sayfa yenilemeden refresh atıyor
        public IActionResult Index2()
        {
            return View();
        }
    }
}
