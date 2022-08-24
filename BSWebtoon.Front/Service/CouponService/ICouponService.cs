using BSWebtoon.Front.Models.DTO.GiftBox;

namespace BSWebtoon.Front.Service.CouponService
{
    public interface ICouponService
    {
        void CouponCreate();
        void CouponUsedRecordCreate();
        void GetUniversalCoupon(GetActivityCouponDTO universalCoupon);
        void NewMemberGetCountdownCoupon();
        void GetReadCoupon(GetReadCouponDTO readCoupon);
    }
}
