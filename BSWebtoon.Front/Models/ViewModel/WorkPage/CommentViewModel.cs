using System;

namespace BSWebtoon.Front.Models.ViewModel.WorkPage
{
    public class CommentViewModel
    {
        public int CommentId { get; set; }
        public int MemberId { get; set; }
        public int EpId { get; set; }
        public int? ReplyToCommentId { get; set; }
        public bool IsSpoiler { get; set; }
        public DateTime CreateTime { get; set; }
        public string Context { get; set; }
        public bool IsDelete { get; set; }

    }
}
