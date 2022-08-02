namespace BSWebtoon.Front.Models.ViewModel.GiftBox
{
    public class ActivityContentViewModel
    {
        public bool IsAuthenticated { get; set; }
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string ActivityImage { get; set; }
        public string ActivityBgColor { get; set; }
        public string ActivityStartTime { get; set; }
        public string ActivityEndTime { get; set; }
        public string ActivityContent { get; set; }
        public bool IsGetUniversalCoupon { get; set; }
    }
}
