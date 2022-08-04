using System;

namespace BSWebtoon.Front.Models.DTO.GiftBox
{
    public class GetActivityCouponDTO
    {
        public int MemberId { get; set; }
        public int ActivityId { get; set; }
        public int CouponTypeId { get; set; }
        public int OriginQuantity { get; set; }
    }
}
