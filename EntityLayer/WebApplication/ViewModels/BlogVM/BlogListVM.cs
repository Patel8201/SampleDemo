using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.WebApplication.ViewModels.BlogVM
{
    public class BlogListVM
    {
        public int Id { get; set; }
        public String CreatedDate { get; set; } = DateTime.Now.ToString("d");
        public string? UpdateDate { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        //public DateTime Date { get; set; }
        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;
    }
}
