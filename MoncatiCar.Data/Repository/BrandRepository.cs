using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Repository;
using MoncatiCar.Data.SeedWork;

namespace MoncatiCar.Data.Repository
{
    public class BrandRepository : RepositoryBase<Brand, Guid>, IBrandRepository
    {
        public BrandRepository(MocatiContext context) : base(context)
        {

        }

        public async Task<bool> CheckBrandName(string brandName)
        {
            return await _context.Brands.AnyAsync(b => b.BrandName == brandName);
        }

        public async Task<IEnumerable<Brand>> GetAllBrandAsync(int page, int limit)
        {
            if(page > 0 && limit > 0)
            {
                return await _context.Brands.Skip((page - 1) * limit).Take(limit).ToListAsync();
            }
            return await _context.Brands.ToListAsync();
        }

        public async Task<Brand> GetBrandById(Guid id)
        {
            return await _context.Brands.Where(b => b.BrandId == id).FirstOrDefaultAsync();
        }

        public async Task<int> GetTotalBrandCountAsync()
        {
            return await _context.Brands.CountAsync();
        }

        public void UpdateBrand(Guid id, Brand brand)
        {
            _context.Update(brand);
        }

    }
}
