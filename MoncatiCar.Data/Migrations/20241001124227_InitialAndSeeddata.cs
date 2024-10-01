using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoncatiCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialAndSeeddata : Migration
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
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "CitizenIds",
                columns: table => new
                {
                    Citizen_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IssuingAuthority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Verified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitizenIds", x => x.Citizen_Id);
                    table.ForeignKey(
                        name: "FK_CitizenIds_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DrivingLicenses",
                columns: table => new
                {
                    DrivingLicenseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LicenseNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Verified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrivingLicenses", x => x.DrivingLicenseId);
                    table.ForeignKey(
                        name: "FK_DrivingLicenses_Users_UserId",
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
                name: "FavoriteCars",
                columns: table => new
                {
                    FavoriteCarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteCars", x => x.FavoriteCarId);
                    table.ForeignKey(
                        name: "FK_FavoriteCars_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId");
                    table.ForeignKey(
                        name: "FK_FavoriteCars_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
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
                    BasePricePerDay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDaysRented = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Rentals_Users_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rentals_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    ContractId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RentalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Signature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractTerms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attachment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.ContractId);
                    table.ForeignKey(
                        name: "FK_Contracts_Rentals_RentalId",
                        column: x => x.RentalId,
                        principalTable: "Rentals",
                        principalColumn: "RentalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RentalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    { new Guid("1c38dc33-e4d6-4922-abc4-1fa8cfc314b2"), "Lexus", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The luxury division of Toyota, Lexus is renowned for its refined craftsmanship, advanced technology, and smooth, comfortable rides. It’s a symbol of reliability and premium quality.", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("4e5784bd-10a3-4fb4-ad50-fb0304da90d9"), "Toyota", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "One of the largest and most reliable car manufacturers in the world. Toyota is known for its long-lasting vehicles, efficiency, and innovations like hybrid technology with models like the Prius.", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("9bb29e7a-ca23-4418-81d4-b9b66e7cf107"), "Ford", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "An American automaker famous for its durable vehicles, including the iconic Ford Mustang and F-Series trucks. Ford has a significant influence on the global automotive industry.", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a1f14e7e-342b-4f17-b7fc-9e7ca13483b2"), "Vinfast", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "A Vietnamese car manufacturer that quickly gained attention for its electric and gasoline vehicles. VinFast aims to bring Vietnamese-made cars to the global market with a focus on quality and innovation.", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("b802da6e-e178-46f5-9884-442e0f1067dc"), "Mg", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Originally a British brand, now owned by Chinese automaker SAIC. MG is known for affordable vehicles with a focus on modern technology and youthful appeal.", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("c11c6f51-c207-4754-9372-046fb4a04c22"), "Hyundai", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "A South Korean car manufacturer that offers a wide range of vehicles, known for their affordability, modern designs, and advanced features. Hyundai has rapidly grown to become a major global player.", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("c6669c8e-f8a8-443c-8446-83c010b44ec0"), "Mazda", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "A Japanese automaker known for its stylish designs, advanced technology, and driving pleasure. Mazda’s “Kodo” design philosophy and SkyActiv technology are key highlights.", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("de716878-747e-4b02-9fce-46d67a13c30f"), "Peugeot", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "A French car brand with a long history, known for producing elegant and reliable vehicles. Peugeot is recognized for its sophisticated design, comfort, and European flair.", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "FeatureId", "CreatedAt", "CreatedBy", "Description", "DisplayName", "FeatureName", "Icon", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Automatically processes toll payments while driving", "Etc", "etc", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fetc-icon.png?alt=media&token=e2494201-b1ff-4cfa-982d-4618537ce4c5", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("06653486-dec4-4054-ba49-c3a63490453e"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Covers and protects the engine compartment from external elements", "Bonnet", "bonnet", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fbonnet-icon.png?alt=media&token=a39d6283-4a5a-48a9-8c6a-8c2d539cd05b", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Displays rear visuals to aid in reversing safely", "Reverse Camera", "reverseCamera", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Freverse_camera-icon.png?alt=media&token=fff470fe-095c-4b9e-ac98-aa31827a6f91", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Provides an open roof option for natural light and ventilation", "Sun Roof", "sunRoof", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fsunroof-icon.png?alt=media&token=88b4101d-1fec-40c0-9534-989e39d08516", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Offers a 360-degree view around the vehicle for safer maneuvering", "Camera 360", "camera360", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2F360_camera-icon.png?alt=media&token=12ef3912-ad25-4216-9d8a-aa3a10f3d956", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("4481e46d-e85b-4870-a210-cdfea8932641"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Projects essential driving information onto the windshield", "Head Up", "headUp", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fhead_up-icon.png?alt=media&token=63087d56-26a4-4f72-affc-3c5d55c33f31", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("533a7038-190b-4830-8125-5d2aacb7174e"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Enables wireless connection for hands-free calls and audio streaming", "Bluetooth", "bluetooth", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fbluetooth-icon.png?alt=media&token=422658da-d565-46e6-9e8f-b0ffccbb77dd", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Allows charging and connecting devices to the vehicle's system", "USB Port", "usbPort", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fusb-icon.png?alt=media&token=3fce192b-6d2f-43f5-8e0b-3546c1e50e31", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Secures infants in a specially designed seat for maximum safety", "Baby Seat", "babySeat", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fbabyseat-icon.png?alt=media&token=2ad93b19-7448-46f9-9029-19871a357eb6", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Provides real-time navigation and location tracking while driving", "Map", "map", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fmap-icon.png?alt=media&token=ebf5968e-074f-4f5f-a20c-9020b5dfac7b", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "A backup tire stored in the vehicle for emergency replacements", "Spare Tire", "spareTire", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fspare_tire-icon.png?alt=media&token=01a8dc7b-e98c-479c-943c-e337e3964e8d", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Offers satellite-based navigation and route guidance", "GPS", "gps", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fgps-icon.png?alt=media&token=39ae42c8-a678-4f05-b5dd-9e20eb42d31f", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("be392eff-ef38-4039-94ec-7922f315ea6a"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Records front road footage for safety and evidence during drives", "Dash Camera", "dashCamera", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fdash_camera-icon.png?alt=media&token=e863e966-7ce5-432f-9629-bd72fcdfcd1f", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Assists in parking by displaying rearview visuals on the screen", "Parking Camera", "parkingCamera", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fparking_camera-icon.png?alt=media&token=39675fd9-2e15-4275-a7e1-085a75fb491f", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Displays video content for rear-seat entertainment during trips", "DVD Monitor", "dvdMonitor", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fdvd-icon.png?alt=media&token=49e66de4-ec15-42d5-9787-50f23ba0c074", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Monitors tire pressure to ensure optimal driving safety", "Tire Pressure Monitor", "tirePressureMonitor", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Ftpms-icon.png?alt=media&token=5d93995e-c886-430c-843b-a80fb6ba3f46", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("f761d066-304f-49f7-b988-3aca64536d9b"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Deploy in collisions to protect passengers from injury", "Air bags", "airbags", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fairbags-icon.png?alt=media&token=55c3c49f-1b88-4782-8124-7828a6df07f8", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Detects collisions and triggers safety mechanisms during impacts", "Impact Sensor", "impactSensor", "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Car%20Features%2Fimpact_sensor-icon.png?alt=media&token=1bc9001d-e5ca-4f48-98f8-dc86934cebc0", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
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
                    { new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 0, null, null, "a3bd13f2-de17-4351-9411-1c8b38742506", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "khanhpham@gmail.com", true, "Nguyen Pham Khanh", null, null, false, null, "KHANHPHAM@GMAIL.COM", "KUEM113", "AQAAAAIAAYagAAAAEJglVi6xKFVdh07LTPs7qM+fXmHXqtlDYWr9SSXZCVyJZ28ddx6w3mDHcdYQYWv8wQ==", "0969998878", false, null, null, "6575f37f-d2fe-4644-94f4-f68b1c39803a", true, false, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "kuem113", null, null },
                    { new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"), 0, null, null, "8fde37da-5f62-4803-8050-d85618761d65", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "duythunglungtinhiu@gmail.com", true, "Pham Hoai Duy", null, null, false, null, "DUYTHUNGLUNGTINHIU", "DUYPRO113", "AQAAAAIAAYagAAAAEAHa21y4cfL9holpkEO0v8dPUhvWbP+GmgDhxTxvfEePqeOvEwsnelymvdN2zMZhPQ==", "0555666612", false, null, null, "88812a0c-8d99-4526-a9d8-108bb3a81517", true, false, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "duypro113", null, null },
                    { new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 0, null, null, "8243ba7f-77a4-413f-b65d-f3ece7fcef27", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "quocdai@gmail.com", true, "Nguyen Quoc Dai", null, null, false, null, "QUOCDAI@GMAIL.COM", "DAINQ115", "AQAAAAIAAYagAAAAEBgIfpOOtnUlgtYHk24cLQJkvJYIwhE857hvPY2vMQl5aCYvEUNV+uU6166wGgnHgw==", "0932748924", false, null, null, "48bc2813-9cc8-42f1-a063-236e044a30d0", true, false, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dainq115", null, null },
                    { new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"), 0, null, null, "dff14eac-873f-4073-9347-4e2b1520b55a", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "khaitoi@gmail.com", true, "Phan Van Khai", null, null, false, null, "KHAITOI@GMAIL.COM", "XAUTRAI123", "AQAAAAIAAYagAAAAEPjYscGitHg7frur6/iL+wo5nDo1TKf23SBNtRj/YFVjR5b72LyaTn3j/9NjNnK9kw==", "0777444499", false, null, null, "55ec6b74-bf52-474e-9f8e-7674e3a23d06", true, false, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "xautrai123", null, null },
                    { new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 0, null, null, "644c088a-6921-4f22-927d-e3bd758792c4", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "quangdalat@gmail.com", true, "Quang La Tui", null, null, false, null, "QUANGDALAT@GMAIL.COM", "QUANGSPA009", "AQAAAAIAAYagAAAAECvjaSSfYCyf2/U+krgJSBbeMqjBy30zNZwtsinz9o/UH/ZsBmv9QFT+dagsv01Wtw==", "0999777712", false, null, null, "2bdf066f-a801-4236-b6d4-4d5c196cbc35", true, false, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "quangspa09", null, null },
                    { new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 0, null, null, "f387f3fb-4220-4e6d-b7fa-6d4fca490d1f", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "toanvan@gmail.com", true, "Van Huu Toan", null, null, false, null, "TOANVAN@GMAIL.COM", "VIPRO123", "AQAAAAIAAYagAAAAEOWFu3BZ+d6k2s06uFa+OlatGGbqbu1v8k5mJvinatEpWR9LORL8sgXPc1nkxG26Rw==", "0999998888", false, null, null, "5f34088d-5314-49b7-8463-e418c5d387d5", true, false, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "vipro123", null, null }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "ModelId", "BrandId", "CreatedAt", "CreatedBy", "Description", "ModelName", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0ed1b055-dcd4-48ee-aeff-7478382f9e96"), new Guid("c6669c8e-f8a8-443c-8446-83c010b44ec0"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "CX5 Deluxe", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("16fd3123-d971-422c-b2af-e47978c27f35"), new Guid("c11c6f51-c207-4754-9372-046fb4a04c22"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Tucson Premium", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("1dc0a8e3-19b1-45f0-aec8-a810722de8f5"), new Guid("9bb29e7a-ca23-4418-81d4-b9b66e7cf107"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ecosport", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("32234d9d-90f2-4011-ba7f-85ead67a98bd"), new Guid("1c38dc33-e4d6-4922-abc4-1fa8cfc314b2"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "RX450H", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("4e39763c-501a-47ea-9d11-f884de1e7e4e"), new Guid("de716878-747e-4b02-9fce-46d67a13c30f"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "3008", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("542d93fd-4bc2-48df-9e58-f12c17a96d79"), new Guid("b802da6e-e178-46f5-9884-442e0f1067dc"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "ZS Standard", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("6e18d51e-2964-4f16-a00c-0d4544671816"), new Guid("4e5784bd-10a3-4fb4-ad50-fb0304da90d9"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Innova", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("affeb1d2-7eb3-4410-a7ca-e3b1adc3cc54"), new Guid("de716878-747e-4b02-9fce-46d67a13c30f"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "2008 GT", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("f660d2b0-0444-4c02-b15a-2ebc871d8f4b"), new Guid("a1f14e7e-342b-4f17-b7fc-9e7ca13483b2"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "VF6 Plus", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("fdfdef71-0e39-48f0-8eec-71f5429ed285"), new Guid("c11c6f51-c207-4754-9372-046fb4a04c22"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Creta", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "CarTypeId", "CreatedAt", "CreatedBy", "DeliveryFeePerKm", "Description", "FreeDeliveryWithinKm", "FuelConsumption", "FuelType", "InstantBooking", "LimitKilometersPerDay", "Location", "LocationDetails", "MaxDeliveryDistance", "ModelId", "OverLimitFeePerKm", "OwnerId", "PricePerDay", "RentalStatus", "RentalTerms", "Seats", "Slug", "Status", "Transmission", "UpdatedAt", "UpdatedBy", "discount", "licensePlate", "year" },
                values: new object[,]
                {
                    { new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), null, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "The 2021 PEUGEOT 2008 GT is a stylish and compact SUV featuring a sporty design, advanced technology, and efficient engine options. It offers a comfortable and spacious interior with premium materials, making it ideal for urban driving and longer journeys", 0, 5f, 0, false, 0, "Thành phố Thủ Đức, Thành phố Hồ Chí Minh", "Thành phố Thủ Đức, Thành phố Hồ Chí Minh", 0, new Guid("affeb1d2-7eb3-4410-a7ca-e3b1adc3cc54"), 0, new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 1101000m, 0, null, 4, "peugeot-2008-gt-2022-x5uac6", true, 1, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, "51H-815.11", 2021 },
                    { new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), null, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, "Comfortable 5-seater car, beautiful car, strong engine, full interior and amenities", 7, 7f, 0, false, 0, "Quận 2, Thành phố Hồ Chí Minh", "Quận 2, Thành phố Hồ Chí Minh", 4, new Guid("16fd3123-d971-422c-b2af-e47978c27f35"), 100, new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 1073000m, 0, null, 5, "hyundai-tucson-premium-2021-nixl5v", true, 1, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10f, "30K-605.01", 2021 },
                    { new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), null, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "The 2021 Toyota Innova E is a versatile and reliable MPV designed for family comfort and practicality. It boasts a spacious interior with ample seating and cargo space, advanced safety features, and a smooth driving experience.", 8, 9f, 0, false, 150, "Quận Bình Thạnh, Thành phố Hồ Chí Minh", "Quận Bình Thạnh, Thành phố Hồ Chí Minh", 5, new Guid("6e18d51e-2964-4f16-a00c-0d4544671816"), 0, new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 821000m, 0, null, 7, "toyota-innova-2020-3ymd75", true, 0, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, "51L-288.32", 2020 },
                    { new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), null, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, "Lexus RX 450h automatic transmission manufactured in 2010 Japan<br/>Last inspection date: 7/7/2023<br/>Clean and tidy family car", 5, 7f, 0, true, 0, "Quận 2, Thành phố Hồ Chí Minh", "Quận 2, Thành phố Hồ Chí Minh", 0, new Guid("32234d9d-90f2-4011-ba7f-85ead67a98bd"), 150, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 3706000m, 0, null, 5, "lexus-rx450h-2010-4urh11", true, 1, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, "51A-900.56", 2010 },
                    { new Guid("8705f403-06bc-4983-8c81-86310959cc37"), null, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "The car is in excellent condition and very clean. Highly recommended!", 0, 9f, 0, true, 50, "Thành phố Thủ Đức, Thành phố Hồ Chí Minh", "Thành phố Thủ Đức, Thành phố Hồ Chí Minh", 7, new Guid("1dc0a8e3-19b1-45f0-aec8-a810722de8f5"), 100, new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 666000m, 0, null, 5, "ford-ecosport-2015-duz4bh", true, 1, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, "51F-320.56", 2015 },
                    { new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), null, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, "Mazda CX5 2017-2.0 Fuel efficient<br/>New, beautiful car, regularly maintained, clean…<br/>Spacious, comfortable car, suitable for family travel.<br/>Car has rear camera, sunroof, dash cam, entertainment system and many other amenities…", 5, 7f, 0, false, 100, "Quận Bình Thạnh, Thành phố Hồ Chí Minh", "Quận Bình Thạnh, Thành phố Hồ Chí Minh", 10, new Guid("0ed1b055-dcd4-48ee-aeff-7478382f9e96"), 200, new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 861000m, 0, null, 4, "mazda-cx5-deluxe-2017-vq57kp", true, 1, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20f, "15A-341.79", 2017 },
                    { new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), null, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, "Beautiful new family car, original interior, clean, equipped with 3M crystalline film, the car is very cool in hot weather, coated with anti-nail and noise-proof tires.<br/>", 10, 381f, 2, false, 200, "Quận Bình Thạnh, Thành phố Hồ Chí Minh", "Quận Bình Thạnh, Thành phố Hồ Chí Minh", 0, new Guid("f660d2b0-0444-4c02-b15a-2ebc871d8f4b"), 0, new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 953000m, 1, null, 5, "vinfast-vf6-plus-2024-j7tjxw", true, 1, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15f, "51L-216.13", 2024 },
                    { new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), null, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "Great car! Very comfortable and spacious for my family trip", 0, 10f, 0, false, 0, "Quận 1, Thành phố Hồ Chí Minh", "Quận 1, Thành phố Hồ Chí Minh", 0, new Guid("4e39763c-501a-47ea-9d11-f884de1e7e4e"), 0, new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 1343000m, 0, null, 5, "peugeot-3008-2022-wlh7hm", true, 1, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, "51K-418.61", 2022 },
                    { new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), null, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, "The 2021 GARAGES ZS SMART UP STANDARD is a compact SUV designed for urban driving. It features a modern exterior with sleek lines, a spacious and well-equipped interior, and smart technology integration. The vehicle offers a smooth ride with fuel-efficient engine options, making it a practical choice for everyday use.", 0, 4f, 0, true, 0, "Quận 9, Thành phố Hồ Chí Minh", "Quận 9, Thành phố Hồ Chí Minh", 0, new Guid("542d93fd-4bc2-48df-9e58-f12c17a96d79"), 0, new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 976000m, 0, null, 4, "mg-zs-standard-2022-k18fhr", true, 1, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, "21A-134.52", 2022 },
                    { new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), null, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, "Safety:\nHyundai Creta has familiar features such as: ABS – EBD – BA brakes, electronic balance, traction control, hill start assist, tire pressure sensor, parking assist sensor, rear camera, 6 airbags…<br/>Convenience: Leather seats, Bose standard sound system, navigation, speed warning, electronic handbrake…", 5, 6f, 0, false, 0, "Quận 9, Thành phố Hồ Chí Minh", "Quận 9, Thành phố Hồ Chí Minh", 0, new Guid("fdfdef71-0e39-48f0-8eec-71f5429ed285"), 150, new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 1033000m, 0, null, 5, "hyundai-creta-2022-wesu5v", true, 1, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0f, "51K-392.51", 2022 }
                });

            migrationBuilder.InsertData(
                table: "CarFeatures",
                columns: new[] { "CarFeatureId", "CarId", "FeatureId" },
                values: new object[,]
                {
                    { new Guid("01c5c1b0-4b91-44b4-88cc-e83ee0ffaeaa"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("020c40bb-1ad0-4b46-bd3a-93aa2afb2630"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("04ce2cc4-66ab-4d2e-a2d9-7b2ed6f0d2d6"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("07e50e90-db3b-42f4-b84c-e8a172da4d7d"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("0aa2e9eb-8f6c-4a61-889c-2ba8e3cc9ade"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("0d6aa684-81f8-49b5-966d-eb31af99e4d7"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("0e782468-8a43-4e29-ba5b-1e01675aed2f"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("10135872-066b-478c-94b2-ed52912cbb37"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("1113f3ab-4635-47fa-830f-accfcb260eb5"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("124ffef6-03ca-44c3-8490-a5e2151a37b2"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("142ef576-c200-402f-b6d4-8bfe0fe6458e"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("148afe9f-b696-4438-835a-b81ca394462d"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("14d04bd1-c225-4bc9-9010-877078b185ed"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("1596651e-dd61-490e-949d-aa89be77038d"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("1a4710d7-9eff-433a-a885-8b5adafe5d38"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("1ca9d15c-1a88-46e5-9757-3215f10a783e"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("20032db8-27cf-4d2b-b00c-c5e2c1de5c01"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("20c73dcc-c552-4335-a05b-613476b726d8"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("230f1fd1-ab12-4c38-9058-432388b62a9a"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("241974b6-4fdb-46c4-b37d-f2c696281220"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("2658fa7f-a913-4fb9-8e80-b5d6ee17cb5b"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("289a75b4-f0be-40ec-bcf8-a5bcbf43c923"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("28b3bcda-b017-4168-8f11-cccd4f51431f"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("294a440f-9287-4e12-a53a-c042f2909bc2"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("29565c46-5953-4114-8249-f32488e9f015"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("2a51bfe0-9b82-45a3-ba3b-95cfb044b975"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("2c9bdcd2-d13d-4b6b-9448-f6134bf88cbf"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("2d34dd50-8599-4302-94a9-4dcbbcfa1e41"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("2e328a34-c34f-4490-9aa4-cbba404a35c0"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("2e394dea-2099-4c73-b67a-98487f84eac3"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("338f6b88-3de6-42e4-9022-8b0dea24adeb"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("345f268d-312b-45cb-af71-5a175353328e"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("356f0c00-cc1f-4d64-9ab3-3255e83ba746"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("3672cdad-0c66-42e5-8ddf-8b0f4d5bc0b7"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("3f082a54-65de-4f75-954a-9f50cc00de18"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("3ff5d058-d210-4610-906c-233bce8cb2c6"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("4000637b-6685-4ad3-af1d-1dee43a39d4f"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("46523852-d566-4955-a140-febe047ef75c"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("4804d426-e855-423a-9445-1d4cf122c24f"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("4ceabcfe-d080-47ff-93c5-fb4d743b13b2"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("4e27ca88-c541-4723-9175-1996ef04be43"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("507531a0-0bee-401a-99d7-c827f18a4d9a"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("50cb843d-0f6e-417b-99ff-375686eeb3d4"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("525b005f-89e1-4269-b90b-39a320853dff"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("54cfdd0d-1f8b-4f90-b656-f21ef8591276"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("58f1e3b0-4687-499c-a046-4fe89c95577e"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("59d7b533-423f-45cf-898c-bb9999ac2aea"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("5a83b399-8fd5-493f-a2a5-68bbe8706cc5"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("628b5a79-e77c-49b6-af5e-63025295f891"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("62a385e6-df16-4bc6-8c30-7c02ff7c61be"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("6405d2c2-87e0-43fa-9882-2e545cd3a18e"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("659f1047-089e-45bc-b213-759957f6a27b"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("6ba6b0dd-2612-46b4-8d15-6045733c254a"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("6c2dcdc9-192c-42a6-80a5-95206bb9e53b"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("6ff6ce8a-1f71-4e1c-b3bb-877b362a82ab"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("723f6f26-2716-417c-b380-d88b15f3c17b"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("7449504e-34ba-4ae5-9848-15f92b556725"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020") },
                    { new Guid("74db20a6-2004-42bc-afbf-b770b3702e57"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("76bc7771-0537-4dae-b553-9203684e84de"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("771d1cbb-1c84-404d-a937-d15018edf6cb"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("7783a9f1-ad44-4502-9f21-f5ce8ac41f65"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("7a59fda9-281c-4d7c-ad56-bec1b5e267e7"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("7c589576-0713-4a52-927f-f2832d84a028"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("7d8e16dd-e5b1-44a0-a299-c419d5e0ac3f"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("7dacc366-c4e9-43bd-aa89-28428d461427"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("7f6957ab-91e6-4698-b914-e96d3475cad0"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("829b49da-5722-4d24-b45b-5327914824d8"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("836b1015-ac31-4918-b272-ca9be2e60f62"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("840206fe-acfe-451c-93ae-799d4e9dc25e"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("84e9371f-43e8-4fc9-909c-46324e25dba3"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("85119574-87fb-400d-a246-5936363ebca8"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("87612d9d-9224-4ade-9103-de0ce45abaf7"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("8d18b88b-b22a-4e0d-8b36-e79efe0656e5"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("8e1467e9-e058-4f35-97b8-83ee4a9a6b5e"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("900a1c44-4c55-42a5-a872-6e1a8a150648"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("9189bc99-e038-409b-ba42-7387fdb14fcf"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("97c79a98-570f-43ab-9c05-d456d4612740"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("981961cd-7300-4059-bbe5-8cf0b20720ed"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("98c038f6-2015-4776-a7ec-eb078f88d7c2"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("9b7bc807-ab4e-40af-a513-a0e24593487b"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("9b9ef306-9382-4217-8482-6c19975ec4f5"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("9d8bc8ee-41ef-4322-b528-4a05611baa3b"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("9dc08556-2f8d-4b13-926b-1af19ac331cc"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("a0691f34-a381-4950-871d-1a1c5f1936c9"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("a292c35f-6c35-424d-acd1-8af35b88b540"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("a2eaf91a-c754-4b14-8052-a6a962a92383"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("a4ab7b13-d447-4a59-9c08-f18940afad77"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("a74a701d-2b27-4646-a72b-2564b0056478"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("a862946a-8bcc-44c0-bb15-34d6d7ec97cf"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("aa568c23-891c-451b-8699-38b0c39cc8ed"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("aa5b99d1-114c-423f-99ea-ffb138416235"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("aedbc2b5-2c4a-453b-bd4d-513684e65a60"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("b0404a63-39c0-4c06-bd4f-d2c3251ad104"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("b2377551-a5e6-4123-b055-64be9856547a"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("b355cccf-16b9-4cbb-8b61-c8d7a38fcc2b"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("b3bc5c9e-2968-4cdf-9f38-1cfd47fb7ad2"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("b613160d-c3eb-4b1c-8683-ea5ea211b37f"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("b7588973-4a8e-4240-ad08-d232c7f33316"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("b8618093-93b8-47e9-8eaa-831cfbfb7d49"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("b99e8c53-ed66-4305-86a4-91fb05418ec3"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("badfac9d-bcf5-4f2d-a5d2-8522e916ab11"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("c0029ad0-87b0-4b3c-b074-386ab20c86ef"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("c4496158-64e2-4378-a524-2e7bfeb5927f"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("c802b962-d85b-4cdf-b071-0e40100a18d5"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("cae4d0af-12a4-4edd-960d-78eb5fb6c2e7"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("d01a99b1-bc75-49c3-8f92-40a465eb6f12"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("d0268b7f-b5c9-4137-abd9-c7bb397b81ec"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("d2f3d466-7807-4573-8671-4cbc25c4aa52"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("d34c7fbd-369f-4872-bd8d-dbcfe945737f"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("d38345d8-85c6-4274-8dcd-6d9f48c54821"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("d3b0e5ff-dd73-4453-8bc6-5f96c5159f69"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("d4daa95d-c8b9-4080-b41e-4bd53c3b2850"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("d98ce857-b516-405d-bb40-55fcd33120a7"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("db5e3c89-e256-48d7-b959-82f6da723721"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("dc16531d-67fe-4328-a05a-f09a6a9a6808"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("dc414b6d-db1a-4fa5-b03a-0fead8ba3459"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("dcdc7283-2af3-487e-aa52-ed832cf56afc"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("ddd721f3-ff43-47ed-bc09-3e97d8fe2df7"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("e04abb6e-9804-4efb-82cc-20f60e641ada"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("e0ecc504-3e4d-42e7-8243-5fe92f971dbd"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("e1028503-5c57-4210-ab22-0aef34208e41"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("e17b0d24-9f33-44f5-9f3e-93ea378fafd1"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("e7169d79-ea0d-4e77-9036-b8423504bd13"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("eb8813da-05ea-48e4-9987-216a6c4c8bf2"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("edca2147-6e03-4d46-8e9a-950f26482bcd"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("f2b6ac81-1d14-46f5-a468-cb12bf18d27b"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("f3940f8d-b6b4-4de4-9ad1-adfb063920ef"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("f52e4aa4-6e25-41b3-a81b-2e9123bf2466"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("f90586a3-6fc6-4505-a46c-e0f2cae6d5bc"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("fb22bb86-3d3c-46d9-8e61-8ab61151a81d"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("fb605f6c-9689-48d1-8ea3-5427deb58c9c"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("fcb8fbc1-282b-4589-b9ee-c5f854ea1a2f"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("fd208250-5fa3-4722-ad54-a163c3f5c8c9"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("fd2e40b4-04c6-4676-b46a-52c3fa4d1f09"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("fd33ec94-80ee-433e-86cf-088bcbca7b5b"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("fd6f8595-10ca-4b33-8fb5-395b415874ea"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("ffa0dfa2-b7ab-49a6-923b-6d21c50f05a4"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "CarId", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy", "Url" },
                values: new object[,]
                {
                    { new Guid("03071ddf-22c3-4321-9cfc-4c1dd506a9a3"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar51.jpg?alt=media&token=6e55f0be-c666-4c50-a30e-44b4a703260d" },
                    { new Guid("0831c830-8ab9-41ee-8abe-aeea4f832715"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar11.jpg?alt=media&token=41cf30ec-f792-4074-9406-a5d2a98a49e6" },
                    { new Guid("113d7987-dea8-4093-8b09-3ee0de72bb3c"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar81.jpg?alt=media&token=22679c70-85f4-4b86-8934-fb1d2a60b1b9" },
                    { new Guid("119d2e54-a9c0-4b7c-87d6-5cd2f2501da9"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar31.jpg?alt=media&token=6c0188d7-d743-4e0b-9795-a0ceeae64dba" },
                    { new Guid("13aecfda-8e98-4c0e-abc0-e20f1d13e961"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar61.jpg?alt=media&token=fab2b814-962d-4098-839c-758fb97642e5" },
                    { new Guid("146a6452-4bc4-4922-bb33-a69d1d0612dd"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar67.jpg?alt=media&token=63ef5ae3-3d82-4e38-8412-aaa93f6785b6" },
                    { new Guid("155e7784-a812-4571-bead-f8d7ca2478b5"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar54.jpg?alt=media&token=ed8a9204-288e-44f8-b047-ba4a80d5a45e" },
                    { new Guid("16931f6d-b074-4bd2-9082-3de35b6db9d5"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar12.jpg?alt=media&token=c1f10fdd-cb99-4c27-933d-4700acc9272e" },
                    { new Guid("1df708b5-2560-4664-89d6-6ee1e3b88d26"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar83.jpg?alt=media&token=127dc8ca-bcdb-42a1-9e7c-44e35ca985c8" },
                    { new Guid("2263a83a-5199-4240-9ecb-b19701d1fcf5"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar41.jpg?alt=media&token=e8d9380a-0931-4215-a080-96204098774d" },
                    { new Guid("23fbf12e-52d0-4438-a9fe-f681d12b89fa"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar82.jpg?alt=media&token=de9c9bc7-c8e8-4969-b680-11fd990fe8a2" },
                    { new Guid("24971c14-5f2f-41aa-886b-1c114186d3bc"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar32.jpg?alt=media&token=9a497c45-8b33-40ae-bf8a-86b29747324b" },
                    { new Guid("27e79248-04e4-4961-a0b1-cf22c2319ae4"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar14.jpg?alt=media&token=6ce903bb-ce8b-4c6d-bc34-d8a1b664f625" },
                    { new Guid("38e6db85-3e32-4077-804c-f2287d118fd0"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar44.jpg?alt=media&token=e55eeb29-93b0-47b3-911f-df204e877469" },
                    { new Guid("4d4c2964-6453-4522-923e-1688da305391"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar22.jpg?alt=media&token=745493d0-4f34-4c7f-bb8c-f8c891e01422" },
                    { new Guid("53337daf-c5af-452f-802a-d8b829a9d068"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar71.jpg?alt=media&token=f67cdcdb-55a4-46da-bcab-a498b8eea245" },
                    { new Guid("589b7e11-94c3-4c5b-b4cb-2b3d215be33b"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar52.jpg?alt=media&token=ad7a0fd8-b4eb-4326-a475-342a9e0b01b8" },
                    { new Guid("5f11ba97-bde5-4400-b6dd-b4e02025a0d7"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar24.jpg?alt=media&token=263ace26-9d00-41d4-869c-760319e406dd" },
                    { new Guid("61c40521-3a6f-4a6a-816d-8c2a7f449997"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar84.jpg?alt=media&token=0c49d25b-e1c5-4b31-b5eb-a313baa44b5e" },
                    { new Guid("63d8419b-ae3c-4867-96e2-2773531291d3"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar101.jpg?alt=media&token=77127151-3472-4206-8540-6909ec874c71" },
                    { new Guid("643c0c50-b89e-4d60-b339-28254d008738"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar66.jpg?alt=media&token=d3102c30-035b-47cd-a8f8-f66be7a24f6f" },
                    { new Guid("6c521908-21ff-4e8d-a8d0-4c05c8a2e5a7"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar74.jpg?alt=media&token=95622732-d623-4eda-aa62-6c8ee1e96f28" },
                    { new Guid("6ebfaf1c-748f-484a-b8b7-b7ddac7c883d"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar42.jpg?alt=media&token=78c1211b-d7a7-45ed-a03a-09a442c2b529" },
                    { new Guid("782d4c8e-2605-4a2d-87ba-3d1f2c9eb4d6"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar33.jpg?alt=media&token=557246dd-3d64-45a5-97fa-9b122cd316c9" },
                    { new Guid("82428e6a-19f6-4599-aae1-13712934b3f8"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar53.jpg?alt=media&token=c76e6223-2ca1-4bac-bd7b-dd3f18323f37" },
                    { new Guid("8dd7c100-ccf9-4e7b-a2e6-aa3525698243"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar104.jpg?alt=media&token=9688114d-001b-4f26-a5d8-562d9fb42bf7" },
                    { new Guid("8df59a4b-c2fe-4023-8a1e-7f308c8f68b8"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar91.jpg?alt=media&token=466bda06-2bf1-493f-9dd5-eee4ce0a94ab" },
                    { new Guid("90fe95a8-3617-4676-abfa-9f86ed314bbb"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar64.jpg?alt=media&token=9a4b198d-c2c4-4585-b424-fd2b326fc97c" },
                    { new Guid("91762bd8-9200-4d45-9ee8-e8f0e983e921"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar23.jpg?alt=media&token=fd7110ec-aa36-4610-a69d-b00abdf886ec" },
                    { new Guid("a870408e-435b-4448-bb23-93bf329e40d5"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar93.jpg?alt=media&token=782b1c2f-49d2-4673-8101-330020231a01" },
                    { new Guid("bf8a664f-88fe-4e7c-b91c-427dd10970c2"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar21.jpg?alt=media&token=735db85a-0e4f-4645-a764-1657d1ccf7d0" },
                    { new Guid("bfbbaa76-998f-4d46-bbfe-664be8c4f6a5"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar63.jpg?alt=media&token=34a62380-de76-46c7-9752-9b13e8cc7ac5" },
                    { new Guid("bfbf38c4-5645-4392-9020-6c5b992ff46e"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar85.jpg?alt=media&token=8ab32d35-6b26-4fb7-8a5a-4e013161a768" },
                    { new Guid("c5de75b4-9631-43c0-8ac6-a9da568a967a"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar62.jpg?alt=media&token=159d9f2e-fad1-4846-876d-3c4b9fa1e720" },
                    { new Guid("d539cbdb-a20c-4fd9-ac69-21fcb067249b"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar92.jpg?alt=media&token=fc46713e-0c32-486c-9c6c-546318f09d9d" },
                    { new Guid("d898f1d5-cf63-4250-a8f7-c8cf25c61a46"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar43.jpg?alt=media&token=b994c70b-b366-44dc-bcbe-d4c6219ba189" },
                    { new Guid("dad87d5e-c756-4ee5-ae27-c3f84901c9d3"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar34.jpg?alt=media&token=d7874dde-8f83-4d86-a902-04ce22c9942c" },
                    { new Guid("de16b5e0-65e8-45d1-ae2c-a446febb4b0d"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar73.jpg?alt=media&token=1750f1a1-62c5-4ab9-87ad-89301f4bc9b2" },
                    { new Guid("e33dfafe-cf13-43ba-93bc-9b150831123e"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar13.jpg?alt=media&token=2782d4ec-0184-47a7-8964-148e4c6928ae" },
                    { new Guid("e746af29-8cfb-4f2a-b1d8-593f44e0acd7"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar72.jpg?alt=media&token=30a3ac2a-0797-4240-b65e-8a3ceb63a839" },
                    { new Guid("ec97accb-b58d-4677-b6c5-4c87e3441de9"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar94.jpg?alt=media&token=94d25ed1-c76b-4edf-be53-0fe909ec5307" },
                    { new Guid("f0e7a8c5-16e7-4a32-bf1d-3cadafaf7153"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar102.jpg?alt=media&token=46f90372-9790-43f5-ae41-6f35c7961660" },
                    { new Guid("fb35d1d2-5ff3-4016-86f0-df5d5657c736"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar103.jpg?alt=media&token=b9e6ed3c-1328-4935-9eab-d3335638e503" },
                    { new Guid("fdf80856-da90-4190-bf4e-66ed0601a4ba"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Cars%2FCar%20ex%2Fcar65.jpg?alt=media&token=8761aa35-f030-4fa7-a020-66f0a6810090" }
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
                name: "IX_CitizenIds_UserId",
                table: "CitizenIds",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_RentalId",
                table: "Contracts",
                column: "RentalId");

            migrationBuilder.CreateIndex(
                name: "IX_DrivingLicenses_UserId",
                table: "DrivingLicenses",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteCars_CarId",
                table: "FavoriteCars",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteCars_UserId",
                table: "FavoriteCars",
                column: "UserId");

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
                name: "IX_Rentals_CustomerId",
                table: "Rentals",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_OwnerId",
                table: "Rentals",
                column: "OwnerId");

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
                name: "CitizenIds");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "DrivingLicenses");

            migrationBuilder.DropTable(
                name: "FavoriteCars");

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
