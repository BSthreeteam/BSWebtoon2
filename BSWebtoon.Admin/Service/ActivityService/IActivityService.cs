using BSWebtoon.Admin.Models.DTO.Activity;
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
