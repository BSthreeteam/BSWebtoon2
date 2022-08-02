using System;
using System.Collections.Generic;

namespace BSWebtoon.Front.Models.DTO.Account
{
    public class CoinDetailsDTO
    {
        public List<CoinDetail> coinDetailList { get; set; }
        public class CoinDetail
        {
            public int RechargeRecordId { get; set; }
            public string ConsumptionOrRecharge { get; set; }
            public int CashPlanContent { get; set; }
            public DateTime CreateTime { get; set; }

        }
    }
}
