using RecipeBlog.BLL.Context;
using RecipeBlog.BLL.Entities;

namespace RecipeBlog.BLL
{
	public class RecipesDataRepository
	{
		public List<Recipes> GetRecipes() 
		{ 
			using (var context = new RecipesDBContext())
            {
				return context.Recipes.ToList();
            }
		}

	}
}
