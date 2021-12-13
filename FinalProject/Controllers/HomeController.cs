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
        public IActionResult ModifyViewData(string name, string email)
        {
            return RedirectToAction("Index");
        }

        public IActionResult AddSubscribers(SubscribersModel model)
        {
            if (ModelState.IsValid)
            {
                //SubscribersModel subscribersModel = new SubscribersModel
                //{
                //    Name = model.Name,
                //    Email = model.Email,
                //    ListOfSubscribers = model.ListOfSubscribers
                //};

                //subscribersModel.SaveSubscribers(subscribersModel);
                //return RedirectToAction("Index");
            }
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}