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
    public class DrivingLicenseRepository : RepositoryBase<DrivingLicense, Guid>, IDrivingLicenseRepository
    {
        public DrivingLicenseRepository(MocatiContext context) : base(context)
        {
        }

        public async Task<DrivingLicense> CheckLisenceNumber(string lisenceNumber)
        {
            return await _context.DrivingLicenses.Where(s => s.LicenseNumber == lisenceNumber).FirstOrDefaultAsync();
        }

        public async Task<DrivingLicense> GetDrivingLicenseUserId(Guid userId)
        {
            return await _context.DrivingLicenses.Where(u => u.UserId == userId).FirstOrDefaultAsync();
        }
    }
}
