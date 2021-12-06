using System;
using System.ComponentModel.DataAnnotations;

namespace EmployManamegent.Common.VModels
{
   public class EmployeeLeaveTypeVM:BaseVM
    {
        [Required]
        public string Name { get; private set; }
        public int DefaultDays { get;private set; }
        public DateTime DateCreated { get;private set; }

        public void SetEmployeeType(string name)
        {
            this.Name = name;
        }
    }
}
