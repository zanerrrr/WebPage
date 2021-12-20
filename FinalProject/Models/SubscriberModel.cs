using System.ComponentModel.DataAnnotations;

namespace RecipeBlog.UI.Models
{   
    
    public class SubscriberModel
    {      
        //[Key]
        //public int Id { get; set; }
        
        [Required(ErrorMessage = "Please enter your Email!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //public static List<Subscribers> listOfSubscribers { get; set; }

        
    }
}
