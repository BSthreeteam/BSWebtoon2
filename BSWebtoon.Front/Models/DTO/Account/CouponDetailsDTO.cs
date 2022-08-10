using System.Collections.Generic;

namespace BSWebtoon.Front.Models.DTO.Account
{
    public class CouponDetailsDTO
    {
        public List<CouponDetail> CouponDetailList { get; set; }
        public class CouponDetail
        {
            public string BuyOrUse { get; set; }
            public string CouponType { get; set; }
            public string BuyOrUseCount { get; set; }
            //public string CouponCount { get; set; }
            public string CreateTime { get; set; }
            public string ComicName { get; set; }
            public string ActivityName { get; set; }
        }
    }
}
