using AutoMapper;
using Microsoft.AspNetCore.Identity;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.SeedWorks.Enums;
using MocatiCar.Core.Services;


namespace MoncatiCar.Data.Services
{
    public class CarService : ICarService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        public CarService(IRepositoryManager repositoryManager, IMapper mapper, UserManager<AppUser> userManager)
        {

            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<CreateUpdateCarRequest> AddCar(CreateUpdateCarRequest carRequest)
        {
            // Tạo 6 ký tự ngẫu nhiên
            var randomSuffix = GenerateRandomString(6);
            var brand = await _repositoryManager.BrandRepository.GetBrandByModelId(carRequest.ModelId);
            var model1 = await _repositoryManager.ModelRepository.GetModelById(carRequest.ModelId);
            if (brand == null || model1 == null)
            {
                throw new Exception("Brand or model not found.");
            }

            // Tạo Slug với định dạng "Brand-Model-Year"
            var slug = $"{brand.BrandName.ToLower()}-{model1.ModelName.ToLower()}-{model1.Year}/{randomSuffix}";

            var model = new Car()
            {
                ModelId = carRequest.ModelId,
                CarTypeId = carRequest.CarTypeId,
                OwnerId = carRequest.OwnerId,
                licensePlate = carRequest.LicensePlate,
                Slug = slug,
                Seats = carRequest.Seats,
                Transmission = carRequest.Transmission,
                FuelType = carRequest.FuelType,
                FuelConsumption = carRequest.FuelConsumption,
                Description = carRequest.Description,
                Location = carRequest.Location,
                PricePerDay = carRequest.PricePerDay,
                RentalStatus = carRequest.RentalStatus,
                Status = false,



            };

            _repositoryManager.CarRepository.Add(model);


            foreach (var imageUrl in carRequest.Images)
            {
                var image = new Image()
                {
                    ImageId = Guid.NewGuid(),
                    CarId = model.CarId,
                    Url = imageUrl,
                    CreatedAt = DateTime.Now,
                };
                _repositoryManager.ImageRepository.Add(image);
            }

            if (carRequest.Features != null && carRequest.Features.Any())
            {
                foreach (var featureName in carRequest.Features)
                {
                    var feature = await _repositoryManager.FeatureRepository.GetFeatureByFeatureNameAsync(featureName);
                    var carFeature = new CarFeature()
                    {
                        CarId = model.CarId,
                        FeatureId = feature != null ? feature.FeatureId : null
                    };
                    _repositoryManager.CarFeatureRepository.Add(carFeature);

                }
            }


            await _repositoryManager.SaveAsync();

            var result = _mapper.Map<CreateUpdateCarRequest>(model);
            return result;
        }

        public async Task<bool> ChangeRentalStatusAsync(Guid id, CarRentalStatus status)
        {
            //if (string.IsNullOrWhiteSpace(status))
            //{
            //    return false;
            //}
            if (status == null)
            {
                return false;

            }
            var car = await _repositoryManager.CarRepository.GetCarByCarId(id);
            if (car == null)
            {
                return false;
            }
            car.RentalStatus = status;
            _repositoryManager.CarRepository.Update(car);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<bool> ChangeStatusAsync(Guid id)
        {
            var car = await _repositoryManager.CarRepository.GetCarByCarId(id);
            if (car == null)
            {
                throw new Exception("Car not found.");
            }
            var check = car.Status;
            if (check == true)
            {
                car.Status = false;
            }
            else
            {
                car.Status = true;
            }
            _repositoryManager.CarRepository.Update(car);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<bool> DeleteCar(Guid id)
        {
            var carId = await _repositoryManager.CarRepository.GetCarByCarId(id);
            if (carId == null)
            {
                return false;
            }
            _repositoryManager.CarRepository.Remove(carId);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<PageResult<CarResponse>> GetAllCars(int page, int limit, string search)
        {
            var listCar = await _repositoryManager.CarRepository.GetAllCarAsync(page, limit, search);
            var totalItems = listCar.Count();
            var carResponse = listCar.Select(car => new CarResponse
            {
                Slug = car.Slug,
                CarId = car.CarId,
                Owner = car.OwnerId,
                LicensePlate = car.licensePlate,
                Brand = car.Model.Brand.BrandName,
                Model = car.Model.ModelName,
                Location = car.Location,
                Seats = car.Seats,
                Transmission = car.Transmission,
                FuelType = car.FuelType,
                FuelConsumption = car.FuelConsumption,
                Description = car.Description,
                PricePerDay = car.PricePerDay,
                Images = car.Images?.Select(img => img.Url).ToList() ?? new List<string>(),
                Features = car.CarFeatures != null
                         ? car.CarFeatures.Select(cf => cf.Feature.FeatureName).ToList()
                                : new List<string>(),

                RentalStatus = car.RentalStatus,
                Status = car.Status,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = car.CreatedBy,
                UpdatedBy = car.UpdatedBy


            });


            return new PageResult<CarResponse>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = carResponse
            };
        }

        public async Task<CarResponse> GetCarByCarId(Guid id)
        {
            var car = await _repositoryManager.CarRepository.GetCarByCarId(id);
            var carResponse = new CarResponse()
            {
                CarId = car.CarId,
                Owner = car.OwnerId,
                LicensePlate = car.licensePlate,
                Slug = car.Slug,
                Brand = car.Model.Brand.BrandName,
                Model = car.Model.ModelName,
                Location = car.Location,
                Seats = car.Seats,
                Transmission = car.Transmission,
                FuelType = car.FuelType,
                FuelConsumption = car.FuelConsumption,
                Description = car.Description,
                PricePerDay = car.PricePerDay,
                Images = car.Images?.Select(img => img.Url).ToList() ?? new List<string>(),
                Features = car.CarFeatures != null
                         ? car.CarFeatures.Select(cf => cf.Feature.FeatureName).ToList()
                                : new List<string>(),

                RentalStatus = car.RentalStatus,
                CreatedAt = car.CreatedAt,
                UpdatedAt = car.UpdatedAt,

            };
            return carResponse;
        }

        public async Task<CarResponeIdandSlug> GetCarBySlug(string slug)
        {
            var car = await _repositoryManager.CarRepository.GetCarBySlug(slug);

            if (car == null)
            {
                throw new Exception($"Car with slug '{slug}' not found.");
            }

            var carResponse = new CarResponeIdandSlug()
            {
                CarId = car.CarId,
                Owner = car.OwnerId,
                LicensePlate = car.licensePlate,

                Brand = car.Model?.Brand?.BrandName ?? string.Empty,
                Model = car.Model?.ModelName ?? string.Empty,
                Location = car.Location,
                Seats = car.Seats,
                Transmission = car.Transmission,
                FuelType = car.FuelType,
                FuelConsumption = car.FuelConsumption,
                Description = car.Description,
                PricePerDay = car.PricePerDay,
                Images = car.Images?.Select(img => img.Url).ToList() ?? new List<string>(),
                Features = car.CarFeatures != null
                          ? car.CarFeatures.Select(cf => cf.Feature.FeatureName).ToList()
                          : new List<string>(),
                RentalStatus = car.RentalStatus,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            return carResponse;
        }


        public async Task<bool> UpdateCar(Guid id, CreateUpdateCarRequest update)
        {
            var query = await _repositoryManager.CarRepository.GetByIdAsync(id);
            if (query == null)
            {
                throw new Exception("Car not found.");
            }
            var checkCartype = await _repositoryManager.CarTypeRepository.GetByIdAsync(update.CarTypeId);
            if (checkCartype == null || !update.CarTypeId.Equals(checkCartype.CarTypeId))
            {
                throw new Exception("Car type not found.");
            }
            var checkModel = await _repositoryManager.ModelRepository.GetByIdAsync(update.ModelId);
            if (checkModel == null || !update.ModelId.Equals(checkModel.ModelId))
            {
                throw new Exception("ModelId isn't exist");
            }
            var checkOwner = await _userManager.FindByIdAsync(update.OwnerId.ToString());
            if (checkOwner == null || !update.OwnerId.Equals(checkOwner.Id))
            {
                throw new Exception("Owner not found.");
            }

            query.ModelId = update.ModelId;
            query.CarTypeId = update.CarTypeId;
            query.OwnerId = update.OwnerId;
            query.licensePlate = update.LicensePlate;

            query.Seats = update.Seats;
            query.Transmission = update.Transmission;
            query.FuelType = update.FuelType;
            query.FuelConsumption = update.FuelConsumption;
            query.Description = update.Description;
            query.Location = update.Location;
            query.PricePerDay = update.PricePerDay;
            query.RentalStatus = update.RentalStatus;



            _repositoryManager.CarRepository.UpdateCar(id, query);
            if (update.Images != null && update.Images.Any())
            {
                List<Image> images = (await _repositoryManager.ImageRepository.GetImagesByCarIdAsync(id)).ToList();
                if (images != null && images.Any())
                {
                    foreach (Image image in images)
                    {
                        image.CarId = null;
                    }
                }
                //Add iamge
                foreach (var i in update.Images)
                {
                    var image = new Image()
                    {
                        CarId = id,
                        Url = i,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,

                    };
                    _repositoryManager.ImageRepository.Add(image);
                }
            }

            //Handle FeatureList by name
            if (update.Features != null && update.Features.Any())
            {
                //remove featureid of CarFeature
                var carFeatureList = await _repositoryManager.CarFeatureRepository.GetALLCarFeatureByCarId(id);
                if (carFeatureList != null && carFeatureList.Any())
                    _repositoryManager.CarFeatureRepository.RemoveRange(carFeatureList);

                foreach (var featureName in update.Features)
                {
                    var feature = await _repositoryManager.FeatureRepository.GetFeatureByFeatureNameAsync(featureName);
                    var carFeature = new CarFeature()
                    {
                        CarId = id,
                        FeatureId = feature != null ? feature.FeatureId : null

                    };
                    _repositoryManager.CarFeatureRepository.Add(carFeature);
                }
            }




            await _repositoryManager.SaveAsync();
            return true;
        }
        private string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

