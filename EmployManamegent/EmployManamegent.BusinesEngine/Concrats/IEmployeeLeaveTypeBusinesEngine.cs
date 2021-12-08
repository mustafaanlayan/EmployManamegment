using EmployManamegent.Common.ResultModels;
using System;
using System.Collections.Generic;
using System.Text;
using EmloyeManagement.Data.DbModel;
using EmployManamegent.Common.VModels;

namespace EmployManamegent.BusinesEngine.Concrats
{
   public interface IEmployeeLeaveTypeBusinesEngine
   {
       Result<List<EmployeeLeaveTypeVM>> GetAllEmployeeLeaveType();
       Result<EmployeeLeaveTypeVM> CreateEmployeeLeaveType(EmployeeLeaveTypeVM model);
        /// <summary>
        /// Get Employ Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
       Result<EmployeeLeaveTypeVM> GetAllEmployeeLeaveType(int id);

        Result<EmployeeLeaveTypeVM> EditEmployeeLeaveType(EmployeeLeaveTypeVM model);
   }
}
