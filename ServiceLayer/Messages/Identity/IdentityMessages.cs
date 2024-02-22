using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Messages.Identity
{
    public static class IdentityMessages
    {
        public static string CheckTitle(string propName)
        {
            return $"{propName} should be in Title format!";
        }
        public static string CheckFirstName(string propName)
        {
            return $"{propName} should be in FirstName format!";
        }
        public static string CheckLastName(string propName)
        {
            return $"{propName} should be in LastName format!";
        }
        public static string CheckOtherLastName(string propName)
        {
            return $"{propName} should be in OtherLastName format!";
        }
        public static string CheckCAQualificationYear(string propName)
        {
            return $"{propName} should be in CAQualificationYear format!";
        }
        public static string CheckProfessionalDesignation(string propName)
        {
            return $"{propName} should be in ProfessionalDesignation format!";
        }
        public static string CheckCurrentTitle(string propName)
        {
            return $"{propName} should be in ProfessionalDesignation format!";
        }
        public static string CheckPhone(string propName)
        {
            return $"{propName} should be in Phone  format!";
        }
        public static string CheckExtension(string propName)
        {
            return $"{propName} should be in Extension  format!";
        }
        public static string CheckCompany(string propName)
        {
            return $"{propName} should be in Company  format!";
        }
        public static string CheckBuildingNumber(string propName)
        {
            return $"{propName} should be in BuildingNumber  format!";
        }
        public static string CheckStreet(string propName)
        {
            return $"{propName} should be in Street  format!";
        }
        public static string CheckCountry(string propName)
        {
            return $"{propName} should be in Country  format!";
        }
        public static string CheckState(string propName)
        {
            return $"{propName} should be in State  format!";
        }
        public static string CheckPostalCode(string propName)
        {
            return $"{propName} should be in PostalCode  format!";
        }
        public static string CheckCommencementYear(string propName)
        {
            return $"{propName} should be in PostalCode  format!";
        }
        public static string CheckLeaveYear(string propName)
        {
            return $"{propName} should be in PostalCode  format!";
        }
        public static string CheckKPMGOffice(string propName)
        {
            return $"{propName} should be in PostalCode  format!";
        }
        public static string CheckEmail(string propName)
        {
            return $"{propName} should be in PostalCode  format!";
        }
    }
}
