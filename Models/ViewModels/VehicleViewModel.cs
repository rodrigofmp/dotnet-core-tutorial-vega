using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace vega.Models.ViewModels
{
    public class VehicleViewModel
    {
        public int Id { get; set; }
        
        public ModelViewModel Model { get; set; }
        
        public MakeVehicleViewModel Make { get; set; }

        public string IsRegistered { get; set; } 

        public ContactViewModel Contact { get; set; }

        public DateTime LastUpdate { get; set; } 

        public ICollection<FeatureViewModel> Features { get; set; }

        public VehicleViewModel()
        {
            Features = new Collection<FeatureViewModel>();
        }          
    }
}