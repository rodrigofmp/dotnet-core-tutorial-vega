using System.Collections.Generic;
using System.Threading.Tasks;
using vega.Core.Repository;
using vega.Models.Entities;

namespace vega.Core.Repository
{
    public interface IMakeRepository
    {
         Task<List<Make>> GetAllMakesWithModelsAsync();
    }
}