using System.Collections.Generic;
using System.Threading.Tasks;
using vega.Core.Repository;
using vega.Models.Entities;

namespace vega.Core.Repository
{
    public interface IFeatureRepository
    {
         Task<List<Feature>> GetAllFeaturesAsync();
    }
}