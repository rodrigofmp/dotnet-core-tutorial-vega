using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using vega.Core.Repository;
using vega.Models.Entities;

namespace vega.Persistence
{
    public class FeatureRepository : IFeatureRepository
    {
        private readonly VegaDbContext context;
        
        public FeatureRepository(VegaDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Feature>> GetAllFeaturesAsync()
        {
            return await context.Features.ToListAsync();
        }
    }
}