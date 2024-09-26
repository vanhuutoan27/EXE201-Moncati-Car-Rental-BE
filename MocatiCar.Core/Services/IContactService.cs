using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;

namespace MocatiCar.Core.Services
{
    public interface IContactService
    {
        public Task CreateContract(CreateContractRequest request);
        public Task<ContractResponse> GetContractByRentalId(Guid rentalId);
        public Task<PageResult<ContractResponse>> GetAllContracts(int page, int limit, Guid? RentalId);
    }
}
