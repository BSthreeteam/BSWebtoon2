namespace BSWebtoon.Front.Models.ViewModel.Account
{
    public class AccountInfoViewModel
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public decimal CoinQuantity { get; set; }
        public int UniversalCouponQuantity { get; set; }
        public int ReadCouponQuantity { get; set; }

    }
}
