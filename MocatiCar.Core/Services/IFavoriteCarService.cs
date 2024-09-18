using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;

namespace MocatiCar.Core.Services
{
    public interface IFavoriteCarService
    {
        public Task<CreateFavoriteCarRequest> AddFavoriteCarAsync(CreateFavoriteCarRequest request);
        public Task<bool> UpdateFavoriteCarAsync(UpdateFavoriteCarRequest request, Guid id);
        public Task<bool> RemoveFavoriteCarAsync(Guid id);
        Task<PageResult<FavoriteCarRespone>> GetAllCarByUser(int page, int limit, Guid userId);
        Task<bool> IsCarAlreadyFavorited(Guid userId, Guid carId);
        Task<bool> IsOwnerOfCar(Guid userId, Guid carId);
    }
}
