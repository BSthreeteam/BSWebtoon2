using BSWebtoon.Admin.Models.DTO.Cloudinarys;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace BSWebtoon.Admin.Service.AdminComicCloudinaryService
{
    public interface IAdminComicCloudinaryService
    {
        Task<UploadImgOutputDTO> UploadAsync(IFormFile file);

        //影片
        //Task<UploadVoideOutputDTO> VideoUploadAsync(IFormFile file);
    }
}
