using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using vega.Models.Entities;

namespace vega.Models.Context
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options): base(options)
        {

        }

        public DbSet<Feature> Features { get; set; }
    }
}