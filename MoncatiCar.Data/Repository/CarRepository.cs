using System.Reflection.PortableExecutable;
using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Repository;
using MocatiCar.Core.SeedWorks.Enums;
using MoncatiCar.Data.SeedWork;

namespace MoncatiCar.Data.Repository
{
    public class CarRepository : RepositoryBase<Car, Guid>, ICarRepository
    {
        public CarRepository(MocatiContext context) : base(context)
        {

        }

        public async Task<(IEnumerable<Car> Cars, int TotalItems)> GetAllCarAsync(int page, int limit, string search,
         bool? status, string modelname,
        string brandname, string transmission,
        string fuelType, int? seats,
        bool? electric, bool? discount, bool? instantBooking,
        string location, string sortedBy, string? order, int? minYear, int? maxYear,
        int? minPrice, int? maxPrice)
        {
            search = search?.Trim();
            modelname = modelname?.Trim();
            brandname = brandname?.Trim();
            transmission = transmission?.Trim();
            location = location?.Trim();
            sortedBy = sortedBy?.Trim();
            order = order?.Trim();

            IQueryable<Car> query = _context.Cars
                                            .Include(m => m.Model)
                                            .ThenInclude(b => b.Brand)
                                            .Include(i => i.Images)
                                            .Include(r => r.Reviews)
                                            .Include(c => c.CarFeatures)
                                            .ThenInclude(cf => cf.Feature);
            //filter year
            if (minYear.HasValue)
            {
                query = query.Where(c => c.year >= minYear.Value);
            }
            if (maxYear.HasValue)
            {
                query = query.Where(c => c.year <= maxYear.Value);
            }
            //filter price
            if (minPrice.HasValue)
            {
                query = query.Where(c => c.PricePerDay >= minPrice.Value);
            }
            if (maxPrice.HasValue)
            {
                query = query.Where(c => c.PricePerDay <= maxPrice.Value);
            }
            // Search slug
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(c => c.Slug.ToLower().Contains(search.ToLower()));
            }
            //filter instantBooking
            if (instantBooking.HasValue)
            {
                query = query.Where(c => c.InstantBooking == instantBooking.Value);
            }

            // Filter by model name
            if (!string.IsNullOrEmpty(modelname))
            {
                query = query.Where(c => c.Model.ModelName.ToLower().Contains(modelname.ToLower()));
            }

            // Filter by brand name
            if (!string.IsNullOrEmpty(brandname))
            {
                query = query.Where(c => c.Model.Brand.BrandName.ToLower().Contains(brandname.ToLower()));
            }

            // Filter by status
            if (status.HasValue)
            {
                query = query.Where(c => c.Status == status.Value);
            }

            // Filter by transmission
            if (!string.IsNullOrEmpty(transmission))
            {
                if (Enum.TryParse(transmission, true, out Transmission transmissionEnum))
                {
                    query = query.Where(c => c.Transmission == transmissionEnum);
                }
            }

            // Filter by fuel type (fuelType)
            if (!string.IsNullOrEmpty(fuelType))
            {
                if (Enum.TryParse(fuelType, true, out FuelType fuelTypeEnum))
                {
                    query = query.Where(c => c.FuelType == fuelTypeEnum);
                }
            }

            // Filter by location
            if (!string.IsNullOrEmpty(location))
            {
                query = query.Where(c => c.Location.ToLower().Contains(location.ToLower()));
            }

            //filer by seats
            if (seats.HasValue)
            {
                query = query.Where(c => c.Seats == seats.Value);
            }
            //filter by discount

            if (discount.HasValue)
            {
                if (discount.Value)
                {
                    // Lọc xe có discount (giảm giá > 0)
                    query = query.Where(c => c.discount.HasValue && c.discount.Value > 0);
                }
                else
                {
                    // Lọc xe không có discount (giảm giá bằng 0 hoặc null)
                    query = query.Where(c => !c.discount.HasValue || c.discount.Value == 0);
                }
            }
            //filter by electric
            if (electric.HasValue)
            {
                if (electric.Value)
                {
                    // Lọc các xe chạy bằng điện (Electric)
                    query = query.Where(c => c.FuelType == FuelType.Electric);
                }
                else
                {
                    // Lọc các xe không phải chạy bằng điện (các loại khác)
                    query = query.Where(c => c.FuelType != FuelType.Electric);
                }
            }
            // Sorting logic based on 'price' and 'year'
            if (!string.IsNullOrEmpty(sortedBy))
            {
                if (sortedBy.Equals("price", StringComparison.OrdinalIgnoreCase))
                {
                    // Sắp xếp theo PricePerDay (decimal)
                    if (!string.IsNullOrEmpty(order) && order.Equals("desc", StringComparison.OrdinalIgnoreCase))
                    {
                        query = query.OrderByDescending(c => c.PricePerDay);
                    }
                    else
                    {
                        query = query.OrderBy(c => c.PricePerDay);
                    }
                }
                else if (sortedBy.Equals("year", StringComparison.OrdinalIgnoreCase))
                {
                    // Sắp xếp theo year (int)
                    if (!string.IsNullOrEmpty(order) && order.Equals("desc", StringComparison.OrdinalIgnoreCase))
                    {
                        query = query.OrderByDescending(c => c.year); // Sắp xếp theo year giảm dần
                    }
                    else
                    {
                        query = query.OrderBy(c => c.year); // Sắp xếp theo year tăng dần
                    }
                }
            }




            // Get total count
            int totalItems = await query.CountAsync();

            // Apply pagination
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }

            var cars = await query.ToListAsync();
            return (cars, totalItems);
        }

        public async Task<(IEnumerable<Car> Cars, int TotalItems)> GetCarByUserAsync(int page, int limit, bool? status, Guid id)
        {
            IQueryable<Car> query = _context.Cars
                .Where(c => c.OwnerId == id)
                .Include(c => c.Model)
                    .ThenInclude(m => m.Brand)
                .Include(c => c.Images)
                .Include(c => c.CarFeatures)
                    .ThenInclude(cf => cf.Feature)
                .Include(c => c.Reviews);

            // Filter by status if provided
            if (status.HasValue)
            {
                query = query.Where(c => c.Status == status.Value);
            }

            // Get the total count of items before applying pagination
            int totalItems = await query.CountAsync();

            // Apply pagination
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }

            var cars = await query.ToListAsync();
            return (cars, totalItems);
        }


        public async Task<Car> GetByLicensePlateAsync(string licensePlate)
        {
            var check = await _context.Cars.FirstOrDefaultAsync(c => c.licensePlate == licensePlate);
            return check;
        }

        public async Task<Car> GetCarByCarId(Guid id)
        {
            var query = await _context.Cars.Where(m => m.CarId == id)
                                           .Include(m => m.Model)
                                             .ThenInclude(b => b.Brand)
                                             .Include(i => i.Images)
                                             .Include(c => c.CarFeatures).ThenInclude(cf => cf.Feature)
                                             .Include(review => review.Reviews).FirstOrDefaultAsync();
            return query;
        }

        public async Task<Car> GetCarBySlug(string slug)
        {
            var query = await _context.Cars.Where(c => c.Slug == slug)
                                            .Include(m => m.Model)
                                            .ThenInclude(b => b.Brand)
                                            .Include(c => c.CarFeatures).ThenInclude(cf => cf.Feature)
                                           .Include(c => c.Images).FirstOrDefaultAsync();
            return query;
        }

        public async Task<int> GetTotalCarAsync()
        {
            return await _context.Cars.CountAsync();
        }

        public void UpdateCar(Guid id, Car car)
        {
            _context.Cars.Update(car);
        }

        public async Task<Car> GetLocationDetailByCarId(Guid carId)
        {
            var query = await _context.Cars.Where(c => c.CarId == carId).FirstOrDefaultAsync();
            return query;
        }

        public async Task<IEnumerable<Car>> GetAllCarByUsername(string userName)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == userName);
            if (user == null) return null;

            return await _context.Cars.Where(c => c.OwnerId == user.Id)
                                                       .Include(m => m.Model)
                                                         .ThenInclude(b => b.Brand)
                                                         .Include(i => i.Images)
                                                         .Include(c => c.CarFeatures).ThenInclude(cf => cf.Feature)
                                                         .Include(review => review.Reviews).ToListAsync();
        }
    }
}
