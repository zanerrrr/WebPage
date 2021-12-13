using System.ComponentModel.DataAnnotations;

namespace RecipeBlog.UI.Models
{
    public class SubscribersModel
    {
        [Serializable]
        public class Subscribers
        {
            [Key]
            public int Id { get; set; }

            public string Name { get; set; }

            [Required]
            public string Email { get; set; }

            public static List<Subscribers> ListOfSubscribers { get; set; }

        }
    }
}
