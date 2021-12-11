using Microsoft.AspNetCore.Mvc;
using RecipeBlog.Models;

namespace RecipeBlog.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Form()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Form(FormModel p)
        {
            return RedirectToAction("Index"); //how to redirect to contact us?
        }
    }
}
