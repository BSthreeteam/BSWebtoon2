using System;

namespace BSWebtoon.Front.Models.DTO.WorkPage
{
    public class CommentDTO
    {
        public int CommentId { get; set; }
        public string MemberName { get; set; }
        public int EpId { get; set; }
        public int? ReplyToCommentId { get; set; }
        public bool IsSpoiler { get; set; }
        public DateTime CreateTime { get; set; }
        public string Context { get; set; }
    }
}
