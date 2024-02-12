using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.WebApplication.ViewModels.RequestAccessVM
{
    public class RequestAccessListVM
    {
        public  int Id { get; set; }

        public  String CreatedDate { get; set; } = DateTime.Now.ToString("d");

        public  string? UpdateDate { get; set; }
        public string Title { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string OtherLastName { get; set; } = null!;

        public int CAQualificationYear { get; set; }

        public string ProfessionalDesignation { get; set; } = null!;

        // Business Details

        public string CurrentTitle { get; set; } = null!;
        public string Phone { get; set; } = null!;

        public string Extension { get; set; } = null!;

        public string Company { get; set; } = null!;

        public string BuildingNumber { get; set; } = null!;
        public string Street { get; set; } = null!;

        public string Country { get; set; } = null!;

        public string State { get; set; } = null!;

        public string City { get; set; } = null!;

        public string PostalCode { get; set; } = null!;

        //Employee Details
        public string CommencementYear { get; set; } = null!;
        public string LeaveYear { get; set; } = null!;

        public string KPMGOffice { get; set; } = null!;

        //Personal Details


        public string Email { get; set; } = null!;


    }
}
