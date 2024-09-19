using AutoMapper;
using Microsoft.AspNetCore.Identity;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.Services;

namespace MoncatiCar.Data.Services
{
    public class FavoriteCarService(IRepositoryManager repositoryManager,
  IMapper mapper, UserManager<AppUser> userManager) : IFavoriteCarService
    {
        private readonly IRepositoryManager _repositoryManager = repositoryManager;
        private readonly IMapper _mapper = mapper;
        private readonly UserManager<AppUser> _userManager = userManager;

        public async Task<CreateFavoriteCarRequest> AddFavoriteCarAsync(CreateFavoriteCarRequest request)
        {

            var model = new FavoriteCar
            {
                CarId = request.carId,
                UserId = request.userId
            };
            if (model.CarId == null)
            {
                throw new Exception("Car does not found.");
            }
            if (model.UserId == null)
            {
                throw new Exception("User does not found.");
            }

            _repositoryManager.FavoriteCarRepository.Add(model);
            await _repositoryManager.SaveAsync();
            var result = _mapper.Map<CreateFavoriteCarRequest>(model);
            return result;
        }

        public async Task<PageResult<FavoriteCarRespone>> GetAllCarByUser(int page, int limit, Guid userId)
        {
            var (listFavoriteCar, totalItems) = await _repositoryManager.FavoriteCarRepository.GetFavoriteCarByUserAsync(page, limit, userId);
            if (listFavoriteCar == null || !listFavoriteCar.Any())
            {
                return new PageResult<FavoriteCarRespone>
                {
                    CurrentPage = page,
                    TotalPages = 0,
                    TotalItems = 0,
                    Items = new List<FavoriteCarRespone>()
                };
            }
            var favoritecarRespone = listFavoriteCar.Select(car => new FavoriteCarRespone
            {
                FavoriteCarId = car.FavoriteCarId,
                CarId = car.CarId,

                OwnerId = car.Car.User.Id,
                ownerName = car.Car.User.FullName,
                ownerAvatar = car.Car?.User?.Avatar,
                licensePlate = car.Car?.licensePlate,
                slug = car.Car?.Slug,
                brand = car.Car?.Model?.Brand?.BrandName,
                model = car.Car?.Model?.ModelName,
                year = car.Car?.year ?? 0,
                seats = car.Car?.Seats ?? 0,
                transmission = car.Car?.Transmission ?? default(MocatiCar.Core.SeedWorks.Enums.Transmission),
                fuelType = car.Car?.FuelType ?? default(MocatiCar.Core.SeedWorks.Enums.FuelType),

                description = car.Car?.Description,
                location = car.Car?.Location,
                pricePerDay = car.Car?.PricePerDay ?? 0,
                image = car.Car?.Images?
                         .OrderBy(img => img.ImageId)
                         .Select(img => img.Url)
                         .FirstOrDefault() ?? string.Empty,
            }).ToList();

            return new PageResult<FavoriteCarRespone>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = favoritecarRespone
            };
        }

        public async Task<bool> IsCarAlreadyFavorited(Guid userId, Guid carId)
        {
            return await _repositoryManager.FavoriteCarRepository.IsCarAlreadyFavorited(userId, carId);
        }

        public async Task<bool> IsOwnerOfCar(Guid userId, Guid carId)
        {
            var car = await _repositoryManager.CarRepository.GetByIdAsync(carId);
            if (car == null) { throw new Exception("Not found Car"); }
            if (car.OwnerId == userId) { return true; }
            return false;
        }

        public async Task<bool> RemoveFavoriteCarAsync(Guid id)
        {
            var faId = await _repositoryManager.FavoriteCarRepository.GetFavoriteCarById(id);
            if (faId != null)
            {
                _repositoryManager.FavoriteCarRepository.Remove(faId);
                await _repositoryManager.SaveAsync();
            }
            return true;
        }

        public async Task<bool> UpdateFavoriteCarAsync(UpdateFavoriteCarRequest request, Guid id)
        {
            var faId = await _repositoryManager.FavoriteCarRepository.GetFavoriteCarById(id);
            if (faId == null)
            {
                throw new Exception("Favorite car does not found.");
            }
            var car = await _repositoryManager.CarRepository.GetCarByCarId(request.CarId);
            if (car is null)
            {
                throw new Exception("Car does not found.");
            }


            faId.CarId = request.CarId;

            _repositoryManager.FavoriteCarRepository.Update(faId);
            await _repositoryManager.SaveAsync();
            return true;
        }


    }
}
