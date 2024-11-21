using CoreMyPortfolio.DAL.Context;
using CoreMyPortfolio.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreMyPortfolio.Controllers
{
    public class UserMessageController : Controller
    {
        MyPortfolioContext context=new MyPortfolioContext();
        [HttpGet]
        public IActionResult AddMessage()
        {
            return RedirectToAction("Index", "Default");
        }
        [HttpPost]
        public IActionResult AddMessage(Message message)
        {
            message.SendDate = DateTime.Now;
            message.IsRead = false;

            context.Messages.Add(message);
            context.SaveChanges();

            return RedirectToAction("Index", "Default");

        }
    }
}
