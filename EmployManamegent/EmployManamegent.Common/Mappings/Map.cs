using AutoMapper;
using EmloyeManagement.Data.DbModel;
using EmployManamegent.Common.VModels;

namespace EmployManamegent.Common.Mappings
{
   public class Map:Profile
    {
        public Map()
        {
            CreateMap<EmployeeLeaveType, EmployeeLeaveTypeVM>().ReverseMap();
            CreateMap<EmployeeLeaveAllocation, EmployeeLeaveAllocationVM>().ReverseMap();
            CreateMap<EmployeeLeaveRequest, EmployeeLeaveRequestVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
        }
    }
}
