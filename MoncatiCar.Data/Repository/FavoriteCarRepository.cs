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
    }
}
