using Microsoft.AspNetCore.Mvc;

namespace RestaurantSignalRWebUI.ViewComponents.MenuComponents
{
	public class _MenuNavbarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
