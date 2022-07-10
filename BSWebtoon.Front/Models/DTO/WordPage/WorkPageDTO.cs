using System;
using System.Collections.Generic;

namespace BSWebtoon.Front.Models.DTO.WordPage
{
    public class WorkPageDTO
    {
        /// <summary>
        /// 作品頁
        /// </summary>
        public string ComicChineseName { get; set; } 
        public string ComicFigure { get; set; }
        public string BannerVideoWeb { get; set; }
        public string ComicVideoWeb { get; set; }
        public string BgCover { get; set; }
        public int AuditType { get; set; }  
        public int ReadTicket { get; set; }
        public bool Islike { get; set; }
        public string MainTagName { get; set; }
        public int ViewCount { get; set; }
        public IEnumerable<EpData> EpList { get; set; }


        /// <summary>
        /// 作品資訊頁
        /// </summary>
        public string TagList { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public string Painter { get; set; }
        public string Introduction { get; set; }


        /// <summary>
        /// 評論頁
        /// </summary>
        public int CommentId { get; set; }
        public int MemberId { get; set; }
        public int EpId { get; set; }
        public int? ReplyToCommentId { get; set; }
        public bool IsSpoiler { get; set; }
        public DateTime CreateTime { get; set; }
        public string Context { get; set; }
        public bool IsDelete { get; set; }
        public int  IsLikeCount { get; set; } //按讚數



        public class EpData
        {
            public int EpId { get; set; }
            public int ComicId { get; set; }
            public string EpTitle { get; set; }
            public string EpCover { get; set; }
            public DateTime UpdateTime { get; set; }
            public int AuditType { get; set; }
            public bool IsCountdownCoupon { get; set; }
            public bool IsFree { get; set; }
        }
    }
}
