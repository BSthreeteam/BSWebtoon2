using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BSWebtoon.Front.Controllers
{
    public class LineLoginController : Controller
    {

        // 這邊要改你申請的應用程式編號及密鑰
        private readonly string _appId = "1657287781";
        private readonly string _appSecret = "bfb84fe044abf733272a40e04bed4d1e";

        private string RedirectUrl => "https://" + HttpContext.Request.Host.ToString() + "/LineLogin/SignInLine";
        private readonly IHttpClientFactory _clientFactory;

        public LineLoginController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        [TempData]
        public Guid State { get; set; }

        public IActionResult Index()
        {
            State = Guid.NewGuid();
            ViewData["LineAuth"] = $"https://access.line.me/oauth2/v2.1/authorize?" +
                $"client_id={_appId}" +
                $"&response_type=code" +
                $"&redirect_uri={RedirectUrl}" +
                $"&scope={HttpUtility.UrlEncode("profile openid email")}" +
                $"&state={State}";

          
            return View();
        }

        public async Task<IActionResult> SignInLine(string code, Guid state, string error, string error_description)
        {
            // 有錯誤訊息(未授權等)、State遺失、State不相同、沒有code
            //if (!string.IsNullOrEmpty(error) || state == null || State != state || string.IsNullOrEmpty(code))
            //    return RedirectToAction(nameof(Index));

            // 使用代碼交換存取權杖 與Facebook 和 Google不同，是使用 application/x-www-form-urlencoded
            var url = "https://api.line.me/oauth2/v2.1/token";
            var postData = new Dictionary<string, string>()
        {
            {"client_id",_appId},
            {"client_secret",_appSecret},
            {"code",code},
            {"grant_type","authorization_code"},
            {"redirect_uri",RedirectUrl}
        };

            var contentPost = new FormUrlEncodedContent(postData);

            var client = _clientFactory.CreateClient();
            var response = await client.PostAsync(url, contentPost);

            string responseContent;
            if (response.IsSuccessStatusCode)
                responseContent = await response.Content.ReadAsStringAsync();
            else
                return RedirectToAction(nameof(Index));

            var lineLoginResource = JsonConvert.DeserializeObject<LINELoginResource>(responseContent);

            // 因為Line API 可以同時取得ClientId Token 和 Access Token，所以這邊有兩種選擇
            // 1. 使用JWT解析Id Token, Nuget > System.IdentityModel.Tokens.Jwt
            //var userInfo = new JwtSecurityToken(lineLoginResource.IDToken).Payload;

            // 2. https://developers.line.biz/en/reference/social-api/#profile
            url = $"https://api.line.me/v2/profile";
            client.DefaultRequestHeaders.Add("authorization", $"Bearer {lineLoginResource.AccessToken}");
            response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                responseContent = await response.Content.ReadAsStringAsync();
                var user = JsonConvert.DeserializeObject<LINEUser>(responseContent);
                ViewBag.line_user = user;

            }



            return View();
        }

        public class LINELoginResource
        {
            [JsonProperty("access_token")]
            public string AccessToken { get; set; }

            [JsonProperty("token_type")]
            public string TokenType { get; set; }

            [JsonProperty("expires_in")]
            public string ExpiresIn { get; set; }

            [JsonProperty("scope")]
            public string Scope { get; set; }

            [JsonProperty("refresh_token")]
            public string RefreshToken { get; set; }

            // 這邊跟一般的TokenResponse不同，多了使用者的Id Token
            [JsonProperty("id_token")]
            public string IDToken { get; set; }
        }

        public class LINEUser
        {
            [JsonProperty("userId")]
            public string Id { get; set; }

            [JsonProperty("displayName")]
            public string Name { get; set; }

            [JsonProperty("pictureUrl")]
            public string PictureUrl { get; set; }

            [JsonProperty("statusMessage")]
            public string StatusMessage { get; set; }
        }
    }
}

