using Microsoft.EntityFrameworkCore;
using RecipeBlog.BLL.Entities;

namespace RecipeBlog.BLL.Context
{
	public class RecipesDBContext : DbContext
	{
		public DbSet<Recipes> Recipes { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
			optionsBuilder.UseSqlServer(@"Server=LAPTOP-9KVL4IOV\SQLEXPRESS01; Database=RecipesDB; Trusted_Connection = true;");
	}
}
