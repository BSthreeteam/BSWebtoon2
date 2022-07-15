using System;
using System.Collections.Generic;
namespace BSWebtoon.Front.Models.DTO.Rank
{
    public class AllTagRankDTO
    {
        public int ClickRecordId { get; set; }
        public int ComicId { get; set; }
        public string ComicName { get; set; }
        public string ComicNameImage { get; set; }
        public string ComicFigure { get; set; }
        public string ComicWeekFigure { get; set; }
        public string BgCover { get; set; }
        public string Introduction { get; set; }
        public string BannerVideoWeb { get; set; }
        public int AuditType { get; set; }
        public string TagName { get; set; }
        public int Diff { get; set; }

        //public IEnumerable<RankClickRecord> RankDiff { get; set; }
        //public class RankClickRecord
        //{
        //    public int ComicId { get; set; }
        //    //public DateTime CreateTime { get; set; }
        //    public string TagName { get; set; }
        //    public int Diff { get; set; }

        //}

    }
}
