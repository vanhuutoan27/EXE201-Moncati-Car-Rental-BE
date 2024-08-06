using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;

namespace MocatiCar.Core.Services
{
    public interface IBrandService
    {
        Task<CreateUpdateBrandRequest> AddBrand(CreateUpdateBrandRequest brandRequest);
        Task<bool> UpdateBrand(Guid id, CreateUpdateBrandRequest brand);
        Task<IEnumerable<BrandRespone>> GetAllBrands(int page, int limit);
        Task<BrandRespone> GetBrandById(Guid id);
        Task<bool> DeleteBrand(Guid id);
    }
}
