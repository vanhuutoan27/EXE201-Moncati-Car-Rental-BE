using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MocatiCar.Core.Domain.Content;

namespace MoncatiCar.Data.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(new List<Brand>()
            {
                new Brand
                {
                    BrandId = Guid.Parse("c6669c8e-f8a8-443c-8446-83c010b44ec0"),
                    BrandName = "Mazda",
                    Description = "A Japanese automaker known for its stylish designs, advanced technology, and driving pleasure. Mazda’s “Kodo” design philosophy and SkyActiv technology are key highlights.",
                    CreatedAt = DateTime.Parse("2024-8-27"),
                    UpdatedAt =  DateTime.Parse("2024-8-27"),
                },
                new Brand
                {
                    BrandId = Guid.Parse("a1f14e7e-342b-4f17-b7fc-9e7ca13483b2"),
                    BrandName = "Vinfast",
                    Description = "A Vietnamese car manufacturer that quickly gained attention for its electric and gasoline vehicles. VinFast aims to bring Vietnamese-made cars to the global market with a focus on quality and innovation.",
                    CreatedAt =  DateTime.Parse("2024-8-27"),
                    UpdatedAt =  DateTime.Parse("2024-8-27"),
                },
                new Brand
                {
                    BrandId = Guid.Parse("de716878-747e-4b02-9fce-46d67a13c30f"),
                    BrandName = "Peugeot",
                    Description = "A French car brand with a long history, known for producing elegant and reliable vehicles. Peugeot is recognized for its sophisticated design, comfort, and European flair.",
                    CreatedAt =  DateTime.Parse("2024-8-27"),
                    UpdatedAt =  DateTime.Parse("2024-8-27"),
                },
                new Brand
                {
                    BrandId = Guid.Parse("9bb29e7a-ca23-4418-81d4-b9b66e7cf107"),
                    BrandName = "Ford",
                    Description = "An American automaker famous for its durable vehicles, including the iconic Ford Mustang and F-Series trucks. Ford has a significant influence on the global automotive industry.",
                    CreatedAt =  DateTime.Parse("2024-8-27"),
                    UpdatedAt =  DateTime.Parse("2024-8-27"),
                },
                new Brand
                {
                    BrandId = Guid.Parse("1c38dc33-e4d6-4922-abc4-1fa8cfc314b2"),
                    BrandName = "Lexus",
                    Description = "The luxury division of Toyota, Lexus is renowned for its refined craftsmanship, advanced technology, and smooth, comfortable rides. It’s a symbol of reliability and premium quality.",
                    CreatedAt =  DateTime.Parse("2024-8-27"),
                    UpdatedAt =  DateTime.Parse("2024-8-27"),
                },
                new Brand
                {
                    BrandId = Guid.Parse("c11c6f51-c207-4754-9372-046fb4a04c22"),
                    BrandName = "Hyundai",
                    Description = "A South Korean car manufacturer that offers a wide range of vehicles, known for their affordability, modern designs, and advanced features. Hyundai has rapidly grown to become a major global player.",
                    CreatedAt =  DateTime.Parse("2024-8-27"),
                    UpdatedAt =  DateTime.Parse("2024-8-27"),
                },
                new Brand
                {
                    BrandId = Guid.Parse("b802da6e-e178-46f5-9884-442e0f1067dc"),
                    BrandName = "Mg",
                    Description = "Originally a British brand, now owned by Chinese automaker SAIC. MG is known for affordable vehicles with a focus on modern technology and youthful appeal.",
                    CreatedAt =  DateTime.Parse("2024-8-27"),
                    UpdatedAt =  DateTime.Parse("2024-8-27"),
                },
                new Brand
                {
                    BrandId = Guid.Parse("4e5784bd-10a3-4fb4-ad50-fb0304da90d9"),
                    BrandName = "Toyota",
                    Description = "One of the largest and most reliable car manufacturers in the world. Toyota is known for its long-lasting vehicles, efficiency, and innovations like hybrid technology with models like the Prius.",
                    CreatedAt =  DateTime.Parse("2024-8-27"),
                    UpdatedAt =  DateTime.Parse("2024-8-27"),
                }
            });
        }
    }
}
