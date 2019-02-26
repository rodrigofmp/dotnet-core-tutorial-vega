using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using vega.Models.Entities;
using vega.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using vega.Core.Repository;

namespace vega.Controllers
{
    [Route("api/vehicles")]
    public class VehiclesController : Controller
    {
        private readonly IVehicleRepository _repository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public VehiclesController(IMapper mapper, IVehicleRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> CreateVehicle([FromBody] SaveVehicleViewModel form)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var model = _mapper.Map<SaveVehicleViewModel, Vehicle>(form);
            model.LastUpdate = DateTime.Now;

            _repository.Add(model);
            await _unitOfWork.CompleteAsync();           

            var vehicle = await _repository.GetVehicle(model.Id);

            var result = _mapper.Map<Vehicle, VehicleViewModel>(vehicle);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVehicle(int id, [FromBody] SaveVehicleViewModel form)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var model = await _repository.GetVehicle(id);

            if (model == null)
                return NotFound();

            _mapper.Map<SaveVehicleViewModel, Vehicle>(form, model);
            model.LastUpdate = DateTime.Now;

            await _unitOfWork.CompleteAsync();

            var vehicle = await _repository.GetVehicle(model.Id);

            var result = _mapper.Map<Vehicle, VehicleViewModel>(vehicle);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var vehicle = await _repository.GetVehicle(id, includeRelated: false);

            if (vehicle == null)
                return NotFound();

            _repository.Remove(vehicle);
            await _unitOfWork.CompleteAsync();

            return Ok(id);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicle(int id)
        {
            var vehicle = await _repository.GetVehicle(id);

            if (vehicle == null)
                return NotFound();

            var vehicleResource = _mapper.Map<Vehicle, VehicleViewModel>(vehicle);

            return Ok(vehicleResource);
        }
    }
}