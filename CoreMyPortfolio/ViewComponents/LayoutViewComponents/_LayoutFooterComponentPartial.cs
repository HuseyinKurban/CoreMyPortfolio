using Microsoft.AspNetCore.Mvc;

namespace CoreMyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutFooterComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
