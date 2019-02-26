using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using vega.Models.Entities;
using vega.Models.ViewModels;
using vega.Core.Repository;
using System.Threading.Tasks;

namespace vega.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly IFeatureRepository _repository;
        private readonly IMapper _mapper;

        public FeaturesController(IMapper mapper, IFeatureRepository repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("api/features")]
        public async Task<IEnumerable<FeatureViewModel>> GetFeaturesAsync()
        {
            var result = new List<FeatureViewModel>();

            var features = await _repository.GetAllFeaturesAsync();
            foreach (var feature in features)
            {
                var featureView = _mapper.Map<Feature, FeatureViewModel>(feature);
                result.Add(featureView);
            }

            return result;
        }
    }
}