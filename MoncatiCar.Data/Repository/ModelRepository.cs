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

        public async Task<IEnumerable<Model>> GetAllModelAsync(int page, int limit)
        {
            if(page > 0 && limit > 0)
            {
                return await _context.Models.Include(b => b.Brand).Skip((page - 1) * limit).Take(limit).ToListAsync();
            }
            return await _context.Models.ToListAsync();
            
        }

        public async Task<IEnumerable<Model>> GetModelByBrandId(Guid brandId)
        {
            return await _context.Models.Where(x => x.BrandId == brandId).ToListAsync();
        }

        public async Task<IEnumerable<Model>> GetModelByBrandName(string name)
        {
            return await _context.Models.Where(b => b.Brand.BrandName.ToLower().Equals(name.ToLower())).ToListAsync();
        }

        public async Task<Model> GetModelById(Guid id)
        {
            return await _context.Models.Where(b => b.ModelId == id).FirstOrDefaultAsync();
        }

        public async Task<int> GetTotalModelCountAsync()
        {
            return await _context.Models.CountAsync();
        }

        public void UpdateModel(Guid id, Model model)
        {
            _context.Update(model);
        }
    }
}
