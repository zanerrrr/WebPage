using System.ComponentModel.DataAnnotations;

namespace RecipeBlog.UI.Models
{   
    [Serializable]
    public class SubscribersModel
    {      
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //public static List<Subscribers> listOfSubscribers { get; set; }

        
    }
}
