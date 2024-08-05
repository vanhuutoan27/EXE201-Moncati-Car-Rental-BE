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
    }
}
