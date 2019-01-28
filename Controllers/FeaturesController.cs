using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using vega.Models.Entities;
using vega.Models.Context;
using vega.Models.ViewModels;

namespace vega.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper;

        public FeaturesController(VegaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("api/features")]
        public IEnumerable<FeatureViewModel> GetFeatures()
        {
            var result = new List<FeatureViewModel>();

            var features = _context.Features.ToList();
            foreach (var feature in features)
            {
                var featureView = _mapper.Map<Feature, FeatureViewModel>(feature);
                result.Add(featureView);
            }

            return result;
        }
    }
}