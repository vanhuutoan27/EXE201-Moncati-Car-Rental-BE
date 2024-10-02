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
        private readonly IFireBaseService _firebaseService;
        private readonly IContactService contactService;
        public RentalService(IRepositoryManager repositoryManager, IMapper mapper, UserManager<AppUser> userManager, IFireBaseService fireBaseService, IContactService contactService)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _userManager = userManager;
            _firebaseService = fireBaseService;
            this.contactService = contactService;
        }

        public async Task<bool> ChangeRentalStatusAsync(Guid id)
        {
            var rental = await _repositoryManager.RentalRepository.GetByIdAsync(id);
            if (rental == null)
            {
                return false;
            }

            // Lấy thông tin xe liên quan tới rental
            var car = await _repositoryManager.CarRepository.GetByIdAsync(rental.CarId.Value);
            if (car == null)
            {
                throw new Exception("Car not found.");
            }

            // Kiểm tra điều kiện nếu rental đã hoàn thành và quá hạn
            if (rental.RentalStatus == RentalStatus.Completed && rental.EndDateTime < DateTime.Now)
            {
                rental.RentalStatus = RentalStatus.Overdue;
            }

            Console.WriteLine($"Current rental status: {rental.RentalStatus}");

            // Thay đổi trạng thái RentalStatus và đồng thời cập nhật trạng thái CarRentalStatus
            switch (rental.RentalStatus)
            {
                case RentalStatus.Pending:
                    rental.RentalStatus = RentalStatus.Confirmed;
                    car.RentalStatus = CarRentalStatus.Rented; // Xe đã được xác nhận và đang được thuê
                    break;
                case RentalStatus.Confirmed:
                    rental.RentalStatus = RentalStatus.Active;
                    car.RentalStatus = CarRentalStatus.Rented; // Xe đã bắt đầu được thuê
                    break;
                case RentalStatus.Active:
                    rental.RentalStatus = RentalStatus.Completed;
                    car.RentalStatus = CarRentalStatus.Available; // Sau khi hoàn tất, xe sẵn sàng cho thuê lại
                    break;
                case RentalStatus.Completed:
                    throw new Exception("Cannot update status from 'Completed'.");
                case RentalStatus.Cancelled:
                case RentalStatus.Overdue:
                    car.RentalStatus = CarRentalStatus.Available; // Xe có thể được cho thuê lại nếu bị hủy hoặc quá hạn
                    throw new Exception("Cannot update status from 'Cancelled' or 'Overdue'.");
                default:
                    throw new Exception("Invalid status.");
            }

            // Cập nhật trạng thái của Rental và Car trong repository
            _repositoryManager.RentalRepository.Update(rental);
            _repositoryManager.CarRepository.Update(car);

            // Lưu thay đổi vào database
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
            if (rental.RentalStatus == RentalStatus.Completed)
            {
                throw new Exception("Cannot update status because rental is already completed.");
            }
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

        public async Task<CreateRentalRequest> CreateRental(CreateRentalRequest rentalRequest)
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
                // RentalAmount = rentalRequest.RentalAmount,
                // InsuranceAmount = rentalRequest.InsuranceAmount,
                // DepositAmount = rentalRequest.DepositAmount,
                BasePricePerDay = rentalRequest.BasePricePerDay,
                TotalDaysRented = rentalRequest.TotalDaysRented,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            _repositoryManager.RentalRepository.Add(create);




            //add contact
            var owner = await _repositoryManager.UserRepository.GetUserById((Guid)rentalRequest.OwnerId);
            var customer = await _repositoryManager.UserRepository.GetUserById((Guid)rentalRequest.CustomerId);
            var car = await _repositoryManager.CarRepository.GetCarByCarId((Guid)rentalRequest.CarId);
            var carName = $"{car.Model.Brand.BrandName} {car.Model.ModelName} {car.year}";
            decimal? carPrice = car.PricePerDay + ((car.PricePerDay * 15) / 100);
            string carPriceString = carPrice?.ToString("F2") ?? string.Empty;  // Format with 2 decimal places or use empty string if null

            var replacements = new Dictionary<string, string>
{
                 {"{ownerName}", owner?.FullName ?? string.Empty },  // Check if owner is null and return empty string if so
                 {"{ownerGender}", owner?.CitizenId?.Gender ?? string.Empty },  // Check if owner or CitizenId is null
                 {"{ownerIdNumber}", owner?.CitizenId?.IdNumber ?? string.Empty },  // Check if owner or CitizenId is null
                 {"{ownerCitizenIssue}", owner?.CitizenId?.IssueDate.ToString("yyyy-MM-dd") ?? string.Empty },  // Check if owner or CitizenId is null and format IssueDate
                 {"{ownerAddress}", owner?.CitizenId?.Address ?? string.Empty },  // Check if owner or CitizenId is null
                 {"{ownerPhoneNumber}", owner?.PhoneNumber ?? string.Empty },  // Check if owner is null

                 {"{customerName}", customer?.FullName ?? string.Empty },  // Check if customer is null
    {"{customerGender}", customer?.CitizenId?.Gender ?? string.Empty },  // Check if customer or CitizenId is null
    {"{customerAddress}", customer?.CitizenId?.Address ?? string.Empty },  // Check if customer or CitizenId is null
    {"{customerPhoneNumber}", customer?.PhoneNumber ?? string.Empty },  // Check if customer is null
    {"{customerIdNumber}", customer?.CitizenId?.IdNumber ?? string.Empty },  // Check if customer or CitizenId is null
    {"{customerCitizenIssue}", customer?.CitizenId?.IssueDate.ToString("yyyy-MM-dd") ?? string.Empty },  // Check if customer or CitizenId is null

    {"{customerLicenseId}", customer?.DrivingLicenses?.LicenseNumber ?? string.Empty },  // Check if customer or DrivingLicenses is null
    {"{customerLicenseIssue}", customer?.DrivingLicenses?.IssueDate.ToString("yyyy-MM-dd") ?? string.Empty },  // Check if customer or DrivingLicenses is null and format IssueDate

    {"{carName}", carName ?? string.Empty },  // Assuming carName is a string variable already checked elsewhere
    {"{carPlate}", car?.licensePlate ?? string.Empty },  // Check if car is null
    {"{carPrice}", carPriceString},  // Assuming carPrice is a numeric variable already checked elsewhere

    // If you plan to include rentalRequest and totalAmount, make sure to handle them as well:
    // {"{rentalAmount}", rentalRequest?.RentalAmount?.ToString() ?? string.Empty },  // Check if rentalRequest is null
    // {"{totalAmount}", customer?.DrivingLicenses?.IssueDate?.ToString("yyyy-MM-dd") ?? string.Empty }  // Check if customer or DrivingLicenses is null and format IssueDate
};



            //fire base 
            string fileName = "MONCATI-CAR-RENTAL-CONTRACT.docx";
            // Step 1: Download the DOCX template from Firebase
            var memory = await _firebaseService.DownloadDocxTemplateFromFirebase(fileName);

            // Step 2: Add user info to the DOCX (ensure changes are applied)
            _firebaseService.AddUserInfoToDocx(memory, replacements);

            // Step 3: Reset the memory stream position before conversion
            memory.Seek(0, SeekOrigin.Begin); // Ensure we're at the start of the modified DOCX
            using (FileStream fs = new FileStream("ModifiedContract.docx", FileMode.Create, FileAccess.Write))
            {
                memory.CopyTo(fs);
            }
            // Step 4: Convert the modified DOCX to PDF
            var pdfStream = _firebaseService.ConvertDocxToPdf(memory);

            // Step 5: Upload the converted PDF to Firebase
            string fileNameUpload = $"{create.RentalId}.pdf";
            string uploadPdfUrl = await _firebaseService.UploadPdfToFirebase(pdfStream, fileNameUpload);

            //create contract
            var contractRequest = new CreateContractRequest()
            {
                RentalId = create.RentalId,
                Attachment = uploadPdfUrl,

            };
            await contactService.CreateContract(contractRequest);




            await _repositoryManager.SaveAsync();
            var result = _mapper.Map<CreateRentalRequest>(create);
            return result;


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

            var rentalResponses = listrental.Select(rental => new RentalRespone
            {
                RentalId = rental.RentalId,
                CarName = $"{rental.Car?.Model?.Brand?.BrandName} {rental.Car?.Model?.ModelName} {rental.Car?.year}",
                CarPlate = rental.Car?.licensePlate,
                CarImage = rental.Car?.Images?.OrderBy(i => i.ImageId).Select(i => i.Url).FirstOrDefault(),
                OwnerName = rental.Owner?.FullName,
                OwnerPhone = rental.Owner?.PhoneNumber,
                CustomerName = rental.Customer?.FullName,
                CustomerPhone = rental.Customer?.PhoneNumber,
                CarId = rental.Car?.CarId,
                CreatedAt = rental.CreatedAt ?? DateTime.Now,
                CreatedBy = rental.CreatedBy,
                CustomerId = rental.Customer?.Id,
                EndDateTime = rental.EndDateTime,
                StartDateTime = rental.StartDateTime,
                Note = rental.Note,
                OwnerId = rental.Owner?.Id,
                PickupLocation = rental.PickupLocation,
                RentalStatus = rental.RentalStatus,
                ReturnLocation = rental.ReturnLocation,
                UpdatedAt = rental.UpdatedAt ?? DateTime.Now,
                UpdatedBy = rental.UpdatedBy,
                BasePricePerDay = rental.BasePricePerDay,
                CommissionPercentage = 15,
                CommissionAmount = rental.BasePricePerDay * 15 / 100,
                TotalPricePerDay = rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100,
                DepositPercentage = 20,
                DepositAmount = (rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * 20,
                TotalDaysRented = rental.TotalDaysRented,
                TotalRentalAmount = (rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * rental.TotalDaysRented,
                InsuranceFee = 60000,
                FinalRentalAmount = (rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * rental.TotalDaysRented + 60000,
                RemainingDepositAmount = ((rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * 20) - ((rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * rental.TotalDaysRented + 60000)

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
            var rentalrespone = carId.Select(rental => new RentalResponseForGetById
            {
                RentalId = rental.RentalId,
                CarName = $"{rental.Car?.Model?.Brand?.BrandName} {rental.Car?.Model?.ModelName} {rental.Car?.year}",
                CarPlate = rental.Car?.licensePlate,
                CarImage = rental.Car?.Images?.OrderBy(i => i.ImageId).Select(i => i.Url).FirstOrDefault(),
                OwnerName = rental.Owner?.FullName,
                OwnerPhone = rental.Owner?.PhoneNumber,
                CustomerName = rental.Customer?.FullName,
                CustomerPhone = rental.Customer?.PhoneNumber,
                CarId = rental.Car?.CarId,
                CreatedAt = rental.CreatedAt ?? DateTime.Now,
                CreatedBy = rental.CreatedBy,
                CustomerId = rental.Customer?.Id,
                EndDateTime = rental.EndDateTime,
                StartDateTime = rental.StartDateTime,
                Note = rental.Note,
                OwnerId = rental.Owner?.Id,
                PickupLocation = rental.PickupLocation,
                RentalStatus = rental.RentalStatus,
                ReturnLocation = rental.ReturnLocation,
                UpdatedAt = rental.UpdatedAt ?? DateTime.Now,
                UpdatedBy = rental.UpdatedBy,
                BasePricePerDay = rental.BasePricePerDay,
                CommissionPercentage = 15,
                CommissionAmount = rental.BasePricePerDay * 15 / 100,
                TotalPricePerDay = rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100,
                DepositPercentage = 20,
                DepositAmount = (rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * 20,
                TotalDaysRented = rental.TotalDaysRented,
                TotalRentalAmount = (rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * rental.TotalDaysRented,
                InsuranceFee = 60000,
                FinalRentalAmount = (rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * rental.TotalDaysRented + 60000,
                RemainingDepositAmount = ((rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * 20) - ((rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * rental.TotalDaysRented + 60000)
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
                OwnerPhone = rental.Owner?.PhoneNumber,
                CustomerName = rental.Customer?.FullName,
                CustomerPhone = rental.Customer?.PhoneNumber,
                CarId = rental.Car?.CarId,
                CreatedAt = rental.CreatedAt ?? DateTime.Now,
                CreatedBy = rental.CreatedBy,
                CustomerId = rental.Customer?.Id,
                EndDateTime = rental.EndDateTime,
                StartDateTime = rental.StartDateTime,
                Note = rental.Note,
                OwnerId = rental.Owner?.Id,
                PickupLocation = rental.PickupLocation,
                RentalStatus = rental.RentalStatus,
                ReturnLocation = rental.ReturnLocation,
                UpdatedAt = rental.UpdatedAt ?? DateTime.Now,
                UpdatedBy = rental.UpdatedBy,
                BasePricePerDay = rental.BasePricePerDay,
                CommissionPercentage = 15,
                CommissionAmount = rental.BasePricePerDay * 15 / 100,
                TotalPricePerDay = rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100,
                DepositPercentage = 20,
                DepositAmount = (rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * 20,
                TotalDaysRented = rental.TotalDaysRented,
                TotalRentalAmount = (rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * rental.TotalDaysRented,
                InsuranceFee = 60000,
                FinalRentalAmount = (rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * rental.TotalDaysRented + 60000,
                RemainingDepositAmount = ((rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * 20) - ((rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * rental.TotalDaysRented + 60000)
            };

            return rentalResponse;
        }

        public async Task<PageResult<RentalResponseForGetById>> GetRentalByCustomerId(Guid id, int page, int limit, RentalStatus? filter, DateTime? startDate, DateTime? endDate)
        {
            var users = await _repositoryManager.RentalRepository.GetRentalByUserId(id, page, limit, filter, startDate, endDate);
            if (users == null)
            {
                //throw new Exception("Owner or Customer not found.");
                return null;
            }
            var totalItems = await _repositoryManager.RentalRepository.CountRecord();
            var rentalrespone = users.Select(rental => new RentalResponseForGetById
            {
                RentalId = rental.RentalId,
                CarName = $"{rental.Car?.Model?.Brand?.BrandName} {rental.Car?.Model?.ModelName} {rental.Car?.year}",
                CarPlate = rental.Car?.licensePlate,
                CarImage = rental.Car?.Images?.OrderBy(i => i.ImageId).Select(i => i.Url).FirstOrDefault(),
                OwnerName = rental.Owner?.FullName,
                OwnerPhone = rental.Owner?.PhoneNumber,
                CustomerName = rental.Customer?.FullName,
                CustomerPhone = rental.Customer?.PhoneNumber,
                CarId = rental.Car?.CarId,
                CreatedAt = rental.CreatedAt ?? DateTime.Now,
                CreatedBy = rental.CreatedBy,
                CustomerId = rental.Customer?.Id,
                EndDateTime = rental.EndDateTime,
                StartDateTime = rental.StartDateTime,
                Note = rental.Note,
                OwnerId = rental.Owner?.Id,
                PickupLocation = rental.PickupLocation,
                RentalStatus = rental.RentalStatus,
                ReturnLocation = rental.ReturnLocation,
                UpdatedAt = rental.UpdatedAt ?? DateTime.Now,
                UpdatedBy = rental.UpdatedBy,
                BasePricePerDay = rental.BasePricePerDay,
                CommissionPercentage = 15,
                CommissionAmount = rental.BasePricePerDay * 15 / 100,
                TotalPricePerDay = rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100,
                DepositPercentage = 20,
                DepositAmount = (rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * 20,
                TotalDaysRented = rental.TotalDaysRented,
                TotalRentalAmount = (rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * rental.TotalDaysRented,
                InsuranceFee = 60000,
                FinalRentalAmount = (rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * rental.TotalDaysRented + 60000,
                RemainingDepositAmount = ((rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * 20) - ((rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * rental.TotalDaysRented + 60000)
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
            updateRental.BasePricePerDay = update.BasePricePerDay;
            updateRental.TotalDaysRented = update.TotalDaysRented;
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

        public async Task<PageResult<RentalResponseForGetById>> GetRentalByOwnerId(Guid id, int page, int limit, RentalStatus? filter, DateTime? startDate, DateTime? endDate)
        {
            var users = await _repositoryManager.RentalRepository.GetRentalByOwnerId(id, page, limit, filter, startDate, endDate);
            if (users == null)
            {
                //throw new Exception("Owner or Customer not found.");
                return null;
            }
            var totalItems =  users.Count();
            var rentalrespone = users.Select(rental => new RentalResponseForGetById
            {
                RentalId = rental.RentalId,
                CarName = $"{rental.Car?.Model?.Brand?.BrandName} {rental.Car?.Model?.ModelName} {rental.Car?.year}",
                CarPlate = rental.Car?.licensePlate,
                CarImage = rental.Car?.Images?.OrderBy(i => i.ImageId).Select(i => i.Url).FirstOrDefault(),
                OwnerName = rental.Owner?.FullName,
                OwnerPhone = rental.Owner?.PhoneNumber,
                CustomerName = rental.Customer?.FullName,
                CustomerPhone = rental.Customer?.PhoneNumber,
                CarId = rental.Car?.CarId,
                CreatedAt = rental.CreatedAt ?? DateTime.Now,
                CreatedBy = rental.CreatedBy,
                CustomerId = rental.Customer?.Id,
                EndDateTime = rental.EndDateTime,
                StartDateTime = rental.StartDateTime,
                Note = rental.Note,
                OwnerId = rental.Owner?.Id,
                PickupLocation = rental.PickupLocation,
                RentalStatus = rental.RentalStatus,
                ReturnLocation = rental.ReturnLocation,
                UpdatedAt = rental.UpdatedAt ?? DateTime.Now,
                UpdatedBy = rental.UpdatedBy,
                BasePricePerDay = rental.BasePricePerDay,
                CommissionPercentage = 15,
                CommissionAmount = rental.BasePricePerDay * 15 / 100,
                TotalPricePerDay = rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100,
                DepositPercentage = 20,
                DepositAmount = (rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * 20,
                TotalDaysRented = rental.TotalDaysRented,
                TotalRentalAmount = (rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * rental.TotalDaysRented,
                InsuranceFee = 60000,
                FinalRentalAmount = (rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * rental.TotalDaysRented + 60000,
                RemainingDepositAmount = ((rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * 20) - ((rental.BasePricePerDay + rental.BasePricePerDay * 15 / 100) * rental.TotalDaysRented + 60000)
            });
            return new PageResult<RentalResponseForGetById>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = rentalrespone
            };
        }
    }
}
