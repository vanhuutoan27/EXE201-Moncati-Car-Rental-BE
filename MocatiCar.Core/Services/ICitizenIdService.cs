using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;

namespace MocatiCar.Core.Services
{
    public interface ICitizenIdService
    {
        Task<CitizenIdResponse> CreateCitizenIdAsync(CreateCitizenIdRequest request);
        Task<PageResult<CitizenIdResponse>> GetAllCitizenAsync(int page, int limit, long? citizendId,
        bool? verify, string? search);
        Task<CitizenIdResponse> GetcitizenIdAsync(Guid id);
        Task<bool> UpdateCitizenIdAsync(UpdateCitizenIdRequest request, Guid id);
        Task<bool> UpdateVerifyAsync(Guid id);
        Task<bool> DeleteCitizenId(Guid id);
        Task<CitizenIdResponse> GetcitizenIdbyUserAsync(Guid id);
    }
}
