using EntityLayer.WebApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configuration
{
    public class RequestAccessConfig : IEntityTypeConfiguration<RequestAccess>
    {
        public void Configure(EntityTypeBuilder<RequestAccess> builder)
        {
            builder.Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            builder.Property(x => x.UpdateDate).IsRequired().HasMaxLength(10);
            builder.Property(x => x.RowVersion).IsRowVersion();

            // Alumni Details
            builder.Property(x => x.Title).HasMaxLength(50);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.OtherLastName).HasMaxLength(100);
            builder.Property(x => x.CAQualificationYear).IsRequired();
            builder.Property(x => x.ProfessionalDesignation).HasMaxLength(100);

            // Business Details
            builder.Property(x => x.CurrentTitle).HasMaxLength(100);
            builder.Property(x => x.Phone).HasMaxLength(20);
            builder.Property(x => x.Extension).HasMaxLength(10);
            builder.Property(x => x.Company).HasMaxLength(100);
            builder.Property(x => x.BuildingNumber).HasMaxLength(20);
            builder.Property(x => x.Street).HasMaxLength(100);
            builder.Property(x => x.Country).HasMaxLength(100);
            builder.Property(x => x.State).HasMaxLength(100);
            builder.Property(x => x.City).HasMaxLength(100);
            builder.Property(x => x.PostalCode).HasMaxLength(20);

            // Employee Details
            builder.Property(x => x.CommencementYear).HasMaxLength(4);
            builder.Property(x => x.LeaveYear).HasMaxLength(4);
            builder.Property(x => x.KPMGOffice).HasMaxLength(100);

            // Personal Details
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);

        }
    }
}
