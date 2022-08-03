namespace BSWebtoon.Front.Models.DTO.WorkPage
{
    public class BuyCouponDTO
    {
        public int ComicId { get; set; }
        public string ComicChineseName { get; set; }
        public int BuyInOneTimeQuantity { get; set; }
        public decimal MemberHaveCoin { get; set; }
        public int MemberHaveReadTicket { get; set; }
    }
}
