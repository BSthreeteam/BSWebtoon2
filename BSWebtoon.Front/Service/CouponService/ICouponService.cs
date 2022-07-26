namespace BSWebtoon.Front.Service.CouponService
{
    public interface ICouponService
    {
        void CouponCreate();
        void CouponUsedRecordCreate();
        void GetUniversalCoupon(string userName, int? comicId, int activityId, int couponTypeId, int getQuantity);
    }
}
