using EmloyeManagement.Data.Concrats;
using EmloyeManagement.Data.DataContext;
using EmloyeManagement.Data.DbModel;

namespace EmloyeManagement.Data.Implemention
{ 
    
    public class EmployeeLeaveTypeRepository: Repository<EmployeeLeaveType>,IEmployeeLeaveTypeRepository
    {
        private readonly MustafaEmployeManamegentContext _ctx;
        public EmployeeLeaveTypeRepository(MustafaEmployeManamegentContext ctx) : base(ctx)
        {
        }
    }
}
