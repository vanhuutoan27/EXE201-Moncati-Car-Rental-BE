using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.SeedWorks;

namespace MocatiCar.Core.Repository
{
    public interface IImageRepository : IRepositoryBase<Image, Guid>
    {
        Task<IEnumerable<Image>> GetImagesByCarIdAsync(Guid CarId);
    }
}
