﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Domain.Identity;
using MoncatiCar.Data.Configurations;

namespace MoncatiCar.Data
{
    public class MocatiContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public MocatiContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarFeature> CarFeatures { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<DrivingLicense> DrivingLicenses { get; set; }
        public DbSet<FavoriteCar> FavoriteCars { get; set; }
        public DbSet<CitizenId> CitizenIds { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims").HasKey(x => x.Id);

            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims")
            .HasKey(x => x.Id);

            builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles")
            .HasKey(x => new { x.RoleId, x.UserId });

            builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens")
               .HasKey(x => new { x.UserId });
  builder.Entity<Car>()
        .Property(c => c.PricePerDay)
        .HasColumnType("decimal(18,2)"); // Precision = 18, Scale = 2

    builder.Entity<Payment>()
        .Property(p => p.Amount)
        .HasColumnType("decimal(18,2)");

    builder.Entity<Rental>()
        .Property(r => r.BasePricePerDay)
        .HasColumnType("decimal(18,2)");

    builder.Entity<Rental>()
        .Property(r => r.TotalDaysRented)
        .HasColumnType("decimal(18,2)");
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new FeatureConfiguration());
            builder.ApplyConfiguration(new BrandConfiguration());
            builder.ApplyConfiguration(new ModelConfiguration());
            builder.ApplyConfiguration(new CarConfiguration());
            builder.ApplyConfiguration(new ImagesConfiguration());
            builder.ApplyConfiguration(new CarFeatureConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());

        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker
               .Entries()
               .Where(e => e.State == EntityState.Added);

            foreach (var entityEntry in entries)
            {
                var dateCreatedProp = entityEntry.Entity.GetType().GetProperty("DateCreated");
                if (entityEntry.State == EntityState.Added
                    && dateCreatedProp != null)
                {
                    dateCreatedProp.SetValue(entityEntry.Entity, DateTime.Now);
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
