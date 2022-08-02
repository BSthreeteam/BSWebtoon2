

using BSWebtoon.Front.Models.ViewModel.Loginoption;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.IO;
//using BSWebtoon.Front.Models.DTO.EP;
using BSWebtoon.Front.Models.DTO.UploadComicDTO;
using BSWebtoon.Front.Models.DTO.CloudinaryDTO;
using System.Threading.Tasks;

namespace BSWebtoon.Front.Service.CloudinaryService
{
    public class CloudinaryService : ICloudinaryService
    {
        private readonly IConfiguration _config;
        private readonly Cloudinary _cloudinary;

        public CloudinaryService(IConfiguration config) //這不需要特意去註冊DI，MVC天生就能注入
        {
            _config = config;

            Account account = new Account(
                _config["Cloudinary:cloudname"],
                _config["Cloudinary:apikey"],
                _config["Cloudinary:apisecret"]
            );

            _cloudinary = new Cloudinary(account);
            _cloudinary.Api.Secure = true;
        }



        public async Task<UploadImgOutputDTO> UploadAsync(IFormFile file)
        {

            var result = new UploadImgOutputDTO
            {
                IsSuccess = false,
            };

            if (file == null || file.Length == 0)
            {
                result.Message = "上傳檔案長度為0,失敗!";
                return result;
            }

            string folderPath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "wwwroot",
                "UP"//必須先手動在wwwroot下建資料夾?
            );
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            //取得作業系統的完整檔案路徑
            string filePath = Path.Combine(
                folderPath,
                Guid.NewGuid().ToString()   //避免大量商家，檔名重疊衝突? 使用全域ID 反正待會會刪掉
                    );

            //还可以获取文件的信息，可做一些條件限制(檔案大小上限...等)
            // file.Length / 1024.0;  // 文件大小 KB
            // file.FileName; // 客户端上传的文件名
            // file.ContentType; // 获取文件 ContentType 或解析 MIME 类型

            try
            {
                //using (var stream = File.Create(filePath)) //網路
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    //以非同步方式將上傳檔案內容Copy複製寫入FileStream檔案資料流
                    await file.CopyToAsync(stream);
                }

                //相對路徑
                //string virtualPath = Url.Content("UploadFiles/" + upload.FileName);

                //完整URL路徑
                //string url = $"{Request.Scheme}://{Request.Host.Value}/{virtualPath}";

                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(filePath), //檔案來源  可以直接放網址的圖， 但 本地檔案 得經由上面過程?
                    PublicId = $"TestCKEditor/{file.FileName}"//【圖床存放路徑】 問題在於若未來圖片不需要了，怎麼刪??

                };

                var uploadResult = _cloudinary.Upload(uploadParams);    //取得回傳結果物件

                //【圖床存放路徑 所導致的圖片位址】 
                result.Url = uploadResult.SecureUrl.ToString();
                //resultImgUrl = uploadResult.Url.ToString();
                //resultImgUrl = _cloudinary.GetResource(uploadParams.PublicId).SecureUrl;

                //刪wwwroot的檔案
                //https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/file-system/how-to-copy-delete-and-move-files-and-folders
                File.Delete(filePath);

                result.IsSuccess = true;
                return result;

                //缺點：圖片一插入就上傳，但文案不一定會儲存...長期下來會有許多冗圖?
            }
            catch (Exception ex)
            {
                result.Message = ex.ToString();
                return result;
            }
        }

        //影片
        public async Task<UploadVoideOutputDTO> VideoUploadAsync(IFormFile file)
        {

            var result = new UploadVoideOutputDTO
            {
                IsSuccess = false,
            };

            if (file == null || file.Length == 0)
            {
                result.Message = "上傳檔案長度為0,失敗!";
                return result;
            }

            string folderPath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "wwwroot",
                "UP"//必須先手動在wwwroot下建資料夾?
            );
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            //取得作業系統的完整檔案路徑
            string filePath = Path.Combine(
                folderPath,
                Guid.NewGuid().ToString()   //避免大量商家，檔名重疊衝突? 使用全域ID 反正待會會刪掉
                    );

            //还可以获取文件的信息，可做一些條件限制(檔案大小上限...等)
            // file.Length / 1024.0;  // 文件大小 KB
            // file.FileName; // 客户端上传的文件名
            // file.ContentType; // 获取文件 ContentType 或解析 MIME 类型

            try
            {
                //using (var stream = File.Create(filePath)) //網路
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    //以非同步方式將上傳檔案內容Copy複製寫入FileStream檔案資料流
                    await file.CopyToAsync(stream);
                }

                //相對路徑
                //string virtualPath = Url.Content("UploadFiles/" + upload.FileName);

                //完整URL路徑
                //string url = $"{Request.Scheme}://{Request.Host.Value}/{virtualPath}";

                var uploadParams = new VideoUploadParams()
                {
                    File = new FileDescription(filePath), //檔案來源  可以直接放網址的圖， 但 本地檔案 得經由上面過程?
                    PublicId = $"TestCKEditor/{file.FileName}"//【圖床存放路徑】 問題在於若未來圖片不需要了，怎麼刪??

                };

                var uploadResult = _cloudinary.Upload(uploadParams);    //取得回傳結果物件

                //【圖床存放路徑 所導致的圖片位址】 
                result.Url = uploadResult.SecureUrl.ToString();
                //resultImgUrl = uploadResult.Url.ToString();
                //resultImgUrl = _cloudinary.GetResource(uploadParams.PublicId).SecureUrl;

                //刪wwwroot的檔案
                //https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/file-system/how-to-copy-delete-and-move-files-and-folders
                File.Delete(filePath);

                result.IsSuccess = true;
                return result;

                //缺點：圖片一插入就上傳，但文案不一定會儲存...長期下來會有許多冗圖?
            }
            catch (Exception ex)
            {
                result.Message = ex.ToString();
                return result;
            }
        }


    }
}
