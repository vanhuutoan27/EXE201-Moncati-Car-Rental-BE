﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MocatiCar.Core.Domain.Identity;

namespace MoncatiCar.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(
                      new AppRole
                      {
                          Id = new Guid("322488F9-7AA9-49B0-B2B8-FD98B7B260FC"),
                          Name = "Customer",
                          NormalizedName = "CUSTOMER",
                          DisplayName = "Khách Hàng"
                      },
                      new AppRole
                      {
                          Id = new Guid("C0278115-8549-4FAD-890A-44F8E8FCC022"),
                          Name = "Manager",
                          NormalizedName = "MANAGER",
                          DisplayName = "Quản Lí"
                      },
                      new AppRole
                      {
                          Id = new Guid("AB8E4032-2D95-45CC-89C1-C039E9E8BC39"),
                          Name = "Owner",
                          NormalizedName = "CarOwener",
                          DisplayName = "Chủ Xe"
                      }
            );
        }
    }
}
