using CoreMyPortfolio.DAL.Context;
using CoreMyPortfolio.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreMyPortfolio.Controllers
{
    public class AboutController : Controller
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IActionResult AboutList()
        {
            var values=context.Abouts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = context.Abouts.Find(id);
            return View(values);
        }

        [HttpPost]
		public IActionResult UpdateAbout(About about)
        {
            context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }

	}
}
