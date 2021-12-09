using EmployManamegent.BusinesEngine.Concrats;
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
            if (id < 0)
                return View();

            var data = _employeeLeaveTypeBusinesEngine.GetAllEmployeeLeaveType(id);
            if (data.IsSucces)

                return View(data.Data);

            return View();


        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(EmployeeLeaveTypeVM model)
        {
            if (ModelState.IsValid)
            {
                var data = _employeeLeaveTypeBusinesEngine.EditEmployeeLeaveType(model);

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

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return Json(new { success = false, message = "Silmek İçin Kayıt Seçiniz" });
           
            var data = _employeeLeaveTypeBusinesEngine.RemoveEmployeeLeaveType(id);
            if (data.IsSucces)

                return Json(new { success = data.IsSucces, message = data.Message });


            else

                return Json(new { success = data.IsSucces, message = data.Message });


        }


    }
}
