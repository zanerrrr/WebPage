using System.ComponentModel.DataAnnotations;

namespace RecipeBlog.Models
{
    [Serializable]
    public class FormModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
