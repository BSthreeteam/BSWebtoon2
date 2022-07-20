using System;
using System.Collections.Generic;

#nullable disable

namespace BSWebtoon.Front.Models
{
    public partial class CommentLikeRecord
    {
        public int CommentLikesId { get; set; }
        public int MemberId { get; set; }
        public int CommentId { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsLike { get; set; }

        public virtual Comment Comment { get; set; }
        public virtual Member Member { get; set; }
    }
}
