using System;
using System.Collections.Generic;
using System.Text;
using EmloyeManagement.Data.Concrats;
using EmloyeManagement.Data.DataContext;
using EmloyeManagement.Data.DbModel;

namespace EmloyeManagement.Data.Implemention
{
    class EmployeeLeaveAllocationRepository:Repository<EmployeeLeaveAllocation>, IEmployeeLeaveAllocationRepository
    {
        private readonly MustafaEmployeManamegentContext _ctx;

        public EmployeeLeaveAllocationRepository(MustafaEmployeManamegentContext ctx):base(ctx)
        {
            _ctx = ctx;
        }
    }
}
