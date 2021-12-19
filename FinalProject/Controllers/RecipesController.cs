using Microsoft.AspNetCore.Mvc;
using RecipeBlog.BLL;
using RecipeBlog.UI.Models;

namespace RecipeBlog.Controllers
{
    public class RecipesController : Controller
    {
        public IActionResult Index()
        {
            var listOfModelRecipes = new List<RecipesModel>();
            var recipesDataRepository = new RecipesDataRepository();
            var listOfRecipes = recipesDataRepository.GetRecipes();
            foreach(var recipe in listOfRecipes)
            {
                var recipeModel = new RecipesModel()
                {
                    Id = recipe.Id,
                    Title = recipe.Title,
                    Description = recipe.Description,
                    Ingredients = recipe.Ingredients,
                    Instructions = recipe.Instructions,
                };

                listOfModelRecipes.Add(recipeModel);
            }
            ViewBag.selectedItem = "recipes";
            return View(listOfModelRecipes);
        }
    }
}
