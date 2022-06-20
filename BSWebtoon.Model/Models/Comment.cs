using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Model.Models
{
    public partial class Comment
    {
        public Comment()
        {
            InverseReplyToComment = new HashSet<Comment>();
            Reports = new HashSet<Report>();
        }

        public int CommentId { get; set; }
        public int MemberId { get; set; }
        public int EpId { get; set; }
        public int ComicId { get; set; }
        public int ReplyToCommentId { get; set; }
        public int? LikeCount { get; set; }
        public string Spoiler { get; set; }
        public DateTime CommentTime { get; set; }
        public string CommentContext { get; set; }

        public virtual Comic Comic { get; set; }
        public virtual Epsiode Ep { get; set; }
        public virtual Comment ReplyToComment { get; set; }
        public virtual ICollection<Comment> InverseReplyToComment { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
