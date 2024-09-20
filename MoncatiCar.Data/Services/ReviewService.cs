using AutoMapper;
using Microsoft.AspNetCore.Identity;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.Services;

namespace MoncatiCar.Data.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        public ReviewService(IRepositoryManager repositoryManager, IMapper mapper, UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public async Task<CreateUpdateReviewRequest> AddReview(CreateUpdateReviewRequest carRequest)
        {
            //check user was reviewed 
            var review = await _repositoryManager.ReviewRepository.HasReview(carRequest.Author, carRequest.CarId);
            if (review != null)
            {
                throw new Exception("You have reviewed this car.");
            }
            var model = new Review
            {
                CarId = carRequest.CarId,
                Author = carRequest.Author,
                Rating = carRequest.Rating,
                Content = carRequest.Content,
                Flag = false,
                RentalId = carRequest.RentalId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            _repositoryManager.ReviewRepository.Add(model);
            await _repositoryManager.SaveAsync();
            return _mapper.Map<CreateUpdateReviewRequest>(model);
        }

        public async Task<bool> ChangeFlagAsync(Guid id)
        {
            var review = await _repositoryManager.ReviewRepository.GetReviewId(id);
            if (review == null)
            {
                return false;
            }
            var check = review.Flag;
            if (check == true)
            {
                review.Flag = false;
            }
            else
            {
                review.Flag = true;
            }

            _repositoryManager.ReviewRepository.Update(review);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<bool> DeleteReview(Guid id)
        {
            Review review = await _repositoryManager.ReviewRepository.GetReviewId(id);
            if (review == null)
            {
                return false;
            }
            _repositoryManager.ReviewRepository.Remove(review);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<PageResult<ReviewRespone>> GetAllReviewAsync(int page, int limit, int star, bool? flag)
        {
            // Call the repository to get reviews
            var listreview = await _repositoryManager.ReviewRepository.GetAllReviewAsync(page, limit, star, flag);

            // Total items for pagination
            var totalItems = listreview.Count();

            // Map the reviews to the response model
            var reviewRespone = listreview.Select(x => new ReviewRespone
            {
                ReviewId = x.ReviewId,
                CarId = x.Car.CarId,
                Author = x.User.Id,
                Rating = x.Rating,
                Content = x.Content,
                Flag = x.Flag,
                RentalId = x.RentalId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            });

            // Return a paginated result
            return new PageResult<ReviewRespone>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = reviewRespone
            };
        }

        public async Task<PageResult<ReviewRespone>> GetAllReviewByUsername(string username, int page, int limit, bool? flag)
        {
            var reviewList = await _repositoryManager.ReviewRepository.GetAllReviewByUsername(username, page, limit, flag);
            var totalItems = reviewList.Count();
            var result = _mapper.Map<IEnumerable<ReviewRespone>>(reviewList);
            return new PageResult<ReviewRespone>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = result
            };
        }

        public async Task<PageResult<ReviewRespone>> GetReviewByCarId(Guid carId, int page, int limit, Boolean? flag)
        {
            var reviews = await _repositoryManager.ReviewRepository.GetReviewByCarId(carId, page, limit, flag);
            int totalItems = reviews.Count();
            if (reviews == null)

            {
                throw new KeyNotFoundException($"No reviews found.");
            }

            var result = _mapper.Map<IEnumerable<ReviewRespone>>(reviews);
            return new PageResult<ReviewRespone>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = result
            };
        }

        public async Task<ReviewRespone> GetReviewById(Guid id)
        {
            var query = await _repositoryManager.ReviewRepository.GetByIdAsync(id);
            if (query == null)
            {
                throw new ArgumentException("No reviews found.");
            }
            return new ReviewRespone
            {
                ReviewId = query.ReviewId,
                CarId = query.CarId,
                Author = query.Author,
                Rating = query.Rating,
                Content = query.Content,
                Flag = query.Flag,
                RentalId = query.RentalId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
        }

        public async Task<PageResult<ReviewRespone>> GetReviewByUserId(Guid userId, int page, int limit, Boolean? flag)
        {
            var user = await _repositoryManager.ReviewRepository.GetReviewByUserId(userId, page, limit, flag);
            var totalItems = user.Count();
            if (user == null)
            {
                throw new Exception($"No reviews found.");
            }
            var result = _mapper.Map<IEnumerable<ReviewRespone>>(user);
            return new PageResult<ReviewRespone>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = result
            };
        }

        public async Task<bool> UpdateReview(Guid id, CreateUpdateReviewRequest update)
        {
            var reviewId = await _repositoryManager.ReviewRepository.GetByIdAsync(id);
            if (reviewId == null)
            {
                return false;
            }
            var checkcarId = await _repositoryManager.CarRepository.GetCarByCarId(update.CarId);
            if (checkcarId == null || !update.CarId.Equals(checkcarId.CarId))
            {
                throw new Exception($"No car found.");
            }
            var checkauthor = await _userManager.FindByIdAsync(update.Author.ToString());
            if (checkauthor == null || !update.Author.Equals(checkauthor.Id))
            {
                throw new Exception($"No user found.");
            }
            reviewId.Rating = update.Rating;
            reviewId.Content = update.Content;
            reviewId.UpdatedAt = DateTime.Now;
            reviewId.CreatedAt = DateTime.Now;
            _repositoryManager.ReviewRepository.Update(reviewId);

            //var updateReview = _mapper.Map<Review>(reviewId);
            await _repositoryManager.SaveAsync();
            return true;

        }
    }
}
