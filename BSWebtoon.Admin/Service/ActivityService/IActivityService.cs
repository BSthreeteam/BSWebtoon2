using BSWebtoon.Admin.Models.DTO.Activitys;
using System.Threading.Tasks;

namespace BSWebtoon.Admin.Service.ActivityService
{
    public interface IActivityService
    {
        string GetEmployeeName(int Employeeid);

        GetAllEmployeeNameOutputDTO GetAllEmployeeName();

        Task<ActivitysOutputDTO> UpActivityInfo(ActivitysInputDTO inputDTO);

        

    }
}
