using CoreMyPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoreMyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
		{
            ViewBag.Img = context.Features.Select(x => x.ImageUrl).FirstOrDefault();
            ViewBag.Email=context.Contacts.Select(x=>x.Email1).FirstOrDefault();
            ViewBag.ToDoListCount=context.ToDoLists.Where(x => x.Status == false).Count();

            var values=context.ToDoLists.Where(x=>x.Status==false).ToList();
            return View(values);
		}
	}
}
