using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace vega.Models.Entities
{
    public class Vehicle : BaseEntity
    {
        public Model Model { get; set; }

        public int ModelId { get; set; }

        [Required]
        public bool IsRegistered { get; set; } 

        [Required]
        [StringLength(60)]        
        public string ContactName { get; set; }       

        [Required]
        [StringLength(20)]        
        public string ContactPhone { get; set; }

        [Required]
        [StringLength(60)]        
        public string ContactEmail { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }

        public ICollection<VehicleFeature> Features { get; set; }

        public Vehicle()
        {
            Features = new Collection<VehicleFeature>();
        }        
    }
}