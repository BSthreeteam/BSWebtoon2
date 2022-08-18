namespace BSWebtoon.Front.Models.DTO.WorkPage
{
    public class BuyCouponDTO
    {
        public int ComicId { get; set; }
        public string ComicChineseName { get; set; }
        public int NotFreeEp { get; set; }
        public decimal MemberHaveCoin { get; set; }
        public int MemberHaveReadTicket { get; set; }
        public int MemberHaveUniversalCoupon { get; set; }
    }
}
