using CoreMyPortfolio.DAL.Context;
using CoreMyPortfolio.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreMyPortfolio.Controllers
{
    public class FeaturesController : Controller
    {
        MyPortfolioContext context=new MyPortfolioContext();

        public IActionResult FeatureList()
        {
            var values= context.Features.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var values = context.Features.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateFeature(Feature feature)
        {
            context.Features.Update(feature);
            context.SaveChanges();
            return RedirectToAction("FeatureList");
        }
    }
}
