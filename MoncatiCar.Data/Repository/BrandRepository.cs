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

        public async Task<IEnumerable<Brand>> GetAllBrandAsync(int page, int limit, string searchName)
        {
            searchName = searchName?.Trim();
            if (string.IsNullOrEmpty(searchName))
            {
                if (page > 0 && limit > 0)
                {
                    return await _context.Brands.Skip((page - 1) * limit).Take(limit).ToListAsync();
                }
                return await _context.Brands.ToListAsync();
            }
            else
            {
                return await _context.Brands
                    .Where(s => s.BrandName.ToLower().Contains(searchName.ToLower()))
                    .Skip((page - 1) * limit).Take(limit).ToListAsync();
            }
        }

        public async Task<Brand> GetBrandById(Guid id)
        {
            return await _context.Brands.Where(b => b.BrandId == id).FirstOrDefaultAsync();
        }

        public async Task<Brand> GetBrandByModelId(Guid id)
        {
            var modelId = await _context.Models.Where(m => m.ModelId == id).Select(m => m.Brand).FirstOrDefaultAsync();
            return modelId;
        }

        public async Task<Brand> GetBrandByNameAsync(string brandName)
        {
            return await _context.Brands.SingleOrDefaultAsync(b => b.BrandName == brandName);
        }

        public async Task<int> GetTotalBrandCountAsync(string search)
        {
            if (!string.IsNullOrEmpty(search))
            {
                return await _context.Brands.Where(s => s.BrandName.ToLower().Contains(search.ToLower().Trim())).CountAsync();
            }
            return await _context.Brands.CountAsync();
        }

        public void UpdateBrand(Guid id, Brand brand)
        {
            _context.Update(brand);
        }

    }
}
