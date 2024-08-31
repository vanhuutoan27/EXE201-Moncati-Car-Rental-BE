using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoncatiCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitalDbAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.RoleId, x.UserId });
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "CarTypes",
                columns: table => new
                {
                    CarTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarTypes", x => x.CarTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    FeatureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FeatureName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.FeatureId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VipStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VipExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    ModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.ModelId);
                    table.ForeignKey(
                        name: "FK_Models_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    addressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    addressName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    locationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    district = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    commune = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isDefault = table.Column<bool>(type: "bit", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.addressId);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    licensePlate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Seats = table.Column<int>(type: "int", nullable: false),
                    Transmission = table.Column<int>(type: "int", nullable: false),
                    FuelType = table.Column<int>(type: "int", nullable: false),
                    FuelConsumption = table.Column<float>(type: "real", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricePerDay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RentalStatus = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    discount = table.Column<float>(type: "real", nullable: true),
                    InstantBooking = table.Column<bool>(type: "bit", nullable: true),
                    LocationDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxDeliveryDistance = table.Column<int>(type: "int", nullable: true),
                    DeliveryFeePerKm = table.Column<int>(type: "int", nullable: true),
                    FreeDeliveryWithinKm = table.Column<int>(type: "int", nullable: true),
                    LimitKilometersPerDay = table.Column<int>(type: "int", nullable: true),
                    OverLimitFeePerKm = table.Column<int>(type: "int", nullable: true),
                    RentalTerms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    year = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CarTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Cars_CarTypes_CarTypeId",
                        column: x => x.CarTypeId,
                        principalTable: "CarTypes",
                        principalColumn: "CarTypeId");
                    table.ForeignKey(
                        name: "FK_Cars_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "ModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CarFeatures",
                columns: table => new
                {
                    CarFeatureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FeatureId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarFeatures", x => x.CarFeatureId);
                    table.ForeignKey(
                        name: "FK_CarFeatures_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId");
                    table.ForeignKey(
                        name: "FK_CarFeatures_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "FeatureId");
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CarId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Images_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId");
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    RentalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StartDayTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDayTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PickupLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReturnLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RentalStatus = table.Column<int>(type: "int", nullable: false),
                    RentalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InsuranceAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DepositAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CommissionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.RentalId);
                    table.ForeignKey(
                        name: "FK_Rentals_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId");
                    table.ForeignKey(
                        name: "FK_Rentals_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Author = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Flag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId");
                    table.ForeignKey(
                        name: "FK_Reviews_Users_Author",
                        column: x => x.Author,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    ContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RentalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Signature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractTerms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_Contracts_Rentals_RentalId",
                        column: x => x.RentalId,
                        principalTable: "Rentals",
                        principalColumn: "RentalId");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RentalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_Rentals_RentalId",
                        column: x => x.RentalId,
                        principalTable: "Rentals",
                        principalColumn: "RentalId");
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("8f3dbc12-27b8-49ac-8049-c67e065ce7c0") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b") }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "BrandName", "CreatedAt", "CreatedBy", "Description", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1c38dc33-e4d6-4922-abc4-1fa8cfc314b2"), "Lexus", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1971), null, "The luxury division of Toyota, Lexus is renowned for its refined craftsmanship, advanced technology, and smooth, comfortable rides. It’s a symbol of reliability and premium quality.", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1972), null },
                    { new Guid("4e5784bd-10a3-4fb4-ad50-fb0304da90d9"), "Toyota", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1979), null, "One of the largest and most reliable car manufacturers in the world. Toyota is known for its long-lasting vehicles, efficiency, and innovations like hybrid technology with models like the Prius.", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1980), null },
                    { new Guid("9bb29e7a-ca23-4418-81d4-b9b66e7cf107"), "Ford", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1968), null, "An American automaker famous for its durable vehicles, including the iconic Ford Mustang and F-Series trucks. Ford has a significant influence on the global automotive industry.", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1968), null },
                    { new Guid("a1f14e7e-342b-4f17-b7fc-9e7ca13483b2"), "Vinfast", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1960), null, "A Vietnamese car manufacturer that quickly gained attention for its electric and gasoline vehicles. VinFast aims to bring Vietnamese-made cars to the global market with a focus on quality and innovation.", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1961), null },
                    { new Guid("b802da6e-e178-46f5-9884-442e0f1067dc"), "Mg", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1977), null, "Originally a British brand, now owned by Chinese automaker SAIC. MG is known for affordable vehicles with a focus on modern technology and youthful appeal.", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1977), null },
                    { new Guid("c11c6f51-c207-4754-9372-046fb4a04c22"), "Hyundai", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1974), null, "A South Korean car manufacturer that offers a wide range of vehicles, known for their affordability, modern designs, and advanced features. Hyundai has rapidly grown to become a major global player.", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1975), null },
                    { new Guid("c6669c8e-f8a8-443c-8446-83c010b44ec0"), "Mazda", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1949), null, "A Japanese automaker known for its stylish designs, advanced technology, and driving pleasure. Mazda’s “Kodo” design philosophy and SkyActiv technology are key highlights.", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1950), null },
                    { new Guid("de716878-747e-4b02-9fce-46d67a13c30f"), "Peugeot", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1964), null, "A French car brand with a long history, known for producing elegant and reliable vehicles. Peugeot is recognized for its sophisticated design, comfort, and European flair.", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1965), null }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "FeatureId", "CreatedAt", "CreatedBy", "Description", "FeatureName", "Icon", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1820), null, "Automatically processes toll payments while driving", "etc", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fetc-icon.png?alt=media&token=e2494201-b1ff-4cfa-982d-4618537ce4c5", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1821), null },
                    { new Guid("06653486-dec4-4054-ba49-c3a63490453e"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1817), null, "Covers and protects the engine compartment from external elements", "bonnet", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fbonnet-icon.png?alt=media&token=a39d6283-4a5a-48a9-8c6a-8c2d539cd05b", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1818), null },
                    { new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1739), null, "Displays rear visuals to aid in reversing safely", "reverseCamera", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Freverse_camera-icon.png?alt=media&token=fff470fe-095c-4b9e-ac98-aa31827a6f91", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1740), null },
                    { new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1752), null, "Provides an open roof option for natural light and ventilation", "sunRoof", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fsunroof-icon.png?alt=media&token=88b4101d-1fec-40c0-9534-989e39d08516", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1753), null },
                    { new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1729), null, "Offers a 360-degree view around the vehicle for safer maneuvering", "camera360", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2F360_camera-icon.png?alt=media&token=12ef3912-ad25-4216-9d8a-aa3a10f3d956", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1730), null },
                    { new Guid("4481e46d-e85b-4870-a210-cdfea8932641"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1748), null, "Projects essential driving information onto the windshield", "headUp", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fhead_up-icon.png?alt=media&token=63087d56-26a4-4f72-affc-3c5d55c33f31", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1749), null },
                    { new Guid("533a7038-190b-4830-8125-5d2aacb7174e"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1726), null, "Enables wireless connection for hands-free calls and audio streaming", "bluetooth", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fbluetooth-icon.png?alt=media&token=422658da-d565-46e6-9e8f-b0ffccbb77dd", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1726), null },
                    { new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1778), null, "Allows charging and connecting devices to the vehicle's system", "usbPort", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fusb-icon.png?alt=media&token=3fce192b-6d2f-43f5-8e0b-3546c1e50e31", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1779), null },
                    { new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1759), null, "Secures infants in a specially designed seat for maximum safety", "babySeat", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fbabyseat-icon.png?alt=media&token=2ad93b19-7448-46f9-9029-19871a357eb6", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1759), null },
                    { new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1699), null, "Provides real-time navigation and location tracking while driving", "map", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fmap-icon.png?alt=media&token=ebf5968e-074f-4f5f-a20c-9020b5dfac7b", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1715), null },
                    { new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1781), null, "A backup tire stored in the vehicle for emergency replacements", "spareTire", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fspare_tire-icon.png?alt=media&token=01a8dc7b-e98c-479c-943c-e337e3964e8d", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1787), null },
                    { new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1756), null, "Offers satellite-based navigation and route guidance", "gps", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fgps-icon.png?alt=media&token=39ae42c8-a678-4f05-b5dd-9e20eb42d31f", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1756), null },
                    { new Guid("be392eff-ef38-4039-94ec-7922f315ea6a"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1735), null, "Records front road footage for safety and evidence during drives", "dashCamera", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fdash_camera-icon.png?alt=media&token=e863e966-7ce5-432f-9629-bd72fcdfcd1f", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1736), null },
                    { new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1733), null, "Assists in parking by displaying rearview visuals on the screen", "parkingCamera", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fparking_camera-icon.png?alt=media&token=39675fd9-2e15-4275-a7e1-085a75fb491f", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1733), null },
                    { new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1809), null, "Displays video content for rear-seat entertainment during trips", "dvdMonitor", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fdvd-icon.png?alt=media&token=49e66de4-ec15-42d5-9787-50f23ba0c074", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1810), null },
                    { new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1743), null, "Monitors tire pressure to ensure optimal driving safety", "tirePressureMonitor", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Ftpms-icon.png?alt=media&token=5d93995e-c886-430c-843b-a80fb6ba3f46", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1743), null },
                    { new Guid("f761d066-304f-49f7-b988-3aca64536d9b"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1824), null, "Deploy in collisions to protect passengers from injury", "airbags", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fairbags-icon.png?alt=media&token=55c3c49f-1b88-4782-8124-7828a6df07f8", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1825), null },
                    { new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1746), null, "Detects collisions and triggers safety mechanisms during impacts", "impactSensor", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fimpact_sensor-icon.png?alt=media&token=1bc9001d-e5ca-4f48-98f8-dc86934cebc0", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(1746), null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), null, "Khách Hàng", "Customer", "CUSTOMER" },
                    { new Guid("ab8e4032-2d95-45cc-89c1-c039e9e8bc39"), null, "Chủ Xe", "Owner", "CarOwener" },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), null, "Quản Lí", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Dob", "Email", "EmailConfirmed", "FullName", "Gender", "LastLoginDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "TwoFactorEnabled", "UpdatedAt", "UpdatedBy", "UserName", "VipExpireDate", "VipStartDate" },
                values: new object[,]
                {
                    { new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 0, null, null, "98072ce5-706a-4aab-b51f-3b7a96dcf991", new DateTime(2024, 8, 31, 12, 48, 21, 194, DateTimeKind.Local).AddTicks(3527), null, null, "khanhpham@gmail.com", true, "Nguyen Pham Khanh", null, null, false, null, null, null, "AQAAAAIAAYagAAAAEJFLmGjYm8UNwN87a2K0+//o6eodlVzve2xhL7TRNkr0hf6qCb6aqqmV1pQFH7JaBA==", "0969998878", false, null, null, null, true, false, new DateTime(2024, 8, 31, 12, 48, 21, 194, DateTimeKind.Local).AddTicks(3495), null, "kuem113", null, null },
                    { new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"), 0, null, null, "ea9f4366-d4be-4481-a18f-be98d30b4437", new DateTime(2024, 8, 31, 12, 48, 21, 474, DateTimeKind.Local).AddTicks(1740), null, null, "duythunglinhtinhiu@gmail.com", true, "Pham Hoai Duy", null, null, false, null, null, null, "AQAAAAIAAYagAAAAEBxUN/ZlPXr6wDbvRP1+MfO6SdWQtbRgsxOIj4/poVlfUd2iZKRudyrRIDQZyLswhw==", "0555666612", false, null, null, null, true, false, new DateTime(2024, 8, 31, 12, 48, 21, 474, DateTimeKind.Local).AddTicks(1710), null, "duypro113", null, null },
                    { new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 0, null, null, "36d36b5b-2e9e-4eeb-bb33-36448b3e4957", new DateTime(2024, 8, 31, 12, 48, 21, 56, DateTimeKind.Local).AddTicks(346), null, null, "quocdai@gmail.com", true, "Nguyen Quoc Dai", null, null, false, null, null, null, "AQAAAAIAAYagAAAAEPEy8tDQxJqkjCkCTwOCotT5ZyOt5YIwcogYC1WcycPBZYuDehh7fgyVJL9ASfRvmw==", "0932748924", false, null, null, null, true, false, new DateTime(2024, 8, 31, 12, 48, 21, 56, DateTimeKind.Local).AddTicks(237), null, "dainq115", null, null },
                    { new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"), 0, null, null, "dd60ca91-0f0c-42f3-9d5b-f99b77f99e3e", new DateTime(2024, 8, 31, 12, 48, 21, 266, DateTimeKind.Local).AddTicks(3740), null, null, "khaitoi@gmail.com", true, "Phan Van Khai", null, null, false, null, null, null, "AQAAAAIAAYagAAAAEGJLjmr71WvNrrA8x+9zsgBC0Eqe6Mb7wA29OGwHqT26IFWZTu+Lc023nf+Iw4ZVZQ==", "0777444499", false, null, null, null, true, false, new DateTime(2024, 8, 31, 12, 48, 21, 266, DateTimeKind.Local).AddTicks(3718), null, "xautrai123", null, null },
                    { new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 0, null, null, "5f15d60c-3d37-4b93-a725-b462d7f4c5e1", new DateTime(2024, 8, 31, 12, 48, 21, 358, DateTimeKind.Local).AddTicks(4802), null, null, "quangdalat@gmail.com", true, "Quang La Tui", null, null, false, null, null, null, "AQAAAAIAAYagAAAAEKXMuknp0o/TTLXVN8bMMXN1kQzT9fsVLwnDZ0ZwwMYSbNAgmk9p8raXbS7ucuJ25w==", "0999777712", false, null, null, null, true, false, new DateTime(2024, 8, 31, 12, 48, 21, 358, DateTimeKind.Local).AddTicks(4778), null, "quangspa09", null, null },
                    { new Guid("8f3dbc12-27b8-49ac-8049-c67e065ce7c0"), 0, null, null, "1a8b2cf1-facf-4866-a61a-1b4891c98af4", new DateTime(2024, 8, 31, 12, 48, 21, 579, DateTimeKind.Local).AddTicks(2630), null, null, "quangdalat@gmail.com", true, "Quang La Tui", null, null, false, null, null, null, "AQAAAAIAAYagAAAAELyI9HRKFdT9ZWk9fu7qDYVRfu/MZnefrQd75IfoMtsULVBsLnOD+FNTE7tMUoc3pA==", "=0888", false, null, null, null, true, false, new DateTime(2024, 8, 31, 12, 48, 21, 579, DateTimeKind.Local).AddTicks(2606), null, "quangspa09", null, null },
                    { new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 0, null, null, "6e535f7e-7432-46b2-bf5b-0e7c3a457543", new DateTime(2024, 8, 31, 12, 48, 21, 115, DateTimeKind.Local).AddTicks(9633), null, null, "toanvan@gmail.com", true, "Van Huu Toan", null, null, false, null, null, null, "AQAAAAIAAYagAAAAEB/N/Bnlh1oZmCPbjv8j3+zMHSfwRJdtSxnc3/MQ64jU3BRDWwBUYy60UuqHNzCILw==", "0999998888", false, null, null, null, true, false, new DateTime(2024, 8, 31, 12, 48, 21, 115, DateTimeKind.Local).AddTicks(9610), null, "vipro123", null, null }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "ModelId", "BrandId", "CreatedAt", "CreatedBy", "Description", "ModelName", "UpdatedAt", "UpdatedBy", "Year" },
                values: new object[,]
                {
                    { new Guid("0ed1b055-dcd4-48ee-aeff-7478382f9e96"), new Guid("c6669c8e-f8a8-443c-8446-83c010b44ec0"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2194), null, null, "CX5 Deluxe", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2197), null, 2017 },
                    { new Guid("16fd3123-d971-422c-b2af-e47978c27f35"), new Guid("c11c6f51-c207-4754-9372-046fb4a04c22"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2224), null, null, "Tucson Premium", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2225), null, 2021 },
                    { new Guid("1dc0a8e3-19b1-45f0-aec8-a810722de8f5"), new Guid("9bb29e7a-ca23-4418-81d4-b9b66e7cf107"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2212), null, null, "Ecosport", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2212), null, 2022 },
                    { new Guid("32234d9d-90f2-4011-ba7f-85ead67a98bd"), new Guid("1c38dc33-e4d6-4922-abc4-1fa8cfc314b2"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2216), null, null, "RX450H", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2216), null, 2010 },
                    { new Guid("4e39763c-501a-47ea-9d11-f884de1e7e4e"), new Guid("de716878-747e-4b02-9fce-46d67a13c30f"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2209), null, null, "3008", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2209), null, 2022 },
                    { new Guid("542d93fd-4bc2-48df-9e58-f12c17a96d79"), new Guid("b802da6e-e178-46f5-9884-442e0f1067dc"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2231), null, null, "ZS Standard", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2232), null, 2022 },
                    { new Guid("6e18d51e-2964-4f16-a00c-0d4544671816"), new Guid("4e5784bd-10a3-4fb4-ad50-fb0304da90d9"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2236), null, null, "Innova", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2236), null, 2020 },
                    { new Guid("affeb1d2-7eb3-4410-a7ca-e3b1adc3cc54"), new Guid("de716878-747e-4b02-9fce-46d67a13c30f"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2228), null, null, "2008 GT", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2228), null, 2021 },
                    { new Guid("f660d2b0-0444-4c02-b15a-2ebc871d8f4b"), new Guid("a1f14e7e-342b-4f17-b7fc-9e7ca13483b2"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2206), null, null, "VF6 Plus", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2207), null, 2024 },
                    { new Guid("fdfdef71-0e39-48f0-8eec-71f5429ed285"), new Guid("c11c6f51-c207-4754-9372-046fb4a04c22"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2220), null, null, "Creta", new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2221), null, 2022 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "CarTypeId", "CreatedAt", "CreatedBy", "DeliveryFeePerKm", "Description", "FreeDeliveryWithinKm", "FuelConsumption", "FuelType", "InstantBooking", "LimitKilometersPerDay", "Location", "LocationDetails", "MaxDeliveryDistance", "ModelId", "OverLimitFeePerKm", "OwnerId", "PricePerDay", "RentalStatus", "RentalTerms", "Seats", "Slug", "Status", "Transmission", "UpdatedAt", "UpdatedBy", "discount", "licensePlate", "year" },
                values: new object[,]
                {
                    { new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), null, new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2419), null, 0, "The 2021 PEUGEOT 2008 GT is a stylish and compact SUV featuring a sporty design, advanced technology, and efficient engine options. It offers a comfortable and spacious interior with premium materials, making it ideal for urban driving and longer journeys", 0, 5f, 0, false, 0, "Thành phố Thủ Đức, Thành phố Hồ Chí Minh", "Thành phố Thủ Đức, Thành phố Hồ Chí Minh", 0, new Guid("affeb1d2-7eb3-4410-a7ca-e3b1adc3cc54"), 0, new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 1101000m, 0, null, 4, "peugeot-2008-gt-2022", true, 1, null, null, 0f, "51H-81511", 0 },
                    { new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), null, new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2412), null, 15, "Comfortable 5-seater car, beautiful car, strong engine, full interior and amenities", 7, 7f, 0, false, 0, "Quận 2, Thành phố Hồ Chí Minh", "Quận 2, Thành phố Hồ Chí Minh", 4, new Guid("16fd3123-d971-422c-b2af-e47978c27f35"), 100, new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 1073000m, 0, null, 5, "hyundai-tucson-premium-2021", true, 1, null, null, 10f, "30K-60501", 0 },
                    { new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), null, new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2434), null, 0, "The 2021 Toyota Innova E is a versatile and reliable MPV designed for family comfort and practicality. It boasts a spacious interior with ample seating and cargo space, advanced safety features, and a smooth driving experience.", 8, 9f, 0, false, 150, "Quận Bình Thạnh, Thành phố Hồ Chí Minh", "Quận Bình Thạnh, Thành phố Hồ Chí Minh", 5, new Guid("6e18d51e-2964-4f16-a00c-0d4544671816"), 0, new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 821000m, 0, null, 7, "toyota-innova-2020", true, 0, null, null, 20f, "51L-28832", 0 },
                    { new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), null, new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2397), null, 10, "Lexus RX 450h automatic transmission manufactured in 2010 Japan\r\nLast inspection date: 7/7/2023\r\nClean and tidy family car", 5, 7f, 0, true, 0, "Quận 2, Thành phố Hồ Chí Minh", "Quận 2, Thành phố Hồ Chí Minh", 0, new Guid("32234d9d-90f2-4011-ba7f-85ead67a98bd"), 150, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 3706000m, 0, null, 5, "lexus-rx450h-2010", true, 1, null, null, 0f, "51A-90056", 0 },
                    { new Guid("8705f403-06bc-4983-8c81-86310959cc37"), null, new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2390), null, 0, "The car is in excellent condition and very clean. Highly recommended!", 0, 9f, 0, true, 50, "Thành phố Thủ Đức, Thành phố Hồ Chí Minh", "Thành phố Thủ Đức, Thành phố Hồ Chí Minh", 7, new Guid("1dc0a8e3-19b1-45f0-aec8-a810722de8f5"), 100, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 666000m, 0, null, 5, "ford-ecosport-2015", true, 1, null, null, 0f, "51F-32056", 0 },
                    { new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), null, new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2359), null, 10, "Mazda CX5 2017-2.0 Fuel efficient\r\nNew, beautiful car, regularly maintained, clean…\r\nSpacious, comfortable car, suitable for family travel.\r\nCar has rear camera, sunroof, dash cam, entertainment system and many other amenities…", 5, 7f, 0, false, 100, "Quận Bình Thạnh, Thành phố Hồ Chí Minh", "Quận Bình Thạnh, Thành phố Hồ Chí Minh", 10, new Guid("0ed1b055-dcd4-48ee-aeff-7478382f9e96"), 200, new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 861000m, 0, null, 4, "mazda-cx5-deluxe-2017", true, 1, null, null, 20f, "15A-34179", 0 },
                    { new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), null, new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2376), null, 10, "Beautiful new family car, original interior, clean, equipped with 3M crystalline film, the car is very cool in hot weather, coated with anti-nail and noise-proof tires.\r\n", 10, 381f, 2, false, 200, "Quận Bình Thạnh, Thành phố Hồ Chí Minh", "Quận Bình Thạnh, Thành phố Hồ Chí Minh", 0, new Guid("f660d2b0-0444-4c02-b15a-2ebc871d8f4b"), 0, new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 953000m, 1, null, 5, "vinfast-vf6-plus-2024", true, 1, null, null, 15f, "51L-21613", 0 },
                    { new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), null, new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2383), null, 0, "Great car! Very comfortable and spacious for my family trip", 0, 10f, 0, false, 0, "Quận 1, Thành phố Hồ Chí Minh", "Quận 1, Thành phố Hồ Chí Minh", 0, new Guid("4e39763c-501a-47ea-9d11-f884de1e7e4e"), 0, new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 1343000m, 0, null, 5, "peugeot-3008-2022", true, 1, null, null, 0f, "51K-41861", 0 },
                    { new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), null, new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2427), null, 20, "The 2021 GARAGES ZS SMART UP STANDARD is a compact SUV designed for urban driving. It features a modern exterior with sleek lines, a spacious and well-equipped interior, and smart technology integration. The vehicle offers a smooth ride with fuel-efficient engine options, making it a practical choice for everyday use.", 0, 4f, 0, true, 0, "Quận 9, Thành phố Hồ Chí Minh", "Quận 9, Thành phố Hồ Chí Minh", 0, new Guid("542d93fd-4bc2-48df-9e58-f12c17a96d79"), 0, new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 976000m, 0, null, 4, "mg-zs-standard-2022", true, 1, null, null, 0f, "21A-13452", 0 },
                    { new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), null, new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2405), null, 10, "Safety:\r\nHyundai Creta has familiar features such as: ABS – EBD – BA brakes, electronic balance, traction control, hill start assist, tire pressure sensor, parking assist sensor, rear camera, 6 airbags…\r\nConvenience:\r\nLeather seats, Bose standard sound system, navigation, speed warning, electronic handbrake…", 5, 6f, 0, false, 0, "Quận 9, Thành phố Hồ Chí Minh", "Quận 9, Thành phố Hồ Chí Minh", 0, new Guid("fdfdef71-0e39-48f0-8eec-71f5429ed285"), 150, new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 1033000m, 0, null, 5, "hyundai-creta-2022", true, 1, null, null, 0f, "51K-39251", 0 }
                });

            migrationBuilder.InsertData(
                table: "CarFeatures",
                columns: new[] { "CarFeatureId", "CarId", "FeatureId" },
                values: new object[,]
                {
                    { new Guid("0372b1d0-7b04-45d9-8408-9c2016ef4f78"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("06f46f85-db5c-4c4f-9e4a-4eec45bb36b7"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("071aea98-350b-47d4-a4e4-f4bfdf894a0c"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("09d7716e-57ab-44dc-bdd7-acbeb9db3080"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("0a741406-da3e-4d6c-b20b-eada2c6480f1"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("0b67898c-4472-40e6-9096-bdc0db118984"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("0cd43172-60e2-46b2-a3e3-70d9d542d520"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("0cee0f02-5c00-481b-aaf5-b379754f86a0"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("0fb2fa9c-d2b0-4807-94ef-afea72776291"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("103c3051-662e-445f-a5c5-ca4e5662d12f"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("124a70b0-1023-47ec-9f5a-f089f04eda53"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("13cacee5-0397-493d-88f3-153c38c85471"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("145676e5-25c5-4e2c-8a59-0e0510d59053"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("14afd082-cc69-43bd-8984-98cb6ba70c0b"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("1665c3c2-fac5-4fce-b412-ad11d7881e5a"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("169b1433-ddcb-40cd-bd57-8adea4c60ca3"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("1b1cb881-a9c7-42c8-b3f4-12150ebf593a"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("1b62a095-4408-44cf-b376-158e6bc8e9d4"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("1b70a359-d109-4085-be32-14fab568fbae"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("1b88b73f-74fe-4603-894e-c2dfdb76c8ac"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("1e0ded2a-ec56-4bf5-83d9-d04f9c5c8cd8"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("215acec6-2929-4f81-859a-3b329efab1e7"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("23eb5459-39ff-4451-90e1-0d12d30a0526"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("2593eeac-fe6e-4bac-89f1-bd3a51928f94"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("29a32663-8c2c-4365-abc1-43bacd9b02c6"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("2abaac31-1e9a-4f23-9e71-bbf785a14099"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("2b37e144-d8b7-451e-82de-b7ffe47da16f"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("2c1dd21a-bee3-4541-9367-a87663124503"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("2d269fd7-75b2-4ca5-8390-b1928cb7032e"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("2dc19158-ce70-48db-841a-34b10e41c49d"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("2fef854d-df5b-4eb3-8e6b-55c4f7c017e9"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("3024b6b5-6461-4b1e-8e3a-cabb36558e70"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("32c3148c-4140-44a6-b9a8-536f52a94d1a"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("33b97bab-c98e-4ac0-a341-504d15c1cc4a"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("394f539a-1454-481e-997d-4c230489f694"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("3aac5206-d6e1-4606-8962-3b7d806bcf47"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("3b9f7b14-b943-47f2-92dc-66ef2d47b4d5"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("3ead4731-5f42-477a-a3b9-77743ae329bd"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("3eb36da5-c4ba-4447-8cab-2b7272c1b3ef"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("3f23c951-fc9a-40a0-9a5b-26ef18411c8d"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("3f2ad367-2036-4633-a966-ed4f9d972329"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("3f2fb8e3-1b57-4748-b05f-8a7f0c7acb4f"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("42641f6f-4524-4cac-b5e7-39580b88182a"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("44911537-0a0f-41b3-b492-8dda1718aa6a"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("45eda9fa-40a4-4c60-9309-f8eabcbaa1fe"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("46f242cc-e099-4d25-a81f-ee3e17cd7258"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("48182253-7316-4478-969c-61c1068a76e5"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("4874a453-72c0-4634-873a-8ed9faa8c72b"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("490daaa8-ef40-4f14-9b20-17002e9ba81e"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("4afd5463-4413-423c-b4d0-d5273cf3857d"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("4b2f60e7-47d6-459f-91ca-9bba37731ccd"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("4f169e1a-05b9-4c42-a738-f7767e9eb2f3"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("5251463b-0c71-4ce5-a252-fd7727ea6f7d"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("57bedf1f-d122-4545-925c-f29c6f3b4408"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("5c1182ea-7ac7-4498-b521-2495fb276084"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("5d156af8-6dd6-45e7-ae09-fcad23787077"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("5d93d95d-3e9c-4c5d-a6c1-04167e6ffb11"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("6337be26-9ec5-406a-a6bb-1a66f3bd0f66"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("65c63098-07a8-4427-bd14-27e1ee234625"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("65d3fac2-f9ea-43e8-8dee-bc959e0f5fd2"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("67eab7f0-14bf-4791-8518-f8991042970c"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("6b0d8d46-27e1-4b00-ac97-18ca6eb9bbf1"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("6c7dc8c6-e303-440f-a568-cc0ea3a83f67"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("6cca2d85-09bc-40f6-bea2-0bd5e0dc1297"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("6f7d9337-6630-4261-834d-ffbd02564700"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("720c2096-23ad-4d04-872a-1453d31ca6fe"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("74320d6d-808c-491a-95c1-809d816c0b22"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("748cd96e-2738-4a63-838d-8ced0bdb8fba"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("75bc2c6d-3ac4-40d3-a999-e6065a318053"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("77db22c3-613f-4f08-94de-7755706a05fa"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("78b04848-6936-4645-ac79-7f6e1da45a7a"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("7adde59b-8300-4221-b740-98b377f1c7e4"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("7b90bd79-8bfd-4948-905b-861538afaf65"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("7d58c747-de2c-4ff0-b514-2c6c8a755a90"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("828349aa-b4a6-4448-ad6c-acb0d6ea9abb"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("85783f6f-bba8-4f95-9704-66b15c65e391"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("8d3b928b-9cd7-4730-aa4f-c2f8d708c1c1"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("8f6f5a4d-36e1-4d1b-ae3d-6014f49d3a0f"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("9041b69d-0bcb-4cb2-8987-6160c0d2597b"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("92c9eb56-199f-4f22-8cf6-d051dc4c5e3d"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("9b10c972-c9a3-44ff-a4bc-95d9c623d5a7"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("9b1f0b65-48d9-4dd7-a589-ef811e3f11e2"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("9b374abd-0af2-404a-9d11-8e55afb550da"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("9b8bc17f-63aa-4423-9a0e-237bd46751ac"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("9c3fd5eb-c832-4bfd-a993-251971fc302b"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("9cd095a0-89bf-46ad-820e-3da3a3d08c6f"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("9e55eaa6-16a5-45b0-a80a-1f9979e238b9"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("9f96075e-0862-4ae4-b746-6402b2ee4d1e"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("a0b200e6-9f8e-472b-8351-a215494fc1b9"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("a7776c61-e108-4101-88bb-fe5f91efd0d9"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("a82e8c4e-a9e5-4bcc-982c-1fe3af54fa51"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("a871c706-bc12-498f-8701-07c5f854f856"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("aa2b1682-03fd-40c5-afa8-d89f5fa24a92"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("ab4988a5-9e58-42a4-b918-9a4fd206ead0"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("ab87626b-2cb8-420b-851c-be92966cceaa"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("ab8d7f19-f8bc-4ffd-b5f3-7980aa9e48d4"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("abac93f6-106f-44b6-b6ba-28f3115539f6"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("afafd427-fa63-4075-b21d-9a213d80492f"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("b1eaf29a-4ebc-47c9-bc6d-68becab01fd8"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("b257969e-2782-4147-8fb5-c49d63e2171c"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("ba475f2a-f1e0-4c38-8419-00f0702b2166"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("bda3b8df-8f0a-4f3a-99eb-bc86524882f3"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("bdb881aa-0a39-49b4-9507-08b6d38ed07d"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("c4f62f00-6536-4d3d-8850-1de7e870d77e"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("ca9a5b98-b6c1-4748-9f1c-c5ac81cb3c83"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("cd19d563-900a-4a1b-be93-be99f0d9cac0"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("cf27275c-bfd5-45d7-ba98-05e3c4917085"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("cfc4b8b1-8e3b-43a3-959e-63d17294824e"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("d1aa1c0a-5b0b-4333-97a8-d507258512ea"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("d22b100b-c024-42a2-87ec-62d9b457f681"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020") },
                    { new Guid("d23be4d7-6076-4f95-b97b-792e7237b587"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("d3544d24-016f-4dc7-acd2-e807bb2ce636"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("dda858e6-f000-4eaa-ace1-1f9ec20a950c"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("df39cb43-21ed-4d47-844e-0f4c31b8a246"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("e0ac2d8a-8246-4c88-b307-e4fa0bcc9248"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("e1387547-deb3-473e-9405-c62e7f677951"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("e422441d-040f-4669-acbe-ef2bbc4be943"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("e4bbc9e0-a5ef-4c70-a25a-4b82eb7b8b10"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("e51f47f7-5e30-4a28-9e73-349022aafc8c"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("e785cf27-71d8-43cc-a560-e7b1fc4b6746"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("e96a1ab4-27b3-4000-b129-5b5af06debde"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("e9fcabe3-2856-4ec4-9a4a-3960475b3bf4"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("eb50c88d-297b-4f58-b996-2d1175a786d0"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("ecc940f9-496e-4e5b-908d-37940ad1f493"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("ede27bb6-12fd-46c0-aa59-281b14b3d703"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("eec89503-5103-4030-8e10-705c1dc2392c"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("ef544bfa-9a72-4c1b-af86-c5eb9132bac3"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("f2a6724d-3fec-47ef-9784-733e6e7ca9bc"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("f49609d4-257e-459a-a72e-feb0606348a5"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("f4caea5f-48ce-41dc-8cd6-25236ec19195"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("f6ba4e92-5c28-4811-bbd8-65f4586c291e"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("f783394d-719d-444a-b288-b2235abfdcb3"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("fa069306-359e-4c5c-95f1-acfc9751f347"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("fc0afc73-b871-49e2-be0e-8a2c88950501"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("fd0398b6-154a-4b7d-97dc-b5806ae02d9f"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("fd0f152b-0aba-47c3-89ef-5b5acb6ae22d"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("fec15619-ba79-411c-b082-7acd8dd98caa"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "CarId", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy", "Url" },
                values: new object[,]
                {
                    { new Guid("0831c830-8ab9-41ee-8abe-aeea4f832715"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2528), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar11.jpg?alt=media&token=41cf30ec-f792-4074-9406-a5d2a98a49e6" },
                    { new Guid("0adcb7d1-0756-417c-abe6-f80ee4c92542"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2668), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar66.jpg?alt=media&token=d3102c30-035b-47cd-a8f8-f66be7a24f6f" },
                    { new Guid("121f43b8-a583-4fc4-9f6e-c394a66a3250"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2710), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar93.jpg?alt=media&token=782b1c2f-49d2-4673-8101-330020231a01" },
                    { new Guid("16931f6d-b074-4bd2-9082-3de35b6db9d5"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2536), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar12.jpg?alt=media&token=c1f10fdd-cb99-4c27-933d-4700acc9272e" },
                    { new Guid("199ceb3a-c747-4b7d-9ee0-de9ea62b1f7e"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2658), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar62.jpg?alt=media&token=159d9f2e-fad1-4846-876d-3c4b9fa1e720" },
                    { new Guid("1afffda1-db44-42be-8ec1-1ff773bac576"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2599), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar32.jpg?alt=media&token=9a497c45-8b33-40ae-bf8a-86b29747324b" },
                    { new Guid("1e0113dd-cf27-4f9b-8ec2-e98ad659f3f4"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2715), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar101.jpg?alt=media&token=77127151-3472-4206-8540-6909ec874c71" },
                    { new Guid("1f67b1ed-a2c4-4882-9665-902cc0ccc28c"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2698), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar91.jpg?alt=media&token=466bda06-2bf1-493f-9dd5-eee4ce0a94ab" },
                    { new Guid("1f9fcfaf-c9d5-4734-a23d-c32a8f9da1e5"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2676), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar72.jpg?alt=media&token=30a3ac2a-0797-4240-b65e-8a3ceb63a839" },
                    { new Guid("230dc7a2-c174-4b3e-ad12-d83949f7c383"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2712), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar94.jpg?alt=media&token=94d25ed1-c76b-4edf-be53-0fe909ec5307" },
                    { new Guid("27e79248-04e4-4961-a0b1-cf22c2319ae4"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2541), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar14.jpg?alt=media&token=6ce903bb-ce8b-4c6d-bc34-d8a1b664f625" },
                    { new Guid("332437e0-0136-4aa8-b173-d79dcc14a1e1"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2630), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar44.jpg?alt=media&token=e55eeb29-93b0-47b3-911f-df204e877469" },
                    { new Guid("3c161132-4448-4b31-9eeb-0188a904594e"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2693), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar84.jpg?alt=media&token=0c49d25b-e1c5-4b31-b5eb-a313baa44b5e" },
                    { new Guid("3d6cfcd0-491f-48e4-b634-e30c1503ce69"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2601), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar33.jpg?alt=media&token=557246dd-3d64-45a5-97fa-9b122cd316c9" },
                    { new Guid("40fe75c8-b92e-4a1f-8106-a50e34e446cc"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2636), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar52.jpg?alt=media&token=ad7a0fd8-b4eb-4326-a475-342a9e0b01b8" },
                    { new Guid("42062dbf-8b91-468f-a69f-530b37accc0e"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2651), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar61.jpg?alt=media&token=fab2b814-962d-4098-839c-758fb97642e5" },
                    { new Guid("4d4c2964-6453-4522-923e-1688da305391"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2556), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar23.jpg?alt=media&token=fd7110ec-aa36-4610-a69d-b00abdf886ec" },
                    { new Guid("4e1c1476-61c4-4c23-98c0-89d8a5b31375"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2708), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar92.jpg?alt=media&token=fc46713e-0c32-486c-9c6c-546318f09d9d" },
                    { new Guid("507ac946-8e80-4b5e-b130-0e354eef9fd9"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2717), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar102.jpg?alt=media&token=46f90372-9790-43f5-ae41-6f35c7961660" },
                    { new Guid("50839781-eb66-44eb-a6da-d9aff354c54b"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2639), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar53.jpg?alt=media&token=c76e6223-2ca1-4bac-bd7b-dd3f18323f37" },
                    { new Guid("5f11ba97-bde5-4400-b6dd-b4e02025a0d7"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2559), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar24.jpg?alt=media&token=263ace26-9d00-41d4-869c-760319e406dd" },
                    { new Guid("61577bc6-2808-49a3-8f65-97f1705c30a9"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2663), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar64.jpg?alt=media&token=9a4b198d-c2c4-4585-b424-fd2b326fc97c" },
                    { new Guid("8feef1ba-941b-4b9a-b15d-25407c61266d"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2691), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar83.jpg?alt=media&token=127dc8ca-bcdb-42a1-9e7c-44e35ca985c8" },
                    { new Guid("91762bd8-9200-4d45-9ee8-e8f0e983e921"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2547), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar22.jpg?alt=media&token=745493d0-4f34-4c7f-bb8c-f8c891e01422" },
                    { new Guid("9234dbb7-6996-4aa6-8b77-09297f6cc365"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2688), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar82.jpg?alt=media&token=de9c9bc7-c8e8-4969-b680-11fd990fe8a2" },
                    { new Guid("9e513ef5-91ca-4554-bdf5-1687a3ca0776"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2604), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar34.jpg?alt=media&token=d7874dde-8f83-4d86-a902-04ce22c9942c" },
                    { new Guid("9f45b34c-ac4f-4908-b5e3-dd224243fa3a"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2683), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar74.jpg?alt=media&token=95622732-d623-4eda-aa62-6c8ee1e96f28" },
                    { new Guid("a772b11e-96e1-478c-85b8-87db280fff49"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2722), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar104.jpg?alt=media&token=9688114d-001b-4f26-a5d8-562d9fb42bf7" },
                    { new Guid("a97bdd79-28e4-4be8-9fd6-4e8dea2d68f2"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2720), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar103.jpg?alt=media&token=b9e6ed3c-1328-4935-9eab-d3335638e503" },
                    { new Guid("acfdf381-d83b-438d-abca-f75e8ee1997c"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2673), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar71.jpg?alt=media&token=f67cdcdb-55a4-46da-bcab-a498b8eea245" },
                    { new Guid("b6fbb11e-e8e5-4361-b8f9-67a55d3c8dab"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2607), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar41.jpg?alt=media&token=e8d9380a-0931-4215-a080-96204098774d" },
                    { new Guid("b91353d8-6973-4aac-91a7-d0dd89b386ae"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2661), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar63.jpg?alt=media&token=34a62380-de76-46c7-9752-9b13e8cc7ac5" },
                    { new Guid("ba0ecf1f-4e45-4107-8129-d78545eb0b55"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2627), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar43.jpg?alt=media&token=b994c70b-b366-44dc-bcbe-d4c6219ba189" },
                    { new Guid("bf8a664f-88fe-4e7c-b91c-427dd10970c2"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2544), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar21.jpg?alt=media&token=735db85a-0e4f-4645-a764-1657d1ccf7d0" },
                    { new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2561), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar31.jpg?alt=media&token=6c0188d7-d743-4e0b-9795-a0ceeae64dba" },
                    { new Guid("c5c6bc64-2ecc-4494-93be-7263dafdf69a"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2666), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar65.jpg?alt=media&token=8761aa35-f030-4fa7-a020-66f0a6810090" },
                    { new Guid("c71d884c-4843-4c16-8344-7cd8e59b6518"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2642), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar54.jpg?alt=media&token=ed8a9204-288e-44f8-b047-ba4a80d5a45e" },
                    { new Guid("cdefe8c1-0a86-44ec-ae03-b24e0a62280f"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2680), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar73.jpg?alt=media&token=1750f1a1-62c5-4ab9-87ad-89301f4bc9b2" },
                    { new Guid("ce175378-0b58-4590-b630-7763ade2f2f5"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2685), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar81.jpg?alt=media&token=22679c70-85f4-4b86-8934-fb1d2a60b1b9" },
                    { new Guid("ce35f9b9-5dc4-42ef-b7b3-482cf1cd5f10"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2633), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar51.jpg?alt=media&token=6e55f0be-c666-4c50-a30e-44b4a703260d" },
                    { new Guid("dc6291c8-4229-4e6d-83fe-7db5b32d1bc3"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2671), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar67.jpg?alt=media&token=63ef5ae3-3d82-4e38-8412-aaa93f6785b6" },
                    { new Guid("e33dfafe-cf13-43ba-93bc-9b150831123e"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2539), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar13.jpg?alt=media&token=2782d4ec-0184-47a7-8964-148e4c6928ae" },
                    { new Guid("fa1534f0-e054-4f89-a476-44f4b4e78fdb"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2624), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar42.jpg?alt=media&token=78c1211b-d7a7-45ed-a03a-09a442c2b529" },
                    { new Guid("fc9e3f9e-361a-4a6c-b9ee-d4a4308a0e31"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new DateTime(2024, 8, 31, 12, 48, 20, 981, DateTimeKind.Local).AddTicks(2695), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar85.jpg?alt=media&token=8ab32d35-6b26-4fb7-8a5a-4e013161a768" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CarFeatures_CarId",
                table: "CarFeatures",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarFeatures_FeatureId",
                table: "CarFeatures",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarTypeId",
                table: "Cars",
                column: "CarTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ModelId",
                table: "Cars",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_OwnerId",
                table: "Cars",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_RentalId",
                table: "Contracts",
                column: "RentalId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_CarId",
                table: "Images",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandId",
                table: "Models",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_RentalId",
                table: "Payments",
                column: "RentalId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_AppUserId",
                table: "Rentals",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_CarId",
                table: "Rentals",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_Author",
                table: "Reviews",
                column: "Author");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CarId",
                table: "Reviews",
                column: "CarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "CarFeatures");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "CarTypes");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
