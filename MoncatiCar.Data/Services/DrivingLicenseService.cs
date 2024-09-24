using AutoMapper;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.Services;

namespace MoncatiCar.Data.Services
{
    public class DrivingLicenseService : IDrivingLicenseService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public DrivingLicenseService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public async Task<CreateDrivingLicenseRequest> AddDrivingLicense(CreateDrivingLicenseRequest drivingLicenseRequest)
        {
            var user = await _repositoryManager.UserRepository.GetByIdAsync(drivingLicenseRequest.UserId);
            if (user == null)
            {
                throw new Exception("User not found.");
            }

            // kiem tra user co drivinglisence hay chua
            var checkDrivingLisence = await _repositoryManager.DrivingLicenseRepository.GetDrivingLicenseUserId(drivingLicenseRequest.UserId);
            if (checkDrivingLisence != null)
            {
                throw new Exception("The user already has a driving license.");
            }
            var createLicense = _mapper.Map<DrivingLicense>(drivingLicenseRequest);
            // check length of LicenseNumber
            if (drivingLicenseRequest.LicenseNumber.Length != 12 || !drivingLicenseRequest.LicenseNumber.All(char.IsDigit))
            {
                throw new Exception("Invalid license number. It must be 12 digits.");
            }

            // check license duplicate
            var existingLicense = await _repositoryManager.DrivingLicenseRepository.CheckLisenceNumber(drivingLicenseRequest.LicenseNumber, null);
            if (existingLicense != null)
            {
                throw new Exception("License number already exists.");
            }

            var modelLicense = new DrivingLicense
            {
                DrivingLicenseId = Guid.NewGuid(),
                LicenseNumber = createLicense.LicenseNumber,
                IssueDate = createLicense.IssueDate,
                Verified = false,
                ExpiryDate = createLicense.ExpiryDate,
                UserId = createLicense.UserId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            _repositoryManager.DrivingLicenseRepository.Add(modelLicense);
            await _repositoryManager.SaveAsync();
            var result = _mapper.Map<CreateDrivingLicenseRequest>(modelLicense);
            return result;
        }

        public async Task<bool> DeleteDrivingLisence(Guid lisenceId)
        {
            var drivingLisence = await _repositoryManager.DrivingLicenseRepository.GetByIdAsync(lisenceId);
            if (drivingLisence == null)
            {
                throw new Exception($"Driving Lisence with ID '{drivingLisence}' does not exist.");
            }
            _repositoryManager.DrivingLicenseRepository.Remove(drivingLisence);
            await _repositoryManager.SaveAsync();
            return true;

        }

        public async Task<PageResult<DrivingLicenseRespone>> GetAllCitizenAsync(int page, int limit)
        {
            var listdrivinglicense = await _repositoryManager.DrivingLicenseRepository.GetAlldrvingLicenseAsync(page, limit);
            var totalItems = listdrivinglicense.Count();
            var drivinglisenceRespone = listdrivinglicense.Select(x => new DrivingLicenseRespone
            {
                DrivingLicenseId = x.DrivingLicenseId,
                CreatedAt = DateTime.Now,
                CreatedBy = x.CreatedBy,
                ExpiryDate = x.ExpiryDate,
                IssueDate = x.IssueDate,
                LicenseNumber = x.LicenseNumber,
                UpdatedAt = DateTime.Now,
                UpdatedBy = x.UpdatedBy,
                UserId = x.UserId,
                Verified = x.Verified,

            });
            return new PageResult<DrivingLicenseRespone>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = drivinglisenceRespone
            };
        }

        public async Task<DrivingLicenseRespone> GetDrivingLicenseById(Guid licenseId)
        {
            var license = await _repositoryManager.DrivingLicenseRepository.GetByIdAsync(licenseId);
            return _mapper.Map<DrivingLicenseRespone>(license);
        }

        public async Task<DrivingLicenseRespone> GetDrivingLicenseUserId(Guid userId)
        {
            var license = await _repositoryManager.DrivingLicenseRepository.GetDrivingLicenseUserId(userId);
            // if (license == null)
            // {
            //     throw new Exception("User not found.");
            // }
            return _mapper.Map<DrivingLicenseRespone>(license);
        }

        public async Task<bool> UpdateDrivingLicense(Guid lisenceId, UpdateDrivingLicenseRequest drivingLicenseRequest)
        {
            var updateLicense = await _repositoryManager.DrivingLicenseRepository.GetByIdAsync(lisenceId);
            if (updateLicense == null)
            {
                throw new Exception($"DrivingLisence with ID '{lisenceId}' does not exist.");
            }

            // check verify
            if (updateLicense.Verified == true)
            {
                updateLicense.Verified = false;
            }

            var createLicense = _mapper.Map<DrivingLicense>(drivingLicenseRequest);

            if (!string.IsNullOrEmpty(drivingLicenseRequest.LicenseNumber) && drivingLicenseRequest.LicenseNumber != updateLicense.LicenseNumber)
            {
                // check length of LicenseNumber
                if (drivingLicenseRequest.LicenseNumber.Length != 12 || !drivingLicenseRequest.LicenseNumber.All(char.IsDigit))
                {
                    throw new Exception("Invalid license number. It must be 12 digits.");
                }
                // check license duplicate
                var existingLicense = await _repositoryManager.DrivingLicenseRepository.CheckLisenceNumber(drivingLicenseRequest.LicenseNumber, lisenceId);
                if (existingLicense != null)
                {
                    throw new Exception("License number already exists.");
                }
                updateLicense.LicenseNumber = drivingLicenseRequest.LicenseNumber;
            }            
            
            updateLicense.IssueDate = drivingLicenseRequest.IssueDate;
            updateLicense.ExpiryDate = drivingLicenseRequest.ExpiryDate;
            updateLicense.UpdatedAt = DateTime.Now;

            _repositoryManager.DrivingLicenseRepository.Update(updateLicense);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<bool> VeryfyDrivingLisence(Guid lisenceId)
        {
            var existingDrivingLisence = await _repositoryManager.DrivingLicenseRepository.GetByIdAsync(lisenceId);
            if (existingDrivingLisence == null)
            {
                throw new Exception("Driving license not found.");
            }
            if (existingDrivingLisence.Verified == true)
            {
                throw new Exception("Driving license is already verified.");
            }
            existingDrivingLisence.Verified = true;
            await _repositoryManager.SaveAsync();
            return true;
        }
    }
}
