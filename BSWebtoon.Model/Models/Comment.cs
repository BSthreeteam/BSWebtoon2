using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class Comment
    {
        public Comment()
        {
            CommentLikeRecord = new HashSet<CommentLikeRecord>();
            InverseReplyToComment = new HashSet<Comment>();
            Report = new HashSet<Report>();
        }

        public int CommentId { get; set; }
        public int MemberId { get; set; }
        public int EpId { get; set; }
        public int? ReplyToCommentId { get; set; }
        public bool IsSpoiler { get; set; }
        public DateTime CreateTime { get; set; }
        public string Context { get; set; }
        public bool IsDelete { get; set; }

        public virtual Episode Ep { get; set; }
        public virtual Member Member { get; set; }
        public virtual Comment ReplyToComment { get; set; }
        public virtual ICollection<CommentLikeRecord> CommentLikeRecord { get; set; }
        public virtual ICollection<Comment> InverseReplyToComment { get; set; }
        public virtual ICollection<Report> Report { get; set; }
    }
}
