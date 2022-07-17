using BSWebtoon.Front.Models.DTO.Comic;
//using BSWebtoon.Model.Models;
using System.Collections.Generic;

namespace BSWebtoon.Front.Models.DTO.Rank
{
    //從Comic、ComicTag、ComicTagList篩選出TagName 
    public class CategoryTagRankDTO:ComicCardDto
    { 
        public string TagName { get; set; }
    }

    //從Comic、ClickRecord 篩選出ComicId、ClickRecordCount 
    public class ClickRecordRsult
    {
        public int ComicId { get; set; }
        public int ClickRecordCount { get; set; }
    }

    //合併篩選出TagName 及ClickRecordCount的表
    public class Integrate : ComicCardDto
    {
        public string TagName { get; set; }
        public int ClickRecordCount { get; set; }


    }
    //最後輸出的DTO
    public class CategoryRankDTO : ComicCardDto
    {
        public string TagName { get; set; }
        public int ClickRecordId { get; set; }
        public int Diff { get; set; }
    }


}
