using EmployManamegent.BusinesEngine.Concrats;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployManamegent.UI.Controller
{
    public class EmployeeLeaveTypeConroller : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IEmployeeLeaveTypeBusinesEngine _employeeLeaveTypeBusinesEngine;

        public EmployeeLeaveTypeConroller(IEmployeeLeaveTypeBusinesEngine employeeLeaveTypeBusinesEngine)
        {
            _employeeLeaveTypeBusinesEngine = employeeLeaveTypeBusinesEngine;
        }
        public IActionResult Index()
        {
            var data = _employeeLeaveTypeBusinesEngine.GetAllEmployeeLeaveType();
            if (data.IsSucces)
            {
                var result = data.Data;
                return View(result);
            }

            return View();
        }
    }
}
