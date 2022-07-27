using BSWebtoon.Front.Models.DTO.UploadComicDTO;
using BSWebtoon.Front.Models.DTO.UploadWorkView;
using System.Threading.Tasks;

namespace BSWebtoon.Front.Service.LoginService
{
    public interface ILoginService
    {
        //漫畫上傳
        Task<UploadComicOutputDTO> UploadComicViewUpdateData(UploadComicInputDTO input);

        //話次與內容上傳
        Task<UploadWorkOutputDTO> UploadWorkViewUpdateData(UploadWorkInputDTO input);
        UploadComicOutputDTO GetNickName(string userName);

    }


}
