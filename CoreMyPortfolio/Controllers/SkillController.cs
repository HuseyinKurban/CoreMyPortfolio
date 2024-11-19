using CoreMyPortfolio.DAL.Context;
using CoreMyPortfolio.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreMyPortfolio.Controllers
{
    public class SkillController : Controller
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IActionResult SkillList()
        {
            var values=context.Skills.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            context.Skills.Add(skill);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public IActionResult DeleteSkill(int id)
        {
            var values = context.Skills.Find(id);
            context.Skills.Remove(values);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var values=context.Skills.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
           context.Skills.Update(skill);
            context.SaveChanges();
            return RedirectToAction("SkillList");

        }
    }
}
