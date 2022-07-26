using System;
using System.Collections.Generic;

namespace BSWebtoon.Front.Models.ViewModel.WorkPage
{
    public class WorkPageViewModel
    {
        public int MemberId { get; set; }
        //作品頁
        public int ComicId { get; set; }
        public string ComicChineseName { get; set; }
        public string BgCover { get; set; }
        public string ComicFigure { get; set; }
        public string BgColor { get; set; }
        public string BannerVideoWeb { get; set; }
        public string ComicVideoWeb { get; set; }
        //public int AuditType { get; set; }
        /// <summary>
        /// 閱讀券數量
        /// </summary>
        public int ReadTicket { get; set; }
        /// <summary>
        /// 是否被收藏
        /// </summary>
        public bool IslikeComic { get; set; }
        /// <summary>
        /// 主標籤
        /// </summary>
        public string MainTagName { get; set; }
        public List<string> TagNames { get; set; }

        /// <summary>
        /// 觀看數
        /// </summary>
        public int ViewCount { get; set; }
        /// <summary>
        /// 按讚數
        /// </summary>
        public int ComicLikeCount { get; set; }
        /// <summary>
        /// 瀏覽紀錄
        /// </summary>
        public string ViewRecordEpTitle { get; set; }


        //作品頁&資訊頁 都需要
        public string Publisher { get; set; }
        public string Painter { get; set; }
        public string Author { get; set; }

        //資訊頁
        public int ComicStatus { get; set; }
        public int? UpdateWeek { get; set; }
        public string Introduction { get; set; }

        //話次
        public List<EpData> EpList { get; set; }
        public class EpData
        {
            public int EpId { get; set; }
            public int ComicId { get; set; }
            public string EpTitle { get; set; }
            public string EpCover { get; set; }
            public string UploadTime { get; set; }
            public bool IsCountdownCoupon { get; set; }
            public bool IsFree { get; set; }
        }

        //留言
        public List<CommentData> CommentList { get; set; }

        public class CommentData
        {
            public int CommentId { get; set; }
            public string CommentMemberName { get; set; }
            public int EpId { get; set; }
            public int ReplyToCommentCount { get; set; }
            public bool IsSpoiler { get; set; }
            public DateTime CreateTime { get; set; }
            public string Context { get; set; }
            public bool IsDelete { get; set; }
            public int CommentLikeCount { get; set; } //按讚數
            public int CommentReportCount { get; set; } //檢舉數
        }

    }
}
