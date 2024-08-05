using AutoMapper;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Responses;

namespace Moncati_Car_API.AutoMappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CarType, CarTypeResponse>().ReverseMap();
        }
    }
}
