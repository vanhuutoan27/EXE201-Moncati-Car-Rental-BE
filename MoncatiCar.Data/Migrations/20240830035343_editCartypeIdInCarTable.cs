using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoncatiCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class editCartypeIdInCarTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarTypes_CarTypeId",
                table: "Cars");

            migrationBuilder.AlterColumn<Guid>(
                name: "CarTypeId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("1c38dc33-e4d6-4922-abc4-1fa8cfc314b2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8406), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8407) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("4e5784bd-10a3-4fb4-ad50-fb0304da90d9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8415), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("9bb29e7a-ca23-4418-81d4-b9b66e7cf107"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8403), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("a1f14e7e-342b-4f17-b7fc-9e7ca13483b2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8397), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("b802da6e-e178-46f5-9884-442e0f1067dc"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8412), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8412) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c11c6f51-c207-4754-9372-046fb4a04c22"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8409), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c6669c8e-f8a8-443c-8446-83c010b44ec0"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8385), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("de716878-747e-4b02-9fce-46d67a13c30f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8400), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8242), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("06653486-dec4-4054-ba49-c3a63490453e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8240), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8204), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8205) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8217), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8193), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8193) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("4481e46d-e85b-4870-a210-cdfea8932641"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8214), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("533a7038-190b-4830-8125-5d2aacb7174e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8190), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8225), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8222), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8174), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8228), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8220), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("be392eff-ef38-4039-94ec-7922f315ea6a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8199), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8196), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8237), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8237) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8208), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("f761d066-304f-49f7-b988-3aca64536d9b"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8246), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8246) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8211), new DateTime(2024, 8, 30, 10, 53, 43, 517, DateTimeKind.Local).AddTicks(8211) });

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarTypes_CarTypeId",
                table: "Cars",
                column: "CarTypeId",
                principalTable: "CarTypes",
                principalColumn: "CarTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarTypes_CarTypeId",
                table: "Cars");

            migrationBuilder.AlterColumn<Guid>(
                name: "CarTypeId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6097), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("06653486-dec4-4054-ba49-c3a63490453e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6094), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6057), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6072), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6043), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("4481e46d-e85b-4870-a210-cdfea8932641"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6067), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("533a7038-190b-4830-8125-5d2aacb7174e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6040), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6083), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6079), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6024), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6087), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6075), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("be392eff-ef38-4039-94ec-7922f315ea6a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6050), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6047), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6091), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6060), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("f761d066-304f-49f7-b988-3aca64536d9b"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6107), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Features",
                keyColumn: "FeatureId",
                keyValue: new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6064), new DateTime(2024, 8, 30, 10, 5, 22, 590, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarTypes_CarTypeId",
                table: "Cars",
                column: "CarTypeId",
                principalTable: "CarTypes",
                principalColumn: "CarTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
