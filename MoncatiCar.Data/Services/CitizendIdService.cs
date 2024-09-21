using AutoMapper;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.Services;
using System.Text.RegularExpressions;

namespace MoncatiCar.Data.Services
{
    public class CitizendIdService : ICitizenIdService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public CitizendIdService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<CitizenIdResponse> CreateCitizenIdAsync(CreateCitizenIdRequest request)
        {
            if (!HasAtleast12Digits(request.IdNumber))
            {
                throw new Exception("IdNumber must to have at least 12 digits.");
            }
            bool checkExisedIdNumber = await _repositoryManager.CitizendIdRepository.HasIdNumberAsync(request.IdNumber);
            if (checkExisedIdNumber)
            {
                throw new Exception("IdNumber already Existed");

            }
            var user = await _repositoryManager.UserRepository.GetByIdAsync(request.UserId);
            if (user == null)
            {
                throw new Exception("Invalid UserId.");
            }
            var citizenId = new CitizenId
            {
                Citizen_Id = new Guid(),
                IdNumber = request.IdNumber,
                Dob = request.Dob,
                Gender = request.Gender,
                Nationality = request.Nationality,
                Address = request.Address,
                IssueDate = request.IssueDate,
                IssuingAuthority = request.IssuingAuthority,
                Verify = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserId = request.UserId
            };
            _repositoryManager.CitizendIdRepository.Add(citizenId);
            await _repositoryManager.SaveAsync();
            return _mapper.Map<CitizenIdResponse>(citizenId);
        }

        public async Task<bool> DeleteCitizenId(Guid id)
        {
            var query = await _repositoryManager.CitizendIdRepository.GetbyId(id);
            if(query == null){
                throw new Exception("CitizenId not found.");
            }
             _repositoryManager.CitizendIdRepository.Remove(query);
             await _repositoryManager.SaveAsync();
             return true;
        }

        public async Task<PageResult<CitizenIdResponse>> GetAllCitizenAsync(int page, int limit, long? citizendId, bool? verify, string? search)
        {
            var listCitizend = await _repositoryManager.CitizendIdRepository.GetAllCitizendIdAsync(page, limit, citizendId, verify, search);
            var totalItems = listCitizend.Count();
            var citizendRespone = listCitizend.Select(x => new CitizenIdResponse
            {
                CitizenId = x.Citizen_Id,
                Address = x.Address,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = x.CreatedBy,
                Dob = x.Dob,
                Gender = x.Gender,
                IdNumber = x.IdNumber,
                IssueDate = x.IssueDate,
                IssuingAuthority = x.IssuingAuthority,
                Nationality = x.Nationality,
                UpdatedBy = x.UpdatedBy,
                Verified = x.Verify

            });
            return new PageResult<CitizenIdResponse>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = citizendRespone
            };
        }

        public async Task<CitizenIdResponse> GetcitizenIdAsync(Guid id)
        {
            var citizenId = await _repositoryManager.CitizendIdRepository.GetbyId(id);
            if (citizenId == null)
            {
                throw new ArgumentException("No citizenId found.");
            };
            return new CitizenIdResponse
            {
                CitizenId = citizenId.Citizen_Id,
                Address = citizenId.Address,
                CreatedAt = DateTime.Now,
                CreatedBy = citizenId.CreatedBy,
                Dob = citizenId.Dob,
                Gender = citizenId.Gender,
                IdNumber = citizenId.IdNumber,
                IssueDate = citizenId.IssueDate,
                IssuingAuthority = citizenId.IssuingAuthority,
                Nationality = citizenId.Nationality,
                UpdatedAt = DateTime.Now,
                UpdatedBy = citizenId.UpdatedBy,
                Verified = citizenId.Verify
            };
        }

        public async Task<CitizenIdResponse> GetcitizenIdbyUserAsync(Guid id)
        {
           var query = await _repositoryManager.CitizendIdRepository.GetbyUserIdAsyn(id);
           if (query == null)
            {
                throw new ArgumentException("No user found.");
            };
            return new CitizenIdResponse
            {
                CitizenId = query.Citizen_Id,
                Address = query.Address,
                CreatedAt = DateTime.Now,
                CreatedBy = query.CreatedBy,
                Dob = query.Dob,
                Gender = query.Gender,
                IdNumber = query.IdNumber,
                IssueDate = query.IssueDate,
                IssuingAuthority = query.IssuingAuthority,
                Nationality = query.Nationality,
                UpdatedAt = DateTime.Now,
                UpdatedBy = query.UpdatedBy,
                Verified = query.Verify
            };
        }

        public async Task<bool> UpdateCitizenIdAsync(UpdateCitizenIdRequest request, Guid id)
        {
            var query = await _repositoryManager.CitizendIdRepository.GetbyId(id);
           if (!HasAtleast12Digits(request.IdNumber))
            {
                throw new Exception("IdNumber must to have at least 12 digits.");
            }
            bool checkExisedIdNumber = await _repositoryManager.CitizendIdRepository.HasIdNumberAsync(request.IdNumber);
            if (checkExisedIdNumber)
            {
                throw new Exception("IdNumber already Existed");

            }
            if (query == null)
            {
                throw new Exception("No CitizenId found.");
            }
            query.Address = request.Address;
            query.Dob = request.Dob;
            query.Gender = request.Gender;
            query.IdNumber = request.IdNumber;
            query.IssueDate = request.IssueDate;
            query.IssuingAuthority = request.IssuingAuthority;
            query.Nationality = request.Nationality;
            _repositoryManager.CitizendIdRepository.Update(query);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<bool> UpdateVerifyAsync(Guid id)
        {
            var query = await _repositoryManager.CitizendIdRepository.GetbyId(id);
            if (query == null)
            {
                return false;
            }
            if (query.Verify == true)
            {
                query.Verify = false;
            }
            else
            {
                query.Verify = true;
            }
            _repositoryManager.CitizendIdRepository.Update(query);
            await _repositoryManager.SaveAsync();
            return true;
        }

        private bool HasAtleast12Digits(string IdNumber)
        {
            Regex regex = new Regex(@"^-?\d{12,}$");
            return regex.IsMatch(IdNumber);
        }
    }
}
