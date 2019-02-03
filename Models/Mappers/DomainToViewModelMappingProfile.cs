using AutoMapper;
using vega.Models.Entities;
using vega.Models.ViewModels;

namespace vega.Models.Mappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Feature, FeatureViewModel>();
            CreateMap<Make, MakeViewModel>();
            CreateMap<Model, ModelViewModel>();
            CreateMap<Vehicle, VehicleViewModel>();
        }
    }
}