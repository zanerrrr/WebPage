using System.ComponentModel.DataAnnotations;

namespace RecipeBlog.UI.Models
{
    public class RecipesModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public string Description { get; set; }
    }
}
