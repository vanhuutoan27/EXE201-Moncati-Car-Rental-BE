using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Repository
{
    public interface IFavoriteCarRepository : IRepositoryBase<FavoriteCar,Guid>
    {
      Task<FavoriteCar>GetFavoriteCarById(Guid id);
    //   Task<FavoriteCar>GetFavoriteCarByUser(Guid Id);
    }
}
