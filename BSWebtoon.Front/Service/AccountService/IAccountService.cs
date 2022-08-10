using BSWebtoon.Front.Models.DTO.Account;

namespace BSWebtoon.Front.Service.AccountService
{
    public interface IAccountService
    {
        AccountInfoDTO GetAccountInfo(int memberId);
        CoinDetailsDTO GetCoinDetails(int memberId);
        CouponDetailsDTO GetCouponDetails(int memberId);
    }
}
