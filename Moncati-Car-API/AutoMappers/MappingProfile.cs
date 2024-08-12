using AutoMapper;
using Microsoft.AspNetCore.Identity;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;

namespace Moncati_Car_API.AutoMappers
{
    public class MappingProfile : Profile
    {
        private readonly UserManager<AppUser> _userManager;

        public MappingProfile()
        {
            CreateMap<CarType, CarTypeResponse>().ReverseMap();
            CreateMap<Model, CreateUpdateModelRequest>().ReverseMap();
            CreateMap<Model, ModelRespone>().ReverseMap();
            CreateMap<Brand, CreateUpdateBrandRequest>().ReverseMap();
            CreateMap<Brand, BrandRespone>().ReverseMap();
            CreateMap<AppUser, UserReponse>()
               .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
               .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
               .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName))
               .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
               .ForMember(dest => dest.Avatar, opt => opt.MapFrom(src => src.Avatar))
               .ForMember(dest => dest.Dob, opt => opt.MapFrom(src => src.Dob))
               .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
               .ReverseMap();

        }
    }
}
