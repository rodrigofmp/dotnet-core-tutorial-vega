using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vega.Models.Entities;
using vega.Models.Context;

namespace vega.Controllers
{
    public class FeaturesController : Controller
    {
        private VegaDbContext _context;

        public FeaturesController(VegaDbContext context)
        {
            _context = context;
        }

        [HttpGet("api/features")]
        public IEnumerable<Feature> GetFeatures() {
            return _context.Features.ToList();
        }        
    }
}