using System.Collections.Generic;

namespace BSWebtoon.Front.Models.DTO.Account
{
    public class CoinDetailsDTO
    {
        public List<CoinDetail> coinDetailList { get; set; }
        public class CoinDetail
        {
            public string ConsumptionOrRecharge { get; set; }
            public string CoinContent { get; set; }
            public string CreateTime { get; set; }
            public string ComicName { get; set; }

        }
    }
}
