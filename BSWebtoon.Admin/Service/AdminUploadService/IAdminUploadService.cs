using BSWebtoon.Admin.Models.DTO.AdminUploadDOT;
using System.Threading.Tasks;

namespace BSWebtoon.Admin.Service.AdminUploadService
{
    public interface IAdminUploadService
    {
        Task<AdminUploadComicDTO> UploadComicViewUpdateData(AdminUploadComicDTO input);

    }
}
