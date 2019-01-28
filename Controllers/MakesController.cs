using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using vega.Models.Entities;
using vega.Models.Context;
using vega.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace vega.Controllers
{
    public class MakesController : Controller
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper;        

        public MakesController(VegaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("api/makes")]
        public IEnumerable<MakeViewModel> GetMakes()
        {
            var result = new List<MakeViewModel>();

            var makes = _context.Makes.Include(m => m.Models);
            foreach (var make in makes)
            {
                var makeView = _mapper.Map<Make, MakeViewModel>(make);
                result.Add(makeView);
            }

            return result;
        }
    }
}