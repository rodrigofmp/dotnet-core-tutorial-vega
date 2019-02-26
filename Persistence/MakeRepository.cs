using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using vega.Core.Repository;
using vega.Models.Entities;

namespace vega.Persistence
{
    public class MakeRepository : IMakeRepository
    {
        private readonly VegaDbContext context;
        
        public MakeRepository(VegaDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Make>> GetAllMakesWithModelsAsync()
        {
            return await context.Makes.Include(m => m.Models).ToListAsync();
        }        
    }
}