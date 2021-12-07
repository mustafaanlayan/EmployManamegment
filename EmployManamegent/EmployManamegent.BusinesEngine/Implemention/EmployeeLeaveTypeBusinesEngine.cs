using EmloyeManagement.Data.Concrats;
using EmployManamegent.BusinesEngine.Concrats;

namespace EmployManamegent.BusinesEngine.Implemention
{
   public class EmployeeLeaveTypeBusinesEngine:IEmployeeLeaveTypeBusinesEngine
   {
       private readonly IUnitOfWork _unitOfWork;

       public EmployeeLeaveTypeBusinesEngine(IUnitOfWork unitOfWork)
       {
           _unitOfWork = unitOfWork;
       }
   }
}
