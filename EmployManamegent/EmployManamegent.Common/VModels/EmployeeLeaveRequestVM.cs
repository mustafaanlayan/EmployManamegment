using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployManamegent.Common.VModels
{
   public class EmployeeLeaveRequestVM:BaseVM
    {
        public string RequestingEmployeeId { get; set; }
       
        public EmployeeVM RequestingEmployee { get; set; }

        public string ApprovedEmployeeId { get; set; }
        
        public EmployeeVM ApproveEmployee { get; set; }


        public int EmployeeLeaveTypeId { get; set; }
       
        public EmployeeLeaveTypeVM EmployeeLeaveType { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequest { get; set; }
        
        [Display(Name = "Talep Açıklama")]
        [MaxLength(ErrorMessage="300 Karekterden Fazla Değer Girilemez")]
        public string RequestComments { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }

    }
}
