using System.ComponentModel.DataAnnotations;

namespace vega.Models.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        public string Name { get; set; }       

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }        
    }
}