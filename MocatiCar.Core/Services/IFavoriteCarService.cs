using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;

namespace MocatiCar.Core.Services
{
    public interface IFavoriteCarService
    {
        public Task<CreateFavoriteCarRequest>AddFavoriteCarAsync(CreateFavoriteCarRequest request);
        public Task<bool> UpdateFavoriteCarAsync(UpdateFavoriteCarRequest request , Guid id);
        public Task<bool> RemoveFavoriteCarAsync(Guid id);
    }
}
