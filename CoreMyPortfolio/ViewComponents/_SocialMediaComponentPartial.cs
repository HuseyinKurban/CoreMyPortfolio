using CoreMyPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoreMyPortfolio.ViewComponents
{
    public class _SocialMediaComponentPartial:ViewComponent
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=context.SocialMedias.ToList();
            return View(values);
        }
    }
}
