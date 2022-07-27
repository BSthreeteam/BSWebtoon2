using System;

namespace BSWebtoon.Model
{
    public enum ComicState
    {
        完結 = 1,
        停更 = 2,
        連載中 = 3,
        新作 = 4
    }
    public enum CouponType
    {
        通用券 = 1,
        閱讀券 = 2,
        倒數免費通用券 = 3,
    }
    public enum AuditType
    {
        審核未通過 = 1,
        未審核 = 2,
        審核失敗 = 3,
        審核中 = 4,
    }
}


