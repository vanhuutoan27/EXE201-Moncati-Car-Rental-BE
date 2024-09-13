using AutoMapper;
using Microsoft.AspNetCore.Identity;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks.Enums;

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
               .ForMember(dest => dest.Role, opt => opt.Ignore())
               .ReverseMap();
    
            CreateMap<Payment, PaymentReponse>()
            .ForMember(dest => dest.PaymentStatus, opt => opt.MapFrom(src => ConvertToPaymentStatus(src.PaymentStatus)))
             .ForMember(dest => dest.Rental, opt => opt.MapFrom(src => src.Rental))
             .ForMember(dest => dest.PaymentMethod, opt => opt.MapFrom(src => src.PaymentMethod))
             .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
             .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
             .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
             .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
             .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedBy));

            CreateMap<Rental, RentalResponse>()
                .ForMember(dest => dest.TotalAmount, opt => opt.MapFrom(src => src.TotalAmount))
                .ForMember(dest => dest.CarId, opt => opt.MapFrom(src => src.CarId))
                .ForMember(dest => dest.CarTypeId, opt => opt.MapFrom(src => src.CarId))
                .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId));




            ///----
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
            CreateMap<Rental ,CreateRentalRequest>().ReverseMap();
            CreateMap<Car , CarResponse>().ReverseMap();
        }
        public static PaymentStatus ConvertToPaymentStatus(string paymentStatus)
        {
            return Enum.TryParse<PaymentStatus>(paymentStatus, true, out var status) ? status : PaymentStatus.Deleted;
        }


    }
}
