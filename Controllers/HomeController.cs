using Microsoft.AspNetCore.Mvc;

namespace SuperMarketMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Error()
        {
            return "I have an error";
        }
    }
}
