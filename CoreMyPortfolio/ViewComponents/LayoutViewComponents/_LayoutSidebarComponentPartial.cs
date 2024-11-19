using CoreMyPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoreMyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutSidebarComponentPartial:ViewComponent
	{
		MyPortfolioContext context=new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.Img=context.Features.Select(x=>x.ImageUrl).FirstOrDefault();
			return View();
		}
	}
}
