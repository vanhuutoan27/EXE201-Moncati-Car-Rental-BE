using MocatiCar.Core.Models.content.Responses;

namespace MocatiCar.Core.Services
{
    public interface ICarTypeService
    {
        Task<IEnumerable<CarTypeResponse>> GetAllCarTypeAsync();
    }
}
