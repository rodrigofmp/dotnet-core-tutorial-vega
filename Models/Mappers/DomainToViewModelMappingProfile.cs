using System.Linq;
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
            CreateMap<Vehicle, VehicleViewModel>()
                .ForMember(vvm => vvm.Contact, opt => opt.MapFrom(v => new ContactViewModel { Name = v.ContactName, Email = v.ContactEmail, Phone = v.ContactPhone }))
                .ForMember(vvm => vvm.Features, opt => opt.MapFrom(v => v.Features.Select(vf => vf.FeatureId)));
        }
    }
}