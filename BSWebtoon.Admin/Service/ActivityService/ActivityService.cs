using BSWebtoon.Admin.IDapperRepository;
//using BSWebtoon.Admin.Models.DTO.Activity;
using BSWebtoon.Admin.Models.DTO.Activitys;
using BSWebtoon.Admin.Models.DTO.Cloudinarys;
using BSWebtoon.Admin.Service.CloudinaryService;
using BSWebtoon.Model.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static BSWebtoon.Admin.Models.DTO.Activitys.GetAllEmployeeNameOutputDTO;

namespace BSWebtoon.Admin.Service.ActivityService
{
    public class ActivityService : IActivityService 
    {

        private readonly IDapperActivityRepository _activityRepository;
        private readonly IDapperEmployeeRepository _employeeRepository;

        private readonly BSRepository _repository;
        private readonly ICloudinaryService _cloudinaryService;

        public ActivityService(
            IDapperActivityRepository activityRepository, 
            IDapperEmployeeRepository employeeRepository, 
            BSRepository repository,
            ICloudinaryService cloudinaryService)
        {
            _activityRepository = activityRepository;
            _employeeRepository = employeeRepository;
            _repository = repository;
            _cloudinaryService = cloudinaryService;
        }


        //當擴充
        //取到登入後名稱
        public string GetEmployeeName(int Employeeid)
        {
            var result = new ActivitysOutputDTO()
            {
                IsSuccess = false,

            };
            string Employee = "";


            //
            //Dapperz; 方法區
            Employee = _employeeRepository.SelectById(Employeeid).EmployeeName;


            //= _activityRepository.SelectAll().Where(x => x.PrincipalEmployee == ).First(x => x.PrincipalEmployee == 17);

            
            return Employee;
        }

        //取到全部的員工名字
        public GetAllEmployeeNameOutputDTO GetAllEmployeeName()
        {
            var result = new GetAllEmployeeNameOutputDTO()
            {
                IsSuccess = false,

            };


            //var EmployeeAllid = _employeeRepository.SelectAll().Where(x => x.EmployeeId == x.EmployeeId).Select(x => new WithAllEmployeeName() { EmployeeId = x.EmployeeId, EmployeeName = x.EmployeeName});
            //result.WeEmployeeName.AddRange(EmployeeAllid);

            result.WeEmployeeName = _employeeRepository.SelectAll()
                .Where(x => x.EmployeeId == x.EmployeeId)
                .Select(x => new WithAllEmployeeName() { EmployeeId = x.EmployeeId, EmployeeName = x.EmployeeName })
                .ToList();


            return result;
        }

        //實作收到使用者輸入的值，寫入資料庫的方法。
        public async Task<ActivitysOutputDTO>UpActivityInfo(ActivitysInputDTO inputDTO)
        {
            var result = new ActivitysOutputDTO()
            {
                IsSuccess = false,
            };


            //圖床轉換
            var ActivityImageOutput = await _cloudinaryService.UploadAsync(inputDTO.ActivityImage);


            var NewActivityInfo = new BSWebtoon.Model.Models.Activity()
            {
                ActivityName = inputDTO.ActivityName,
                ActivityStartTime = inputDTO.ActivityStartTime,
                ActivityEndTime  = inputDTO.ActivityEndTime,
                ActivityImage = ActivityImageOutput.Url,
                ActivityBgColor  = inputDTO.ActivityBgColor,
                ActivityContent = inputDTO.ActivityContent,
                PrincipalEmployee = inputDTO.ActivityEmployeeName,
                CreateTime = DateTime.UtcNow,
                IsDelete = false
            };

            
             var a = _activityRepository.Create(NewActivityInfo);

            result.IsSuccess = true;
            return result;

        }



        public async Task<UpdateActivityOutputDTO> EidtActivityInfo(UpdateActivityInputDTO inputDTO)
        {
            UploadImgOutputDTO  ActivityImageOutput;

            var result = new UpdateActivityOutputDTO()
            {
                IsSuccess = false,
            };

            if (inputDTO.ActivityImage != null)
            {
                //圖床轉換
                ActivityImageOutput = await _cloudinaryService.UploadAsync(inputDTO.ActivityImage);

                var NewActivityPic = new BSWebtoon.Model.Models.Activity()
                {
                    ActivityId = inputDTO.ActivityId,
                    ActivityImage = ActivityImageOutput.Url,
                    
                };
                if (NewActivityPic.ActivityImage != null)
                {
                    _activityRepository.UpdateImg(NewActivityPic);
                }

            }

           
            var NewActivityInfo = new BSWebtoon.Model.Models.Activity()
            {
                ActivityId = inputDTO.ActivityId,
                ActivityName = inputDTO.ActivityName,
                ActivityStartTime = inputDTO.ActivityStartTime,
                ActivityEndTime = inputDTO.ActivityEndTime,
                //ActivityImage = ActivityImageOutput.Url,
                ActivityBgColor = inputDTO.ActivityBgColor,
                ActivityContent = inputDTO.ActivityContent,              
            };

            //if (NewActivityInfo.ActivityImage != null)
            //{
            //    _activityRepository.UpdateImg(NewActivityInfo);
            //}
            
            _activityRepository.Update(NewActivityInfo);

            return result;
        }


    }
}
