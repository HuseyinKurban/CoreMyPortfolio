using CoreMyPortfolio.DAL.Context;
using CoreMyPortfolio.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreMyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            //ekleme işlemini yap , veritabanına kaydet, beni listeye geri yönlendir.
            context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            //gelen idyi bul, idyi sil, değişiklikleri kaydet, beni listeye geri yönlendir.
            var value = context.Experiences.Find(id);
            context.Experiences.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value=context.Experiences.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            context.Experiences.Update(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }    
    }
}
