using RecipeBlog.BLL.Context;
using RecipeBlog.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBlog.BLL
{
	public class RecipesDataRepository
	{
		private readonly RecipesDBContext _context;

		public RecipesDataRepository(RecipesDBContext context)
		{
			_context = context;
		}

	}
}
