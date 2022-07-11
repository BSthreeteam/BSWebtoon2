using System;
using System.Collections.Generic;
namespace BSWebtoon.Front.Models.DTO.WorkPage
{
    public class WorkPageDTO
    {
        //漫畫資訊
        public int ComicId { get; set; }
        public string ComicChineseName { get; set; }
        public string ComicFigure { get; set; }
        public string BgCover { get; set; }
        public string BgColor { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public int ComicStatus { get; set; }
        //閱讀券
        public int CouponCount { get; set; }
        //主標籤
        public string MainTag { get; set; }
        //觀看數
        public int ViewCount { get; set; }
        //按讚數
        public int LikeCount { get; set; }
        //集數
        public IEnumerable<EpData> EpList { get; set; }
        public class EpData
        {
            public int EpId { get; set; }
            public string EpTitle { get; set; }
            public string EpCover { get; set; }
            public DateTime UploadTime { get; set; }
            public int AuditTypeId { get; set; }
            public bool IsCountdownCoupon { get; set; }
            public bool IsFree { get; set; }

        }
        //留言
        public IEnumerable<CommentData> CommentList { get; set; }

        public class CommentData
        {
            public int MemberId { get; set; }
            public int? ReplyToCommentId { get; set; }
            public string Context { get; set; }
            public DateTime CreateTime { get; set; }
            public bool IsSpoiler { get; set; }
            public bool IsDelete { get; set; }

        }
    }
}
