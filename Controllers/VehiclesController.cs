using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using vega.Models.Context;
using vega.Models.Entities;
using vega.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace vega.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper;

        public VehiclesController(VegaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("api/vehicles")]
        public IEnumerable<VehicleViewModel> GetVehicles()
        {
            var result = new List<VehicleViewModel>();

            var vehicles = _context.Vehicles.Include(m => m.Model);
            foreach (var vehicle in vehicles)
            {
                var vehicleView = _mapper.Map<Vehicle, VehicleViewModel>(vehicle);
                result.Add(vehicleView);
            }

            return result;
        }

        [HttpPost("api/vehicles/create")]
        public IActionResult Create([FromBody] VehicleViewModel form)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return BadRequest(Json(allErrors));
            }

            var model = _mapper.Map<VehicleViewModel, Vehicle>(form);
            model.LastUpdate = DateTime.Now;

            _context.Vehicles.Add(model);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPost("api/vehicles/update")]
        public IActionResult Update([FromBody] VehicleViewModel form)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return BadRequest(Json(allErrors));
            }

            var model = _context.Vehicles.Where(v => v.Id == form.Id).SingleOrDefault();
            if (model != null)
            {
                _mapper.Map<VehicleViewModel, Vehicle>(form, model);
                model.LastUpdate = DateTime.Now;
                _context.Vehicles.Update(model);
                _context.SaveChanges();
                return Ok();
            }
            else {
                return NotFound();
            }
        }

        [HttpPost("api/vehicles/delete")]
        public IActionResult Delete([FromBody] VehicleViewModel form)
        {
            var model = _context.Vehicles.Where(v => v.Id == form.Id).SingleOrDefault();
            if (model != null)
            {
                _context.Vehicles.Remove(model);
                _context.SaveChanges();
                return Ok();
            }
            else {
                return NotFound();
            }
        }
    }
}