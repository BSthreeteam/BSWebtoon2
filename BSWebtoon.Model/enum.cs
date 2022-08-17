using System;

namespace BSWebtoon.Model
{
    public enum ComicState
    {
        finish = 1,//完結
        stopUpdate = 2, //停更
        serialize = 3,//連載中
        newWork =4//新作
    }
    public enum CouponType
    {
        
        universalCoupon = 1,//通用券
        readCoupon = 2,//閱讀券
        countdownCoupon = 3,//倒數免費券
    }
    public enum AuditType
    {
        
        auditPass =1,//審核通過
        Unaudit = 2,//未審核
        auditFailure =3,//審核失敗
        auditProcessing =4,//審核中
    }

    public enum Week
    {

        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
    }

}


