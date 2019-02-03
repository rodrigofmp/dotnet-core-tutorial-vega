using vega.Models.Entities;

namespace vega.Models.ViewModels
{
    public class VehicleViewModel
    {
        public int Id { get; set; }
        
        public int ModelId { get; set; }

        public bool IsRegistered { get; set; } 

        public string ContactName { get; set; }       

        public string ContactPhone { get; set; }

        public string ContactEmail { get; set; }
    }
}