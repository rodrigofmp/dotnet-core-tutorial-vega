using System.Threading.Tasks;
using vega.Models.Entities;

namespace vega.Core.Repository
{
    public interface IVehicleRepository
    {
        Task<Vehicle> GetVehicle(int id, bool includeRelated = true);
        void Add(Vehicle vehicle);
        void Remove(Vehicle vehicle);
    }
}