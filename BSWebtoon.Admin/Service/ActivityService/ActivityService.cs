using BSWebtoon.Admin.IDapperRepository;
using BSWebtoon.Admin.Models.DTO.Activity;
using BSWebtoon.Front.Service.CloudinaryService;
using BSWebtoon.Model.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static BSWebtoon.Admin.Models.DTO.Activity.GetAllEmployeeNameOutputDTO;

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


        //先在還沒做登入當 擴充
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




        public async Task<ActivitysOutputDTO>UpActivityInfo(ActivitysInputDTO inputDTO)
        {
            var result = new ActivitysOutputDTO()
            {
                IsSuccess = false,
            };

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

            //_repository.Create(NewActivityInfo);
            //_repository.SaveChange();
             var a = _activityRepository.Create(NewActivityInfo);

            result.IsSuccess = true;
            return result;

        }


    }
}
