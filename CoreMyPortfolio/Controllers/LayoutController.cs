using Microsoft.AspNetCore.Mvc;

namespace CoreMyPortfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
