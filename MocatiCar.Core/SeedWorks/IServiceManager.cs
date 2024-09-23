using MocatiCar.Core.Services;

namespace MocatiCar.Core.SeedWorks
{
    public interface IServiceManager
    {
        ICarFeatureService CarFeatureService { get; }
        ICarService CarService { get; }
        ICarTypeService CarTypeService { get; }
        IFeatureService FeatureService { get; }
        IImageService ImageService { get; }
        IModelService ModelService { get; }
        IReviewService ReviewService { get; }
        IBrandService BrandService { get; }
        IAddressService AddressService { get; }
        IUserService UserService { get; }
        IRentalService RentalService { get; }
        ICitizenIdService CitizenIdService { get; }
        IFavoriteCarService FavoriteCarService { get; }
        IDrivingLicenseService DrivingLicenseService { get; }
        IContactService ContactService { get; }
    }
}
