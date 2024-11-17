using Microsoft.AspNetCore.Mvc;

namespace CoreMyPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
