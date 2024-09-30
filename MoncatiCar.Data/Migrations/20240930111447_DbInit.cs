using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoncatiCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class DbInit : Migration
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
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    { new Guid("0075ba2c-f60d-4f75-b9f1-f71579bc4fd2"), 0, null, null, "34829b48-5758-45b1-8cba-13c4ab6519ed", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "khanhpham@gmail.com", true, "Nguyen Pham Khanh", null, null, false, null, "KHANHPHAM@GMAIL.COM", "KUEM113", "AQAAAAIAAYagAAAAEAyeMIOcrHTxgKZDGiRxMEkXXvMHFz5ECpKR+x2oQ+xOePWAR7ogeHE9Vq4gEi0WKA==", "0969998878", false, null, null, "683459c2-988d-44b7-8702-d2f0af1fe126", true, false, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "kuem113", null, null },
                    { new Guid("1246b8e5-af73-4aa3-bdef-b8815e21a78b"), 0, null, null, "96d3c224-4530-4c35-9931-06cfa792f8ed", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "duythunglungtinhiu@gmail.com", true, "Pham Hoai Duy", null, null, false, null, "DUYTHUNGLUNGTINHIU", "DUYPRO113", "AQAAAAIAAYagAAAAELLUN8zg4UebEXRMIjZfAczYEU09AuNZR58mTG43Te0KVm/upPaMlsZYvEhS2XeaeQ==", "0555666612", false, null, null, "89399396-3fd1-477a-9bb6-18f13c45db14", true, false, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "duypro113", null, null },
                    { new Guid("277ea066-d041-40ff-9dae-6271dbd6fd87"), 0, null, null, "faaf3d5e-3e66-45b7-8a66-874b329be2e8", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "quocdai@gmail.com", true, "Nguyen Quoc Dai", null, null, false, null, "QUOCDAI@GMAIL.COM", "DAINQ115", "AQAAAAIAAYagAAAAEMguecmvzR2eDwr7bP2pp56nJMcbX1nPtDqbIp8xSkEGo+5VS/WNgGPQ5ziFal6EfQ==", "0932748924", false, null, null, "d180c27c-aed6-4e65-a408-7dd685c5862c", true, false, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dainq115", null, null },
                    { new Guid("3b1a8845-765f-4d91-984a-4e8a9d7d376e"), 0, null, null, "e316c84d-4b90-4ca5-8f10-143a501f63ae", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "khaitoi@gmail.com", true, "Phan Van Khai", null, null, false, null, "KHAITOI@GMAIL.COM", "XAUTRAI123", "AQAAAAIAAYagAAAAEGosP+MYRWNaueu4JExkp0U0l+IvfI8n1Aw9vjOB7JK3SwCLY59HS2GIoXxMGgB48Q==", "0777444499", false, null, null, "00a52244-db72-4ac3-9737-6a5211d68b3a", true, false, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "xautrai123", null, null },
                    { new Guid("4565f47a-7239-4666-b9b4-0523b1d9ba3d"), 0, null, null, "f35be1fd-8f29-4edb-99ea-0c27402f3fbe", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "quangdalat@gmail.com", true, "Quang La Tui", null, null, false, null, "QUANGDALAT@GMAIL.COM", "QUANGSPA009", "AQAAAAIAAYagAAAAEBIPhNmvBDsZworBS7CJtURlIIw+n5FFzFBNNlMQTEqyqhDwVdJJjWaC2bRGg/byyA==", "0999777712", false, null, null, "373c9920-1b4b-49d0-8500-f5359487ead7", true, false, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "quangspa09", null, null },
                    { new Guid("9d7e87a9-b070-4607-a0b0-2d2322aece9b"), 0, null, null, "3478e318-e803-4f4e-b6f4-6d37c4702a70", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "toanvan@gmail.com", true, "Van Huu Toan", null, null, false, null, "TOANVAN@GMAIL.COM", "VIPRO123", "AQAAAAIAAYagAAAAELN/+GwIRE1LGZjDfa/ICDni3gVls71XJNiAaB3UZyBhCvVZ8Nh3flowVZMPZr7iSg==", "0999998888", false, null, null, "e44d7639-74bb-451d-acc3-166baf98b965", true, false, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "vipro123", null, null }
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
                    { new Guid("00c3690a-a2a3-424e-8cf8-f7be3eaef70e"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("02b02c05-d471-481f-9e2d-eea006259c22"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("051380b1-c41b-4b86-a138-e9285be09ad7"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("0715a1d4-1041-4f70-87ba-a04941e473a7"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("089b4926-3fe3-4e81-8444-e25bad7901c5"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("0be6a15e-fc09-46e8-890a-d73044530eb0"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("13b26f92-4cce-4055-83ac-06957f903cf0"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("15142767-b5db-40c7-9443-fa37e7c12472"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("16fe5d6b-6fd6-427e-b83d-510b3d89f1e3"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("17044c39-f761-431a-95d8-87c200942262"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("1bf443c8-18b1-4b54-8938-14706158e89e"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("1c8ae122-1d77-4e8d-a83e-b86b16bad2d8"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("1cb852eb-dfdd-41e2-bc3d-e3fb933fa142"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("1cf95e33-9396-4e5e-a14d-757ca5e58dbf"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("25369653-3144-4903-ac53-b396fc75b027"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("25b05aaa-72a2-4c39-82c3-afad634d5483"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("25f6114f-1c36-42e4-93a5-006216d3640e"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("26cdff59-9b9e-4ecb-8aa9-399b275560a3"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("28c9cbc6-3067-4973-ba8d-e7cb9f5151db"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("293041cc-451d-4a53-95bd-139c419167ab"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("2987c5a1-89d8-4570-b71e-5eada31bce91"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("29ba2620-0441-470d-bd9f-9c6b89bd529a"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("2b996fbe-ce04-4139-9934-9ab70eccadab"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("2ba07103-86dd-4b8b-97e3-3e4089f987e6"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("2cc1e9f3-9a94-4f6c-8888-ce7d641df459"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("2e700155-23c9-4896-ad5c-7f7dc6ecc542"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("2f01bb8f-c142-4c4c-bd70-1f5c6474b727"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("2fb5c29f-e681-4df6-a06f-914d890add3d"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("30d21678-de39-4185-962d-a7b5fb10bd9f"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("324b2ff4-27d6-422a-a525-81633c4bfcf1"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("32570cc7-989a-4e06-88a1-c82a7d017d8e"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("3341701b-970e-4711-ba75-d87c8751d32a"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("33b1cbed-5710-4b2f-a286-bcf2dbcd36d7"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("35491dd1-e04a-4596-b639-7da3bb97ace0"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("3604b649-11f1-4684-903e-01420de712ea"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("3642b580-bb7e-458c-ae6f-0c26efd47e4a"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("38be11cd-0a5f-4f9a-be29-570af5bafac0"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("3a03e56a-0c01-470a-82d4-e11b2354a8f1"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("3a53a90f-a551-4a24-a6d6-a12af8219943"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("3f03e9ff-48fc-4978-90cd-c68c4ba4c997"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("6ebf1d36-35fa-4cad-9d6f-671476d02020") },
                    { new Guid("419b9e85-d256-4555-824f-88ffd6ee2bc7"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("43928d4e-858e-4bae-8b65-ea395c4d625e"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("43c5c7a2-eaba-483d-a36c-401aafcc8a8c"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("43d71d21-916b-43c3-b726-d87d5921b97a"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("4cf38dc6-b8b9-4232-9d9e-d1a756538e6a"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("4ed9662f-398c-48a1-a309-723d827a799f"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("4efd922f-2eff-46eb-9362-5e958886fcf4"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("4f6f11b7-aaee-44f6-a668-f11cdaaf342e"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("500b8970-cf10-4315-abce-b2a6c5cf7aaa"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("5457f905-cb0f-4e28-8085-ebffaa523ced"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("54adcbc6-0b9a-4603-ada1-d7cabd10d0de"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("577fd271-d5c6-4964-98db-9da1980b9a8f"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("59c48f47-65b9-4d9f-865c-f63d748ac76e"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("5b14cd80-fbba-44d2-b1bc-04db2cb8ff90"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("5d4d8e6c-cf04-4125-aaee-6d7e2538fda9"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("629158bf-647d-46af-99b4-ac9fdb5074c1"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("6425a557-4eee-4239-8947-00cf9c2322b4"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("66ae11a5-5526-41c9-82c0-e32ca8c0c7b0"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("6a8d933f-d44c-4e9a-a0f4-127e18f1459b"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("6da9e44e-239f-4d7e-9696-9fc4a06785bc"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("6e833f86-172f-4ea2-b317-af9319506cc6"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("71a51308-cf36-49ca-bbf0-72ba47148eda"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("72fcbe9a-620f-49d7-93f7-b4575aa0e69d"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("76c55f9c-9330-4eb1-b352-48895c7735d3"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("779da76e-e662-4747-b141-e7b333840c10"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("789cf9b7-040f-481e-886a-a082ec8b7d28"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("7935f927-9c97-403b-9a47-f719abc9d108"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("7c7017ed-1766-4507-8fe7-08ec1c8ea92b"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("7eff22b9-7c7e-404e-891e-e4e9ddfc150d"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("7f5f1020-a548-4d52-8fe2-459e94d56da7"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("81e6e07f-11b8-4f3f-a7d1-7f0941c1f9b8"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("8459c4fb-ea40-459d-baac-89a62e842648"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("855d2d07-e399-4393-b4b4-2c01e3329e2e"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("87668ac5-0e58-4654-b09a-bb52a016ef1f"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("87a2d4b5-1100-4e26-a0f1-ccf10d7c77f3"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("8db378e8-631c-4a28-821f-629149d1cc00"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("8e7ce0bd-7c49-4a47-bb7e-5a7fc3cc202c"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("8ea0f634-cc65-4597-897f-b2116a3a6200"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("8f51a461-e18a-4e68-a0da-343e77460b82"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("933e0d92-09a4-4cf5-b77f-b63dabfae573"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("95477fc3-189e-43c1-ab10-2a0c8d3e3eac"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("95d9e042-6bf8-42f1-99fa-fa49c4fd0e21"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("9f7bcec9-1b2a-4619-9829-8c8d1224d278"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("a026880b-0521-477a-a719-bfa37839ea4c"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("a1583238-c06e-4d1f-b41d-2eebfff48d01"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("a3cb7e8a-f077-4748-a27d-8ed39b17588e"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("a6650930-9f32-463c-b1ec-968882af9e0a"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("a735acad-5db6-4105-a061-b126e6a57b47"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("a764f6c2-6a56-4208-9f57-6c7e2f0cb6da"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("a89009d7-37f5-4331-a45d-a6480942aacd"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("aca4f7eb-4177-402c-ae69-cb5315e5d586"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("acabaffb-c81b-4d40-b7ae-f84548d41ef5"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("b0d487b1-3da2-419a-b2ea-5dafcfc25923"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("b10eb808-9e51-4b3b-a141-0614b201b766"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("b2884c7b-6f86-4b70-962d-9eb7c1a97b54"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("b33e977d-2f20-4001-b4ba-90cedec796f2"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("b4255b64-c26f-4702-9872-3ce175a30c54"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("b52ddad4-79f8-40be-8ae5-3b39531b6274"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("b6f29a5e-8e48-4246-9757-28316b8f2d76"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("b74ae734-9e31-4f11-9ffd-56fe7493bac7"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("bba4e89b-fae9-4ce3-a949-2c47611b71d0"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("be203b02-e77d-4354-9a15-3f1915b18370"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("bed82794-07c3-4988-8a66-24e2cc1682f3"), new Guid("7ac71700-7a87-45b6-9120-19d4ed3933fa"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("c00d0a03-7d98-4657-8b52-d5a3a6e418c1"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("c074acf7-8ed5-4ec8-8f5e-e025595afa17"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("c17b3d59-a487-4c2f-af14-ced6b43fb9ef"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("c235ca42-7ab9-49b3-a9b3-7406b375d358"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("c56c5393-46f9-42d3-b4b4-4ff7daaa569c"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("274aa3a0-05f8-4ff0-b100-e70ddb0d39d9") },
                    { new Guid("c6079760-918d-46b4-8af4-15a4cffe08e3"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("c6b4661d-d06b-4ab2-ae9f-5ca26f8c0ffa"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("c7b6808d-8c62-4003-81f4-d28d0e8c8c60"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("c872884c-44f5-440b-823d-ac2e62cda204"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("ca485459-27af-4b16-9c51-f24e48be8eff"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("ca50ea8e-fc3a-448c-8438-ac37387c7937"), new Guid("d2da81d0-8f87-43cb-9dba-1a0903c1871a"), new Guid("905d9d8f-7b09-4536-82d1-d15b938b2dac") },
                    { new Guid("cc7e24f5-2b46-43da-baa6-f6724b135843"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("cdb283d3-b12a-4af1-bfda-a035e1632a88"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("ce2ffdf3-e65a-492f-819b-af9ebe29ad6f"), new Guid("35fa8298-81a2-4ddd-9312-0876455bf402"), new Guid("057670f0-ab14-41bf-b5f0-42c0bdcc069c") },
                    { new Guid("cef3e05e-38b7-45fc-8b11-a4519fc95e76"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("d1d531e8-8a2e-4b69-902d-9e336e870832"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("d2a86ebc-3067-424a-946e-894f7d6e6dbf"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f8ad09a1-d149-44c9-ac14-d5c8cb1d4167") },
                    { new Guid("d2da8a3b-6d1b-4b27-b7c3-67c195d4b5f4"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("06653486-dec4-4054-ba49-c3a63490453e") },
                    { new Guid("d4f8e366-fcc1-451d-8e1a-3c3f3b0cc284"), new Guid("1e83d72d-ad11-4f9f-b342-b39a2ef7a2f8"), new Guid("182612c2-4fbf-46d9-bee0-9e1a10c29ff5") },
                    { new Guid("d5094df4-5a05-4e7d-963e-fe54085062f0"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("59df0181-9f39-4f9c-b41f-2a0f3d6360d0") },
                    { new Guid("d579e14a-729d-4f4a-a089-c9ffc8e80985"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("d59d582d-821f-4c12-8f79-c84d75cdcc2e"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("25814c9e-4ee4-4f36-a973-44cf0cf64485") },
                    { new Guid("d8ddb532-2861-44be-86b3-e21a4a89402e"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("d9968663-fecf-40dd-9a12-9f25f3c07924"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") },
                    { new Guid("e877d23f-b488-43bc-b822-98eaedd66a48"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("f761d066-304f-49f7-b988-3aca64536d9b") },
                    { new Guid("e96d6b30-ee80-4d37-9964-dca27e9f8cea"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("4481e46d-e85b-4870-a210-cdfea8932641") },
                    { new Guid("ed97f4a6-349a-4a2b-a01c-503d56a6490d"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("c4d9f42e-6c19-4ee3-b9ea-6b004aa1dfa3") },
                    { new Guid("eda320a7-23fd-4dae-8aeb-ce3ad76a1043"), new Guid("8705f403-06bc-4983-8c81-86310959cc37"), new Guid("9501c63f-e7ca-4ef6-898e-9c8a23f4edd1") },
                    { new Guid("f0427496-3b30-4ab4-beb9-e8b68e6259eb"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("e285ec6a-3119-43b5-8edb-209fa732a77d") },
                    { new Guid("f8d01684-e392-44fc-954d-4fd92edd8519"), new Guid("06ed14a0-a17e-48d8-868f-33cf5ce916aa"), new Guid("533a7038-190b-4830-8125-5d2aacb7174e") },
                    { new Guid("fae90a19-8c1c-4b30-8635-b381566334c1"), new Guid("87ffac08-1eb6-4c3f-8ec8-977860913635"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("fd2442da-f04a-456a-b62a-fbae80716972"), new Guid("e9743276-25fd-4b47-a8ac-be13f27d2a53"), new Guid("be392eff-ef38-4039-94ec-7922f315ea6a") },
                    { new Guid("feca736c-f162-4e28-b1d0-c7c2e6ad32a0"), new Guid("95cf0585-b940-4afb-926d-01d9a3a27259"), new Guid("845a0c8f-59d5-4abb-bdc9-bf95d4d0ce1c") },
                    { new Guid("ff1b7a50-fdc5-484b-9a0b-6abb0f6ddfc0"), new Guid("c0ee3730-2717-4f50-8294-cf13437bbc2b"), new Guid("defbc09e-9f00-49b9-a37e-592a17cecc63") }
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
