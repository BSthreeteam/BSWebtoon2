﻿using System;
using System.Collections.Generic;

namespace BSWebtoon.Front.Models.ViewModels.Rank
{
    public class RankViewModel_ClickRecord
    {
       public ClickRecordRank FirstRank { get; set; } 
        public List<ClickRecordRank> OtherRank { get; set; } 
        
        public class ClickRecordRank
        {
            public int ClickRecordId { get; set; }
            public int ClickRecordCount { get; set; }
            public int ComicId { get; set; }
            public string ComicName { get; set; }
            public string ComicNameImage { get; set; }
            public string ComicWeekFigure { get; set; }
            public string ComicFigure { get; set; }
            public string BgCover { get; set; }
            public string BgColor { get; set; }
            public string Introduction { get; set; }
            public string BannerVideoWeb { get; set; }
            public string TagName { get; set; }
            public int TagId { get; set; }
            public int Diff { get; set; }
        }
    }
}
