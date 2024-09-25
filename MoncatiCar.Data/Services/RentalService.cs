using AutoMapper;
using Microsoft.AspNetCore.Identity;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.SeedWorks.Enums;
using MocatiCar.Core.Services;

namespace MoncatiCar.Data.Services
{
    public class RentalService : IRentalService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        private readonly IContactService _contactService;
        public RentalService(IRepositoryManager repositoryManager, IMapper mapper, UserManager<AppUser> userManager, IContactService contactService)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _userManager = userManager;
            _contactService = contactService;
        }

        public async Task<bool> ChangeRentalStatusAsync(Guid id)
        {
            var rental = await _repositoryManager.RentalRepository.GetByIdAsync(id);
            if (rental == null)
            {
                return false;
            }
            if (rental.RentalStatus == RentalStatus.Completed && rental.EndDateTime < DateTime.Now)
            {
                rental.RentalStatus = RentalStatus.Overdue;
            }
            Console.WriteLine($"Current rental status: {rental.RentalStatus}");

            switch (rental.RentalStatus)
            {
                case RentalStatus.Pending:
                    rental.RentalStatus = RentalStatus.Confirmed;
                    break;
                case RentalStatus.Confirmed:
                    rental.RentalStatus = RentalStatus.Active;
                    break;
                case RentalStatus.Active:
                    rental.RentalStatus = RentalStatus.Completed;
                    break;
                case RentalStatus.Completed:
                    throw new Exception("Cannot update status from 'Completed'.");
                case RentalStatus.Cancelled:
                case RentalStatus.Overdue:
                    throw new Exception("Cannot update status from the 'Cancel'.");
                default:
                    throw new Exception("Invalid status.");
            }

            _repositoryManager.RentalRepository.Update(rental);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<bool> ChangeRentalStatusToCancelAsync(Guid id)
        {
            var rental = await _repositoryManager.RentalRepository.GetRentalByIdAsync(id);
            if (rental == null)
            {
                return false;
            }
            // Kiểm tra nếu EndDayTime đã qua và trạng thái hiện tại là Active
            if (rental.RentalStatus == RentalStatus.Active && rental.EndDateTime < DateTime.Now)
            {
                rental.RentalStatus = RentalStatus.Overdue;
            }
            else
            {
                // Nếu không bị Overdue, cập nhật thành Cancelled
                rental.RentalStatus = RentalStatus.Cancelled;
            }

            rental.UpdatedAt = DateTime.Now;
            _repositoryManager.RentalRepository.Update(rental);
            await _repositoryManager.SaveAsync();
            return true;

        }

        public async Task<CreateRentalResponse> CreateRental(CreateRentalRequest rentalRequest)
        {

            var create = new Rental()
            {
                CarId = rentalRequest.CarId,
                OwnerId = rentalRequest.OwnerId,
                CustomerId = rentalRequest.CustomerId,
                StartDateTime = rentalRequest.StartDateTime,
                EndDateTime = rentalRequest.EndDateTime,
                PickupLocation = rentalRequest.PickupLocation,
                ReturnLocation = rentalRequest.ReturnLocation,
                Note = rentalRequest.Note,
                RentalAmount = rentalRequest.RentalAmount,
                InsuranceAmount = rentalRequest.InsuranceAmount,
                DepositAmount = rentalRequest.DepositAmount,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            create.RemainAmount = create.DepositAmount - (create.RentalAmount + create.InsuranceAmount);
            create.CommissionAmount = create.RentalAmount * 15 / 100;
            _repositoryManager.RentalRepository.Add(create);

            //add contact
            var owner = await _repositoryManager.UserRepository.GetByIdAsync((Guid)rentalRequest.OwnerId);
            var customer = await _repositoryManager.UserRepository.GetByIdAsync((Guid)rentalRequest.CustomerId);
            var replacements = new Dictionary<string, string>
            {
                {"{ownerName}", owner.FullName },
                {"{ownerIdnumber}", null },
                {"{ownerAddress}", null },
                {"{ownerPhoneNumber}", owner.PhoneNumber },
                {"{customerName}",  customer.FullName},
                {"{customerAddress}", null },
                {"{customerIdnumber}", null },
                {"{customerPhoneNumber}", customer.PhoneNumber },
                {"{citizenProvideDay}", null },
                {"{citzenProvideDay}", null },
                {"{driveLicense}", null },
                {"{driveProvideDay}", null },

            };
            string templateFilePath = "C:/Users/Admin/Desktop/Moncati/Moncati-Contract-Rental.docx";
            string tempFilePath = Path.Combine("C:/Users/Admin/Desktop/Moncati/", $"{create.RentalId}.docx");
            System.IO.File.Copy(templateFilePath, tempFilePath, true);

            _contactService.InsertDataInFile(tempFilePath, replacements);

            var pdfBytes = _contactService.ConverDocxToPdf(tempFilePath);
            //System.IO.File.Delete(tempFilePath);

            await _repositoryManager.SaveAsync();
            //var result = _mapper.Map<CreateRentalRequest>(create);

            return new CreateRentalResponse
            {
                FileReturn = pdfBytes,
                rentalId = create.RentalId
            };
        }

        public async Task<bool> DeleteRental(Guid id)
        {
            var rentalId = await _repositoryManager.RentalRepository.GetRentalByIdAsync(id);
            if (rentalId == null)
            {
                throw new Exception("Rental not found.");
            }
            _repositoryManager.RentalRepository.Remove(rentalId);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<PageResult<RentalRespone>> GetAllRentalsAsync(int page, int limit, RentalStatus? filter, DateTime? startDate, DateTime? endDate)
        {
            var listrental = await _repositoryManager.RentalRepository.GetAllRentalAsync(page, limit, filter, startDate, endDate);
            var totalItems = await _repositoryManager.RentalRepository.CountRecord();

            var rentalResponses = listrental.Select(x => new RentalRespone
            {
                RentalId = x.RentalId,
                CarName = $"{x.Car?.Model?.Brand?.BrandName} {x.Car?.Model?.ModelName} {x.Car?.year}",
                CarPlate = x.Car?.licensePlate,
                CarImage = x.Car?.Images?.OrderBy(i => i.ImageId).Select(i => i.Url).FirstOrDefault(),
                OwnerName = x.Owner?.FullName,
                OnwerPhone = x.Owner?.PhoneNumber,
                CustomerName = x.Customer?.FullName,
                CustomerPhone = x.Customer?.PhoneNumber,
                CarId = x.Car?.CarId,
                CommissionAmount = x.CommissionAmount,
                CreatedAt = x.CreatedAt ?? DateTime.Now,
                CreatedBy = x.CreatedBy,
                CustomerId = x.Customer?.Id,
                DepositAmount = x.DepositAmount,
                EndDateTime = x.EndDateTime,
                StartDateTime = x.StartDateTime,
                InsuranceAmount = x.InsuranceAmount,
                Note = x.Note,
                OwnerId = x.Owner?.Id,
                PickupLocation = x.PickupLocation,
                RentalAmount = x.RentalAmount,
                RentalStatus = x.RentalStatus,
                ReturnLocation = x.ReturnLocation,
                RemainAmount = x.RemainAmount,
                UpdatedAt = x.UpdatedAt ?? DateTime.Now,
                UpdatedBy = x.UpdatedBy,

            });

            return new PageResult<RentalRespone>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = rentalResponses
            };
        }

        public async Task<PageResult<RentalResponseForGetById>> GetRentalByCarId(Guid id, int page, int limit, RentalStatus? filter, DateTime? startDate, DateTime? endDate)
        {
            var carId = await _repositoryManager.RentalRepository.GetRentalByCarId(id, page, limit, filter, startDate, endDate);
            var totalItems = await _repositoryManager.RentalRepository.CountRecord();

            if (carId == null)
            {
                return null;
            }
            var rentalrespone = carId.Select(x => new RentalResponseForGetById
            {
                RentalId = x.RentalId,
                CarName = $"{x.Car?.Model?.Brand?.BrandName} {x.Car?.Model?.ModelName} {x.Car?.year}",
                CarPlate = x.Car?.licensePlate,
                CarImage = x.Car?.Images?.OrderBy(i => i.ImageId).Select(i => i.Url).FirstOrDefault(),
                OwnerName = x.Owner?.FullName,
                OnwerPhone = x.Owner?.PhoneNumber,
                CustomerName = x.Customer?.FullName,
                CustomerPhone = x.Customer?.PhoneNumber,
                CarId = x.Car?.CarId,
                CommissionAmount = x.CommissionAmount,
                CreatedAt = x.CreatedAt ?? DateTime.Now,
                CreatedBy = x.CreatedBy,
                CustomerId = x.Customer?.Id,
                DepositAmount = x.DepositAmount,
                EndDateTime = x.EndDateTime,
                StartDateTime = x.StartDateTime,
                InsuranceAmount = x.InsuranceAmount,
                Note = x.Note,
                OwnerId = x.Owner?.Id,
                PickupLocation = x.PickupLocation,
                RentalAmount = x.RentalAmount,
                RentalStatus = x.RentalStatus,
                ReturnLocation = x.ReturnLocation,
                RemainAmount = x.RemainAmount,
                UpdatedAt = x.UpdatedAt ?? DateTime.Now,
                UpdatedBy = x.UpdatedBy,
            });
            return new PageResult<RentalResponseForGetById>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = rentalrespone
            };
        }

        public async Task<RentalRespone> GetRentalById(Guid id)
        {
            // Lấy rental từ repository
            var rental = await _repositoryManager.RentalRepository.GetRentalByIdAsync(id);
            if (rental == null)
            {
                throw new Exception("Rental not found.");
            }

            var rentalResponse = new RentalRespone
            {
                RentalId = rental.RentalId,
                CarName = $"{rental.Car?.Model?.Brand?.BrandName} {rental.Car?.Model?.ModelName} {rental.Car?.year}",
                CarPlate = rental.Car?.licensePlate,
                CarImage = rental.Car?.Images?.OrderBy(i => i.ImageId).Select(i => i.Url).FirstOrDefault(),
                OwnerName = rental.Owner?.FullName,
                OnwerPhone = rental.Owner?.PhoneNumber,
                CustomerName = rental.Customer?.FullName,
                CustomerPhone = rental.Customer?.PhoneNumber,
                CarId = rental.Car?.CarId,
                CommissionAmount = rental.CommissionAmount,
                CreatedAt = rental.CreatedAt ?? DateTime.Now,
                CreatedBy = rental.CreatedBy,
                CustomerId = rental.Customer?.Id,
                DepositAmount = rental.DepositAmount,
                EndDateTime = rental.EndDateTime,
                StartDateTime = rental.StartDateTime,
                InsuranceAmount = rental.InsuranceAmount,
                Note = rental.Note,
                OwnerId = rental.Owner?.Id,
                PickupLocation = rental.PickupLocation,
                RentalAmount = rental.RentalAmount,
                RentalStatus = rental.RentalStatus,
                ReturnLocation = rental.ReturnLocation,
                RemainAmount = rental.RemainAmount,
                UpdatedAt = rental.UpdatedAt ?? DateTime.Now,
                UpdatedBy = rental.UpdatedBy,

            };
            return rentalResponse;
        }

        public async Task<PageResult<RentalResponseForGetById>> getRentalByOwnerId(Guid id, int page, int limit, RentalStatus? filter, DateTime? startDate, DateTime? endDate)
        {
            var users = await _repositoryManager.RentalRepository.GetRentalByOwnerId(id, page, limit, filter, startDate, endDate);
            if (users == null)
            {
                //throw new Exception("Owner or Customer not found.");
                return null;
            }
            var totalItems = await _repositoryManager.RentalRepository.CountRecord();
            var rentalrespone = users.Select(x => new RentalResponseForGetById
            {
                RentalId = x.RentalId,
                CarName = $"{x.Car?.Model?.Brand?.BrandName} {x.Car?.Model?.ModelName} {x.Car?.year}",
                CarPlate = x.Car?.licensePlate,
                CarImage = x.Car?.Images?.OrderBy(i => i.ImageId).Select(i => i.Url).FirstOrDefault(),
                OwnerName = x.Owner?.FullName,
                OnwerPhone = x.Owner?.PhoneNumber,
                CustomerName = x.Customer?.FullName,
                CustomerPhone = x.Customer?.PhoneNumber,
                CarId = x.Car?.CarId,
                CommissionAmount = x.CommissionAmount,
                CreatedAt = x.CreatedAt ?? DateTime.Now,
                CreatedBy = x.CreatedBy,
                CustomerId = x.Customer?.Id,
                DepositAmount = x.DepositAmount,
                EndDateTime = x.EndDateTime,
                StartDateTime = x.StartDateTime,
                InsuranceAmount = x.InsuranceAmount,
                Note = x.Note,
                OwnerId = x.Owner?.Id,
                PickupLocation = x.PickupLocation,
                RentalAmount = x.RentalAmount,
                RentalStatus = x.RentalStatus,
                ReturnLocation = x.ReturnLocation,
                RemainAmount = x.RemainAmount,
                UpdatedAt = x.UpdatedAt ?? DateTime.Now,
                UpdatedBy = x.UpdatedBy,
            });
            //     var rentalreponse = _mapper.Map<IEnumerable<RentalResponseForGetById>>(users);
            return new PageResult<RentalResponseForGetById>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = rentalrespone
            };
        }

        public async Task<PageResult<RentalResponseForGetById>> GetRentalByUserId(Guid id, int page, int limit, RentalStatus? filter, DateTime? startDate, DateTime? endDate)
        {
            var users = await _repositoryManager.RentalRepository.GetRentalByUserId(id, page, limit, filter, startDate, endDate);
            if (users == null)
            {
                //throw new Exception("Owner or Customer not found.");
                return null;
            }
            var totalItems = await _repositoryManager.RentalRepository.CountRecord();
            var rentalrespone = users.Select(x => new RentalResponseForGetById
            {
                RentalId = x.RentalId,
                CarName = $"{x.Car?.Model?.Brand?.BrandName} {x.Car?.Model?.ModelName} {x.Car?.year}",
                CarPlate = x.Car?.licensePlate,
                CarImage = x.Car?.Images?.OrderBy(i => i.ImageId).Select(i => i.Url).FirstOrDefault(),
                OwnerName = x.Owner?.FullName,
                OnwerPhone = x.Owner?.PhoneNumber,
                CustomerName = x.Customer?.FullName,
                CustomerPhone = x.Customer?.PhoneNumber,
                CarId = x.Car?.CarId,
                CommissionAmount = x.CommissionAmount,
                CreatedAt = x.CreatedAt ?? DateTime.Now,
                CreatedBy = x.CreatedBy,
                CustomerId = x.Customer?.Id,
                DepositAmount = x.DepositAmount,
                EndDateTime = x.EndDateTime,
                StartDateTime = x.StartDateTime,
                InsuranceAmount = x.InsuranceAmount,
                Note = x.Note,
                OwnerId = x.Owner?.Id,
                PickupLocation = x.PickupLocation,
                RentalAmount = x.RentalAmount,
                RentalStatus = x.RentalStatus,
                ReturnLocation = x.ReturnLocation,
                RemainAmount = x.RemainAmount,
                UpdatedAt = x.UpdatedAt ?? DateTime.Now,
                UpdatedBy = x.UpdatedBy,
            });
            return new PageResult<RentalResponseForGetById>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = rentalrespone
            };
        }

        public async Task<bool> UpdateEndTimeRentalAsync(Guid id)
        {
            var query = await _repositoryManager.RentalRepository.GetByIdAsync(id);
            if (query == null)
            {
                return false;
            }
            query.EndDateTime = DateTime.Now;
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<bool> UpdateRentalAsync(Guid id, UpdateRentalRequest update)
        {
            var updateRental = await _repositoryManager.RentalRepository.GetRentalByIdAsync(id);
            if (updateRental == null)
            {
                return false;
            }
            updateRental.PickupLocation = update.PickupLocation;
            updateRental.ReturnLocation = update.ReturnLocation;
            updateRental.Note = update.Note;
            updateRental.RentalAmount = update.RentalAmount;
            updateRental.InsuranceAmount = update.InsuranceAmount;
            updateRental.DepositAmount = update.DepositAmount;
            updateRental.RemainAmount = update.DepositAmount - update.RentalAmount + update.InsuranceAmount;
            updateRental.CommissionAmount = update.RentalAmount * 20 / 100;
            _repositoryManager.RentalRepository.Update(updateRental);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<bool> UpdateStartTimeRentalAsync(Guid id)
        {
            var query = await _repositoryManager.RentalRepository.GetRentalByIdAsync(id);
            if (query == null)
            {
                return false;
            }
            query.StartDateTime = DateTime.Now;
            await _repositoryManager.SaveAsync();
            return true;
        }
    }
}
