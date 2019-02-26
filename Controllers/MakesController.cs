using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using vega.Models.Entities;
using vega.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using vega.Core.Repository;
using System.Threading.Tasks;

namespace vega.Controllers
{
    public class MakesController : Controller
    {
        private readonly IMakeRepository _repository;
        private readonly IMapper _mapper;        

        public MakesController(IMapper mapper, IMakeRepository repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("api/makes")]
        public async Task<IEnumerable<MakeViewModel>> GetMakesAsync()
        {
            var result = new List<MakeViewModel>();

            var makes = await _repository.GetAllMakesWithModelsAsync();
            foreach (var make in makes)
            {
                var makeView = _mapper.Map<Make, MakeViewModel>(make);
                result.Add(makeView);
            }

            return result;
        }
    }
}