using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Repository;
using MoncatiCar.Data.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoncatiCar.Data.Repository
{
    public class FavoriteCarRepository : RepositoryBase<FavoriteCar , Guid>,IFavoriteCarRepository
    {
        public FavoriteCarRepository(MocatiContext context) : base(context) 
        {
        
        }

        public async Task<FavoriteCar> GetFavoriteCarById(Guid id)
        {
            var query = await _context.FavoriteCars.FirstOrDefaultAsync(f => f.FavoriteCarId == id);
            return query;
        }

        // public async Task<FavoriteCar> GetFavoriteCarByUser(Guid Id)
        // {
        //    var userId = await _context.FavoriteCars.Where(f => f.UserId == id).FirstOrDefaultAsync();
        // }
    }
}
