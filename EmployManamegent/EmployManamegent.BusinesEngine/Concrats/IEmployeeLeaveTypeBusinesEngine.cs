using EmployManamegent.Common.ResultModels;
using System;
using System.Collections.Generic;
using System.Text;
using EmloyeManagement.Data.DbModel;

namespace EmployManamegent.BusinesEngine.Concrats
{
   public interface IEmployeeLeaveTypeBusinesEngine
   {
       Result<List<EmployeeLeaveType>> GetAllEmployeeLeaveType();
   }
}
