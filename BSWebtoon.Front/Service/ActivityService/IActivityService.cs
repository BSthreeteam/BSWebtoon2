using BSWebtoon.Front.Models.DTO.GiftBox;

namespace BSWebtoon.Front.Service.ActivityService
{
    public interface IActivityService
    {
        GiftBoxDTO ReadGiftBox();
        ActivityContentDTO ReadActivityContent(int ActivityId, int MemberId);
    }
}
