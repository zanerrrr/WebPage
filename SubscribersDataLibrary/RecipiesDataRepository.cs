using RecipeBlog.BLL.Context;
using RecipeBlog.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBlog.BLL
{
	public class RecipiesDataRepository
	{
		private readonly RecipiesDBContext _context;

		public RecipiesDataRepository(RecipiesDBContext context)
		{
			_context = context;
		}

	}
}
