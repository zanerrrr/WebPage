using Microsoft.AspNetCore.Mvc;

namespace RecipeBlog.Controllers
{
    public class RecipesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
