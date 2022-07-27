﻿using BSWebtoon.Front.Models.DTO.GiftBox;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System.Linq;
using System;
using System.Collections.Generic;

namespace BSWebtoon.Front.Service.ActivityService
{
    public class ActivityService : IActivityService
    {
        private readonly BSRepository _repository;

        public ActivityService(BSRepository repository)
        {
            _repository = repository;
        }

        public GiftBoxDTO ReadGiftBox()
        {
            var giftBoxList = _repository.GetAll<Activity>().Where(a => a.IsDelete == false)
                .Where(a => a.ActivityStartTime < DateTime.UtcNow.AddHours(8) && a.ActivityEndTime > DateTime.UtcNow.AddHours(8));

            var allList = new List<GiftBoxDTO.GiftBoxItem>() { };

            var addGiftBoxList = giftBoxList.Select(a => new GiftBoxDTO.GiftBoxItem
            {
                ActivityId = a.ActivityId,
                ActivityName = a.ActivityName,
                ActivityBgColor = a.ActivityBgColor,
                ActivityImage = a.ActivityImage
            }).ToList();

            allList.AddRange(addGiftBoxList);

            return new GiftBoxDTO() { GiftBoxItems = allList};
        }
    }
}
