using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using vega.Models.Entities;

namespace vega.Models.ViewModels
{
    public class SaveVehicleViewModel
    {
        public int Id { get; set; }
        
        [Required]
        public int ModelId { get; set; }

        [Required]
        public string IsRegistered { get; set; } 

        public ContactViewModel Contact { get; set; } 

        public ICollection<int> Features { get; set; }

        public SaveVehicleViewModel()
        {
            Features = new Collection<int>();
        }        
    }
}