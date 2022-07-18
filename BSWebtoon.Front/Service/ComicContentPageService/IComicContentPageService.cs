using BSWebtoon.Front.Models.DTO.WorkContent;
using System.Collections.Generic;

namespace BSWebtoon.Front.Service.ContentPageService
{
    public interface IComicContentPageService
    {
        public List<WorkContentDTO> ReadComicContent(int ComicId);
    }
}
