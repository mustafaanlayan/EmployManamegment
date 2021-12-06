using System;
using System.Collections.Generic;
using System.Text;
using EmloyeManagement.Data.Concrats;
using EmloyeManagement.Data.DataContext;

namespace EmloyeManagement.Data.Implemention
{
   public class UnitOfWork:IUnitOfWork
   {
       private readonly MustafaEmployeManamegentContext _ctx;

       public UnitOfWork(MustafaEmployeManamegentContext ctx)
       {
           _ctx = ctx;
           employeeLeaveAllocation = new EmployeLeaveAllocationRepository(_ctx);
           employeeLeaveRequest = new EmployeeLeaveRequestRepository(_ctx);
           employeeLeaveType = new EmployeeLeaveTypeRepository(_ctx);
       }

       public IEmployeeLeaveAllocationRepository employeeLeaveAllocation { get; private set; }
       public IEmployeeLeaveRequest employeeLeaveRequest { get; private set; }
       public IEmployeeLeaveTypeRepository employeeLeaveType { get; private set; }

        public void Save()
       {
           _ctx.SaveChanges();
       }

        public void Dispose()
        {
            _ctx.Dispose();
        }
        
    }
}
