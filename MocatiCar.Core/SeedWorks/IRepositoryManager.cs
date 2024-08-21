using MocatiCar.Core.Repository;

namespace MocatiCar.Core.SeedWorks
{
    public interface IRepositoryManager
    {
        ICarFeatureRepository CarFeatureRepository { get; }
        ICarRepository CarRepository { get; }
        ICarTypeRepository CarTypeRepository { get; }
        IFeatureRepository FeatureRepository { get; }
        IImageRepository ImageRepository { get; }
        IModelRepository ModelRepository { get; }
        IReviewRepository ReviewRepository { get; }
        IBrandRepository BrandRepository { get; }
        IUserRepository UserRepository { get; }
        IAddressRepository AddressRepository { get; }
        Task SaveAsync();
    }
}
