﻿using BSWebtoon.Front.Models.DTO.WorkPage;
using BSWebtoon.Model.Models;
using System.Collections.Generic;
using System.Linq;

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

        WorkPageDTO WorkPageRead(int comicId);
        void CreateClickRecord(int comicId);
        public ReadworkContentOutputDTO ReadworkContent(int EpId);


        BuyCouponDTO ReadBuyCoupon(int comicId);
        public List<CommentDTO> GetComment(int EpId);
        public void CreateComment(CommentDTO comment);




    }
}
