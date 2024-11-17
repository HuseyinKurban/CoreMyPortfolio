using CoreMyPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoreMyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.Image=portfolioContext.Features.Select(x=>x.ImageUrl).FirstOrDefault();
            var values=portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
