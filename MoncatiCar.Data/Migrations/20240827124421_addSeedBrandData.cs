using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoncatiCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class addSeedBrandData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "BrandName", "CreatedAt", "CreatedBy", "Description", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1c38dc33-e4d6-4922-abc4-1fa8cfc314b2"), "Lexus", new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2353), null, "The luxury division of Toyota, Lexus is renowned for its refined craftsmanship, advanced technology, and smooth, comfortable rides. It’s a symbol of reliability and premium quality.", new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2354), null },
                    { new Guid("4e5784bd-10a3-4fb4-ad50-fb0304da90d9"), "Toyota", new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2364), null, "One of the largest and most reliable car manufacturers in the world. Toyota is known for its long-lasting vehicles, efficiency, and innovations like hybrid technology with models like the Prius.", new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2364), null },
                    { new Guid("9bb29e7a-ca23-4418-81d4-b9b66e7cf107"), "Ford", new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2350), null, "An American automaker famous for its durable vehicles, including the iconic Ford Mustang and F-Series trucks. Ford has a significant influence on the global automotive industry.", new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2350), null },
                    { new Guid("a1f14e7e-342b-4f17-b7fc-9e7ca13483b2"), "Vinfast", new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2343), null, "A Vietnamese car manufacturer that quickly gained attention for its electric and gasoline vehicles. VinFast aims to bring Vietnamese-made cars to the global market with a focus on quality and innovation.", new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2344), null },
                    { new Guid("b802da6e-e178-46f5-9884-442e0f1067dc"), "Mg", new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2360), null, "Originally a British brand, now owned by Chinese automaker SAIC. MG is known for affordable vehicles with a focus on modern technology and youthful appeal.", new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2361), null },
                    { new Guid("c11c6f51-c207-4754-9372-046fb4a04c22"), "Hyundai", new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2357), null, "A South Korean car manufacturer that offers a wide range of vehicles, known for their affordability, modern designs, and advanced features. Hyundai has rapidly grown to become a major global player.", new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2358), null },
                    { new Guid("c6669c8e-f8a8-443c-8446-83c010b44ec0"), "Mazda", new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2337), null, "A Japanese automaker known for its stylish designs, advanced technology, and driving pleasure. Mazda’s “Kodo” design philosophy and SkyActiv technology are key highlights.", new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2338), null },
                    { new Guid("de716878-747e-4b02-9fce-46d67a13c30f"), "Peugeot", new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2347), null, "A French car brand with a long history, known for producing elegant and reliable vehicles. Peugeot is recognized for its sophisticated design, comfort, and European flair.", new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2347), null }
                });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2213), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("06653486-dec4-4054-ba49-c3a63490453e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2210), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2177), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2193), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2164), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("4481e46d-e85b-4870-a210-cdfea8932641"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2189), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("533a7038-190b-4830-8125-5d2aacb7174e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2161), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2202), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2199), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2141), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2204), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2195), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("be392eff-ef38-4039-94ec-7922f315ea6a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2172), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2168), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2208), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2180), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("f761d066-304f-49f7-b988-3aca64536d9b"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2217), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2184), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2186) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("1c38dc33-e4d6-4922-abc4-1fa8cfc314b2"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("4e5784bd-10a3-4fb4-ad50-fb0304da90d9"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("9bb29e7a-ca23-4418-81d4-b9b66e7cf107"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("a1f14e7e-342b-4f17-b7fc-9e7ca13483b2"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("b802da6e-e178-46f5-9884-442e0f1067dc"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c11c6f51-c207-4754-9372-046fb4a04c22"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c6669c8e-f8a8-443c-8446-83c010b44ec0"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("de716878-747e-4b02-9fce-46d67a13c30f"));

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("06653486-dec4-4054-ba49-c3a63490453e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3815), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3785), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3797), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3775), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("4481e46d-e85b-4870-a210-cdfea8932641"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3793), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("533a7038-190b-4830-8125-5d2aacb7174e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3772), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3807), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3804), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3758), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3809), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3800), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3801) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("be392eff-ef38-4039-94ec-7922f315ea6a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3780), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3778), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3778) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3812), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3788), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("f761d066-304f-49f7-b988-3aca64536d9b"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3823), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3790), new DateTime(2024, 8, 27, 15, 27, 17, 67, DateTimeKind.Local).AddTicks(3791) });
        }
    }
}
