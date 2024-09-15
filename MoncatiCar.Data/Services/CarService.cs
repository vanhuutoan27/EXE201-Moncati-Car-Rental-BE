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
            var randomSuffix = GenerateRandomString(6).ToLower();
            var brand = await _repositoryManager.BrandRepository.GetBrandByNameAsync(carRequest.BrandName);
            if (brand == null)
            {
                brand = new Brand
                {
                    BrandId = Guid.NewGuid(),
                    BrandName = carRequest.BrandName,
                    Description = "Generated when creating a new car.",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                _repositoryManager.BrandRepository.Add(brand);
                await _repositoryManager.SaveAsync(); // Lưu lại Brand mới
            }
            var model1 = await _repositoryManager.ModelRepository.GetModelByNameAndBrandIdAsync(carRequest.ModelName, brand.BrandId);

            if (model1 == null)
            {
                model1 = new Model
                {
                    ModelId = Guid.NewGuid(),
                    ModelName = carRequest.ModelName,
                    BrandId = brand.BrandId,
                    Description = "Generated when creating a new car.",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                _repositoryManager.ModelRepository.Add(model1);
                await _repositoryManager.SaveAsync();
            }

            //check bien so
            var existingCar = await _repositoryManager.CarRepository.GetByLicensePlateAsync(carRequest.LicensePlate);
            if (existingCar != null)
            {
                throw new Exception($"A car with license plate '{carRequest.LicensePlate}' already exists.");

            }

            var model = new Car()
            {
                ModelId = model1.ModelId,
                //CarTypeId = carRequest.CarTypeId,
                OwnerId = carRequest.OwnerId,
                licensePlate = carRequest.LicensePlate,
                year = carRequest.Year,
                discount = carRequest.discount,
                Status = false,
                Seats = carRequest.Seats,
                Transmission = (Transmission)carRequest.Transmission,
                FuelType = (FuelType)carRequest.FuelType,
                FuelConsumption = carRequest.FuelConsumption,
                Description = carRequest.Description,
                Location = carRequest.Location,
                PricePerDay = carRequest.PricePerDay,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                InstantBooking = false,
                LocationDetails = carRequest.LocationDetails,
                MaxDeliveryDistance = carRequest.MaxDeliveryDistance,
                DeliveryFeePerKm = carRequest.DeliveryFeePerKm,
                FreeDeliveryWithinKm = carRequest.FreeDeliveryWithinKm,
                LimitKilometersPerDay = carRequest.LimitKilometersPerDay,
                OverLimitFeePerKm = carRequest.OverLimitFeePerKm,
                RentalTerms = carRequest.RentalTerms,
            };
            // Tạo Slug với định dạng "Brand-Model-Year"
            model.Slug = $"{brand.BrandName.ToLower().Trim()}-{model1.ModelName.ToLower().Trim()}-{model.year}-{randomSuffix}";
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

        public async Task<PageResult<CarResponse>> GetAllCarByUser(int page, int limit, bool? status, Guid userId)
        {
            var (listCar, totalItems) = await _repositoryManager.CarRepository.GetCarByUserAsync(page, limit, status, userId);

            // Check if there are no cars available
            if (listCar == null || !listCar.Any())
            {
                return new PageResult<CarResponse>
                {
                    CurrentPage = page,
                    TotalPages = 0,
                    TotalItems = 0,
                    Items = new List<CarResponse>()
                };
            }

            var carResponse = listCar.Select(car => new CarResponse
            {
                Slug = car.Slug,
                CarId = car.CarId,
                Owner = (Guid)car.OwnerId,
                LicensePlate = car.licensePlate,
                Brand = car.Model.Brand.BrandName,
                Model = car.Model.ModelName,
                year = car.year,
                Location = car.Location,
                Seats = car.Seats,
                Transmission = car.Transmission,
                FuelType = car.FuelType,
                FuelConsumption = (float)car.FuelConsumption,
                Description = car.Description,
                PricePerDay = car.PricePerDay,
                Images = car.Images?.OrderBy(img => img.ImageId).Select(img => img.Url).ToList() ?? new List<string>(),
                RentalStatus = car.RentalStatus,
                Status = car.Status,
                CreatedAt = car.CreatedAt,
                UpdatedAt = car.UpdatedAt,
                CreatedBy = car.CreatedBy,
                UpdatedBy = car.UpdatedBy,
                InstantBooking = car.InstantBooking,
                Discount = (float)car.discount,
                MaxDeliveryDistance = car.MaxDeliveryDistance,
                DeliveryFeePerKm = car.DeliveryFeePerKm,
                FreeDeliveryWithinKm = car.FreeDeliveryWithinKm,
                LimitKilometersPerDay = car.LimitKilometersPerDay,
                OverLimitFeePerKm = car.OverLimitFeePerKm,
                RentalTerms = car.RentalTerms,
            }).ToList();

            return new PageResult<CarResponse>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = carResponse
            };
        }


        public async Task<PageResult<CarResponse>> GetAllCars(int page, int limit, string search, bool? status, string fuelType, string brandName, string modelName, string transmission, string location, string sortedBy, string order)
        {
            // Gọi repository để lấy danh sách xe và tổng số mục
            (IEnumerable<Car> listCar, int totalItems) = await _repositoryManager.CarRepository.GetAllCarAsync(page, limit, search, status, modelName, brandName, transmission, fuelType, location, sortedBy, order);

            // Chuyển đổi dữ liệu từ Car thành CarResponse
            var carResponse = listCar.Select(car => new CarResponse
            {
                Slug = car.Slug,
                CarId = car.CarId,
                Owner = car.OwnerId ?? Guid.Empty,
                LicensePlate = car.licensePlate,
                Brand = car.Model.Brand.BrandName,
                Model = car.Model.ModelName,
                year = car.year,
                Location = car.Location,
                Seats = car.Seats,
                Transmission = car.Transmission,
                FuelType = car.FuelType,
                FuelConsumption = (float?)car.FuelConsumption ?? 0,
                Description = car.Description,
                PricePerDay = car.PricePerDay,
                Images = car.Images?.OrderBy(img => img.ImageId).Select(img => img.Url).ToList() ?? new List<string>(),
                RentalStatus = car.RentalStatus,
                Status = car.Status,
                CreatedAt = car.CreatedAt,
                UpdatedAt = car.UpdatedAt,
                CreatedBy = car.CreatedBy,
                UpdatedBy = car.UpdatedBy,
                InstantBooking = car.InstantBooking,
                Discount = (float)car.discount,
                MaxDeliveryDistance = car.MaxDeliveryDistance,
                DeliveryFeePerKm = car.DeliveryFeePerKm,
                FreeDeliveryWithinKm = car.FreeDeliveryWithinKm,
                LimitKilometersPerDay = car.LimitKilometersPerDay,
                OverLimitFeePerKm = car.OverLimitFeePerKm,
                RentalTerms = car.RentalTerms,
            }).ToList();

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
                Owner = (Guid)car.OwnerId,
                LicensePlate = car.licensePlate,
                Slug = car.Slug,
                Brand = car.Model.Brand.BrandName,
                Model = car.Model.ModelName,
                year = car.year,
                Location = car.Location,
                Discount = (float)car.discount,
                Seats = car.Seats,
                Transmission = car.Transmission,
                FuelType = car.FuelType,
                FuelConsumption = (float)car.FuelConsumption,
                Description = car.Description,
                PricePerDay = car.PricePerDay,
                Images = car.Images?.OrderBy(img => img.ImageId).Select(img => img.Url).ToList() ?? new List<string>(),
                //Features = car.CarFeatures != null
                //         ? car.CarFeatures.Select(cf => cf.Feature.FeatureName).ToList()
                //                : new List<string>(),
                RentalStatus = car.RentalStatus,
                Status = car.Status,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = car.CreatedBy,
                UpdatedBy = car.UpdatedBy,
                InstantBooking = car.InstantBooking,

                MaxDeliveryDistance = car.MaxDeliveryDistance,
                DeliveryFeePerKm = car.DeliveryFeePerKm,
                FreeDeliveryWithinKm = car.FreeDeliveryWithinKm,
                LimitKilometersPerDay = car.LimitKilometersPerDay,
                OverLimitFeePerKm = car.OverLimitFeePerKm,
                RentalTerms = car.RentalTerms,

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
                Owner = (Guid)car.OwnerId,
                LicensePlate = car.licensePlate,
                Brand = car.Model.Brand.BrandName,
                Model = car.Model.ModelName,
                year = car.year,
                Location = car.Location,
                Seats = car.Seats,
                Transmission = car.Transmission,
                FuelType = car.FuelType,
                FuelConsumption = (float)car.FuelConsumption,
                Description = car.Description,
                PricePerDay = car.PricePerDay,
                discount = (float)car.discount,
                Images = car.Images?.OrderBy(img => img.ImageId).Select(img => img.Url).ToList() ?? new List<string>(),
                //Features = car.CarFeatures != null
                //  ? car.CarFeatures.Select(cf => cf.Feature.FeatureName).ToList() // Null check added here
                //         : new List<string>(),
                RentalStatus = car.RentalStatus,
                Status = car.Status,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = car.CreatedBy,
                UpdatedBy = car.UpdatedBy,
                InstantBooking = car.InstantBooking,
                MaxDeliveryDistance = car.MaxDeliveryDistance,
                DeliveryFeePerKm = car.DeliveryFeePerKm,
                FreeDeliveryWithinKm = car.FreeDeliveryWithinKm,
                LimitKilometersPerDay = car.LimitKilometersPerDay,
                OverLimitFeePerKm = car.OverLimitFeePerKm,
                RentalTerms = car.RentalTerms,
            };

            return carResponse;
        }



        public async Task<bool> UpdateCar(Guid id, UpdateCarRequest update)
        {
            var car = await _repositoryManager.CarRepository.GetByIdAsync(id);
            if (car == null)
            {
                throw new Exception("Car not found.");
            }

            //car.CarTypeId = update.CarTypeId;
            car.OwnerId = update.OwnerId;
            car.licensePlate = update.LicensePlate;
            car.year = update.Year;
            car.discount = update.discount;

            car.Seats = update.Seats;
            car.Transmission = (Transmission)update.Transmission;
            car.FuelType = (FuelType)update.FuelType;
            car.FuelConsumption = update.FuelConsumption;
            car.Description = update.Description;
            car.Location = update.Location;
            car.PricePerDay = update.PricePerDay;

            car.Status = true;
            car.InstantBooking = update.InstantBooking;
            car.LocationDetails = update.LocationDetails;
            car.MaxDeliveryDistance = update.MaxDeliveryDistance;
            car.DeliveryFeePerKm = update.DeliveryFeePerKm;
            car.FreeDeliveryWithinKm = update.FreeDeliveryWithinKm;
            car.LimitKilometersPerDay = update.LimitKilometersPerDay;
            car.OverLimitFeePerKm = update.OverLimitFeePerKm;
            car.RentalTerms = update.RentalTerms;
            car.CreatedAt = DateTime.Now;
            car.UpdatedAt = DateTime.Now;



            // Cập nhật hình ảnh
            if (update.Images != null && update.Images.Any())
            {
                var existingImages = (await _repositoryManager.ImageRepository.GetImagesByCarIdAsync(id)).ToList();
                if (existingImages != null && existingImages.Any())
                {
                    _repositoryManager.ImageRepository.RemoveRange(existingImages);
                }

                foreach (var imageUrl in update.Images)
                {
                    var image = new Image()
                    {
                        CarId = id,
                        Url = imageUrl,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                    };
                    _repositoryManager.ImageRepository.Add(image);
                }
            }

            // Cập nhật danh sách tính năng
            if (update.Features != null && update.Features.Any())
            {
                var existingCarFeatures = await _repositoryManager.CarFeatureRepository.GetALLCarFeatureByCarId(id);
                if (existingCarFeatures != null && existingCarFeatures.Any())
                {
                    _repositoryManager.CarFeatureRepository.RemoveRange(existingCarFeatures);
                }

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

            // Lưu thay đổi
            _repositoryManager.CarRepository.UpdateCar(id, car);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<bool> UpdateCarByCustomer(Guid id, UpdateCarByCustomer update)
        {
            var car = await _repositoryManager.CarRepository.GetByIdAsync(id);
            if (car == null)
            {

                throw new Exception("Car not found!");
            }


            car.discount = update.discount;


            car.FuelConsumption = update.FuelConsumption;
            car.Description = update.Description;
            car.Location = update.Location;
            car.PricePerDay = update.PricePerDay;
            car.discount = update.discount;
            car.Status = true;
            car.InstantBooking = update.InstantBooking;
            car.LocationDetails = update.LocationDetails;
            car.MaxDeliveryDistance = update.MaxDeliveryDistance;
            car.DeliveryFeePerKm = update.DeliveryFeePerKm;
            car.FreeDeliveryWithinKm = update.FreeDeliveryWithinKm;
            car.LimitKilometersPerDay = update.LimitKilometersPerDay;
            car.OverLimitFeePerKm = update.OverLimitFeePerKm;
            car.RentalTerms = update.RentalTerms;
            car.CreatedAt = DateTime.Now;
            car.UpdatedAt = DateTime.Now;


            _repositoryManager.CarRepository.UpdateCar(id, car);
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

