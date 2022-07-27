using System;

namespace BSWebtoon.Model
{
    public enum ComicState
    {
        finish = 1, 
        stopUpdate = 2, 
        serialize = 3,
        newWork =4
    }
    public enum CouponType
    {
        
        universalCoupon = 1,
        readCoupon = 2,
        countdownCoupon = 3,
    }
    public enum AuditType
    {
        
        auditPass =1,
        Unaudit = 2,
        auditFailure =3,
        auditProcessing =4,
    }
}
