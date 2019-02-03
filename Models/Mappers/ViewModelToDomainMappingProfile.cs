using AutoMapper;
using vega.Models.Entities;
using vega.Models.ViewModels;

namespace vega.Models.Mappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<VehicleViewModel, Vehicle>();
        }        
    }
}