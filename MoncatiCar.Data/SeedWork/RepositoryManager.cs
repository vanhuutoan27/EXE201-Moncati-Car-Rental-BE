﻿using MocatiCar.Core.Repository;
using MocatiCar.Core.SeedWorks;
using MoncatiCar.Data.Repository;

namespace MoncatiCar.Data.SeedWork
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly MocatiContext _context;
        private readonly Lazy<ICarFeatureRepository> _carFeatureRepository;
        private readonly Lazy<ICarRepository> _carRepository;
        private readonly Lazy<ICarTypeRepository> _carTypeRepository;
        private readonly Lazy<IFeatureRepository> _featureRepository;
        private readonly Lazy<IImageRepository> _imageRepository;
        private readonly Lazy<IModelRepository> _modelRepository;
        private readonly Lazy<IReviewRepository> _reviewRepository;
        private readonly Lazy<IBrandRepository> _brandRepository;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IPaymentRepository> _paymentRepository;


        private readonly Lazy<IAddressRepository> _addressRepository;
        private readonly Lazy<IRentalRepository> _rentalRepository;
        private readonly Lazy<ICitizendIdRepository> _citizendIdRepository;
        private readonly Lazy<IFavoriteCarRepository> _favoriteCarRepository;
        private readonly Lazy<IDrivingLicenseRepository> _drivingLicenseRepository;
        private readonly Lazy<IContractRepository> _contractRepository;
        public RepositoryManager(MocatiContext context)
        {
            _context = context;
            _carFeatureRepository = new Lazy<ICarFeatureRepository>(() => new CarFeatureRepository(context));
            _carRepository = new Lazy<ICarRepository>(() => new CarRepository(context));
            _carTypeRepository = new Lazy<ICarTypeRepository>(() => new CarTypeRepository(context));
            _featureRepository = new Lazy<IFeatureRepository>(() => new FeatureRepository(context));
            _imageRepository = new Lazy<IImageRepository>(() => new ImageRepository(context));
            _modelRepository = new Lazy<IModelRepository>(() => new ModelRepository(context));
            _reviewRepository = new Lazy<IReviewRepository>(() => new ReviewRepository(context));
            _brandRepository = new Lazy<IBrandRepository>(() => new BrandRepository(context));
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(context));
            _addressRepository = new Lazy<IAddressRepository>(() => new AddressRepository(context));
            _paymentRepository = new Lazy<IPaymentRepository>(() => new PaymentRepository(context));

            _rentalRepository = new Lazy<IRentalRepository>(() => new RentalRepository(context));
            _citizendIdRepository = new Lazy<ICitizendIdRepository>(() => new CitizenIdRepository(context));
            _favoriteCarRepository = new Lazy<IFavoriteCarRepository>(() => new FavoriteCarRepository(context));
            _drivingLicenseRepository = new Lazy<IDrivingLicenseRepository>(() => new DrivingLicenseRepository(context));
            _contractRepository = new Lazy<IContractRepository>(() => new ContractRepository(context));
        }

        public ICarFeatureRepository CarFeatureRepository => _carFeatureRepository.Value;

        public ICarRepository CarRepository => _carRepository.Value;

        public ICarTypeRepository CarTypeRepository => _carTypeRepository.Value;

        public IFeatureRepository FeatureRepository => _featureRepository.Value;

        public IImageRepository ImageRepository => _imageRepository.Value;

        public IModelRepository ModelRepository => _modelRepository.Value;

        public IReviewRepository ReviewRepository => _reviewRepository.Value;

        public IBrandRepository BrandRepository => _brandRepository.Value;
        public IAddressRepository AddressRepository => _addressRepository.Value;

        public IUserRepository UserRepository => _userRepository.Value;
        public IPaymentRepository PaymentRepository => _paymentRepository.Value;

        public IRentalRepository RentalRepository => _rentalRepository.Value;
        public IFavoriteCarRepository FavoriteCarRepository => _favoriteCarRepository.Value;

        public IDrivingLicenseRepository DrivingLicenseRepository => _drivingLicenseRepository.Value;
        public ICitizendIdRepository CitizendIdRepository => _citizendIdRepository.Value;

        public IContractRepository ContractRepository => _contractRepository.Value;

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
