using System.ComponentModel.DataAnnotations;

namespace RecipeBlog.UI.Models
{
    public class RecipesModel
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Ingredients { get; set; }
        public string Description { get; set; }
    }
}
