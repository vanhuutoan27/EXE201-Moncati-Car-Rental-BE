using AutoMapper;
using Microsoft.AspNetCore.Identity;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.Services;
using MoncatiCar.Data.Services;

namespace MoncatiCar.Data.SeedWork
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICarFeatureService> _carFeatureService;
        private readonly Lazy<ICarService> _carService;
        private readonly Lazy<ICarTypeService> _carTypeService;
        private readonly Lazy<IFeatureService> _featureService;
        private readonly Lazy<IImageService> _imageService;
        private readonly Lazy<IModelService> _modelService;
        private readonly Lazy<IReviewService> _reviewService;
        private readonly Lazy<IBrandService> _brandService;
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IAddressService> _addressService;
        private readonly Lazy<IRentalService> _rentalService;
        private readonly Lazy<ICitizenIdService> _citizenIdService;
        private readonly Lazy<IFavoriteCarService> _favoriteCarService;
        private readonly Lazy<IDrivingLicenseService> _drivingLicenseService;
        private readonly Lazy<IContactService> _contactService;
        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper, UserManager<AppUser> userManager, IContactService contactService, IFireBaseService fireBaseService)
        {
            _carFeatureService = new Lazy<ICarFeatureService>(() => new CarFeatureService(repositoryManager, mapper));
            _carService = new Lazy<ICarService>(() => new CarService(repositoryManager, mapper, userManager));
            _carTypeService = new Lazy<ICarTypeService>(() => new CarTypeService(repositoryManager, mapper));
            _featureService = new Lazy<IFeatureService>(() => new FeatureService(repositoryManager, mapper));
            _imageService = new Lazy<IImageService>(() => new ImageService(repositoryManager, mapper));
            _modelService = new Lazy<IModelService>(() => new ModelService(repositoryManager, mapper));
            _reviewService = new Lazy<IReviewService>(() => new ReviewService(repositoryManager, mapper, userManager));
            _brandService = new Lazy<IBrandService>(() => new BrandService(repositoryManager, mapper));
            _userService = new Lazy<IUserService>(() => new UserService(userManager, repositoryManager, mapper));
            _addressService = new Lazy<IAddressService>(() => new AddressService(repositoryManager, mapper));
            _rentalService = new Lazy<IRentalService>(() => new RentalService(repositoryManager, mapper, userManager, fireBaseService));
            _citizenIdService = new Lazy<ICitizenIdService>(() => new CitizendIdService(repositoryManager, mapper));
            _favoriteCarService = new Lazy<IFavoriteCarService>(() => new FavoriteCarService(repositoryManager, mapper, userManager));
            _drivingLicenseService = new Lazy<IDrivingLicenseService>(() => new DrivingLicenseService(repositoryManager, mapper));
            _contactService = new Lazy<IContactService>(() => new ContactService(repositoryManager, mapper));
        }
        public ICarFeatureService CarFeatureService => _carFeatureService.Value;

        public ICarService CarService => _carService.Value;

        public ICarTypeService CarTypeService => _carTypeService.Value;

        public IFeatureService FeatureService => _featureService.Value;

        public IImageService ImageService => _imageService.Value;

        public IModelService ModelService => _modelService.Value;

        public IReviewService ReviewService => _reviewService.Value;

        public IBrandService BrandService => _brandService.Value;

        public IUserService UserService => _userService.Value;

        public IAddressService AddressService => _addressService.Value;

        public IRentalService RentalService => _rentalService.Value;

        public ICitizenIdService CitizenIdService => _citizenIdService.Value;
        public IFavoriteCarService FavoriteCarService => _favoriteCarService.Value;
        public IDrivingLicenseService DrivingLicenseService => _drivingLicenseService.Value;

        public IContactService ContactService => _contactService.Value;
    }
}
