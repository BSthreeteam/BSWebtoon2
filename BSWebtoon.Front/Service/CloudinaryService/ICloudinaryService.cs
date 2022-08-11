using BSWebtoon.Front.Models.DTO.CloudinaryDTO;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace BSWebtoon.Front.Service.CloudinaryService
{
    public interface ICloudinaryService
    {
        Task<UploadImgOutputDTO> UploadAsync(IFormFile file);

        //影片
        Task<UploadVoideOutputDTO> VideoUploadAsync(IFormFile file);
    }
}
