using System.Collections.Generic;

namespace BSWebtoon.Front.Models.DTO.Rank
{
    public class CategoryTagRank
    {
        public string CategoryTagName { get; set; }
        public List<AllTagRankDTO> CategoryRankList  {get;set;} 
    }
}
