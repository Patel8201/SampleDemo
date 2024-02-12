using CoreLayer.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.WebApplication.Entities
{
      public class Blog :  BaseEntity
    {
        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;
       
        //public DateTime Date { get; set; }

        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;
    }
}
