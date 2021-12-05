using System;

namespace EmloyeManagement.Data.DbModel
{
   public class EmployeeLeaveType:BaseEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
