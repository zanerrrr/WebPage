using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBlog.BLL.Entities
{
	public class Recipes
	{
		[Key]
		public int Id { get; set; }
		public string Title { get; set; }
		public string Ingredients { get; set; }
		public string Description { get; set; }

	}
}
