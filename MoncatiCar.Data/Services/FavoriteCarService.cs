using AutoMapper;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Domain.Content;
using System.Runtime.CompilerServices;

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
