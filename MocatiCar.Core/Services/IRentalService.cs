using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks.Enums;

namespace MocatiCar.Core.Services
{
    public interface IRentalService
    {
        Task<PageResult<RentalRespone>> GetAllRentalsAsync(int page, int limit, RentalStatus? filter, DateTime? startDate, DateTime? endDate);
        Task<RentalRespone> GetRentalById(Guid id);
        Task<CreateRentalRequest> CreateRental(CreateRentalRequest rentalRequest);
        Task<PageResult<RentalResponseForGetById>> GetRentalByCarId(Guid id, int page, int limit, RentalStatus? filter, DateTime? startDate, DateTime? endDate);
        Task<PageResult<RentalResponseForGetById>> GetRentalByUserId(Guid id, int page, int limit, RentalStatus? filter, DateTime? startDate, DateTime? endDate);
        Task<bool> DeleteRental(Guid id);
        Task<bool> UpdateRentalAsync(Guid id, UpdateRentalRequest update);
        Task<bool> UpdateStartTimeRentalAsync(Guid id);
        Task<bool> UpdateEndTimeRentalAsync(Guid id);
        Task<bool> ChangeRentalStatusAsync(Guid id);
        Task<bool> ChangeRentalStatusToCancelAsync(Guid id);

        //Task<PageResult<RentalResponseForGetById>> getRentalByOwnerId(Guid id, int page, int limit, RentalStatus? filter, DateTime? startDate, DateTime? endDate);
    }
}
