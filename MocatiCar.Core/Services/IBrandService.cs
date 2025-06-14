﻿using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;

namespace MocatiCar.Core.Services
{
    public interface IBrandService
    {
        Task<CreateUpdateBrandRequest> AddBrand(CreateUpdateBrandRequest brandRequest);
        Task<bool> UpdateBrand(Guid id, CreateUpdateBrandRequest brand);
        Task<PageResult<BrandRespone>> GetAllBrands(int page, int limit, string? searchName);
        Task<BrandRespone> GetBrandById(Guid id);
        Task<bool> DeleteBrand(Guid id);
    }
}
