using System;
using System.Collections.Generic;
using System.Text;

namespace EmloyeManagement.Data.Concrats
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeLeaveAllocationRepository employeeLeaveAllocation { get; }
        IEmployeeLeaveRequest employeeLeaveRequest { get; }
        IEmployeeLeaveTypeRepository employeeLeaveType { get; }
        void Save();
    }
}
