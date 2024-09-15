using AutoMapper;
using Microsoft.AspNetCore.Identity;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.SeedWorks.Enums;
using MocatiCar.Core.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoncatiCar.Data.Services
{
    public class RentalService : IRentalService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        public RentalService(IRepositoryManager repositoryManager, IMapper mapper, UserManager<AppUser> userManager)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<bool> ChangeRentalStatusAsync(Guid id)
        {
            var rental = await _repositoryManager.RentalRepository.GetByIdAsync(id);
            if (rental == null)
            {
                return false;
            }
            if (rental.RentalStatus == RentalStatus.Completed &&  rental.EndDayTime < DateTime.Now)
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
                    throw new Exception("Cannot update status from the current state.");
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
            if (rental.RentalStatus == RentalStatus.Active && rental.EndDayTime < DateTime.Now)
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
                StartDayTime = rentalRequest.StartDayTime,
                EndDayTime = rentalRequest.EndDayTime,
                PickupLocation = rentalRequest.PickupLocation,
                ReturnLocation = rentalRequest.ReturnLocation,
                Note = rentalRequest.Note,
                RentalAmount = rentalRequest.RentalAmount,
                InsuranceAmount = rentalRequest.InsuranceAmount,
                DepositAmount = rentalRequest.DepositAmount,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            create.TotalAmount = create.DepositAmount - (create.RentalAmount + create.InsuranceAmount);
            create.CommissionAmount = create.RentalAmount * 20 / 100;
            _repositoryManager.RentalRepository.Add(create);
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

        public async Task<PageResult<RentalRespone>> GetAllRentalsAsync(int page, int limit, RentalStatus? filter)
        {
            var listrental = await _repositoryManager.RentalRepository.GetAllRentalAsync(page, limit, filter);
            var totalItems = listrental.Count();

            var rentalResponses = listrental.Select(x => new RentalRespone
            {
                CarId = x.Car?.CarId,
                CommissionAmount = x.CommissionAmount,
                CustomerId = x.Customer?.Id,
                CreatedAt = DateTime.Now,
                CreatedBy = x.CreatedBy,
                UpdatedAt = DateTime.Now,
                StartDayTime = x.StartDayTime,
                EndDayTime = x.EndDayTime,
                DepositAmount = x.DepositAmount,
                InsuranceAmount = x.InsuranceAmount,
                Note = x.Note,
                OwnerId = x.Owner?.Id,
                PickupLocation = x.PickupLocation,
                RentalAmount = x.RentalAmount,
                RentalId = x.RentalId,
                RentalStatus = x.RentalStatus,
                ReturnLocation = x.ReturnLocation,
                TotalAmount = x.TotalAmount,
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

        public async Task<IEnumerable<RentalRespone>> GetRentalByCarId(Guid id)
        {
            var carId = await _repositoryManager.RentalRepository.GetRentalByCarId(id);
            if (carId == null)
            {
                throw new Exception("Car not found.");

            }
            var rentalrespone = carId.Select(x => new RentalRespone
            {
                RentalId = x.RentalId,
                CarId = x.Car?.CarId,
                CommissionAmount = x.CommissionAmount,
                CreatedAt = DateTime.Now,
                CreatedBy = x.CreatedBy,
                EndDayTime = x.EndDayTime,
                CustomerId = x.Customer?.Id,
                DepositAmount = x.DepositAmount,
                InsuranceAmount = x.InsuranceAmount,
                Note = x.Note,
                OwnerId = x.Owner?.Id,
                PickupLocation = x.PickupLocation,
                RentalAmount = x.RentalAmount,
                RentalStatus = x.RentalStatus,
                ReturnLocation = x.ReturnLocation,
                StartDayTime = x.StartDayTime,
                TotalAmount = x.TotalAmount,
                UpdatedAt = DateTime.Now,
                UpdatedBy = x.UpdatedBy
            });
            return rentalrespone;
        }

        public async Task<RentalRespone> GetRentalById(Guid id)
        {
            var rental = await _repositoryManager.RentalRepository.GetRentalByIdAsync(id);
            if (rental == null)
            {
                throw new Exception("Rental not found.");
            }

            return new RentalRespone
            {
                RentalId = rental.RentalId,
                CarId = rental.Car?.CarId,
                CommissionAmount = rental.CommissionAmount,
                CreatedAt = rental.CreatedAt ?? DateTime.Now,
                CreatedBy = rental.CreatedBy,
                CustomerId = rental.Customer?.Id,
                DepositAmount = rental.DepositAmount,
                EndDayTime = rental.EndDayTime,
                StartDayTime = rental.StartDayTime,
                InsuranceAmount = rental.InsuranceAmount,
                Note = rental.Note,
                OwnerId = rental.Owner?.Id,
                PickupLocation = rental.PickupLocation,
                RentalAmount = rental.RentalAmount,
                RentalStatus = rental.RentalStatus,
                ReturnLocation = rental.ReturnLocation,
                TotalAmount = rental.TotalAmount,
                UpdatedAt = rental.UpdatedAt ?? DateTime.Now,
                UpdatedBy = rental.UpdatedBy,
            };
        }


        public async Task<IEnumerable<RentalRespone>> GetRentalByUserId(Guid id)
        {
            var users = await _repositoryManager.RentalRepository.GetRentalByUserId(id);
            if (users == null)
            {
                throw new Exception("Owner or Customer not found.");
            }
            var rentalrespone = users.Select(x => new RentalRespone
            {
                RentalId = x.RentalId,
                CarId = x.Car?.CarId,
                CommissionAmount = x.CommissionAmount,
                CreatedAt = DateTime.Now,
                CreatedBy = x.CreatedBy,
                EndDayTime = x.EndDayTime,
                CustomerId = x.Customer?.Id,
                DepositAmount = x.DepositAmount,
                InsuranceAmount = x.InsuranceAmount,
                Note = x.Note,
                OwnerId = x.Owner?.Id,
                PickupLocation = x.PickupLocation,
                RentalAmount = x.RentalAmount,
                RentalStatus = x.RentalStatus,
                ReturnLocation = x.ReturnLocation,
                StartDayTime = x.StartDayTime,
                TotalAmount = x.TotalAmount,
                UpdatedAt = DateTime.Now,
                UpdatedBy = x.UpdatedBy
            });
            return rentalrespone;
        }

        public async Task<bool> UpdateEndTimeRentalAsync(Guid id)
        {
            var query = await _repositoryManager.RentalRepository.GetByIdAsync(id);
            if (query == null)
            {
                return false;
            }
            query.EndDayTime = DateTime.Now;
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
            updateRental.TotalAmount = update.DepositAmount - (update.RentalAmount + update.InsuranceAmount);
            updateRental.CommissionAmount = update.RentalAmount * 20/100;
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
            query.StartDayTime = DateTime.Now;
            await _repositoryManager.SaveAsync();
            return true;
        }
    }
}
