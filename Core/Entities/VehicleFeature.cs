namespace vega.Models.Entities
{
    public class VehicleFeature
    {
        public Vehicle Vehicle { get; set; }

        public int VehicleId { get; set; }

        public Feature Feature { get; set; }

        public int FeatureId { get; set; }
    }
}