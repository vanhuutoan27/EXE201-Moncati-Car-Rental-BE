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
        private bool HasAtleast12Digits(string IdNumber)
        {
            Regex regex = new Regex(@"^-?\d{12,}$");
            return regex.IsMatch(IdNumber);
        }
    }
}
