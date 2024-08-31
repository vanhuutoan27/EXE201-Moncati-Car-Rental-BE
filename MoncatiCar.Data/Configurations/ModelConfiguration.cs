using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MocatiCar.Core.Domain.Content;

namespace MoncatiCar.Data.Configurations
{
    public class ModelConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(new List<Model>()
            {
                new Model
                {
                    ModelId = Guid.Parse("0ED1B055-DCD4-48EE-AEFF-7478382F9E96"),
                    ModelName = "CX5 Deluxe",
                    Description = null,
                    Year = 2017,
                    BrandId = Guid.Parse("c6669c8e-f8a8-443c-8446-83c010b44ec0"),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now

                },
                new Model
                {
                    ModelId = Guid.Parse("F660D2B0-0444-4C02-B15A-2EBC871D8F4B"),
                    ModelName = "VF6 Plus",
                    Description = null,
                    Year = 2024,
                    BrandId = Guid.Parse("a1f14e7e-342b-4f17-b7fc-9e7ca13483b2"),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now

                },
                new Model
                {
                    ModelId = Guid.Parse("4E39763C-501A-47EA-9D11-F884DE1E7E4E"),
                    ModelName = "3008",
                    Description = null,
                    Year = 2022,
                    BrandId = Guid.Parse("de716878-747e-4b02-9fce-46d67a13c30f"),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now

                },
                new Model
                {
                    ModelId = Guid.Parse("1DC0A8E3-19B1-45F0-AEC8-A810722DE8F5"),
                    ModelName = "Ecosport",
                    Description = null,
                    Year = 2022,
                    BrandId = Guid.Parse("9bb29e7a-ca23-4418-81d4-b9b66e7cf107"),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now

                },
                new Model
                {
                    ModelId = Guid.Parse("32234D9D-90F2-4011-BA7F-85EAD67A98BD"),
                    ModelName = "RX450H",
                    Description = null,
                    Year = 2010,
                    BrandId = Guid.Parse("1c38dc33-e4d6-4922-abc4-1fa8cfc314b2"),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now

                },
                new Model
                {
                    ModelId = Guid.Parse("FDFDEF71-0E39-48F0-8EEC-71F5429ED285"),
                    ModelName = "Creta",
                    Description = null,
                    Year = 2022,
                    BrandId = Guid.Parse("c11c6f51-c207-4754-9372-046fb4a04c22"),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now

                },
                new Model
                {
                    ModelId = Guid.Parse("16FD3123-D971-422C-B2AF-E47978C27F35"),
                    ModelName = "Tucson Premium",
                    Description = null,
                    Year = 2021,
                    BrandId = Guid.Parse("c11c6f51-c207-4754-9372-046fb4a04c22"),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now

                },
                new Model
                {
                    ModelId = Guid.Parse("AFFEB1D2-7EB3-4410-A7CA-E3B1ADC3CC54"),
                    ModelName = "2008 GT",
                    Description = null,
                    Year = 2021,
                    BrandId = Guid.Parse("de716878-747e-4b02-9fce-46d67a13c30f"),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now

                },
                new Model
                {
                    ModelId = Guid.Parse("542D93FD-4BC2-48DF-9E58-F12C17A96D79"),
                    ModelName = "ZS Standard",
                    Description = null,
                    Year = 2022,
                    BrandId = Guid.Parse("b802da6e-e178-46f5-9884-442e0f1067dc"),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now

                },
                new Model
                {
                    ModelId = Guid.Parse("6E18D51E-2964-4F16-A00C-0D4544671816"),
                    ModelName = "Innova",
                    Description = null,
                    Year = 2020,
                    BrandId = Guid.Parse("4e5784bd-10a3-4fb4-ad50-fb0304da90d9"),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now

                }

            });
        }
    }
}
