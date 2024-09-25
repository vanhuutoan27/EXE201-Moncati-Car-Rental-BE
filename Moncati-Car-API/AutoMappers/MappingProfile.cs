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
               .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Id))

               .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.UserName))
               .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName))
               .ForMember(dest => dest.Avatar, opt => opt.MapFrom(src => src.Avatar))
               .ForMember(dest => dest.Dob, opt => opt.MapFrom(src => src.Dob))
               .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
              .ForMember(dest => dest.DrivingLicense, opt => opt.MapFrom(src => src.DrivingLicenses != null && src.DrivingLicenses.Verified))
              .ForMember(dest => dest.CitizenId, opt => opt.MapFrom(src => src.CitizenId != null && src.CitizenId.Verified))

               .ForMember(dest => dest.Role, opt => opt.Ignore())
               .ReverseMap();

            CreateMap<Car, CreateUpdateCarRequest>().ReverseMap();
            CreateMap<Car, CarResponeIdandSlug>()
                    .ForMember(dest => dest.Images, opt =>
                    opt.MapFrom(src => src.Images.Select(i => i.Url)
                    .ToList()));
            CreateMap<Review, ReviewRespone>().ReverseMap();
            CreateMap<Review, CreateUpdateReviewRequest>().ReverseMap();
            CreateMap<Brand, BrandResponeGetAll>().ReverseMap();
            CreateMap<Feature, FeatureResponses>().ReverseMap();
            CreateMap<CarType, CreateUpdateCarTypeRequest>().ReverseMap();
            CreateMap<Address, CreateAddressRequest>().ReverseMap();
            CreateMap<Address, AddressRespone>().ReverseMap();
            CreateMap<Address, GetAddressByUsernameRespone>().ReverseMap();
            CreateMap<Rental, CreateRentalRequest>().ReverseMap();
            CreateMap<Car, CarResponse>().ReverseMap();

           // CreateMap<Rental,>


            CreateMap<CitizenId, CitizenIdResponse>().ReverseMap();

            CreateMap<Rental ,CreateRentalRequest>().ReverseMap();
            CreateMap<Car , CarResponse>().ReverseMap();
            CreateMap<FavoriteCar , CreateFavoriteCarRequest>().ReverseMap();
            CreateMap<DrivingLicense, CreateDrivingLicenseRequest>().ReverseMap();
            CreateMap<DrivingLicense, UpdateDrivingLicenseRequest>().ReverseMap();
            CreateMap<DrivingLicense, DrivingLicenseRespone>().ReverseMap();
          CreateMap<CitizenId, CitizenIdResponse>()
    .ForMember(dest => dest.CitizenId, opt => opt.MapFrom(src => src.Citizen_Id))
    .ReverseMap();

        }
    }
}
