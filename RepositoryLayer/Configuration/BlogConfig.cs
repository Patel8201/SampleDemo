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
    public class BlogConfig : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(x => x.CreatedDate).IsRequired().HasMaxLength(10);
            builder.Property(x => x.UpdateDate).IsRequired().HasMaxLength(10);
            builder.Property(x => x.RowVersion).IsRowVersion();

            builder.Property(x => x.Title).IsRequired().
                HasMaxLength(200);
            builder.Property(x => x.Content).IsRequired().
                HasMaxLength(200);
            //builder.Property(x => x.Date).IsRequired().HasColumnType("datetime");
            builder.Property(x => x.FileName).IsRequired().HasMaxLength(255);
            builder.Property(x => x.FileType).IsRequired().HasMaxLength(50);
           
            //builder.HasData(new Blog
            //{  
            //    Id = 1,
            //    Title = "Navigating the Evolving Landscape of Auditing: Challenges and Opportunities",
            //    Content = "n the dynamic realm of financial oversight",
                

            //    FileName ="Test",
            //    FileType = "Test"
            //    //Id = 1,
            //    //Title = "Navigating the Evolving Landscape of Auditing: Challenges and Opportunities",
            //    //Content = "n the dynamic realm of financial oversight",
            //    ////Date = DateTime.Now,

            //    //FileName ="Test",
            //    //FileType = "Test"
            //});
        }
    }
}
