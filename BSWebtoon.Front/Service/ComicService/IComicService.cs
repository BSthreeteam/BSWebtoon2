using BSWebtoon.Front.Models.DTO.WorkPage;
using System.Collections.Generic;

namespace BSWebtoon.Front.Service.ComicService
{
    public interface IComicService
    {
        void ComicTagCreate();
        void ComicCreate();
        void ComicTagListCreate();
        void ComicTagListUpdate();
        void EpCreate();
        void EpContentCreate();
        //void EpUpdate();

        WorkPageDTO WorkPageRead(int comicId,string userName);
        void CreateClickRecord(int comicId, int memberId);
        public List<WorkContentDTO> ReadworkContent(int ComicId, string useerName);

    }
}
