using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using EmloyeManagement.Data.Concrats;
using EmloyeManagement.Data.DataContext;
using EmloyeManagement.Data.DbModel;

namespace EmloyeManagement.Data.Implemention
{
    public class EmployeLeaveAllocationRepository :Repository<EmployeeLeaveAllocation>,IEmployeeLeaveAllocationRepository
    {
        private readonly MustafaEmployeManamegentContext _ctx;

        public EmployeLeaveAllocationRepository(MustafaEmployeManamegentContext ctx):base(ctx)
        {
            _ctx = ctx;
        }
    }
}
