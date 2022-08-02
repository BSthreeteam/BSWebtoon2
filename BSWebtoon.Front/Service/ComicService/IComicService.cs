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

        WorkPageDTO WorkPageRead(int comicId, int memberId);
        void CreateClickRecord(int comicId, int memberId);
        public List<WorkContentDTO> ReadworkContent(int ComicId, string useerName);

        public List<CommentDTO> GetComment(int EpId);
        public void CreateComment(CommentDTO comment);

    }
}
