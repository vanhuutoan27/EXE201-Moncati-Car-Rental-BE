using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Repository
{
    public interface IDrivingLicenseRepository : IRepositoryBase<DrivingLicense, Guid>
    {
        Task<DrivingLicense> GetDrivingLicenseUserId(Guid userId);
        Task<DrivingLicense> CheckLisenceNumber(string lisenceNumber, Guid? currentId);
        Task<IEnumerable<DrivingLicense>> GetAlldrvingLicenseAsync(int page, int limit, string search);
    }
}
