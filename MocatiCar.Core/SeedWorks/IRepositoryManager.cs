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
        IPaymentRepository PaymentRepository { get; }
        IRentalRepository RentalRepository { get; }
        ICitizendIdRepository CitizendIdRepository { get; }
        IFavoriteCarRepository FavoriteCarRepository { get; }
        IDrivingLicenseRepository DrivingLicenseRepository { get; }
        IContractRepository ContractRepository { get; }
        Task SaveAsync();
    }
}
