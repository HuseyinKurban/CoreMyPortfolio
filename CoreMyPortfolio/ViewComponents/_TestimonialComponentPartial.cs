using CoreMyPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoreMyPortfolio.ViewComponents
{
    public class _TestimonialComponentPartial:ViewComponent
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=context.Testimonials.ToList();
                return View(values);
        }
    }
}
