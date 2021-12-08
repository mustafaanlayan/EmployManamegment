using System;
using System.ComponentModel.DataAnnotations;

namespace EmployManamegent.Common.VModels
{
   public class EmployeeLeaveTypeVM:BaseVM
    {
        [Required]
        public string Name { get;  set; }
        public int DefaultDays { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }

        public void SetEmployeeType(string name)
        {
            this.Name = name;
        }
    }
}
