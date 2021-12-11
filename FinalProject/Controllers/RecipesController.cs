using Microsoft.AspNetCore.Mvc;

namespace RecipeBlog.Controllers
{
    public class RecipesController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.selectedItem = "recipes";
            return View();
        }
    }
}
