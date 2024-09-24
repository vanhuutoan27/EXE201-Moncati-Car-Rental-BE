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

        public async Task<DrivingLicense> CheckLisenceNumber(string lisenceNumber, Guid? currentId)
        {
            if (currentId == null)
            {
                return await _context.DrivingLicenses.Where(s => s.LicenseNumber == lisenceNumber).FirstOrDefaultAsync();
            }
            else
            {
                return await _context.DrivingLicenses.Where(s => s.LicenseNumber == lisenceNumber && s.UserId != currentId).FirstOrDefaultAsync();
            }
        }

        public async Task<IEnumerable<DrivingLicense>> GetAlldrvingLicenseAsync(int page, int limit)
        {
            IQueryable<DrivingLicense> query = _context.DrivingLicenses.AsQueryable();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return await query.ToListAsync();
        }

        public async Task<DrivingLicense> GetDrivingLicenseUserId(Guid userId)
        {
            return await _context.DrivingLicenses.Where(u => u.UserId == userId).FirstOrDefaultAsync();
        }
    }
}
