using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Repository;
using MoncatiCar.Data.SeedWork;

namespace MoncatiCar.Data.Repository
{

    public class FavoriteCarRepository : RepositoryBase<FavoriteCar, Guid>, IFavoriteCarRepository
    {
        public FavoriteCarRepository(MocatiContext context) : base(context)
        {

        }

        public async Task<FavoriteCar> GetFavoriteCarById(Guid id)
        {
            var query = await _context.FavoriteCars.FirstOrDefaultAsync(f => f.FavoriteCarId == id);
            return query;
        }
        public async Task<(IEnumerable<FavoriteCar> FavoriteCarsCars, int TotalItems)> GetFavoriteCarByUserAsync(int page, int limit, Guid userId)
        {
            // Thực hiện truy vấn lấy danh sách FavoriteCar từ cơ sở dữ liệu và bao gồm các bảng liên quan
            var favoriteCarsQuery = _context.FavoriteCars
                .Where(f => f.UserId == userId && f.Car.Status == true)
                .Include(u => u.User)
                .Include(f => f.Car)
                // Include Car
                .ThenInclude(c => c.Model) // Include Model in Car
                .ThenInclude(m => m.Brand) // Include Brand in Model
                .Include(f => f.Car.Images) // Include Images in Car
                .Skip((page - 1) * limit)
                .Take(limit);

            var favoriteCars = await favoriteCarsQuery.ToListAsync();
            var totalItems = await _context.FavoriteCars.CountAsync(f => f.UserId == userId);

            return (favoriteCars, totalItems);
        }

        public async Task<bool> IsCarAlreadyFavorited(Guid userId, Guid carId)
        {
            return await _context.FavoriteCars
         .AnyAsync(f => f.UserId == userId && f.CarId == carId);
        }


    }
}
