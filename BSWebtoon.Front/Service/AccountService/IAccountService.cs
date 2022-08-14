using BSWebtoon.Front.Models.DTO.Account;

namespace BSWebtoon.Front.Service.AccountService
{
    public interface IAccountService
    {
        AccountInfoDTO GetAccountInfo();
        CoinDetailsDTO GetCoinDetails();
        CouponDetailsDTO GetCouponDetails();
    }
}
