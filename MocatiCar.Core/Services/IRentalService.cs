using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Services
{
    public interface IRentalService
    {
        Task<PageResult<RentalRespone>> GetAllRentalsAsync(int page, int limit, RentalStatus? filter , DateTime? createAt);
        Task<RentalRespone> GetRentalById (Guid id);
        Task<CreateRentalRequest> CreateRental(CreateRentalRequest rentalRequest);
        Task<IEnumerable<RentalRespone>> GetRentalByCarId(Guid id);
        Task<IEnumerable<RentalRespone>> GetRentalByUserId(Guid id);
        Task<bool> DeleteRental(Guid id);
        Task<bool> UpdateRentalAsync(Guid id , UpdateRentalRequest update);
        Task<bool> UpdateStartTimeRentalAsync(Guid id);
        Task<bool> UpdateEndTimeRentalAsync(Guid id);
        Task<bool> ChangeRentalStatusAsync(Guid id);
        Task<bool> ChangeRentalStatusToCancelAsync(Guid id);
    }
}
