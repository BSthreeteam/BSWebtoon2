using BSWebtoon.Front.Models.DTO.Comic;
using System;
using System.Collections.Generic;
namespace BSWebtoon.Front.Models.DTO.Rank
{
    public class AllTagRankDTO : ComicCardDto
    {
        public int ClickRecordId { get; set; }
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
