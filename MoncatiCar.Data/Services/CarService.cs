using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic.FileIO;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
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
            var brand = await _repositoryManager.BrandRepository.GetBrandById(carRequest.BrandId);
            var model1 = await _repositoryManager.ModelRepository.GetModelById(carRequest.ModelId);
            if (brand == null || model1 == null)
            {
                throw new Exception("Brand or Model not found.");
            }

            // Tạo Slug với định dạng "Brand-Model-Year"
            var slug = $"{brand.BrandName.ToLower()}-{model1.ModelName.ToLower()}-{model1.Year}/{randomSuffix}";

            var model = new Car()
            {
                ModelId =carRequest.ModelId,
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
                Status = carRequest.Status,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = carRequest.CreatedBy,
                UpdatedBy = carRequest.UpdatedBy,

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
                    UpdatedAt = DateTime.Now,
                };
                _repositoryManager.ImageRepository.Add(image);
            }
            //foreach (var reviewDto in carRequest.Reviews)
            //{
            //    var review = new Review
            //    {
            //        ReviewId = Guid.NewGuid(),
            //        Author = model.OwnerId,
            //        Rating = reviewDto.Rating,
            //        Content = reviewDto.Content,
            //        CreatedAt = DateTime.Now,
            //        UpdatedAt = DateTime.Now,

            //    };

            //    _repositoryManager.ReviewRepository.Add(review);
            //}

            await _repositoryManager.SaveAsync();

            var result = _mapper.Map<CreateUpdateCarRequest>(model);
            return result;
        }

        public async Task<bool> ChangeStatusAsync(Guid id)
        {
           var car = await _repositoryManager.CarRepository.GetCarByCarId(id);
            if(car == null)
            {
                throw new Exception("Not Found Car!");
            }
            var check = car.Status;
            if(check == true)
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
            _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<IEnumerable<CarResponse>> GetAllCars(int page, int limit)
        {
            var listCar = await _repositoryManager.CarRepository.GetAllCarAsync(page, limit);

            var carResponse = listCar.Select(car => new CarResponse
            {
                
                Owner = car.OwnerId,
                LicensePlate = car.licensePlate,
                Slug = car.Slug,
                Brand = car.Model.Brand.BrandName,
                Model = car.Model.ModelName,

                Seats = car.Seats,
                Transmission = car.Transmission,
                FuelType = car.FuelType,
                FuelConsumption = car.FuelConsumption,
                Description = car.Description,
                PricePerDay = car.PricePerDay,
                Images = car.Images?.Select(img => new ImageResponse
                {
                    ImageId = img.ImageId,
                    Url = img.Url,
                    CreatedAt = (DateTime)img.CreatedAt,
                    UpdatedAt = (DateTime)img.UpdatedAt,
                }).ToList() ?? new List<ImageResponse>(),

                //Reviews = car.Reviews?.Select(review => new ReviewResponse
                //{
                //    ReviewId = review.ReviewId,
                //    Author = review.Author,
                //    Content = review.Content,
                //    CreatedAt = (DateTime)review.CreatedAt,
                //    UpdatedAt = (DateTime)review.UpdatedAt,
                //}).ToList() ?? new List<ReviewResponse>(),
                RentalStatus = car.RentalStatus,
                Status = car.Status,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = car.CreatedBy,
                UpdatedBy = car.UpdatedBy,
            });


            return carResponse;
        }

        public async Task<CarResponeIdandSlug> GetCarByCarId(Guid id)
        {
            var query = await _repositoryManager.CarRepository.GetCarByCarId(id);

            return _mapper.Map<CarResponeIdandSlug>(query);
        }

        public async Task<CarResponeIdandSlug> GetCarBySlug(string slug)
        {
            var query = await _repositoryManager.CarRepository.GetCarBySlug(slug);
            return _mapper.Map<CarResponeIdandSlug>(query);
        }

        public async Task<bool> UpdateCar(Guid id, CreateUpdateCarRequest update)
        {
            var query = await _repositoryManager.CarRepository.GetByIdAsync(id);
            if (query == null)
            {
                throw new Exception("Car isn't exist");
            }
            var checkCartype = await _repositoryManager.CarTypeRepository.GetByIdAsync(update.CarTypeId);
            if (checkCartype == null || !update.CarTypeId.Equals(checkCartype.CarTypeId))
            {
                throw new Exception("CarTypeId isn't exist");
            }
            var checkModel = await _repositoryManager.ModelRepository.GetByIdAsync(update.ModelId);
            if (checkModel == null || !update.ModelId.Equals(checkModel.ModelId))
            {
                throw new Exception("ModelId isn't exist");
            }
            var checkOwner = await _userManager.FindByIdAsync(update.OwnerId.ToString());
            if(checkOwner == null || !update.OwnerId.Equals(checkOwner.Id))
            {
                throw new Exception("OwnerId isn't exist");
            }
            
            query.ModelId = update.ModelId;
            query.CarTypeId = update.CarTypeId;
            query.OwnerId = update.OwnerId;
            query.licensePlate = update.LicensePlate;
            query.Slug = update.Slug;
            query.Seats = update.Seats;
            query.Transmission = update.Transmission;
            query.FuelType = update.FuelType;
            query.FuelConsumption = update.FuelConsumption;
            query.Description = update.Description;
            query.Location = update.Location;
            query.PricePerDay = update.PricePerDay;
            query.RentalStatus = update.RentalStatus;
            query.Status     = update.Status;
            query.CreatedAt = DateTime.Now;
            query.UpdatedAt = DateTime.Now;
            query.CreatedBy = update.CreatedBy;
            query.UpdatedBy = update.UpdatedBy;

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

