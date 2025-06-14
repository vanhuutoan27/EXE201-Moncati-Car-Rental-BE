﻿using AutoMapper;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.Services;

namespace MoncatiCar.Data.Services
{
    public class ContactService : IContactService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public ContactService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task CreateContract(CreateContractRequest request)
        {
            var contract = new Contract()
            {
                RentalId = request.RentalId,
                Signature = request.Signature,
                ContractTerms = request.ContractTerms,
                Attachment = request.Attachment,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _repositoryManager.ContractRepository.Add(contract);
            await _repositoryManager.SaveAsync();
        }

        public async Task<PageResult<ContractResponse>> GetAllContracts(int page, int limit, Guid? RentalId)
        {
            var contracts = await _repositoryManager.ContractRepository.GetAllContractAsync(page, limit, RentalId);
            var contractReponse = _mapper.Map<IEnumerable<ContractResponse>>(contracts.Items);
            var getAll = await _repositoryManager.ContractRepository.GetAllAsync();
            
            return new PageResult<ContractResponse>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(getAll.Count() / (double)limit),
                TotalItems = contracts.TotalCount,
                Items = contractReponse
            };
        }

        public async Task<ContractResponse> GetContractByRentalId(Guid rentalId)
        {
            var contract = await _repositoryManager.ContractRepository.GetContractByRentalId(rentalId);
            return _mapper.Map<ContractResponse>(contract);
        }

        public async Task<bool> UpdateContract(UpdateContractRequest request, Guid id)
        {
            var contractId = await _repositoryManager.ContractRepository.GetContractByRentalId(id);
            if (contractId == null)
            {
                throw new Exception("contract not found.");
            }
            contractId.Signature = request.Signature;
            contractId.ContractTerms = request.ContractTerms;
            _repositoryManager.ContractRepository.Update(contractId);
            await _repositoryManager.SaveAsync();
            return true;
        }
    }
}
