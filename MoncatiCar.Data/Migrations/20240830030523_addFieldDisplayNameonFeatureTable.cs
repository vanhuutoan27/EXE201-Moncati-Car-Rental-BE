using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoncatiCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class addFieldDisplayNameonFeatureTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "Features",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("1c38dc33-e4d6-4922-abc4-1fa8cfc314b2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6305), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("4e5784bd-10a3-4fb4-ad50-fb0304da90d9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6313), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("9bb29e7a-ca23-4418-81d4-b9b66e7cf107"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6302), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("a1f14e7e-342b-4f17-b7fc-9e7ca13483b2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6296), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("b802da6e-e178-46f5-9884-442e0f1067dc"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6310), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c11c6f51-c207-4754-9372-046fb4a04c22"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6308), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c6669c8e-f8a8-443c-8446-83c010b44ec0"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6287), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("de716878-747e-4b02-9fce-46d67a13c30f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6300), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c"),
                columns: new[] { "CreatedAt", "DisplayName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6097), "Etc", new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("06653486-dec4-4054-ba49-c3a63490453e"),
                columns: new[] { "CreatedAt", "DisplayName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6094), "Bonnet", new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5"),
                columns: new[] { "CreatedAt", "DisplayName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6057), "Reverse Camera", new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485"),
                columns: new[] { "CreatedAt", "DisplayName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6072), "Sun Roof", new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"),
                columns: new[] { "CreatedAt", "DisplayName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6043), "Camera 360", new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("4481e46d-e85b-4870-a210-cdfea8932641"),
                columns: new[] { "CreatedAt", "DisplayName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6067), "Head Up", new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("533a7038-190b-4830-8125-5d2aacb7174e"),
                columns: new[] { "CreatedAt", "DisplayName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6040), "Bluetooth", new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"),
                columns: new[] { "CreatedAt", "DisplayName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6083), "USB Port", new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020"),
                columns: new[] { "CreatedAt", "DisplayName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6079), "Baby Seat", new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"),
                columns: new[] { "CreatedAt", "DisplayName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6024), "Map", new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac"),
                columns: new[] { "CreatedAt", "DisplayName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6087), "Spare Tire", new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1"),
                columns: new[] { "CreatedAt", "DisplayName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6075), "GPS", new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("be392eff-ef38-4039-94ec-7922f315ea6a"),
                columns: new[] { "CreatedAt", "DisplayName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6050), "Dash Camera", new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"),
                columns: new[] { "CreatedAt", "DisplayName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6047), "Parking Camera", new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63"),
                columns: new[] { "CreatedAt", "DisplayName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6091), "DVD Monitor", new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d"),
                columns: new[] { "CreatedAt", "DisplayName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6060), "Tire Pressure Monitor", new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("f761d066-304f-49f7-b988-3aca64536d9b"),
                columns: new[] { "CreatedAt", "DisplayName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6107), "Air bags", new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167"),
                columns: new[] { "CreatedAt", "DisplayName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6064), "Impact Sensor", new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6064) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "Features");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("1c38dc33-e4d6-4922-abc4-1fa8cfc314b2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2353), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("4e5784bd-10a3-4fb4-ad50-fb0304da90d9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2364), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("9bb29e7a-ca23-4418-81d4-b9b66e7cf107"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2350), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("a1f14e7e-342b-4f17-b7fc-9e7ca13483b2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2343), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("b802da6e-e178-46f5-9884-442e0f1067dc"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2360), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c11c6f51-c207-4754-9372-046fb4a04c22"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2357), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c6669c8e-f8a8-443c-8446-83c010b44ec0"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2337), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("de716878-747e-4b02-9fce-46d67a13c30f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2347), new DateTime(2024, 8, 27, 19, 44, 20, 862, DateTimeKind.Local).AddTicks(2347) });

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
    }
}
