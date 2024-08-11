using AutoMapper;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;

namespace Moncati_Car_API.AutoMappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CarType, CarTypeResponse>().ReverseMap();
            CreateMap<Model, CreateUpdateModelRequest>().ReverseMap();
            CreateMap<Model, ModelRespone>().ReverseMap();
            CreateMap<Brand, CreateUpdateBrandRequest>().ReverseMap();
            CreateMap<Brand, BrandRespone>().ReverseMap();
            CreateMap<Car , CreateUpdateCarRequest>().ReverseMap();
            CreateMap<Car , CarResponeIdandSlug>()
                .ForMember(dest => dest.Images , opt => 
                opt.MapFrom(src => src.Images.Select(i => i.Url)
                .ToList()));
                
        }
    }
}
