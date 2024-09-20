using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Services
{
    public interface IDrivingLicenseService
    {
        Task<DrivingLicenseRespone> GetDrivingLicenseById(Guid licenseId);
        Task<DrivingLicenseRespone> GetDrivingLicenseUserId(Guid userId);
        Task<CreateDrivingLicenseRequest> AddDrivingLicense(Guid userId, CreateDrivingLicenseRequest drivingLicenseRequest);
        Task<bool> UpdateDrivingLicense(Guid userId, UpdateDrivingLicenseRequest drivingLicenseRequest);
        Task<bool> DeleteDrivingLisence(Guid lisenceId);
    }
}
