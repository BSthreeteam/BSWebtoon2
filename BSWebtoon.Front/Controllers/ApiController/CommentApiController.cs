using BSWebtoon.Front.Models.DTO.WorkPage;
using BSWebtoon.Front.Service.ComicService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BSWebtoon.Front.Controllers.ApiController
{
    [ApiController]
    [Route("/api/[controller]/[action]")]//最好寫Action因為我們controller可能有很多小雞很複雜，所以加一個Action
    public class CommentApiController : ControllerBase
    {
        private readonly IComicService _comicService;

        public CommentApiController(IComicService comicService)
        {
            _comicService = comicService;
        }

        [HttpGet("{id}")]///api/CommentApi/GetCommentAll/879
        public IActionResult GetCommentAll([FromRoute]int id)
        {
            try
            {
                var result = _comicService.GetComment(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok($"錯誤訊息:{ex}");
            }
        }


        [HttpPost]
        public IActionResult PostComment(CommentDTO comment)
        {
            try
            {

                _comicService.CreateComment(comment);
                return Ok();
            }
            catch (Exception ex)
            {
                return Ok($"錯誤訊息:{ex}");

            }
        }

    }
}
