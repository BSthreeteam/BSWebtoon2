using System;
using System.Collections.Generic;

namespace BSWebtoon.Front.Models.DTO.WorkPage
{

    public class CommentDTO
    {
        public CommentContxt MainComment { get; set; }
        public List<ReplyCommentContxt> ReplyMainComment { get; set; }







    }

    public class CommentContxt
    {
        public int CommentId { get; set; }
        public string MemberName { get; set; }
        public int EpId { get; set; }
        public bool IsSpoiler { get; set; }
        public DateTime CreateTime { get; set; }
        public string Context { get; set; }
    }

    public class ReplyCommentContxt: CommentContxt
    {
        public int? ReplyToCommentId { get; set; }

    }
}
