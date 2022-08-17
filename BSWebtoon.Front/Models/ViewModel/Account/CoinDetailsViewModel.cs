using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BSWebtoon.Front.Models.ViewModel.Account
{
    public class CoinDetailsViewModel
    {
        public List<CoinDetail> coinDetailList { get; set; }
        public int activePage { get; set; }
        public int pages { get; set; }
        public class CoinDetail
        {
            public string ConsumptionOrRecharge { get; set; }
            public string CoinContent { get; set; }
            public string CreateTime { get; set; }
            public string ComicName { get; set; }
        }
    }
}
