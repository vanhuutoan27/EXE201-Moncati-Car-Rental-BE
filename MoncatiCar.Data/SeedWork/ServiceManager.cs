using AutoMapper;
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

        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _carFeatureService = new Lazy<ICarFeatureService>(() => new CarFeatureService(repositoryManager, mapper));
            _carService = new Lazy<ICarService>(() => new CarService(repositoryManager, mapper));
            _carTypeService = new Lazy<ICarTypeService>(() => new CarTypeService(repositoryManager, mapper));
            _featureService = new Lazy<IFeatureService>(() => new FeatureService(repositoryManager, mapper));
            _imageService = new Lazy<IImageService>(() => new ImageService(repositoryManager, mapper));
            _modelService = new Lazy<IModelService>(() => new ModelService(repositoryManager, mapper));
            _reviewService = new Lazy<IReviewService>(() => new ReviewService(repositoryManager, mapper));
        }

        public ICarFeatureService CarFeatureService => _carFeatureService.Value;

        public ICarService CarService => _carService.Value;

        public ICarTypeService CarTypeService => _carTypeService.Value;

        public IFeatureService FeatureService => _featureService.Value;

        public IImageService ImageService => _imageService.Value;

        public IModelService ModelService => _modelService.Value;

        public IReviewService ReviewService => _reviewService.Value;
    }
}
