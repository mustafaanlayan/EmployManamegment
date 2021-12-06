using EmloyeManagement.Data.Concrats;
using EmloyeManagement.Data.DataContext;
using EmloyeManagement.Data.DbModel;

namespace EmloyeManagement.Data.Implemention
{
   public class EmployeeLeaveRequestRepository: Repository<EmployeeLeaveRequest>,IEmployeeLeaveRequest
   {
       private readonly MustafaEmployeManamegentContext _ctx;
        public EmployeeLeaveRequestRepository(MustafaEmployeManamegentContext ctx) : base(ctx)
        {
        }
    }
}
