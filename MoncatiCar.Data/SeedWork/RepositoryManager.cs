using MocatiCar.Core.Repository;
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

        }

        public ICarFeatureRepository CarFeatureRepository => _carFeatureRepository.Value;

        public ICarRepository CarRepository => _carRepository.Value;

        public ICarTypeRepository CarTypeRepository => _carTypeRepository.Value;

        public IFeatureRepository FeatureRepository => _featureRepository.Value;

        public IImageRepository ImageRepository => _imageRepository.Value;

        public IModelRepository ModelRepository => _modelRepository.Value;

        public IReviewRepository ReviewRepository => _reviewRepository.Value;

        public async Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
