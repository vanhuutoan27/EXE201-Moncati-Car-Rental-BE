using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.SeedWorks;

namespace MocatiCar.Core.Repository
{
    public interface ICarFeatureRepository : IRepositoryBase<CarFeature, Guid>
    {
        Task<IEnumerable<CarFeature>> GetALLCarFeatureByCarId(Guid CarId);
    }
}
