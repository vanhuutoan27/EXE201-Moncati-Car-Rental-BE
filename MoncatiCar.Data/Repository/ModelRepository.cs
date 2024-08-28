using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Repository;
using MoncatiCar.Data.SeedWork;

namespace MoncatiCar.Data.Repository
{
    public class ModelRepository : RepositoryBase<Model, Guid>, IModelRepository
    {
        public ModelRepository(MocatiContext context) : base(context)
        {
        }

        public async Task<bool> CheckModelNameExist(string modelName)
        {
            return await _context.Models.AnyAsync(x => x.ModelName == modelName);
        }

        public async Task<IEnumerable<Model>> GetAllModelAsync(int page, int limit, string searchName)
        {
            searchName = searchName?.Trim();
            if(string.IsNullOrEmpty(searchName))
            {
                if (page > 0 && limit > 0)
                {
                    return await _context.Models.Include(b => b.Brand).Skip((page - 1) * limit).Take(limit).ToListAsync();
                }
                return await _context.Models.ToListAsync();
            } else
            {
                return await _context.Models.Include(b => b.Brand)
                    .Where(s => s.ModelName.ToLower().Contains(searchName.ToLower()))
                    .Skip((page - 1) * limit).Take(limit).ToListAsync();
            }         
        }

        public async Task<IEnumerable<Model>> GetModelByBrandId(Guid brandId)
        {
            return await _context.Models.Include(i => i.Brand).Where(x => x.BrandId == brandId).ToListAsync();
        }

        public async Task<IEnumerable<Model>> GetModelByBrandName(string name)
        {
            return await _context.Models.Where(b => b.Brand.BrandName.ToLower().Contains(name.ToLower())).ToListAsync();
        }

        public async Task<Model> GetModelById(Guid id)
        {
            return await _context.Models.Where(b => b.ModelId == id).FirstOrDefaultAsync();
        }

        public async Task<Model> GetModelByNameAndBrandIdAsync(string modelName, Guid brandId)
        {
            return await _context.Models
                .SingleOrDefaultAsync(m => m.ModelName == modelName && m.BrandId == brandId);
        }

        public async Task<int> GetTotalModelCountAsync(string search)
        {
            if(!string.IsNullOrEmpty(search))
            {
                var resultSearch = await _context.Models.Where(s => s.ModelName.ToLower().Contains(search.ToLower().Trim())).CountAsync();
                return resultSearch;
            }
            return await _context.Models.CountAsync();
        }

        public void UpdateModel(Guid id, Model model)
        {
            _context.Update(model);
        }
    }
}
