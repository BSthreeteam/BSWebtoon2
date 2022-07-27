using BSWebtoon.Front.Models.DTO.CloudinaryDTO;
using BSWebtoon.Front.Models.DTO.UploadWorkView;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace BSWebtoon.Front.Service.CloudinaryService
{
    public interface ICloudinaryService
    {
        ////void UploadWorkViewUpdateData(IFormFile file);

        //UploadWorkOutputDTO UploadWorkViewUpdateData(UploadWorkInputDTO input);


        Task<UploadImgOutputDTO> UploadAsync(IFormFile file);

        //影片
        Task<UploadVoideOutputDTO> VideoUploadAsync(IFormFile file);
    }
}
