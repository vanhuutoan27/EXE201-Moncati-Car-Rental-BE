using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.SeedWorks.Enums;

namespace MoncatiCar.Data.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasData(new List<Car>()
            {
                new Car
                {
                    CarId = Guid.Parse("87FFAC08-1EB6-4C3F-8EC8-977860913635"),
                    Slug = "mazda-cx5-deluxe-2017",
                    licensePlate = "15A-34179",
                    Seats = 4,
                    Transmission = Transmission.Automatic,
                    FuelType = FuelType.Gasoline,
                    FuelConsumption = "7",
                    Description = "Mazda CX5 2017-2.0 Fuel efficient\r\nNew, beautiful car, regularly maintained, clean…\r\nSpacious, comfortable car, suitable for family travel.\r\nCar has rear camera, sunroof, dash cam, entertainment system and many other amenities…",
                    Location = "Quận Bình Thạnh, Thành phố Hồ Chí Minh",
                    PricePerDay = 861000,
                    RentalStatus = CarRentalStatus.Available,
                    Status = true,
                    CreatedAt = DateTime.Now,

                },
                new Car
                {
                    CarId = Guid.Parse("E7B60B7D-3D98-4D57-A7B3-26AE245E59AD"),
                    Slug = "vinfast-vf6-plus-2024",
                    licensePlate = "51L-21613",
                    Seats = 5,
                    Transmission = Transmission.Automatic,
                    FuelType = FuelType.Electric,
                    FuelConsumption = "381",
                    Description = "Beautiful new family car, original interior, clean, equipped with 3M crystalline film, the car is very cool in hot weather, coated with anti-nail and noise-proof tires.\r\nThe car is spacious, safe, comfortable, suitable for family travel.\r\nBattery charging fee is calculated according to Vinfast unit price.",
                    Location = "Quận Bình Thạnh, Thành phố Hồ Chí Minh",
                    PricePerDay = 953000,
                    RentalStatus = CarRentalStatus.Rented,
                    Status = true,
                    CreatedAt = DateTime.Now,

                },
                new Car
                {
                    CarId = Guid.Parse("5C262BAE-1D5A-4443-9CE9-EDCFF60F441F"),
                    Slug = "peugeot-3008-2022",
                    licensePlate = "51K-41861",
                    Seats = 5,
                    Transmission = Transmission.Automatic,
                    FuelType = FuelType.Gasoline,
                    FuelConsumption = "10",
                    Description = "Great car! Very comfortable and spacious for my family trip",
                    Location = "Quận 1, Thành phố Hồ Chí Minh",
                    PricePerDay = 1343000,
                    RentalStatus = CarRentalStatus.Available,
                    Status = true,
                    CreatedAt = DateTime.Now,

                },
                new Car
                {
                    CarId = Guid.Parse("CA0BCF5A-B8BC-42DC-A8E4-A799CD150CEB"),
                    Slug = "ford-ecosport-2015",
                    licensePlate = "51F-32056",
                    Seats = 5,
                    Transmission = Transmission.Automatic,
                    FuelType = FuelType.Gasoline,
                    FuelConsumption = "9",
                    Description = "The car is in excellent condition and very clean. Highly recommended!",
                    Location = "Thành phố Thủ Đức, Thành phố Hồ Chí Minh",
                    PricePerDay = 666000,
                    RentalStatus = CarRentalStatus.Available,
                    Status = true,
                    CreatedAt = DateTime.Now,

                },
                new Car
                {
                    CarId = Guid.Parse("E35C7BD8-DA1C-45C2-8F30-6BE66C4040A9"),
                    Slug = "lexus-rx450h-2010",
                    licensePlate = "51A-90056",
                    Seats = 5,
                    Transmission = Transmission.Automatic,
                    FuelType = FuelType.Gasoline,
                    FuelConsumption = "7",
                    Description = "Lexus RX 450h automatic transmission manufactured in 2010 Japan\r\nLast inspection date: 7/7/2023\r\nClean and tidy family car",
                    Location = "Quận 2, Thành phố Hồ Chí Minh",
                    PricePerDay = 3706000,
                    RentalStatus = CarRentalStatus.Available,
                    Status = true,
                    CreatedAt = DateTime.Now,

                },
                 new Car
                {
                    CarId = Guid.Parse("E35C7BD8-DA1C-45C2-8F30-6BE66C4040A9"),
                    Slug = "lexus-rx450h-2010",
                    licensePlate = "51A-90056",
                    Seats = 5,
                    Transmission = Transmission.Automatic,
                    FuelType = FuelType.Gasoline,
                    FuelConsumption = "7",
                    Description = "Lexus RX 450h automatic transmission manufactured in 2010 Japan\r\nLast inspection date: 7/7/2023\r\nClean and tidy family car",
                    Location = "Quận 2, Thành phố Hồ Chí Minh",
                    PricePerDay = 3706000,
                    RentalStatus = CarRentalStatus.Available,
                    Status = true,
                    CreatedAt = DateTime.Now,

                },

            });
        }
    }
}
