using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.SeedWorks.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Repository
{
    public interface IRentalRepository : IRepositoryBase<Rental , Guid>
    {
        Task<IEnumerable<Rental>> GetAllRentalAsync(int page , int limit ,RentalStatus? filter );
        Task<Rental> GetRentalByIdAsync(Guid id);
        Task<IEnumerable<Rental>> GetRentalByCarId(Guid id);
        Task<IEnumerable<Rental>> GetRentalByUserId(Guid id);
    }
}
