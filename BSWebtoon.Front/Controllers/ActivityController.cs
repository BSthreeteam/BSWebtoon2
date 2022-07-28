using BSWebtoon.Front.Models.ViewModel.GiftBox;
using BSWebtoon.Front.Service.ActivityService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public IActionResult ActivityContent()
        {
            return View();
        }
    }
}
