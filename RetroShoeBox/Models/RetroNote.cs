using System.ComponentModel.DataAnnotations;

namespace RetroShoeBox.Models
{
    public class RetroNote
    {
        [Required]
        public string Note { get; set; }
        [Required]
        public string Owner { get; set; }
    }
}