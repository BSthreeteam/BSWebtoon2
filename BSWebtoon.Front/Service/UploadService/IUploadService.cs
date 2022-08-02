using BSWebtoon.Front.Models.DTO.UploadComicDTO;
using System.Threading.Tasks;

namespace BSWebtoon.Front.Service.UploadService
{
    public interface IUploadService
    {
        string GetNickName(int userid);
        //漫畫上傳
        Task<UploadComicOutputDTO> UploadComicViewUpdateData(UploadComicInputDTO input);

        /// <summary>
        /// 查到此作者所有未完結漫畫、每部漫畫到已經到第幾集
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        GetComicInfoOutputDTO GetComicInfoToUploadEp(GetComicInfoInputDTO input);

        //話次與內容上傳
        Task<UploadEpOutputDTO> UploadEp(UploadEpInputDTO input);


    }
}
