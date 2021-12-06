using System;
using System.ComponentModel.DataAnnotations;

namespace EmployManamegent.Common.VModels
{
   public class EmployeeVM
    {
        public string Id { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhonenUmber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TaxNo { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
