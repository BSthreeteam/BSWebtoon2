namespace BSWebtoon.Front.Models.DTO.Account
{
    public class AccountInfoDTO
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public decimal CoinQuantity { get; set; }
        public int UniversalCouponQuantity { get; set; }
        public int ReadCouponQuantity { get; set; }

    }
}
