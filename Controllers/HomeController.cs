using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/Index
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Home/Contact
        [HttpPost]
        public IActionResult Contact(string name, string email, string message)
        {
            // For now, simply send a thank you message.
            ViewBag.Message = "Thank you for contacting us, " + name + "!";
            return View("Index");
        }
    }
}