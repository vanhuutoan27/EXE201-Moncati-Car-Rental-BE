using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoncatiCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
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
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PickupLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReturnLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RentalStatus = table.Column<int>(type: "int", nullable: false),
                    RentalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InsuranceAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DepositAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RemainAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    Flag = table.Column<bool>(type: "bit", nullable: false),
                    RentalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                        name: "FK_Reviews_Rentals_RentalId",
                        column: x => x.RentalId,
                        principalTable: "Rentals",
                        principalColumn: "RentalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_Author",
                        column: x => x.Author,
                        principalTable: "Users",
                        principalColumn: "Id");
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
                    { new Guid("1c38dc33-e4d6-4922-abc4-1fa8cfc314b2"), "Lexus", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9136), null, "The luxury division of Toyota, Lexus is renowned for its refined craftsmanship, advanced technology, and smooth, comfortable rides. It’s a symbol of reliability and premium quality.", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9136), null },
                    { new Guid("4e5784bd-10a3-4fb4-ad50-fb0304da90d9"), "Toyota", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9145), null, "One of the largest and most reliable car manufacturers in the world. Toyota is known for its long-lasting vehicles, efficiency, and innovations like hybrid technology with models like the Prius.", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9145), null },
                    { new Guid("9bb29e7a-ca23-4418-81d4-b9b66e7cf107"), "Ford", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9133), null, "An American automaker famous for its durable vehicles, including the iconic Ford Mustang and F-Series trucks. Ford has a significant influence on the global automotive industry.", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9134), null },
                    { new Guid("a1f14e7e-342b-4f17-b7fc-9e7ca13483b2"), "Vinfast", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9127), null, "A Vietnamese car manufacturer that quickly gained attention for its electric and gasoline vehicles. VinFast aims to bring Vietnamese-made cars to the global market with a focus on quality and innovation.", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9128), null },
                    { new Guid("b802da6e-e178-46f5-9884-442e0f1067dc"), "Mg", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9142), null, "Originally a British brand, now owned by Chinese automaker SAIC. MG is known for affordable vehicles with a focus on modern technology and youthful appeal.", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9142), null },
                    { new Guid("c11c6f51-c207-4754-9372-046fb4a04c22"), "Hyundai", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9139), null, "A South Korean car manufacturer that offers a wide range of vehicles, known for their affordability, modern designs, and advanced features. Hyundai has rapidly grown to become a major global player.", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9139), null },
                    { new Guid("c6669c8e-f8a8-443c-8446-83c010b44ec0"), "Mazda", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9119), null, "A Japanese automaker known for its stylish designs, advanced technology, and driving pleasure. Mazda’s “Kodo” design philosophy and SkyActiv technology are key highlights.", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9121), null },
                    { new Guid("de716878-747e-4b02-9fce-46d67a13c30f"), "Peugeot", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9130), null, "A French car brand with a long history, known for producing elegant and reliable vehicles. Peugeot is recognized for its sophisticated design, comfort, and European flair.", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9131), null }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "FeatureId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "FeatureName", "Icon", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8940), null, "Automatically processes toll payments while driving", "Etc", "etc", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fetc-icon.png?alt=media&token=e2494201-b1ff-4cfa-982d-4618537ce4c5", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8940), null },
                    { new Guid("06653486-dec4-4054-ba49-c3a63490453e"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8937), null, "Covers and protects the engine compartment from external elements", "Bonnet", "bonnet", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fbonnet-icon.png?alt=media&token=a39d6283-4a5a-48a9-8c6a-8c2d539cd05b", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8937), null },
                    { new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8872), null, "Displays rear visuals to aid in reversing safely", "Reverse Camera", "reverseCamera", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Freverse_camera-icon.png?alt=media&token=fff470fe-095c-4b9e-ac98-aa31827a6f91", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8873), null },
                    { new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8897), null, "Provides an open roof option for natural light and ventilation", "Sun Roof", "sunRoof", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fsunroof-icon.png?alt=media&token=88b4101d-1fec-40c0-9534-989e39d08516", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8897), null },
                    { new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8861), null, "Offers a 360-degree view around the vehicle for safer maneuvering", "Camera 360", "camera360", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2F360_camera-icon.png?alt=media&token=12ef3912-ad25-4216-9d8a-aa3a10f3d956", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8861), null },
                    { new Guid("4481e46d-e85b-4870-a210-cdfea8932641"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8882), null, "Projects essential driving information onto the windshield", "Head Up", "headUp", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fhead_up-icon.png?alt=media&token=63087d56-26a4-4f72-affc-3c5d55c33f31", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8883), null },
                    { new Guid("533a7038-190b-4830-8125-5d2aacb7174e"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8857), null, "Enables wireless connection for hands-free calls and audio streaming", "Bluetooth", "bluetooth", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fbluetooth-icon.png?alt=media&token=422658da-d565-46e6-9e8f-b0ffccbb77dd", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8858), null },
                    { new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8927), null, "Allows charging and connecting devices to the vehicle's system", "USB Port", "usbPort", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fusb-icon.png?alt=media&token=3fce192b-6d2f-43f5-8e0b-3546c1e50e31", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8928), null },
                    { new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8920), null, "Secures infants in a specially designed seat for maximum safety", "Baby Seat", "babySeat", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fbabyseat-icon.png?alt=media&token=2ad93b19-7448-46f9-9029-19871a357eb6", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8921), null },
                    { new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8831), null, "Provides real-time navigation and location tracking while driving", "Map", "map", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fmap-icon.png?alt=media&token=ebf5968e-074f-4f5f-a20c-9020b5dfac7b", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8844), null },
                    { new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8930), null, "A backup tire stored in the vehicle for emergency replacements", "Spare Tire", "spareTire", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fspare_tire-icon.png?alt=media&token=01a8dc7b-e98c-479c-943c-e337e3964e8d", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8931), null },
                    { new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8899), null, "Offers satellite-based navigation and route guidance", "GPS", "gps", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fgps-icon.png?alt=media&token=39ae42c8-a678-4f05-b5dd-9e20eb42d31f", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8905), null },
                    { new Guid("be392eff-ef38-4039-94ec-7922f315ea6a"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8867), null, "Records front road footage for safety and evidence during drives", "Dash Camera", "dashCamera", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fdash_camera-icon.png?alt=media&token=e863e966-7ce5-432f-9629-bd72fcdfcd1f", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8868), null },
                    { new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8864), null, "Assists in parking by displaying rearview visuals on the screen", "Parking Camera", "parkingCamera", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fparking_camera-icon.png?alt=media&token=39675fd9-2e15-4275-a7e1-085a75fb491f", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8865), null },
                    { new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8934), null, "Displays video content for rear-seat entertainment during trips", "DVD Monitor", "dvdMonitor", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fdvd-icon.png?alt=media&token=49e66de4-ec15-42d5-9787-50f23ba0c074", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8934), null },
                    { new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8876), null, "Monitors tire pressure to ensure optimal driving safety", "Tire Pressure Monitor", "tirePressureMonitor", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Ftpms-icon.png?alt=media&token=5d93995e-c886-430c-843b-a80fb6ba3f46", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8876), null },
                    { new Guid("f761d066-304f-49f7-b988-3aca64536d9b"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8943), null, "Deploy in collisions to protect passengers from injury", "Air bags", "airbags", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fairbags-icon.png?alt=media&token=55c3c49f-1b88-4782-8124-7828a6df07f8", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8944), null },
                    { new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8879), null, "Detects collisions and triggers safety mechanisms during impacts", "Impact Sensor", "impactSensor", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fimpact_sensor-icon.png?alt=media&token=1bc9001d-e5ca-4f48-98f8-dc86934cebc0", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(8880), null }
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
                    { new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 0, null, null, "988849c0-fcdd-4ddb-a4d8-8b55614b341b", new DateTime(2024, 9, 16, 23, 43, 22, 527, DateTimeKind.Local).AddTicks(8196), null, null, "khanhpham@gmail.com", true, "Nguyen Pham Khanh", null, null, false, null, "KHANHPHAM@GMAIL.COM", "KUEM113", "AQAAAAIAAYagAAAAEAF0ry5+1S9panMinhUfuramMIa1NGXvgT8O46YJ6zxTIB3iSzOpHrPpPDAGk28m0A==", "0969998878", false, null, null, "a079eebb-826d-4204-be3a-511842c77bdf", true, false, new DateTime(2024, 9, 16, 23, 43, 22, 527, DateTimeKind.Local).AddTicks(8183), null, "kuem113", null, null },
                    { new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"), 0, null, null, "c55c4b49-c66e-43e1-8c97-8cbd95b3b283", new DateTime(2024, 9, 16, 23, 43, 22, 730, DateTimeKind.Local).AddTicks(7159), null, null, "duythunglungtinhiu@gmail.com", true, "Pham Hoai Duy", null, null, false, null, "DUYTHUNGLUNGTINHIU", "DUYPRO113", "AQAAAAIAAYagAAAAEJYKyNr46oLmYY1Ai9EvnbwBAvQ9hLdXE8E9mMson8FTemkHfKXfntOBtA/aTVRMUA==", "0555666612", false, null, null, "db034f99-1224-4686-96bb-56123d65c408", true, false, new DateTime(2024, 9, 16, 23, 43, 22, 730, DateTimeKind.Local).AddTicks(7139), null, "duypro113", null, null },
                    { new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 0, null, null, "064e8a6f-4636-4e72-9490-04795a39f41f", new DateTime(2024, 9, 16, 23, 43, 22, 399, DateTimeKind.Local).AddTicks(6439), null, null, "quocdai@gmail.com", true, "Nguyen Quoc Dai", null, null, false, null, "QUOCDAI@GMAIL.COM", "DAINQ115", "AQAAAAIAAYagAAAAECNA5dnP/ULd3UBfZP0k2xSuoMUUvHlLEeFvg/EdVACLQtLVYvvcPWgEca6yuHBc4w==", "0932748924", false, null, null, "dc89f468-694b-46b1-b627-7f9bfe1ff9ed", true, false, new DateTime(2024, 9, 16, 23, 43, 22, 399, DateTimeKind.Local).AddTicks(6420), null, "dainq115", null, null },
                    { new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"), 0, null, null, "2d06dd1a-c754-4b10-818c-6ad9e314a4cd", new DateTime(2024, 9, 16, 23, 43, 22, 590, DateTimeKind.Local).AddTicks(9367), null, null, "khaitoi@gmail.com", true, "Phan Van Khai", null, null, false, null, "KHAITOI@GMAIL.COM", "XAUTRAI123", "AQAAAAIAAYagAAAAEB3uPaaXjqT78ZvmK9G2NXDKXJFv3H2ihGaogJPh29x5qE2A4r7BSjILUqjiWeaLvQ==", "0777444499", false, null, null, "e1d04033-fea6-4689-9416-ea4af2cf317d", true, false, new DateTime(2024, 9, 16, 23, 43, 22, 590, DateTimeKind.Local).AddTicks(9353), null, "xautrai123", null, null },
                    { new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 0, null, null, "8818e2aa-01ba-407f-85a9-694c051ad54e", new DateTime(2024, 9, 16, 23, 43, 22, 658, DateTimeKind.Local).AddTicks(3129), null, null, "quangdalat@gmail.com", true, "Quang La Tui", null, null, false, null, "QUANGDALAT@GMAIL.COM", "QUANGSPA009", "AQAAAAIAAYagAAAAEFfSDoDgPMCZg7RKHqWMk8IwZAEPCZ73o3IdXi/vHK0eCJBEYrGoz63kCKN832r5+w==", "0999777712", false, null, null, "dd535c5f-e517-4744-bb1b-eff84783ba92", true, false, new DateTime(2024, 9, 16, 23, 43, 22, 658, DateTimeKind.Local).AddTicks(3110), null, "quangspa09", null, null },
                    { new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 0, null, null, "f7beb47b-1f49-4c55-8b97-7b5deac1c83d", new DateTime(2024, 9, 16, 23, 43, 22, 463, DateTimeKind.Local).AddTicks(2723), null, null, "toanvan@gmail.com", true, "Van Huu Toan", null, null, false, null, "TOANVAN@GMAIL.COM", "VIPRO123", "AQAAAAIAAYagAAAAEBsSnRBFPT1lUtARiWG+Rvuxb4EwFyJK0yDyfZbWeufGX9bHu1ehOyypjoKQZXT7FA==", "0999998888", false, null, null, "4d3e8a7c-efb4-4d53-b8ac-f99d0e6559fe", true, false, new DateTime(2024, 9, 16, 23, 43, 22, 463, DateTimeKind.Local).AddTicks(2710), null, "vipro123", null, null }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "ModelId", "BrandId", "CreatedAt", "CreatedBy", "Description", "ModelName", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0ed1b055-dcd4-48ee-aeff-7478382f9e96"), new Guid("c6669c8e-f8a8-443c-8446-83c010b44ec0"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9272), null, null, "CX5 Deluxe", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9273), null },
                    { new Guid("16fd3123-d971-422c-b2af-e47978c27f35"), new Guid("c11c6f51-c207-4754-9372-046fb4a04c22"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9296), null, null, "Tucson Premium", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9296), null },
                    { new Guid("1dc0a8e3-19b1-45f0-aec8-a810722de8f5"), new Guid("9bb29e7a-ca23-4418-81d4-b9b66e7cf107"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9287), null, null, "Ecosport", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9288), null },
                    { new Guid("32234d9d-90f2-4011-ba7f-85ead67a98bd"), new Guid("1c38dc33-e4d6-4922-abc4-1fa8cfc314b2"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9290), null, null, "RX450H", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9290), null },
                    { new Guid("4e39763c-501a-47ea-9d11-f884de1e7e4e"), new Guid("de716878-747e-4b02-9fce-46d67a13c30f"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9284), null, null, "3008", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9285), null },
                    { new Guid("542d93fd-4bc2-48df-9e58-f12c17a96d79"), new Guid("b802da6e-e178-46f5-9884-442e0f1067dc"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9302), null, null, "ZS Standard", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9302), null },
                    { new Guid("6e18d51e-2964-4f16-a00c-0d4544671816"), new Guid("4e5784bd-10a3-4fb4-ad50-fb0304da90d9"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9305), null, null, "Innova", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9306), null },
                    { new Guid("affeb1d2-7eb3-4410-a7ca-e3b1adc3cc54"), new Guid("de716878-747e-4b02-9fce-46d67a13c30f"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9299), null, null, "2008 GT", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9299), null },
                    { new Guid("f660d2b0-0444-4c02-b15a-2ebc871d8f4b"), new Guid("a1f14e7e-342b-4f17-b7fc-9e7ca13483b2"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9281), null, null, "VF6 Plus", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9282), null },
                    { new Guid("fdfdef71-0e39-48f0-8eec-71f5429ed285"), new Guid("c11c6f51-c207-4754-9372-046fb4a04c22"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9293), null, null, "Creta", new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9294), null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "CarTypeId", "CreatedAt", "CreatedBy", "DeliveryFeePerKm", "Description", "FreeDeliveryWithinKm", "FuelConsumption", "FuelType", "InstantBooking", "LimitKilometersPerDay", "Location", "LocationDetails", "MaxDeliveryDistance", "ModelId", "OverLimitFeePerKm", "OwnerId", "PricePerDay", "RentalStatus", "RentalTerms", "Seats", "Slug", "Status", "Transmission", "UpdatedAt", "UpdatedBy", "discount", "licensePlate", "year" },
                values: new object[,]
                {
                    { new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), null, new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9506), null, 0, "The 2021 PEUGEOT 2008 GT is a stylish and compact SUV featuring a sporty design, advanced technology, and efficient engine options. It offers a comfortable and spacious interior with premium materials, making it ideal for urban driving and longer journeys", 0, 5f, 0, false, 0, "Thành phố Thủ Đức, Thành phố Hồ Chí Minh", "Thành phố Thủ Đức, Thành phố Hồ Chí Minh", 0, new Guid("affeb1d2-7eb3-4410-a7ca-e3b1adc3cc54"), 0, new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 1101000m, 0, null, 4, "peugeot-2008-gt-2022-x5uac6", true, 1, new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9506), null, 0f, "51H-815.11", 2021 },
                    { new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), null, new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9499), null, 15, "Comfortable 5-seater car, beautiful car, strong engine, full interior and amenities", 7, 7f, 0, false, 0, "Quận 2, Thành phố Hồ Chí Minh", "Quận 2, Thành phố Hồ Chí Minh", 4, new Guid("16fd3123-d971-422c-b2af-e47978c27f35"), 100, new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 1073000m, 0, null, 5, "hyundai-tucson-premium-2021-nixl5v", true, 1, new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9500), null, 10f, "30K-605.01", 2021 },
                    { new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), null, new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9520), null, 0, "The 2021 Toyota Innova E is a versatile and reliable MPV designed for family comfort and practicality. It boasts a spacious interior with ample seating and cargo space, advanced safety features, and a smooth driving experience.", 8, 9f, 0, false, 150, "Quận Bình Thạnh, Thành phố Hồ Chí Minh", "Quận Bình Thạnh, Thành phố Hồ Chí Minh", 5, new Guid("6e18d51e-2964-4f16-a00c-0d4544671816"), 0, new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 821000m, 0, null, 7, "toyota-innova-2020-3ymd75", true, 0, new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9520), null, 20f, "51L-288.32", 2020 },
                    { new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), null, new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9480), null, 10, "Lexus RX 450h automatic transmission manufactured in 2010 Japan<br/>Last inspection date: 7/7/2023<br/>Clean and tidy family car", 5, 7f, 0, true, 0, "Quận 2, Thành phố Hồ Chí Minh", "Quận 2, Thành phố Hồ Chí Minh", 0, new Guid("32234d9d-90f2-4011-ba7f-85ead67a98bd"), 150, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 3706000m, 0, null, 5, "lexus-rx450h-2010-4urh11", true, 1, new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9481), null, 0f, "51A-900.56", 2010 },
                    { new Guid("8705f403-06bc-4983-8c81-86310959cc37"), null, new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9473), null, 0, "The car is in excellent condition and very clean. Highly recommended!", 0, 9f, 0, true, 50, "Thành phố Thủ Đức, Thành phố Hồ Chí Minh", "Thành phố Thủ Đức, Thành phố Hồ Chí Minh", 7, new Guid("1dc0a8e3-19b1-45f0-aec8-a810722de8f5"), 100, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 666000m, 0, null, 5, "ford-ecosport-2015-duz4bh", true, 1, new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9474), null, 0f, "51F-320.56", 2015 },
                    { new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), null, new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9445), null, 10, "Mazda CX5 2017-2.0 Fuel efficient<br/>New, beautiful car, regularly maintained, clean…<br/>Spacious, comfortable car, suitable for family travel.<br/>Car has rear camera, sunroof, dash cam, entertainment system and many other amenities…", 5, 7f, 0, false, 100, "Quận Bình Thạnh, Thành phố Hồ Chí Minh", "Quận Bình Thạnh, Thành phố Hồ Chí Minh", 10, new Guid("0ed1b055-dcd4-48ee-aeff-7478382f9e96"), 200, new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 861000m, 0, null, 4, "mazda-cx5-deluxe-2017-vq57kp", true, 1, new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9446), null, 20f, "15A-341.79", 2017 },
                    { new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), null, new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9460), null, 10, "Beautiful new family car, original interior, clean, equipped with 3M crystalline film, the car is very cool in hot weather, coated with anti-nail and noise-proof tires.<br/>", 10, 381f, 2, false, 200, "Quận Bình Thạnh, Thành phố Hồ Chí Minh", "Quận Bình Thạnh, Thành phố Hồ Chí Minh", 0, new Guid("f660d2b0-0444-4c02-b15a-2ebc871d8f4b"), 0, new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 953000m, 1, null, 5, "vinfast-vf6-plus-2024-j7tjxw", true, 1, new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9460), null, 15f, "51L-216.13", 2024 },
                    { new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), null, new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9466), null, 0, "Great car! Very comfortable and spacious for my family trip", 0, 10f, 0, false, 0, "Quận 1, Thành phố Hồ Chí Minh", "Quận 1, Thành phố Hồ Chí Minh", 0, new Guid("4e39763c-501a-47ea-9d11-f884de1e7e4e"), 0, new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 1343000m, 0, null, 5, "peugeot-3008-2022-wlh7hm", true, 1, new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9467), null, 0f, "51K-418.61", 2022 },
                    { new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), null, new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9512), null, 20, "The 2021 GARAGES ZS SMART UP STANDARD is a compact SUV designed for urban driving. It features a modern exterior with sleek lines, a spacious and well-equipped interior, and smart technology integration. The vehicle offers a smooth ride with fuel-efficient engine options, making it a practical choice for everyday use.", 0, 4f, 0, true, 0, "Quận 9, Thành phố Hồ Chí Minh", "Quận 9, Thành phố Hồ Chí Minh", 0, new Guid("542d93fd-4bc2-48df-9e58-f12c17a96d79"), 0, new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 976000m, 0, null, 4, "mg-zs-standard-2022-k18fhr", true, 1, new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9513), null, 0f, "21A-134.52", 2022 },
                    { new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), null, new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9489), null, 10, "Safety:\nHyundai Creta has familiar features such as: ABS – EBD – BA brakes, electronic balance, traction control, hill start assist, tire pressure sensor, parking assist sensor, rear camera, 6 airbags…<br/>Convenience: Leather seats, Bose standard sound system, navigation, speed warning, electronic handbrake…", 5, 6f, 0, false, 0, "Quận 9, Thành phố Hồ Chí Minh", "Quận 9, Thành phố Hồ Chí Minh", 0, new Guid("fdfdef71-0e39-48f0-8eec-71f5429ed285"), 150, new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 1033000m, 0, null, 5, "hyundai-creta-2022-wesu5v", true, 1, new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9489), null, 0f, "51K-392.51", 2022 }
                });

            migrationBuilder.InsertData(
                table: "CarFeatures",
                columns: new[] { "CarFeatureId", "CarId", "FeatureId" },
                values: new object[,]
                {
                    { new Guid("0079370f-d727-4cb4-913e-7fffee1d5ec7"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("011afe81-28b9-4fa6-8bc6-e730eb76d586"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("012de710-e1c1-4344-9fac-a090a79e7487"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("04478558-d4ae-4cdb-9d76-0b07a972b8d1"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("04bc33e6-7e7d-429e-85ac-98ff8cc1d081"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("09a98aa4-adac-44e1-b2b6-62ad1905063c"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("0adc8c54-5726-47f3-a47c-6ce51838e9dd"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("0d3f4de4-e7d2-4ae4-a85f-9e36106ab5e0"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("0eb5155a-9e1a-4157-b367-b2a5fb91d638"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("0ec637f4-fc19-4d29-87bf-bb677fe8748b"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("15e286f8-138a-43f8-9846-002c30033bf0"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("18561628-ddbc-4181-aa86-c86c57ef6277"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("1907401c-cbbe-44e5-9676-bfe5c8cef758"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("199a5e85-5926-41ec-8e09-f8019a20dd97"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("1b4c1f45-10fe-4a69-bc40-def125a06309"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("2277ab49-8d4c-4153-a142-abbb736c9a7f"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("264af823-2ac9-48c6-a958-3937576f1794"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("29278e74-a6a7-49ba-8909-d308d8fad858"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("2c68564e-f637-48f3-b206-c1fd715c6d67"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("30fe90b0-7c87-486a-8e69-2e558e81f52a"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("325ab062-ce1b-4876-b9d4-85cc9d8080d7"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("338e1b7c-1881-4a89-9966-b19cf87a3bb7"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("341a965f-4561-4fcd-b27f-bed13befbba4"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("35805686-af0d-4930-b247-b098e45cd768"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("36484e6f-eed5-459d-98d5-94ffdce531a5"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020") },
                    { new Guid("36b5d92b-8c79-4e9d-9846-ca232a71c792"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("38eff55d-e311-481c-9dfb-95ec3dd4d0a3"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("390fb556-cbec-4752-9732-9fe147066ed3"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("39e1a852-7923-4ce8-a334-1b636263d4c7"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("3b3c13bb-20a6-4b56-9c29-b9374b8cb2f1"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("3b66ae02-c67d-4163-a2e5-eff4016bb4bb"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("43ceb81a-6685-43a4-83d4-2e592ecae2ca"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("45bce616-2857-4126-a680-66766016a164"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("465e30d5-953b-4118-b2ea-a9c9b36416bf"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("4861eff9-7d54-485c-9e4f-0d265187e49d"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("48d6a8a0-3ef1-4e1c-a6a5-a65d32f068f2"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("4ce06706-90ed-494a-b898-2a07832cd3f7"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("54290f16-c3d5-4224-8d83-fa1edf11931c"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("557b90cb-e08b-420f-821c-2fb11dadc6fa"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("55bc36a7-0aff-456c-a376-e67381989518"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("58c5d923-4f77-4eee-9005-cf4d05e632f7"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("58fd0256-1cd4-45f0-85af-40f46ea34a71"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("5abbeecf-297d-4858-a361-082a80e1ccba"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("5c8c1bb9-e3c3-4724-968c-ee80548c7efd"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("5d205524-07f6-4806-809a-1554d52bf556"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("612579de-b38f-4f86-8f74-34b6baaff4e1"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("644649d6-0a9b-46b2-94e8-331065fb634d"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("65c00c94-2a8f-4850-8daa-2c217ed5eb32"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("6d0cf248-6d02-4f65-8e67-1806ecaa07e0"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("6f258a8f-a09e-4b62-9b26-d9b0a30fd03c"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("6fbd2ac2-6958-4b1d-89e0-3d5b328fc2e3"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("70749d25-8fab-4f18-886e-7b074c6419b1"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("70d22794-1ce0-4230-b744-fdd492e43e13"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("74d96b24-9b6c-4f36-8db6-7f25c2dac801"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("7530accb-c0ed-4d4c-a615-20026428f39a"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("75d74760-96f7-4a69-b88f-fd382db1a178"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("767105a0-32f8-4a82-b627-8daff606511a"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("76bb0ac8-2ff0-4aae-a63e-adf0fe67142d"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("77741c7f-108a-4de3-a07a-d7b94551508d"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("77805996-858a-4e37-b6ee-d23f60e65176"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("7cd102d0-8c5d-4adc-b51c-1fb3d5c35d4b"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("817765c0-f118-4f16-aa3e-bbb21f87a1cb"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("835715b8-f4fa-437c-873d-03857ec989ab"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("84686ee9-1089-4084-ba8e-2dca034c27b1"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("85a7c065-077a-42c3-ac85-8227d2db15eb"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("87729be9-efa4-4292-b681-4ee09f621099"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("87becde9-3286-4f6b-88f8-8c275e62a598"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("88156e6d-d5e1-47ca-9a7c-cd707858d7f3"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("8c0a36b4-6ff7-4eb8-8e6a-dccf3734e105"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("8c770d61-3df3-42bd-ae3b-758af03d33fd"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("8d1ac6fa-e67d-46ab-915a-c4c36576f9c3"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("8d48e163-3c64-4786-8508-63c03e25b333"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("8df96209-67c7-454a-9f24-a54372302e37"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("8e4be143-8928-4933-969d-6f90def26e9e"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("90304272-ea48-4b8f-9a74-a1e7d602bf02"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("91f90fa8-448e-4595-9023-b06523f531d9"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("92bd29e0-731c-4eba-a1fa-9f70e10ed827"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("93af733b-698c-4989-bb97-fa31b324e2a6"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("9652a99c-b668-4dc3-a5fb-1c9e119cb3c8"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("9a89cdc4-0dbb-43c1-be97-a3d5164bdbeb"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("9b7523eb-2c86-4509-b6d3-b6881ba0b2f8"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("9eda9fb9-a537-43e3-9f53-9e9dd6907c74"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("a0185274-e9d8-4568-abe5-a9533c866193"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("a049717b-d837-4110-9e62-968647b0b371"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("a45d6cf3-7e68-48d7-a48e-93a1c6e341cd"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("a4de277f-57c2-4b77-8efc-cfde7e94079b"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("a8f6324d-814f-4ecc-bd8b-ee110c708a93"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("aaa6562d-6bba-408c-8ef1-2cd143752252"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("ad18678c-9c9b-4845-86c7-79b60eb506ad"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("ad76c63a-8a3d-4ab1-9ff1-0d9419f1c51f"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("af1f121c-1f3f-43ad-9e52-9022e0305d93"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("b23579b5-b3f2-4a92-b478-6ca90f426caf"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("b27468a0-be36-4970-a1d7-e806cc5d4371"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("b32b3e26-46ea-44b4-8b43-4aea77816d89"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("b3cdf864-6257-4963-81b8-2eba933ee77d"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("b78fcdd2-5469-4bab-ae6e-4e3133d11c6b"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("b79ab04a-0876-40d1-8997-26e06bfd1a67"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("b866cf65-b478-4660-8982-5a20c0a63d73"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("bbd29178-5b03-46c0-98c2-dc54e8d7f19f"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("bcf9da8f-aabd-47b3-a930-844770d27587"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("bd686437-552c-4e01-8862-a8eb9b2c023e"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("c12bfd89-7476-45c8-b157-dfb1fa142146"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("ca5502f8-5736-4361-b453-2e7961680d79"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("d0d15e5e-979a-4170-943f-03f763183f45"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("d252b1bb-ad5d-4720-b576-a3b31b6b8f99"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("d2730afd-9cfd-450c-8c7b-281f3eff44f4"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("d464fa66-d70a-4d0f-83d4-6c95c48dd990"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("d6687491-cb05-4d43-a3b3-0624183c425d"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("d6c813b1-5220-463b-a443-f24387bc824f"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("d8213107-77c0-4681-b379-1fafbc893c03"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("d96eef50-5327-4898-80a8-1353d282166b"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("d9f7c790-8721-4fee-8971-2bf2979fe525"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("db3f4732-0224-4a51-9a30-546c051613a0"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("dcf6793f-0127-4dfe-a8cf-a4f0e61c1194"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("de10e0d6-44fd-49b1-8bc8-e3de58209943"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("decbfc51-579e-41a4-8fba-1f24a06a117d"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("e0ffe5bb-a6b9-42a4-adcd-21430e4b0faa"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("e22debd8-2eb5-480a-bf9d-46194ff37a2f"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("e2c20490-d322-4167-9a04-b7c967c41baa"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("e30b8fce-2a97-4e99-827b-9ae074ad46e2"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("e41b3ffc-f94e-4b72-877f-2214f254a8b9"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("e466f1bd-dcac-4ee3-a0f7-9f7bdea40afd"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("e836582e-6e17-44de-a479-00775613c8a6"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("e9107360-5995-4f0a-9b44-620b14944a47"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("ea3449a1-458e-465a-9f81-6d35103ecb49"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("ea91acba-a2b9-4c0f-9b90-ffe5b35bc1e6"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("ebb87c27-3c7d-4d9b-8571-cac810df1476"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("ef6c2bee-fb8c-4b80-9dda-22cbad25b131"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("ef74b5fd-623d-4fb7-a43a-8832a4f87702"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("f17c3b27-56cb-4062-ae05-ceaccf3bf703"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("f3b0cab0-97c1-4d43-8de6-546f66f76e6d"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("f53a73f5-c1d8-4e52-86eb-e1106d1d70b4"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("f594e1f6-4e5f-40cb-9e16-db29aede8753"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("f8040376-d7f4-4428-bbda-d9ed4ad32191"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("f9a33513-4a91-44e0-8c64-a2f10afb70da"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("fd48801d-4c19-4ab5-9802-c99edc98ddcd"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("fffe4702-2f4e-44e5-95ca-8e0b23cb3fc1"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "CarId", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy", "Url" },
                values: new object[,]
                {
                    { new Guid("03071ddf-22c3-4321-9cfc-4c1dd506a9a3"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9746), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar51.jpg?alt=media&token=6e55f0be-c666-4c50-a30e-44b4a703260d" },
                    { new Guid("0831c830-8ab9-41ee-8abe-aeea4f832715"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9687), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar11.jpg?alt=media&token=41cf30ec-f792-4074-9406-a5d2a98a49e6" },
                    { new Guid("113d7987-dea8-4093-8b09-3ee0de72bb3c"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9791), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar81.jpg?alt=media&token=22679c70-85f4-4b86-8934-fb1d2a60b1b9" },
                    { new Guid("119d2e54-a9c0-4b7c-87d6-5cd2f2501da9"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9722), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar31.jpg?alt=media&token=6c0188d7-d743-4e0b-9795-a0ceeae64dba" },
                    { new Guid("13aecfda-8e98-4c0e-abc0-e20f1d13e961"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9761), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar61.jpg?alt=media&token=fab2b814-962d-4098-839c-758fb97642e5" },
                    { new Guid("146a6452-4bc4-4922-bb33-a69d1d0612dd"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9777), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar67.jpg?alt=media&token=63ef5ae3-3d82-4e38-8412-aaa93f6785b6" },
                    { new Guid("155e7784-a812-4571-bead-f8d7ca2478b5"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9755), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar54.jpg?alt=media&token=ed8a9204-288e-44f8-b047-ba4a80d5a45e" },
                    { new Guid("16931f6d-b074-4bd2-9082-3de35b6db9d5"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9695), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar12.jpg?alt=media&token=c1f10fdd-cb99-4c27-933d-4700acc9272e" },
                    { new Guid("1df708b5-2560-4664-89d6-6ee1e3b88d26"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9796), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar83.jpg?alt=media&token=127dc8ca-bcdb-42a1-9e7c-44e35ca985c8" },
                    { new Guid("2263a83a-5199-4240-9ecb-b19701d1fcf5"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9735), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar41.jpg?alt=media&token=e8d9380a-0931-4215-a080-96204098774d" },
                    { new Guid("23fbf12e-52d0-4438-a9fe-f681d12b89fa"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9794), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar82.jpg?alt=media&token=de9c9bc7-c8e8-4969-b680-11fd990fe8a2" },
                    { new Guid("24971c14-5f2f-41aa-886b-1c114186d3bc"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9725), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar32.jpg?alt=media&token=9a497c45-8b33-40ae-bf8a-86b29747324b" },
                    { new Guid("27e79248-04e4-4961-a0b1-cf22c2319ae4"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9701), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar14.jpg?alt=media&token=6ce903bb-ce8b-4c6d-bc34-d8a1b664f625" },
                    { new Guid("38e6db85-3e32-4077-804c-f2287d118fd0"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9743), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar44.jpg?alt=media&token=e55eeb29-93b0-47b3-911f-df204e877469" },
                    { new Guid("4d4c2964-6453-4522-923e-1688da305391"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9707), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar22.jpg?alt=media&token=745493d0-4f34-4c7f-bb8c-f8c891e01422" },
                    { new Guid("53337daf-c5af-452f-802a-d8b829a9d068"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9780), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar71.jpg?alt=media&token=f67cdcdb-55a4-46da-bcab-a498b8eea245" },
                    { new Guid("589b7e11-94c3-4c5b-b4cb-2b3d215be33b"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9749), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar52.jpg?alt=media&token=ad7a0fd8-b4eb-4326-a475-342a9e0b01b8" },
                    { new Guid("5f11ba97-bde5-4400-b6dd-b4e02025a0d7"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9712), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar24.jpg?alt=media&token=263ace26-9d00-41d4-869c-760319e406dd" },
                    { new Guid("61c40521-3a6f-4a6a-816d-8c2a7f449997"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9799), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar84.jpg?alt=media&token=0c49d25b-e1c5-4b31-b5eb-a313baa44b5e" },
                    { new Guid("63d8419b-ae3c-4867-96e2-2773531291d3"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9819), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar101.jpg?alt=media&token=77127151-3472-4206-8540-6909ec874c71" },
                    { new Guid("643c0c50-b89e-4d60-b339-28254d008738"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9775), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar66.jpg?alt=media&token=d3102c30-035b-47cd-a8f8-f66be7a24f6f" },
                    { new Guid("6c521908-21ff-4e8d-a8d0-4c05c8a2e5a7"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9788), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar74.jpg?alt=media&token=95622732-d623-4eda-aa62-6c8ee1e96f28" },
                    { new Guid("6ebfaf1c-748f-484a-b8b7-b7ddac7c883d"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9738), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar42.jpg?alt=media&token=78c1211b-d7a7-45ed-a03a-09a442c2b529" },
                    { new Guid("782d4c8e-2605-4a2d-87ba-3d1f2c9eb4d6"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9730), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar33.jpg?alt=media&token=557246dd-3d64-45a5-97fa-9b122cd316c9" },
                    { new Guid("82428e6a-19f6-4599-aae1-13712934b3f8"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9752), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar53.jpg?alt=media&token=c76e6223-2ca1-4bac-bd7b-dd3f18323f37" },
                    { new Guid("8dd7c100-ccf9-4e7b-a2e6-aa3525698243"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9828), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar104.jpg?alt=media&token=9688114d-001b-4f26-a5d8-562d9fb42bf7" },
                    { new Guid("8df59a4b-c2fe-4023-8a1e-7f308c8f68b8"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9808), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar91.jpg?alt=media&token=466bda06-2bf1-493f-9dd5-eee4ce0a94ab" },
                    { new Guid("90fe95a8-3617-4676-abfa-9f86ed314bbb"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9769), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar64.jpg?alt=media&token=9a4b198d-c2c4-4585-b424-fd2b326fc97c" },
                    { new Guid("91762bd8-9200-4d45-9ee8-e8f0e983e921"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9709), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar23.jpg?alt=media&token=fd7110ec-aa36-4610-a69d-b00abdf886ec" },
                    { new Guid("a870408e-435b-4448-bb23-93bf329e40d5"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9814), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar93.jpg?alt=media&token=782b1c2f-49d2-4673-8101-330020231a01" },
                    { new Guid("bf8a664f-88fe-4e7c-b91c-427dd10970c2"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9704), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar21.jpg?alt=media&token=735db85a-0e4f-4645-a764-1657d1ccf7d0" },
                    { new Guid("bfbbaa76-998f-4d46-bbfe-664be8c4f6a5"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9767), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar63.jpg?alt=media&token=34a62380-de76-46c7-9752-9b13e8cc7ac5" },
                    { new Guid("bfbf38c4-5645-4392-9020-6c5b992ff46e"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9802), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar85.jpg?alt=media&token=8ab32d35-6b26-4fb7-8a5a-4e013161a768" },
                    { new Guid("c5de75b4-9631-43c0-8ac6-a9da568a967a"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9764), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar62.jpg?alt=media&token=159d9f2e-fad1-4846-876d-3c4b9fa1e720" },
                    { new Guid("d539cbdb-a20c-4fd9-ac69-21fcb067249b"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9811), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar92.jpg?alt=media&token=fc46713e-0c32-486c-9c6c-546318f09d9d" },
                    { new Guid("d898f1d5-cf63-4250-a8f7-c8cf25c61a46"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9740), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar43.jpg?alt=media&token=b994c70b-b366-44dc-bcbe-d4c6219ba189" },
                    { new Guid("dad87d5e-c756-4ee5-ae27-c3f84901c9d3"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9733), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar34.jpg?alt=media&token=d7874dde-8f83-4d86-a902-04ce22c9942c" },
                    { new Guid("de16b5e0-65e8-45d1-ae2c-a446febb4b0d"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9786), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar73.jpg?alt=media&token=1750f1a1-62c5-4ab9-87ad-89301f4bc9b2" },
                    { new Guid("e33dfafe-cf13-43ba-93bc-9b150831123e"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9698), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar13.jpg?alt=media&token=2782d4ec-0184-47a7-8964-148e4c6928ae" },
                    { new Guid("e746af29-8cfb-4f2a-b1d8-593f44e0acd7"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9783), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar72.jpg?alt=media&token=30a3ac2a-0797-4240-b65e-8a3ceb63a839" },
                    { new Guid("ec97accb-b58d-4677-b6c5-4c87e3441de9"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9816), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar94.jpg?alt=media&token=94d25ed1-c76b-4edf-be53-0fe909ec5307" },
                    { new Guid("f0e7a8c5-16e7-4a32-bf1d-3cadafaf7153"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9822), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar102.jpg?alt=media&token=46f90372-9790-43f5-ae41-6f35c7961660" },
                    { new Guid("fb35d1d2-5ff3-4016-86f0-df5d5657c736"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9825), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar103.jpg?alt=media&token=b9e6ed3c-1328-4935-9eab-d3335638e503" },
                    { new Guid("fdf80856-da90-4190-bf4e-66ed0601a4ba"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 9, 16, 23, 43, 22, 335, DateTimeKind.Local).AddTicks(9772), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar65.jpg?alt=media&token=8761aa35-f030-4fa7-a020-66f0a6810090" }
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

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RentalId",
                table: "Reviews",
                column: "RentalId",
                unique: true);
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
