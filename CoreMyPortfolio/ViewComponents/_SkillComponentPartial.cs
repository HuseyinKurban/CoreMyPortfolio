using CoreMyPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoreMyPortfolio.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
         MyPortfolioContext portfolioContext=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=portfolioContext.Skills.ToList();
              return View(values);
        }
    }
}
