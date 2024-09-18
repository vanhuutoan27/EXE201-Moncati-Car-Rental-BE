using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.SeedWorks;

namespace MocatiCar.Core.Repository
{
    public interface IFavoriteCarRepository : IRepositoryBase<FavoriteCar, Guid>
    {
        Task<FavoriteCar> GetFavoriteCarById(Guid id);
        Task<(IEnumerable<FavoriteCar> FavoriteCarsCars, int TotalItems)> GetFavoriteCarByUserAsync(int page, int limit, Guid id);
        Task<bool> IsCarAlreadyFavorited(Guid userId, Guid carId);
    }
}
