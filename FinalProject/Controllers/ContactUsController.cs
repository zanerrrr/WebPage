using Microsoft.AspNetCore.Mvc;

namespace RecipeBlog.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
