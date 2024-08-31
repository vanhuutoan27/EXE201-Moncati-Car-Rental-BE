using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoncatiCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDBAndSeedData : Migration
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
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { new Guid("1c38dc33-e4d6-4922-abc4-1fa8cfc314b2"), "Lexus", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4153), null, "The luxury division of Toyota, Lexus is renowned for its refined craftsmanship, advanced technology, and smooth, comfortable rides. It’s a symbol of reliability and premium quality.", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4153), null },
                    { new Guid("4e5784bd-10a3-4fb4-ad50-fb0304da90d9"), "Toyota", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4160), null, "One of the largest and most reliable car manufacturers in the world. Toyota is known for its long-lasting vehicles, efficiency, and innovations like hybrid technology with models like the Prius.", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4161), null },
                    { new Guid("9bb29e7a-ca23-4418-81d4-b9b66e7cf107"), "Ford", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4149), null, "An American automaker famous for its durable vehicles, including the iconic Ford Mustang and F-Series trucks. Ford has a significant influence on the global automotive industry.", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4150), null },
                    { new Guid("a1f14e7e-342b-4f17-b7fc-9e7ca13483b2"), "Vinfast", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4142), null, "A Vietnamese car manufacturer that quickly gained attention for its electric and gasoline vehicles. VinFast aims to bring Vietnamese-made cars to the global market with a focus on quality and innovation.", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4143), null },
                    { new Guid("b802da6e-e178-46f5-9884-442e0f1067dc"), "Mg", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4157), null, "Originally a British brand, now owned by Chinese automaker SAIC. MG is known for affordable vehicles with a focus on modern technology and youthful appeal.", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4158), null },
                    { new Guid("c11c6f51-c207-4754-9372-046fb4a04c22"), "Hyundai", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4155), null, "A South Korean car manufacturer that offers a wide range of vehicles, known for their affordability, modern designs, and advanced features. Hyundai has rapidly grown to become a major global player.", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4156), null },
                    { new Guid("c6669c8e-f8a8-443c-8446-83c010b44ec0"), "Mazda", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4122), null, "A Japanese automaker known for its stylish designs, advanced technology, and driving pleasure. Mazda’s “Kodo” design philosophy and SkyActiv technology are key highlights.", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4124), null },
                    { new Guid("de716878-747e-4b02-9fce-46d67a13c30f"), "Peugeot", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4146), null, "A French car brand with a long history, known for producing elegant and reliable vehicles. Peugeot is recognized for its sophisticated design, comfort, and European flair.", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4147), null }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "FeatureId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "FeatureName", "Icon", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3867), null, "Automatically processes toll payments while driving", "Etc", "etc", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fetc-icon.png?alt=media&token=e2494201-b1ff-4cfa-982d-4618537ce4c5", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3868), null },
                    { new Guid("06653486-dec4-4054-ba49-c3a63490453e"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3863), null, "Covers and protects the engine compartment from external elements", "Bonnet", "bonnet", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fbonnet-icon.png?alt=media&token=a39d6283-4a5a-48a9-8c6a-8c2d539cd05b", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3864), null },
                    { new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3781), null, "Displays rear visuals to aid in reversing safely", "Reverse Camera", "reverseCamera", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Freverse_camera-icon.png?alt=media&token=fff470fe-095c-4b9e-ac98-aa31827a6f91", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3782), null },
                    { new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3795), null, "Provides an open roof option for natural light and ventilation", "Sun Roof", "sunRoof", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fsunroof-icon.png?alt=media&token=88b4101d-1fec-40c0-9534-989e39d08516", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3796), null },
                    { new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3772), null, "Offers a 360-degree view around the vehicle for safer maneuvering", "Camera 360", "camera360", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2F360_camera-icon.png?alt=media&token=12ef3912-ad25-4216-9d8a-aa3a10f3d956", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3772), null },
                    { new Guid("4481e46d-e85b-4870-a210-cdfea8932641"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3792), null, "Projects essential driving information onto the windshield", "Head Up", "headUp", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fhead_up-icon.png?alt=media&token=63087d56-26a4-4f72-affc-3c5d55c33f31", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3793), null },
                    { new Guid("533a7038-190b-4830-8125-5d2aacb7174e"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3768), null, "Enables wireless connection for hands-free calls and audio streaming", "Bluetooth", "bluetooth", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fbluetooth-icon.png?alt=media&token=422658da-d565-46e6-9e8f-b0ffccbb77dd", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3769), null },
                    { new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3846), null, "Allows charging and connecting devices to the vehicle's system", "USB Port", "usbPort", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fusb-icon.png?alt=media&token=3fce192b-6d2f-43f5-8e0b-3546c1e50e31", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3847), null },
                    { new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3813), null, "Secures infants in a specially designed seat for maximum safety", "Baby Seat", "babySeat", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fbabyseat-icon.png?alt=media&token=2ad93b19-7448-46f9-9029-19871a357eb6", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3826), null },
                    { new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3734), null, "Provides real-time navigation and location tracking while driving", "Map", "map", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fmap-icon.png?alt=media&token=ebf5968e-074f-4f5f-a20c-9020b5dfac7b", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3753), null },
                    { new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3855), null, "A backup tire stored in the vehicle for emergency replacements", "Spare Tire", "spareTire", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fspare_tire-icon.png?alt=media&token=01a8dc7b-e98c-479c-943c-e337e3964e8d", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3855), null },
                    { new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3810), null, "Offers satellite-based navigation and route guidance", "GPS", "gps", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fgps-icon.png?alt=media&token=39ae42c8-a678-4f05-b5dd-9e20eb42d31f", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3810), null },
                    { new Guid("be392eff-ef38-4039-94ec-7922f315ea6a"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3778), null, "Records front road footage for safety and evidence during drives", "Dash Camera", "dashCamera", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fdash_camera-icon.png?alt=media&token=e863e966-7ce5-432f-9629-bd72fcdfcd1f", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3778), null },
                    { new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3775), null, "Assists in parking by displaying rearview visuals on the screen", "Parking Camera", "parkingCamera", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fparking_camera-icon.png?alt=media&token=39675fd9-2e15-4275-a7e1-085a75fb491f", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3776), null },
                    { new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3859), null, "Displays video content for rear-seat entertainment during trips", "DVD Monitor", "dvdMonitor", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fdvd-icon.png?alt=media&token=49e66de4-ec15-42d5-9787-50f23ba0c074", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3859), null },
                    { new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3784), null, "Monitors tire pressure to ensure optimal driving safety", "Tire Pressure Monitor", "tirePressureMonitor", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Ftpms-icon.png?alt=media&token=5d93995e-c886-430c-843b-a80fb6ba3f46", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3785), null },
                    { new Guid("f761d066-304f-49f7-b988-3aca64536d9b"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3872), null, "Deploy in collisions to protect passengers from injury", "Air bags", "airbags", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fairbags-icon.png?alt=media&token=55c3c49f-1b88-4782-8124-7828a6df07f8", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3873), null },
                    { new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3788), null, "Detects collisions and triggers safety mechanisms during impacts", "Impact Sensor", "impactSensor", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fimpact_sensor-icon.png?alt=media&token=1bc9001d-e5ca-4f48-98f8-dc86934cebc0", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(3789), null }
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
                    { new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 0, null, null, "d108cc45-99ba-4ff3-9fc5-26bf6c208f9c", new DateTime(2024, 8, 31, 21, 47, 49, 327, DateTimeKind.Local).AddTicks(1433), null, null, "khanhpham@gmail.com", true, "Nguyen Pham Khanh", null, null, false, null, "KHANHPHAM@GMAIL.COM", null, "AQAAAAIAAYagAAAAEFXyvPV0aDZaOeTQg1O8p8q7mxAhXaD/O9YlYN3IZePtEH9RtuXWO5W/XWdiYvk/1Q==", "0969998878", false, null, null, null, true, false, new DateTime(2024, 8, 31, 21, 47, 49, 327, DateTimeKind.Local).AddTicks(1404), null, "kuem113", null, null },
                    { new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"), 0, null, null, "6ba2d1e8-76ba-411b-b625-2224103c7779", new DateTime(2024, 8, 31, 21, 47, 49, 535, DateTimeKind.Local).AddTicks(8441), null, null, "duythunglungtinhiu@gmail.com", true, "Pham Hoai Duy", null, null, false, null, "DUYTHUNGLUNGTINHIU", null, "AQAAAAIAAYagAAAAEPF3I+G1XdfMO056ke9bexWmUhYcnfqrSdCxW4Sj+PxMlZJkE6BSVpKS6h08v2MqDg==", "0555666612", false, null, null, null, true, false, new DateTime(2024, 8, 31, 21, 47, 49, 535, DateTimeKind.Local).AddTicks(8424), null, "duypro113", null, null },
                    { new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 0, null, null, "3699cb1c-515c-43d2-aa1d-217607756898", new DateTime(2024, 8, 31, 21, 47, 49, 198, DateTimeKind.Local).AddTicks(3242), null, null, "quocdai@gmail.com", true, "Nguyen Quoc Dai", null, null, false, null, "QUOCDAI@GMAIL.COM", "DAINQ115", "AQAAAAIAAYagAAAAELMk1Gr/iOk83gMVwJCrLI421cGeOthUg5o1ukQUNBmAsIHO3xxTe9WmQqW7tbIHHA==", "0932748924", false, null, null, null, true, false, new DateTime(2024, 8, 31, 21, 47, 49, 198, DateTimeKind.Local).AddTicks(3211), null, "dainq115", null, null },
                    { new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"), 0, null, null, "8f10552d-4857-470f-888a-be7d66ce38d6", new DateTime(2024, 8, 31, 21, 47, 49, 406, DateTimeKind.Local).AddTicks(8032), null, null, "khaitoi@gmail.com", true, "Phan Van Khai", null, null, false, null, "KHAITOI@GMAIL.COM", null, "AQAAAAIAAYagAAAAEAItkrZE18ZMAf+B2FpS76ngqly1eYYkdwMRpHDiR1KibbLPcaDJw8Pu5gs/ldVPbQ==", "0777444499", false, null, null, null, true, false, new DateTime(2024, 8, 31, 21, 47, 49, 406, DateTimeKind.Local).AddTicks(8010), null, "xautrai123", null, null },
                    { new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 0, null, null, "80e83611-498f-41e3-a5a6-615e17fee95e", new DateTime(2024, 8, 31, 21, 47, 49, 476, DateTimeKind.Local).AddTicks(3505), null, null, "quangdalat@gmail.com", true, "Quang La Tui", null, null, false, null, "QUANGDALAT@GMAIL.COM", null, "AQAAAAIAAYagAAAAEJ6wB6mD9c2n+y0jnwxryWYw0Z29saJpTOZU+FsLr5+vieDrN704O/ODP6Q7Gwwq4g==", "0999777712", false, null, null, null, true, false, new DateTime(2024, 8, 31, 21, 47, 49, 476, DateTimeKind.Local).AddTicks(3481), null, "quangspa09", null, null },
                    { new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 0, null, null, "72503917-5efd-4ba3-acb7-fe1e9fe08827", new DateTime(2024, 8, 31, 21, 47, 49, 260, DateTimeKind.Local).AddTicks(9033), null, null, "toanvan@gmail.com", true, "Van Huu Toan", null, null, false, null, "TOANVAN@GMAIL.COM", null, "AQAAAAIAAYagAAAAEDIMu8opl6KiLJ90ngYAvR90RwgHhG1PeckU09iK7zT6FTe4lCcEvZO5F9P5GzvdMg==", "0999998888", false, null, null, null, true, false, new DateTime(2024, 8, 31, 21, 47, 49, 260, DateTimeKind.Local).AddTicks(9007), null, "vipro123", null, null }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "ModelId", "BrandId", "CreatedAt", "CreatedBy", "Description", "ModelName", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0ed1b055-dcd4-48ee-aeff-7478382f9e96"), new Guid("c6669c8e-f8a8-443c-8446-83c010b44ec0"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4284), null, null, "CX5 Deluxe", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4287), null },
                    { new Guid("16fd3123-d971-422c-b2af-e47978c27f35"), new Guid("c11c6f51-c207-4754-9372-046fb4a04c22"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4318), null, null, "Tucson Premium", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4318), null },
                    { new Guid("1dc0a8e3-19b1-45f0-aec8-a810722de8f5"), new Guid("9bb29e7a-ca23-4418-81d4-b9b66e7cf107"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4309), null, null, "Ecosport", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4310), null },
                    { new Guid("32234d9d-90f2-4011-ba7f-85ead67a98bd"), new Guid("1c38dc33-e4d6-4922-abc4-1fa8cfc314b2"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4312), null, null, "RX450H", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4312), null },
                    { new Guid("4e39763c-501a-47ea-9d11-f884de1e7e4e"), new Guid("de716878-747e-4b02-9fce-46d67a13c30f"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4306), null, null, "3008", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4307), null },
                    { new Guid("542d93fd-4bc2-48df-9e58-f12c17a96d79"), new Guid("b802da6e-e178-46f5-9884-442e0f1067dc"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4323), null, null, "ZS Standard", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4324), null },
                    { new Guid("6e18d51e-2964-4f16-a00c-0d4544671816"), new Guid("4e5784bd-10a3-4fb4-ad50-fb0304da90d9"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4332), null, null, "Innova", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4333), null },
                    { new Guid("affeb1d2-7eb3-4410-a7ca-e3b1adc3cc54"), new Guid("de716878-747e-4b02-9fce-46d67a13c30f"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4320), null, null, "2008 GT", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4321), null },
                    { new Guid("f660d2b0-0444-4c02-b15a-2ebc871d8f4b"), new Guid("a1f14e7e-342b-4f17-b7fc-9e7ca13483b2"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4303), null, null, "VF6 Plus", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4304), null },
                    { new Guid("fdfdef71-0e39-48f0-8eec-71f5429ed285"), new Guid("c11c6f51-c207-4754-9372-046fb4a04c22"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4315), null, null, "Creta", new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4316), null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "CarTypeId", "CreatedAt", "CreatedBy", "DeliveryFeePerKm", "Description", "FreeDeliveryWithinKm", "FuelConsumption", "FuelType", "InstantBooking", "LimitKilometersPerDay", "Location", "LocationDetails", "MaxDeliveryDistance", "ModelId", "OverLimitFeePerKm", "OwnerId", "PricePerDay", "RentalStatus", "RentalTerms", "Seats", "Slug", "Status", "Transmission", "UpdatedAt", "UpdatedBy", "discount", "licensePlate", "year" },
                values: new object[,]
                {
                    { new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), null, new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4500), null, 0, "The 2021 PEUGEOT 2008 GT is a stylish and compact SUV featuring a sporty design, advanced technology, and efficient engine options. It offers a comfortable and spacious interior with premium materials, making it ideal for urban driving and longer journeys", 0, 5f, 0, false, 0, "Thành phố Thủ Đức, Thành phố Hồ Chí Minh", "Thành phố Thủ Đức, Thành phố Hồ Chí Minh", 0, new Guid("affeb1d2-7eb3-4410-a7ca-e3b1adc3cc54"), 0, new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 1101000m, 0, null, 4, "peugeot-2008-gt-2022", true, 1, null, null, 0f, "51H-81511", 0 },
                    { new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), null, new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4493), null, 15, "Comfortable 5-seater car, beautiful car, strong engine, full interior and amenities", 7, 7f, 0, false, 0, "Quận 2, Thành phố Hồ Chí Minh", "Quận 2, Thành phố Hồ Chí Minh", 4, new Guid("16fd3123-d971-422c-b2af-e47978c27f35"), 100, new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 1073000m, 0, null, 5, "hyundai-tucson-premium-2021", true, 1, null, null, 10f, "30K-60501", 0 },
                    { new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), null, new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4512), null, 0, "The 2021 Toyota Innova E is a versatile and reliable MPV designed for family comfort and practicality. It boasts a spacious interior with ample seating and cargo space, advanced safety features, and a smooth driving experience.", 8, 9f, 0, false, 150, "Quận Bình Thạnh, Thành phố Hồ Chí Minh", "Quận Bình Thạnh, Thành phố Hồ Chí Minh", 5, new Guid("6e18d51e-2964-4f16-a00c-0d4544671816"), 0, new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 821000m, 0, null, 7, "toyota-innova-2020", true, 0, null, null, 20f, "51L-28832", 0 },
                    { new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), null, new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4479), null, 10, "Lexus RX 450h automatic transmission manufactured in 2010 Japan\r\nLast inspection date: 7/7/2023\r\nClean and tidy family car", 5, 7f, 0, true, 0, "Quận 2, Thành phố Hồ Chí Minh", "Quận 2, Thành phố Hồ Chí Minh", 0, new Guid("32234d9d-90f2-4011-ba7f-85ead67a98bd"), 150, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 3706000m, 0, null, 5, "lexus-rx450h-2010", true, 1, null, null, 0f, "51A-90056", 0 },
                    { new Guid("8705f403-06bc-4983-8c81-86310959cc37"), null, new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4473), null, 0, "The car is in excellent condition and very clean. Highly recommended!", 0, 9f, 0, true, 50, "Thành phố Thủ Đức, Thành phố Hồ Chí Minh", "Thành phố Thủ Đức, Thành phố Hồ Chí Minh", 7, new Guid("1dc0a8e3-19b1-45f0-aec8-a810722de8f5"), 100, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 666000m, 0, null, 5, "ford-ecosport-2015", true, 1, null, null, 0f, "51F-32056", 0 },
                    { new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), null, new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4447), null, 10, "Mazda CX5 2017-2.0 Fuel efficient\r\nNew, beautiful car, regularly maintained, clean…\r\nSpacious, comfortable car, suitable for family travel.\r\nCar has rear camera, sunroof, dash cam, entertainment system and many other amenities…", 5, 7f, 0, false, 100, "Quận Bình Thạnh, Thành phố Hồ Chí Minh", "Quận Bình Thạnh, Thành phố Hồ Chí Minh", 10, new Guid("0ed1b055-dcd4-48ee-aeff-7478382f9e96"), 200, new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 861000m, 0, null, 4, "mazda-cx5-deluxe-2017", true, 1, null, null, 20f, "15A-34179", 0 },
                    { new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), null, new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4460), null, 10, "Beautiful new family car, original interior, clean, equipped with 3M crystalline film, the car is very cool in hot weather, coated with anti-nail and noise-proof tires.\r\n", 10, 381f, 2, false, 200, "Quận Bình Thạnh, Thành phố Hồ Chí Minh", "Quận Bình Thạnh, Thành phố Hồ Chí Minh", 0, new Guid("f660d2b0-0444-4c02-b15a-2ebc871d8f4b"), 0, new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 953000m, 1, null, 5, "vinfast-vf6-plus-2024", true, 1, null, null, 15f, "51L-21613", 0 },
                    { new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), null, new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4466), null, 0, "Great car! Very comfortable and spacious for my family trip", 0, 10f, 0, false, 0, "Quận 1, Thành phố Hồ Chí Minh", "Quận 1, Thành phố Hồ Chí Minh", 0, new Guid("4e39763c-501a-47ea-9d11-f884de1e7e4e"), 0, new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 1343000m, 0, null, 5, "peugeot-3008-2022", true, 1, null, null, 0f, "51K-41861", 0 },
                    { new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), null, new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4505), null, 20, "The 2021 GARAGES ZS SMART UP STANDARD is a compact SUV designed for urban driving. It features a modern exterior with sleek lines, a spacious and well-equipped interior, and smart technology integration. The vehicle offers a smooth ride with fuel-efficient engine options, making it a practical choice for everyday use.", 0, 4f, 0, true, 0, "Quận 9, Thành phố Hồ Chí Minh", "Quận 9, Thành phố Hồ Chí Minh", 0, new Guid("542d93fd-4bc2-48df-9e58-f12c17a96d79"), 0, new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 976000m, 0, null, 4, "mg-zs-standard-2022", true, 1, null, null, 0f, "21A-13452", 0 },
                    { new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), null, new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4487), null, 10, "Safety:\r\nHyundai Creta has familiar features such as: ABS – EBD – BA brakes, electronic balance, traction control, hill start assist, tire pressure sensor, parking assist sensor, rear camera, 6 airbags…\r\nConvenience:\r\nLeather seats, Bose standard sound system, navigation, speed warning, electronic handbrake…", 5, 6f, 0, false, 0, "Quận 9, Thành phố Hồ Chí Minh", "Quận 9, Thành phố Hồ Chí Minh", 0, new Guid("fdfdef71-0e39-48f0-8eec-71f5429ed285"), 150, new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 1033000m, 0, null, 5, "hyundai-creta-2022", true, 1, null, null, 0f, "51K-39251", 0 }
                });

            migrationBuilder.InsertData(
                table: "CarFeatures",
                columns: new[] { "CarFeatureId", "CarId", "FeatureId" },
                values: new object[,]
                {
                    { new Guid("02a4997b-41d7-424a-a574-e357419c25de"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("037b7cef-ed59-4e3e-9a8c-8ac8ca5a7195"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("07d32bec-0614-42d4-9e9d-c2b1362cc9c8"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("07e5adf5-df15-497d-b35e-e73fbcd11f34"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("0887bf3e-3e88-4afc-a3b5-23064cce57b2"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("0a2cf19c-be27-4109-826e-55be180cec73"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("0d4bfff9-9780-403f-814d-8465d7d939e2"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("0ee8aeff-8507-4a2d-8e63-7b2c16a4b3fe"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("0fac08ad-c052-437c-a953-7dc16ec37ade"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("130ebd68-f37a-49f8-8d9d-436f08e35726"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("15b4e7b4-ef1d-47c4-86a8-2aa6a6274fb9"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("18a1c97d-72e9-4165-abdf-dbae452ee0f1"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("1b62a948-36ba-4a8f-b009-d2fef378c923"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("1d449f54-afce-4e99-97a7-ec8700782a85"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("1dee2c2c-903d-48da-ab5c-55c5f07d5e47"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("1e4f0a37-8ad5-4335-8b08-c5db35e53a85"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("1f69535a-ad06-4c7d-858d-1ba0b9c1c85f"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("20218aa9-a59b-4475-94fe-83e51942bf80"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("2254a845-abec-46cc-b18b-cd6b5da41a53"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("25b890cb-a6d8-4f76-9d33-ec5f939b2fb1"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("26e8f890-9dfe-460e-a6f8-ee32967a8ce8"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("27ddd5a6-1d5a-4579-bef7-4fe23ee392f0"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("29e5c32c-855e-4e07-891f-b6ec04bf1e45"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("32f21ed1-bcfc-4eaa-9755-2017077d47d9"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("358a32da-040c-4465-a799-d8ca5dc4aed6"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("3817ff06-9af5-4ba9-80a4-e5b37f7ba3b2"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("382f7d7f-fe1a-4298-992d-51a6a42180d0"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("3869ca6b-59d0-4917-aa94-213354bc9255"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("38da6dcc-018c-4ecb-a96e-09539b94436a"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("3f43fa65-c27e-455f-9a44-7fdb0d64283a"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("4087db83-d159-4881-b5ba-152cb4cd4420"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("40dc6879-4c3d-460c-be74-fd39dfb6c3f5"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("424db010-d2e1-4967-bf53-8c2cd20cebbc"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("43479f92-2868-42e8-b2f3-6627ffdc3369"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("44a04b5f-dab3-494c-b12b-6bb4a76c7131"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("45bc5546-f22d-4177-b733-6b544a234e16"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("45e8c293-756d-42df-afa3-e0c08a0ad2d0"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("48a9e854-81fa-437a-9b1e-f9b1e49ac47d"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("497facca-3929-40d7-90c7-e2df44d7e24e"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("4b68ddbf-a0fc-40e3-b5e0-9dfc536767a0"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("4c58191d-bc12-49b9-b7ad-24aa8d501c1c"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("4e4d754f-6e8d-481d-a425-d79ad53edf55"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("507798b3-2dc9-4791-9f63-1564f2c507a3"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("510914a3-89e8-4263-a9f2-6491570535b7"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("5239b24c-d3e4-43d0-b57c-02fe3a7e2391"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("52df5e4c-fd5b-461c-b7f8-1f52dbf2f8fc"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("53086613-506b-4926-aeca-b6930131ba45"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("54d604ac-cd1a-465c-9b84-2b05dccd00bb"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("59a211c9-1644-4e75-b095-0536aec2f53b"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("59b18a64-0ff4-47c0-ad8e-5ed27d99fe49"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("5e7c3e76-78d8-4763-ab4e-7240cb16d886"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("5e8af497-5c8f-4fb4-a57b-0f2d5e49045a"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("6013eb53-5731-464a-b90b-10a1a09fade7"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("61a69832-7ee7-4cf3-b340-0cb0e872fd60"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("61de9d18-d401-489a-87d8-66c256c12627"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("65264b4e-a44a-499b-96a3-91e7fb371652"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("6600ee30-0d5b-44bd-85ed-eddfc7f0bbfe"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("67177507-a563-4022-867f-30e538a37f5a"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("6780bbaa-b90d-44fe-bff0-6a77c67cbd57"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("694e083c-ea58-432b-bab7-1d5dc8c1d39d"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("6a5c43d8-0664-4abf-9780-2bb1bce1b024"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("6b019877-53fc-4875-9b4a-1947d648e9c1"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("6bdc630e-4c85-4105-bf2b-b3c83b36a8bd"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("6ef1896e-34e5-42fb-b6e8-40f4fd317c41"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("704c0330-fe91-45ba-b6d8-f52ac8e49ef6"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("72f01c30-0b36-4795-935a-951c5b46fd5b"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("754d5eb2-8b23-484d-a3a5-87fa0eb0c23a"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("77676318-3413-4986-9352-a257b0950d35"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("78c6bff0-b222-4e71-98a9-68d9d24ff3c1"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("793743b9-c0ea-44d6-96ff-df2ee493b0b9"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("7b4ed3d4-1f8c-442c-9327-cff01c008bd6"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("7c20e53f-2f6e-4bc4-94e5-529b48dee2f2"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("7c2c3cec-f10a-4282-b9df-cbb0863cf72e"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("7d21c61a-c5c7-4332-abb3-f36e72255c97"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020") },
                    { new Guid("7d41e290-8f9b-4763-9bc1-6d6b1294f442"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("7f3779e9-be0d-4e63-851e-b8a210cdd256"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("820fffb2-47a1-4fe2-9133-be6d29bc5173"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("85267dd6-60ff-4283-ac4a-3323df342c4b"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("89dacb66-ad4e-490b-a183-e67f28cb28d1"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("8b3e2b55-f8db-45e3-9c82-60d84e826fc2"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("8ed64f44-86cd-49d4-a058-4f7c0f1cb7fb"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("8f3addd8-bdc0-4f86-94a2-d13ab91338e9"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("8faf57d4-887c-494c-84fa-018c228ae29e"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("903d5ba7-8ea8-4bbf-9e5d-040b0078b4cc"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("93911cc6-6ecc-43f7-ae83-c601c7b85c11"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("9af29473-b29d-4ea8-a26d-4c380b3e8438"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("a105704d-b39d-4f4c-a4f5-d94b46b5002b"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("a2eb972d-762b-41c6-93d0-41ec7dd11e26"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("a3a49676-75b1-4f5b-8697-ad79cad41458"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("a501d5e9-6954-4aca-864e-4b67ff73bccd"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("a70514e1-95aa-40bb-84ea-26f351aef544"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("a88ecc24-209c-4aaf-8c28-2c771ec5293b"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("ab75764b-7581-4c4e-b268-3b152961c27c"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("ad82a091-5301-47ce-8016-edddf5198433"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("ade937d3-f433-4f6b-b6bf-614a6b2f7c22"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("aea16103-2234-4f09-98e2-e91de3c899a0"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("b47cd4b6-2ce6-41a0-87ca-7a5ffc98d2a3"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("b59cdefa-691f-48fe-9e66-26ed4c023d9c"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("b65f4a47-810f-409a-b992-75c539dd02d9"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("b66d3375-b73d-4e2a-92a0-7e3d24d673ed"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("bb86189b-6059-4289-8510-41909bd8aa8f"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("bbb10aae-b034-4251-886c-e7d471928c79"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("bd84671c-98c2-437d-a6dc-3d6c423cc630"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("be0e2c28-6e7d-485b-9af8-e08cd91c86d6"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("c439a8f9-42d7-4e0b-8dea-671645e48157"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("c53a467f-76c8-41ef-87be-038a2eb4c7c5"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("c5710cf3-44c0-47f9-a411-1e3063e053a1"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("cb9feb68-86e5-407c-a2eb-7364d52d4a26"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("cc409f82-de18-49b4-929b-813185b58315"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("cd004243-99ff-4b91-891f-44ae14973a4f"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("d0cf8f9d-70d7-4c75-a2b1-323d17bf2cd7"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("d2152edc-eb7e-408a-bdfa-bc26b3d3ce8e"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("d2b3e3ac-6e55-46e9-99ea-95ed373cf0f9"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("d46dddb2-996b-42ff-9cba-52efeb064b58"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("d48cd2bc-ae3e-44f9-9655-6531af5176fd"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("d6e97f05-1503-465f-8a17-301b793d7744"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("d829fd7b-a183-413b-99dd-661879d7e532"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("e170448e-e202-483b-8a2f-1b2fd43a899c"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("e32402c5-4236-4d26-9a1d-775969f37f22"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("e53b3763-15a6-41dd-947c-8e8ca90916da"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("e5566b7e-4c3b-447d-bccd-b5dd648b995e"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("e5c9ce5c-30a4-4ce3-bda4-a69067c0f32b"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("e5e077ab-1bb3-4f24-bf0a-50ad9c36b7c6"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("e65ba93a-7fa8-4db7-8ff0-a668c371d766"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("e66deb04-4506-4334-9371-1f6e596c7068"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("e6757420-e22f-47ef-b2a1-a2f5be3cc50f"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("e87c6fe1-e3d9-4ad2-8c7b-c43dcddb32c9"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("e8c02ced-c28a-44cd-945d-366cd4b12017"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("e94d8127-d8dd-4a5f-a412-df0bf9afcc60"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("ecb0d65c-b2fc-4e94-8433-c5e54aa12031"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("efaaaa3b-e803-4aea-bddf-6bbd2b8e859f"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("f22ed126-802f-4a22-a096-af667bd2d42e"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("f2d5d822-abb8-485b-a269-289b5c8862b3"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("f58dce58-854e-4e29-9f64-5181079d64f7"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("fd324240-d392-49f6-8132-f9eefb055410"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("fda5451e-d97a-42e0-b27d-6bcfe7980fdc"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("ff93aebd-1e9e-4879-9dd8-13fe9b1ef72f"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "CarId", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy", "Url" },
                values: new object[,]
                {
                    { new Guid("01415b07-05d0-44d4-9027-4f40e52d25c1"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4687), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar42.jpg?alt=media&token=78c1211b-d7a7-45ed-a03a-09a442c2b529" },
                    { new Guid("052fbe49-a2d1-4c88-9586-516783ed4890"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4754), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar73.jpg?alt=media&token=1750f1a1-62c5-4ab9-87ad-89301f4bc9b2" },
                    { new Guid("06a627e6-aaae-49dd-a327-b489c1d23aea"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4796), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar101.jpg?alt=media&token=77127151-3472-4206-8540-6909ec874c71" },
                    { new Guid("0831c830-8ab9-41ee-8abe-aeea4f832715"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4621), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar11.jpg?alt=media&token=41cf30ec-f792-4074-9406-a5d2a98a49e6" },
                    { new Guid("0d18713b-3b35-444c-8b44-315761eb5b91"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4730), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar61.jpg?alt=media&token=fab2b814-962d-4098-839c-758fb97642e5" },
                    { new Guid("10528d9c-5134-491c-b44c-8f460bfc602b"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4679), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar33.jpg?alt=media&token=557246dd-3d64-45a5-97fa-9b122cd316c9" },
                    { new Guid("16931f6d-b074-4bd2-9082-3de35b6db9d5"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4629), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar12.jpg?alt=media&token=c1f10fdd-cb99-4c27-933d-4700acc9272e" },
                    { new Guid("16aef887-6abe-41d6-9774-eb3c9230593d"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4803), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar104.jpg?alt=media&token=9688114d-001b-4f26-a5d8-562d9fb42bf7" },
                    { new Guid("17d5a593-480f-4eaf-9acf-a615bdee8a6f"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4761), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar81.jpg?alt=media&token=22679c70-85f4-4b86-8934-fb1d2a60b1b9" },
                    { new Guid("27e79248-04e4-4961-a0b1-cf22c2319ae4"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4634), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar14.jpg?alt=media&token=6ce903bb-ce8b-4c6d-bc34-d8a1b664f625" },
                    { new Guid("2ac1891e-4502-4bd6-b470-f34aa0dd8a35"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4742), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar65.jpg?alt=media&token=8761aa35-f030-4fa7-a020-66f0a6810090" },
                    { new Guid("2f1fc4e4-b8c9-4541-941e-46ac106564f9"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4719), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar53.jpg?alt=media&token=c76e6223-2ca1-4bac-bd7b-dd3f18323f37" },
                    { new Guid("36b03555-79cb-4d92-bf47-7c3679fe8c4a"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4769), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar84.jpg?alt=media&token=0c49d25b-e1c5-4b31-b5eb-a313baa44b5e" },
                    { new Guid("3817a903-cf93-40d1-a10e-0327c7573281"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4785), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar91.jpg?alt=media&token=466bda06-2bf1-493f-9dd5-eee4ce0a94ab" },
                    { new Guid("3fb9c107-9d5d-4f14-a566-02597e2f1fb3"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4747), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar67.jpg?alt=media&token=63ef5ae3-3d82-4e38-8412-aaa93f6785b6" },
                    { new Guid("406f7247-2478-40c9-b71b-7a767eb9c75f"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4716), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar52.jpg?alt=media&token=ad7a0fd8-b4eb-4326-a475-342a9e0b01b8" },
                    { new Guid("4c43c5b7-b5a8-441f-a452-59f7cf342661"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4764), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar82.jpg?alt=media&token=de9c9bc7-c8e8-4969-b680-11fd990fe8a2" },
                    { new Guid("4d4c2964-6453-4522-923e-1688da305391"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4642), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar23.jpg?alt=media&token=fd7110ec-aa36-4610-a69d-b00abdf886ec" },
                    { new Guid("53735351-aea9-405c-b159-27c3db212eeb"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4682), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar34.jpg?alt=media&token=d7874dde-8f83-4d86-a902-04ce22c9942c" },
                    { new Guid("56f0387b-b33f-4b01-80a6-09e9c1617839"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4706), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar51.jpg?alt=media&token=6e55f0be-c666-4c50-a30e-44b4a703260d" },
                    { new Guid("5f11ba97-bde5-4400-b6dd-b4e02025a0d7"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4644), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar24.jpg?alt=media&token=263ace26-9d00-41d4-869c-760319e406dd" },
                    { new Guid("6154aab4-b0ea-4c05-961d-f427d8d76164"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4744), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar66.jpg?alt=media&token=d3102c30-035b-47cd-a8f8-f66be7a24f6f" },
                    { new Guid("632862d4-07ee-4f1b-9145-0b7538661549"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4676), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar32.jpg?alt=media&token=9a497c45-8b33-40ae-bf8a-86b29747324b" },
                    { new Guid("72c15c93-5ddb-4372-874c-d0b8efb84b4b"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4793), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar94.jpg?alt=media&token=94d25ed1-c76b-4edf-be53-0fe909ec5307" },
                    { new Guid("7ad9f62a-262e-44f1-ba1d-4fa5445100ba"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4787), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar92.jpg?alt=media&token=fc46713e-0c32-486c-9c6c-546318f09d9d" },
                    { new Guid("7f27a9f3-a44f-45ee-855c-dbd29c50de83"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4700), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar43.jpg?alt=media&token=b994c70b-b366-44dc-bcbe-d4c6219ba189" },
                    { new Guid("7fe66fef-109a-4a1b-b7f5-dd8fab2b6cb0"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4782), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar85.jpg?alt=media&token=8ab32d35-6b26-4fb7-8a5a-4e013161a768" },
                    { new Guid("86ebd101-6115-47d9-8773-e0b6e777ffa9"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4685), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar41.jpg?alt=media&token=e8d9380a-0931-4215-a080-96204098774d" },
                    { new Guid("8b4f2cd3-7d63-4f43-acff-e10cc109c6c8"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4721), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar54.jpg?alt=media&token=ed8a9204-288e-44f8-b047-ba4a80d5a45e" },
                    { new Guid("91762bd8-9200-4d45-9ee8-e8f0e983e921"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4639), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar22.jpg?alt=media&token=745493d0-4f34-4c7f-bb8c-f8c891e01422" },
                    { new Guid("94b84909-d132-41cb-ab2b-96b283105e10"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4749), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar71.jpg?alt=media&token=f67cdcdb-55a4-46da-bcab-a498b8eea245" },
                    { new Guid("98044320-53b7-4efe-b03b-a628ee058c09"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4737), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar63.jpg?alt=media&token=34a62380-de76-46c7-9752-9b13e8cc7ac5" },
                    { new Guid("9edc92db-d030-41d1-8543-a53932e6e4de"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4703), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar44.jpg?alt=media&token=e55eeb29-93b0-47b3-911f-df204e877469" },
                    { new Guid("a05dc2d8-47b0-4bcb-8a2d-490b359f91e0"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4801), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar103.jpg?alt=media&token=b9e6ed3c-1328-4935-9eab-d3335638e503" },
                    { new Guid("add44282-7e88-4f9a-97ad-d730d4468904"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4732), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar62.jpg?alt=media&token=159d9f2e-fad1-4846-876d-3c4b9fa1e720" },
                    { new Guid("ba3bef04-d8a5-4855-83cc-4ff53ad1b648"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4740), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar64.jpg?alt=media&token=9a4b198d-c2c4-4585-b424-fd2b326fc97c" },
                    { new Guid("bf8a664f-88fe-4e7c-b91c-427dd10970c2"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4636), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar21.jpg?alt=media&token=735db85a-0e4f-4645-a764-1657d1ccf7d0" },
                    { new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4646), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar31.jpg?alt=media&token=6c0188d7-d743-4e0b-9795-a0ceeae64dba" },
                    { new Guid("c1d350f5-299f-4a1c-836c-4e7b879f7983"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4767), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar83.jpg?alt=media&token=127dc8ca-bcdb-42a1-9e7c-44e35ca985c8" },
                    { new Guid("df82701f-1bdf-4268-999c-353da1707016"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4752), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar72.jpg?alt=media&token=30a3ac2a-0797-4240-b65e-8a3ceb63a839" },
                    { new Guid("e33dfafe-cf13-43ba-93bc-9b150831123e"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4632), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar13.jpg?alt=media&token=2782d4ec-0184-47a7-8964-148e4c6928ae" },
                    { new Guid("e95e3e73-79a0-4de3-93cc-9f658c6fd641"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4759), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar74.jpg?alt=media&token=95622732-d623-4eda-aa62-6c8ee1e96f28" },
                    { new Guid("f5c54779-856b-4338-85fe-3f6fdd6f2498"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4798), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar102.jpg?alt=media&token=46f90372-9790-43f5-ae41-6f35c7961660" },
                    { new Guid("ff5cc549-62f0-405d-98d8-809484fde891"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new DateTime(2024, 8, 31, 21, 47, 49, 137, DateTimeKind.Local).AddTicks(4791), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar93.jpg?alt=media&token=782b1c2f-49d2-4673-8101-330020231a01" }
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
