using System.Collections.Generic;

namespace BSWebtoon.Front.Service.ComicService
{
    public interface IComicService
    {
        void ComicTagCreate();
        void ComicCreate();
        void ComicTagListCreate();
        //void ComicTagListUpdate();
        void EpCreate();
        void EpContentCreate();
        //void EpUpdate();
    }
}
