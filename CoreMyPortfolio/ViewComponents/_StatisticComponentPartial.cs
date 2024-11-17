﻿using CoreMyPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace CoreMyPortfolio.ViewComponents
{
    public class _StatisticComponentPartial:ViewComponent
    {
        MyPortfolioContext context=new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.SkillCount = context.Skills.Count();
            ViewBag.ExperienceCount = context.Experiences.Count();
            ViewBag.PortfolioCount = context.Portfolios.Count();
            ViewBag.skillValueAvg = context.Skills.Sum(x => x.Value);

            return View();
        }
    }
}