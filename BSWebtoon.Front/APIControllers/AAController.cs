using BSWebtoon.Front.Models.ViewModel.Favorite;
using BSWebtoon.Front.Service.FavoriteService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BSWebtoon.Front.APIControllers
{
    //# Endpoint端點：能對外界的接觸點，路由可以安排'接待'(請求)的所有action

    //# 兩種controller的action都是端點。差別是： 
    //      普通：回應 【Html網頁語法】
    //      回傳：回應 【資料】

    //#  所以重點需觀察 發請求過來時有沒有跳轉
    //      有跳轉(超連結/表單post) => 通常用普通action來接，才能回應網頁
    //      無跳轉 (發AJAX) => 通常用API的action來接


    [Route("api/[controller]/[action]")] //路由pattern可以改這樣，就可指定action
    [ApiController]
    public class AAController : ControllerBase
    {
        private readonly IFavoriteService _favoriteService;
        private readonly FavoriteService _readfavoriteService;

        //[HttpGet("{routeParam1}_{routeParam2}/{routeParam3?}")] //可以從controller的pattern接續
        [HttpGet("~/api/[controller]/[action]/{routeParam1}_{routeParam2}/{routeParam3}")]  //也可以從根 開始寫
        public IActionResult ReadFavorite(
            [FromRoute] int routeParam1,
            [FromRoute] string routeParam2,
            [FromRoute] bool routeParam3,
            [FromQuery] int a,
            [FromQuery] string b,
            [FromQuery] bool c)
            {

            //假設去DB，組出了一筆產品ViewModel (一對多關係 都會跨表格)

            //var Favorite = _favoriteService.ReadFavorite();
            //var Favorite_result = new FavoriteViewModel
            //{
            //    FavoriteList = Favorite.Select(f => new FavoriteViewModel.FavoriteData
            //    {
            //        FavoriteId = f.FavoriteId,
            //        MemberId = f.MemberId,
            //        ComicId = f.ComicId,
            //        //ComicChineseName = f.ComicChineseName,
            //        //ComicEnglishName = f.ComicEnglishName,
            //        //ComicNameImage = f.ComicNameImage,
            //        //ComicFigure = f.ComicFigure,
            //        //BgColor = f.BgColor,
            //    }).ToList()
            //};

            var result = new
            {  //這裡用匿名類型 裝一下 ViewModel，總之能回應到前端JS
                ProductName = "除濕機",
                UnitPrice = 123,
                Pictures = new List<string>
                {
                    "https://picsum.photos/300/200/?random=1",
                    "https://picsum.photos/300/200/?random=2",
                    "https://picsum.photos/300/200/?random=3",
                },

                //--------------------------------------------------------
                // 呼叫 Service 存取資料
                //var products = _productService.GetProductList();



        };
            //await System.Threading.Tasks.Task.Delay(3333); //拖延一下，模擬去DB挖資料的時間



            //通用的直接指定statusCode
            //return base.StatusCode(200, result);
            return base.StatusCode(200, result);
            //直接夾帶回傳，基本上預設是 自動以JSON字串 傳遞

            #region 多種內建的方法 (base. 是非必要，但從 base. 查找，會比較沒那麼雜一點 )
            //  代表 不同的 statusCode
            //  每種方法 通常都可夾帶著 物件 回應，前端收到的回應 以 .json() 處理

            //各種狀態碼 可查MDN https://developer.mozilla.org/zh-TW/docs/Web/HTTP/Status
            //2XX 是正常
            base.Ok(new { }); //200
            base.Accepted(new { }); //202
            base.NoContent(); //204
            base.Conflict(new { }); //209

            //3XX 是 重定向/重導 系列
            //302 (暫時轉址)
            base.Redirect("https://localhost:5001/Home/Privacy");
            base.LocalRedirect("/Home/Privacy");
            base.RedirectToAction("Privacy", "Home");
            //base.RedirectToRoute(""); //這我沒感覺到用途

            //301 (永久轉址) (上面每個方法都有 永久轉址的版本，列一個展示而已)
            base.RedirectPermanent("https://localhost:5001/Home/Privacy");


            //4XX 用戶端錯誤
            base.BadRequest(new { }); //400
            base.Unauthorized(new { }); //401
            base.Forbid(); //403
            base.NotFound(new { }); //404
            new UnsupportedMediaTypeResult(); //415??
            base.UnprocessableEntity(); //422


            //5XX 伺服器端錯誤


            //有點特別的? 
            //base.PhysicalFile(); //回傳實體檔案用?
            #endregion 
        }


        //route/QueryString的參數，和get/post 無關
        //所以post應該也能接收...只是好像沒啥必要
        [HttpPost]
        public IActionResult DemoPost([FromBody] DemoAJAXPostModel requestParam)//接收AJAX的body 名稱可隨意
        {
            //post 通常處理 C/U/D， 異動DB可能會 有問題
            //service層 可考慮用到try catch
            var outputDto = new
            {
                IsSuccess = true,
                Message = "",
            };

            //最基本的 可能一律用 200 和 400，寫專題應該夠用
            if (!outputDto.IsSuccess)
            {
                return BadRequest(outputDto.Message); //可善用DTO的Message作為錯誤訊息
            }

            return Ok("demo"); //成功的回傳，通常沒訊息要告知
        }

        //巢狀class 示範用
        public class DemoAJAXPostModel
        {
            //屬性
            //  一定要public
            //  名稱 一定要對應到(可以 JS小駝峰、C#大駝峰)
            public int FavoriteId { get; set; }
            public int MemberId { get; set; }
            public int ComicId { get; set; }
            public string ComicChineseName { get; set; }
            public string ComicWeekFigure { get; set; }
            public string BgColor { get; set; }
        }
    }
}
