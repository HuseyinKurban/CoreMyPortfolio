using CoreMyPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoreMyPortfolio.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.Title=context.Contacts.Select(x=>x.Title).FirstOrDefault();
            ViewBag.Description=context.Contacts.Select(x=>x.Description).FirstOrDefault();

            var values=context.Contacts.ToList();
            return View(values);
        }
    }
}
