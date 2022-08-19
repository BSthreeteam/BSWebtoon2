using BSWebtoon.Front.Models.ViewModel.GiftBox;
using BSWebtoon.Front.Service.ActivityService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BSWebtoon.Front.Controllers
{
    public class ActivityController : Controller
    {
        private readonly IActivityService _activityService;

        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        public IActionResult GiftBox()
        {
            var giftBoxSource = _activityService.ReadGiftBox();

            var allGiftBox = new List<GiftBoxViewModel.GiftBoxItem>() { };

            foreach (var giftBox in giftBoxSource.GiftBoxItems)
            {
                allGiftBox.Add(new GiftBoxViewModel.GiftBoxItem
                {
                    ActivityId = giftBox.ActivityId,
                    ActivityName = giftBox.ActivityName,
                    ActivityBgColor = giftBox.ActivityBgColor,
                    ActivityImage = giftBox.ActivityImage
                });
            }

            var result = new GiftBoxViewModel() { GiftBoxItems = allGiftBox };

            return View(result);
        }
        public IActionResult ActivityContent(int Id)
        {
            var memberId = User.Claims.FirstOrDefault() == null ? 0 : int.Parse(User.Claims.FirstOrDefault(x => x.Type == "MemberID").Value);
            var activityContentSource = _activityService.ReadActivityContent(Id);

            var result = new ActivityContentViewModel()
            {
                IsAuthenticated = User.Identity.IsAuthenticated,
                ActivityId = activityContentSource.ActivityId,
                ActivityName = activityContentSource.ActivityName,
                ActivityImage = activityContentSource.ActivityImage,
                ActivityBgColor = activityContentSource.ActivityBgColor,
                ActivityContent = activityContentSource.ActivityContent,
                ActivityStartTime = activityContentSource.ActivityStartTime,
                ActivityEndTime = activityContentSource.ActivityEndTime,
                IsGetUniversalCoupon = activityContentSource.IsGetUniversalCoupon,
            };

            return View(result);
        }
    }
}
