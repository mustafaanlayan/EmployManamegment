using System;
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
        public Result<List<EmployeeLeaveTypeVM>> GetAllEmployeeLeaveType()
        {
            var data = _unitOfWork.employeeLeaveType.GetAll().ToList();
            #region 1.Yontem
            //if (data != null)
            //{
            //    List<EmployeeLeaveType> returnData = new List<EmployeeLeaveType>();
            //    foreach (var item in data)
            //    {
            //        returnData.Add(new EmployeeLeaveType()
            //        {
            //            Id = item.Id,
            //            DateCreated = item.DateCreated,
            //            DefaultDays = item.DefaultDays,
            //            Name = item.Name
            //        });
            //    }

            //    return new Result<List<EmployeeLeaveType>>(true, ResultConstans.RecordFound, returnData);
            //}
            //else
            //{
            //    return new Result<List<EmployeeLeaveType>>(false, ResultConstans.RecordNotFound);
            //}
            #endregion

            #region 2.Yontem
            var leaveTypes = _mapper.Map<List<EmployeeLeaveType>, List<EmployeeLeaveTypeVM>>(data);
            return new Result<List<EmployeeLeaveTypeVM>>(true, ResultConstans.RecordFound, leaveTypes); 
            #endregion
        }

        /// <summary>
        /// New Employ Create
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Result<EmployeeLeaveTypeVM> CreateEmployeeLeaveType(EmployeeLeaveTypeVM model)
        {
            if (model!=null)
            {
                try
                {
                    var leaveTypes =
                                _mapper.Map<EmployeeLeaveTypeVM, EmployeeLeaveType>(model);
                    leaveTypes.DateCreated = DateTime.Now;
                    _unitOfWork.employeeLeaveType.Add(leaveTypes);
                    _unitOfWork.Save();
                    return new Result<EmployeeLeaveTypeVM>(true, ResultConstans.RecordCreateSuccesFulyy);
                }
                catch (Exception ex)
                {

                    return new Result<EmployeeLeaveTypeVM>(false,ResultConstans.RecordCreateNotSuccesFulyy +"->"+ ex.Message.ToString());
                }
            }
            else
            {
                return new Result<EmployeeLeaveTypeVM>(false, "Parametre Olarak Geçilen Data Boş Olamaz !");
            }
        }

      public  Result<EmployeeLeaveTypeVM> GetAllEmployeeLeaveType(int id)
        {
            var data = _unitOfWork.employeeLeaveType.Get(id);
            if (data!=null)
            {
                var leaveTypes =
                    _mapper.Map<EmployeeLeaveType, EmployeeLeaveTypeVM>(data);
                return new Result<EmployeeLeaveTypeVM>(true, ResultConstans.RecordFound, leaveTypes);
            }
            else
            {
                return new Result<EmployeeLeaveTypeVM>(false, ResultConstans.RecordNotFound);
            }
        }
        #endregion
    }
}
