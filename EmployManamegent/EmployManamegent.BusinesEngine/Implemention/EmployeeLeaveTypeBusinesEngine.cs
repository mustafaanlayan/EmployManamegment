using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EmloyeManagement.Data.Concrats;
using EmloyeManagement.Data.DbModel;
using EmployManamegent.BusinesEngine.Concrats;
using EmployManamegent.Common.ContstansModels;
using EmployManamegent.Common.ResultModels;
using EmployManamegent.Common.VModels;

namespace EmployManamegent.BusinesEngine.Implemention
{
   public class EmployeeLeaveTypeBusinesEngine:IEmployeeLeaveTypeBusinesEngine
   {
        #region Varible
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private List<EmployeeLeaveType> returnData;
        #endregion

        #region Consractor
        public EmployeeLeaveTypeBusinesEngine(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion

        #region Custom Metod
        public Result<List<EmployeeLeaveType>> GetAllEmployeeLeaveType()
        {
            var data = _unitOfWork.employeeLeaveType.GetAll().ToList();
            #region 1.Yontem
            if (data != null)
            {
                List<EmployeeLeaveType> returnData = new List<EmployeeLeaveType>();
                foreach (var item in data)
                {
                    returnData.Add(new EmployeeLeaveType()
                    {
                        Id = item.Id,
                        DateCreated = item.DateCreated,
                        DefaultDays = item.DefaultDays,
                        Name = item.Name
                    });
                }

                return new Result<List<EmployeeLeaveType>>(true, ResultConstans.RecordFound, returnData);
            }
            else
            {
                return new Result<List<EmployeeLeaveType>>(false, ResultConstans.RecordNotFound);
            }
            #endregion

            #region 2.Yontem
            //var leaveTypes = _mapper.Map<List<EmployeeLeaveType>, List<EmployeeLeaveTypeVM>>(data);
            //return new Result<List<EmployeeLeaveTypeVM>>(true, ResultConstans.RecordFound, leaveTypes); 
            #endregion
        } 
        #endregion
    }
}
