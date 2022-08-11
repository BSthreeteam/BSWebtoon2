using BSWebtoon.Admin.Models.DTO.AdminUploadDTO;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace BSWebtoon.Admin.Service.AdminCloudinaryService
{
    public interface IAdminCloudinaryService
    {
        Task<AdminUploadImgOutputDTO> UploadAsync(IFormFile file);

        //影片
        //Task<UploadVoideOutputDTO> VideoUploadAsync(IFormFile file);
    }
}
