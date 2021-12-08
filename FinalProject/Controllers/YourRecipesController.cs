using Microsoft.AspNetCore.Mvc;

namespace RecipeBlog.Controllers
{
    public class YourRecipesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
