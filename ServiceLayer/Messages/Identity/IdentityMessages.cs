using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Messages.Identity
{
    public static class IdentityMessages
    {
        public static string CheckEmailAddress(string propName)
        {
            return $"{propName} should be in email format!";
        }  
        public static string ComparePassword(string propName)
        {
            return $"{propName} must be same with the Password";
        }
    }
}
