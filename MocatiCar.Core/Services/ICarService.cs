﻿using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks.Enums;

namespace MocatiCar.Core.Services
{
    public interface ICarService
    {
        Task<CreateUpdateCarRequest> AddCar(CreateUpdateCarRequest carRequest);
        Task<PageResult<CarResponse>> GetAllCars(int page, int limit, string search, bool? status, string fuel, int? seats,
        bool? electric, bool? discount, bool? instantBooking, string brandName,
            string modelName, string transmission, string location, string sortedBy, string order, int? minYear, int? maxYear,
        int? minPrice, int? maxPrice, string rentalStatus);
        Task<CarResponse> GetCarByCarId(Guid id);
        Task<CarResponeIdandSlug> GetCarBySlug(string slug);
        Task<PageResult<CarResponse>> GetAllCarByUser(int page, int limit, bool? status, Guid userId);
        Task<PageResult<CarResponse>> GetAllCarByUserNameOfOwner(int page, int limit, bool? status, string username);
        Task<bool> UpdateCar(Guid id, UpdateCarRequest update);
        Task<bool> DeleteCar(Guid id);
        Task<bool> ChangeStatusAsync(Guid id);
        Task<bool> ChangeRentalStatusAsync(Guid id, CarRentalStatus status);
        Task<bool> UpdateCarByCustomer(Guid id, UpdateCarByCustomer update);
        Task<LocationDetailRespone> GetLocationDetailbyCarId(Guid id);

    }
}
