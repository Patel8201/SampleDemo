﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.WebApplication.ViewModels.HomeVM
{
    public class HomeListVM
    {
        public int Id { get; set; }

        public String CreatedDate { get; set; } = DateTime.Now.ToString("d");

        public string? UpdateDate { get; set; }
        public string Header { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;
        // Notable Alumnae
        public string FullName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Twitter { get; set; } = null!;
        public string Linkedin { get; set; } = null!;
        public string Facebook { get; set; } = null!;
        public string Instagram { get; set; } = null!;
    }
}
