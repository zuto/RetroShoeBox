using System.ComponentModel.DataAnnotations;

namespace RetroShoeBox.Models
{
    public class UserDetails
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public bool IsLoggedIn { get; set; }
    }
}