using CoreMyPortfolio.DAL.Context;
using CoreMyPortfolio.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CoreMyPortfolio.Controllers
{
    public class ContactsController : Controller
    {
        MyPortfolioContext context=new MyPortfolioContext();

        public IActionResult ContactsList()
        {
            var values=context.Contacts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateContacts(int id)
        {
            var values= context.Contacts.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateContacts(Contact contact)
        {
           
            context.Contacts.Update(contact);
            context.SaveChanges();
            return RedirectToAction("ContactsList");
        }

    }
}
