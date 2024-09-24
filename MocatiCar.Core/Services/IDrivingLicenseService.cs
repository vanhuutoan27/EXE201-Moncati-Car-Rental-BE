using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;

namespace MocatiCar.Core.Services
{
    public interface IDrivingLicenseService
    {
        Task<DrivingLicenseRespone> GetDrivingLicenseById(Guid licenseId);
        Task<DrivingLicenseRespone> GetDrivingLicenseUserId(Guid userId);
        Task<PageResult<DrivingLicenseRespone>>GetAllCitizenAsync(int page, int limit , string search);
        Task<CreateDrivingLicenseRequest> AddDrivingLicense(CreateDrivingLicenseRequest drivingLicenseRequest);
        Task<bool> UpdateDrivingLicense(Guid userId, UpdateDrivingLicenseRequest drivingLicenseRequest);
        Task<bool> DeleteDrivingLisence(Guid lisenceId);
        Task<bool> VeryfyDrivingLisence(Guid lisenceId);
    }
}
