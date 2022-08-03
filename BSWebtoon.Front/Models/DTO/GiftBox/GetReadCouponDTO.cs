using System;

namespace BSWebtoon.Front.Models.DTO.GiftBox
{
    public class GetReadCouponDTO
    {
        public int MemberId { get; set; }
        public int ComicId { get; set; }
        public int CouponTypeId { get; set; }
        public int OriginQuantity { get; set; }
        public DateTime CreateTime { get; set; }
        public int SpendCoin { get; set; }
    }
}
