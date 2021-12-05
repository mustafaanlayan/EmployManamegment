using System;
using Microsoft.AspNetCore.Identity;

namespace EmloyeManagement.Data.DbModel
{
   public class Employee:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TaxNo { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
