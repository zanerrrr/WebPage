using Microsoft.EntityFrameworkCore;
using RecipeBlog.BLL.Entities;

namespace RecipeBlog.BLL.Context
{
	public class RecipesDBContext : DbContext
	{
		public DbSet<Recipes> Recipes { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-S62MUI2\SQLEXPRESS; Database=SubscribersDB; Trusted_Connection = true;");
	}
}
