using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;

namespace MocatiCar.Core.Repository
{
    public interface IBrandRepository : IRepositoryBase<Brand, Guid>
    {
        Task<IEnumerable<Brand>> GetAllBrandAsync(int page, int limit);
        Task<int> GetTotalBrandCountAsync();
        Task<Brand> GetBrandById(Guid id);
        void UpdateBrand(Guid id, Brand brand);
        Task<bool> CheckBrandName(string brandName);
    }
}
