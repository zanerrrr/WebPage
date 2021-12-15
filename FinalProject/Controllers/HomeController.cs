using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using FinalProject.Models;
using RecipeBlog.UI.Models;

namespace RecipeBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(SubscribersModel m)
        {
            if (!ModelState.IsValid)
            {
                string name = m.Name;
                string email = m.Email;
            }
                        
            return View();
           
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}