using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
            var model = new Review
            {
                CarId = carRequest.CarId,
                Author = carRequest.Author,
                Rating = carRequest.Rating,
                Content = carRequest.Content,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,

            };
            _repositoryManager.ReviewRepository.Add(model);
            await _repositoryManager.SaveAsync();
            return _mapper.Map<CreateUpdateReviewRequest>(model);
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

        public async Task<IEnumerable<ReviewRespone>> GetAllReviewAsync(int page, int limit)
        {
            var listreview = await _repositoryManager.ReviewRepository.GetAllReviewAsync(page, limit);
            var reviewRespone = listreview.Select(x => new ReviewRespone
            {
                ReviewId = x.ReviewId,
                CarId = x.Car.CarId,
                Author = x.User.Id,
                Rating = x.Rating,
                Content= x.Content,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            });

            return reviewRespone;
        }

        public async Task<ReviewRespone> GetReviewById(Guid id)
        {
            var query = await _repositoryManager.ReviewRepository.GetByIdAsync(id);
            if (query == null)
            {
                throw new ArgumentException("ReviewId does not exsit!");
            }
            return new ReviewRespone
            {
                ReviewId = query.ReviewId,
                CarId = query.CarId,
                Author = query.Author,
                Rating = query.Rating,
                Content = query.Content,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
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
                throw new Exception("CarId does not match");
            }
            var checkauthor = await _userManager.FindByIdAsync(update.Author.ToString());
            if (checkauthor == null || !update.Author.Equals(checkauthor.Id))
            {

                throw new Exception("UserId does not match");
            }
            reviewId.Rating = update.Rating;
            reviewId.Content= update.Content;
            reviewId.UpdatedAt = DateTime.Now;
            reviewId.CreatedAt = DateTime.Now;
            _repositoryManager.ReviewRepository.Update(reviewId);

            var updateReview = _mapper.Map<Review>(reviewId);
            await _repositoryManager.SaveAsync();
            return true;
           
        }
    }
}
