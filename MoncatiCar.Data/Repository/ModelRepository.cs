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
    }
}
