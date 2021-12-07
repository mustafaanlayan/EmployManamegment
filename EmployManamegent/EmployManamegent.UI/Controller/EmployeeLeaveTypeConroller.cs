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
            return View();
        }
    }
}
