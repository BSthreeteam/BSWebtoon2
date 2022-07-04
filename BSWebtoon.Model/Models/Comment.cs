using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class Comment
    {
        public Comment()
        {
            CommentLikeRecords = new HashSet<CommentLikeRecord>();
            InverseReplyToComment = new HashSet<Comment>();
            Reports = new HashSet<Report>();
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
        public virtual ICollection<CommentLikeRecord> CommentLikeRecords { get; set; }
        public virtual ICollection<Comment> InverseReplyToComment { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
