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
    public class EventConfig : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            builder.Property(x => x.UpdateDate).IsRequired().HasMaxLength(10);
            builder.Property(x => x.RowVersion).IsRowVersion();

            builder.Property(x => x.Title).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Content).IsRequired().HasMaxLength(200);
            //builder.Property(x => x.Date).IsRequired().HasColumnType("datetime");
            builder.Property(x => x.FileName).IsRequired().HasMaxLength(255);
            builder.Property(x => x.FileType).IsRequired().HasMaxLength(50);

            //builder.HasData(new Blog
            //{
            //    Id = 1,
            //    Title = "Navigating the Evolving Landscape of Auditing: Challenges and Opportunities",
            //    Content = "In the dynamic realm of financial oversight",
            //    //Date = DateTime.Now, // Provide a valid date value here
            //    FileName = "Test",
            //    FileType = "Test"
            //});

        }
    }
}
