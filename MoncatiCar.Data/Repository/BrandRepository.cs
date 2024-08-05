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
    }
}
