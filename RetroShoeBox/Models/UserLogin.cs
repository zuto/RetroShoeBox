using System.ComponentModel.DataAnnotations;

namespace RetroShoeBox.Models
{
    public class UserLogin
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public bool IsLoggedIn { get; set; }
    }
}
