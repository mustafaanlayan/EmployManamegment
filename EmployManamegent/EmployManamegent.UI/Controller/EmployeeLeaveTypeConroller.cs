﻿using EmployManamegent.BusinesEngine.Concrats;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmloyeManagement.Data.DbModel;
using EmployManamegent.Common.VModels;

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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeLeaveTypeVM model)
        {
            if (ModelState.IsValid)
            {
                var data = _employeeLeaveTypeBusinesEngine.CreateEmployeeLeaveType(model);

                if (data.IsSucces)
                {
                    return RedirectToAction("Index");
                }

                return View(model);

            }
            else
            {
                return View();
            }
            
        }

        public ActionResult Edit(int id)
        {
            if (id<0)
                return View();

            var data = _employeeLeaveTypeBusinesEngine.GetAllEmployeeLeaveType(id);
            if (data.IsSucces)
            
                return RedirectToAction("Index");

                return View();
            

        }
    }

    
}
