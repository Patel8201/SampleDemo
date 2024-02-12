using EntityLayer.WebApplication.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Configuration
{
    public class HomeConfig : IEntityTypeConfiguration<Home>
    {
        public void Configure(EntityTypeBuilder<Home> builder)
        {
            builder.Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            builder.Property(x => x.UpdateDate).IsRequired().HasMaxLength(10);
            builder.Property(x => x.RowVersion).IsRowVersion();



            builder.Property(x => x.Header).IsRequired()
                .HasMaxLength(200);
            builder.Property(x => x.Description).IsRequired()
                .HasMaxLength(200);


            builder.Property(x => x.FullName).IsRequired()
                .HasMaxLength(200);
            builder.Property(x => x.Title).IsRequired().
                HasMaxLength(200);

            builder.Property(x => x.FileName).IsRequired();
            builder.Property(x => x.FileType).IsRequired();

            //builder.HasData(new Home
            //{
            //    Id = 1,
            //    Header = "Alumni Web Portal",
            //    Description = "Past Meet Present:", 
            //    FullName = "Donald John",
            //    Title = "Ex CEO",
            //    FileName = "test",
            //    FileType = "Test",
            //    Facebook = "Facebook",
            //    Instagram = "Instagram",
            //    Twitter = "Twitter",
            //    Linkedin = "Linkedin",

            //});
        }
    }
}
