using BSWebtoon.Front.Models.DTO.WorkContent;
using System.Collections.Generic;

namespace BSWebtoon.Front.Service.ContentPageService
{
    public interface IComicContentPageService
    {
        public string IsLogin(string useerName);
        public List<WorkContentDTO> ReadEpContent(int ComicId, string useerName);
    }
}
