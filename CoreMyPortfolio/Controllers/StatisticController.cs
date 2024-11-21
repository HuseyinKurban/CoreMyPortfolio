using CoreMyPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoreMyPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context=new MyPortfolioContext();

        public IActionResult StatisticIndex()
        {
            ViewBag.YetenekSayisi = context.Skills.Count();
            ViewBag.MessajSayisi = context.Messages.Count();
            ViewBag.OkunmayanMesajSayisi=context.Messages.Where(x=>x.IsRead==false).Count();
            ViewBag.OkunanMesajSayisi=context.Messages.Where(x=>x.IsRead==true).Count();
            ViewBag.YetenekOrtalamasi = context.Skills.Average(x => x.Value);
            ViewBag.DeneyimSayisi = context.Experiences.Count();
            ViewBag.ProjeSayisi = context.Portfolios.Count();
            ViewBag.EnYuksekYetenek = (from s in context.Skills
                                       orderby s.Value descending
                                       select s.Title).FirstOrDefault();
            ViewBag.EnDusukYetenek = (from s in context.Skills
                                       orderby s.Value ascending
                                       select s.Title).FirstOrDefault();
            return View();
        }
    }
}
