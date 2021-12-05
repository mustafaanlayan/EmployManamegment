using System;
using System.Collections.Generic;
using System.Text;
using EmloyeManagement.Data.DbModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmloyeManagement.Data.DataContext
{
   public class MustafaEmployeManamegentContext:IdentityDbContext
    {
        public MustafaEmployeManamegentContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeLeaveAllocation> EmployeeLeaveAllocations { get; set; }
        public DbSet<EmployeeLeaveRequest> EmployeeLeaveRequests { get; set; }
        public DbSet<EmployeeLeaveType> EmployeeLeaveTypes { get; set; }
    }

}
