using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Repository;
using MoncatiCar.Data.SeedWork;

namespace MoncatiCar.Data.Repository
{
    public class ImageRepository : RepositoryBase<Image, Guid>, IImageRepository
    {
        public ImageRepository(MocatiContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Image>> GetImagesByCarIdAsync(Guid CarId)
        {
            return await _context.Images.Where(c => c.CarId == CarId).ToListAsync();
            
        }
    }
}
