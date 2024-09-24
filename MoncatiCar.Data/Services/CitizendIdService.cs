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
                throw new Exception("ID number must contain at least 12 digits.");
            }
            bool checkExisedIdNumber = await _repositoryManager.CitizendIdRepository.HasIdNumberAsync(request.IdNumber);
            if (checkExisedIdNumber)
            {
                throw new Exception("ID number already exists.");

            }
            var user = await _repositoryManager.UserRepository.GetByIdAsync(request.UserId);
            if (user == null)
            {
                throw new Exception("Invalid user ID.");
            }
            var citizenId = new CitizenId
            {
                Citizen_Id = new Guid(),
                IdNumber = request.IdNumber,
                Dob = request.Dob,
                Gender = request.Gender,
                FullName = request.FullName,
                Nationality = request.Nationality,
                Address = request.Address,
                IssueDate = request.IssueDate,
                IssuingAuthority = request.IssuingAuthority,
                Verified = false,
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
            if (query == null)
            {
                throw new Exception("Citizen ID not found.");
            }
            _repositoryManager.CitizendIdRepository.Remove(query);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<PageResult<CitizenIdResponse>> GetAllCitizenAsync(int page, int limit, string? citizendId, bool? verify, string? search)
        {
            var paginatedCitizends = await _repositoryManager.CitizendIdRepository.GetAllCitizenIdAsync(page, limit, citizendId, verify, search);
            var citizendRespone = paginatedCitizends.Items.Select(x => new CitizenIdResponse
            {
                CitizenId = x.Citizen_Id,
                FullName = x.FullName,
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
                Verified = x.Verified

            });
            return new PageResult<CitizenIdResponse>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(paginatedCitizends.TotalCount / (double)limit),
                TotalItems = paginatedCitizends.TotalCount,
                Items = citizendRespone
            };
        }

        public async Task<CitizenIdResponse> GetcitizenIdAsync(Guid id)
        {
            var citizenId = await _repositoryManager.CitizendIdRepository.GetbyId(id);
            if (citizenId == null)
            {
                throw new ArgumentException("Citizen ID not found.");
            };
            return new CitizenIdResponse
            {
                CitizenId = citizenId.Citizen_Id,
                FullName = citizenId.FullName,
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
                Verified = citizenId.Verified
            };
        }

        public async Task<CitizenIdResponse> GetcitizenIdbyUserAsync(Guid id)
        {
            var query = await _repositoryManager.CitizendIdRepository.GetbyUserIdAsyn(id);
            // if (query == null)
            // {
            //     throw new Exception("User not found.");
            // }
            return _mapper.Map<CitizenIdResponse>(query);

        }

        public async Task<bool> UpdateCitizenIdAsync(UpdateCitizenIdRequest request, Guid id)
        {
            var query = await _repositoryManager.CitizendIdRepository.GetbyId(id);
            if (!HasAtleast12Digits(request.IdNumber))
            {
                throw new Exception("ID number must contain at least 12 digits.");
            }
            bool checkExisedIdNumber = await _repositoryManager.CitizendIdRepository.HasIdNumberAsync(request.IdNumber);
            if (checkExisedIdNumber)
            {
                throw new Exception("ID number already exists.");

            }
            if (query == null)
            {
                throw new Exception("Citizen ID not found.");
            }
            if(query.Verified == true){
                query.Verified = false;
            }
            query.Address = request.Address;
            query.FullName = request.FullName;
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
            if (query.Verified == true)
            {
                query.Verified = false;
            }
            else
            {
                query.Verified = true;
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
