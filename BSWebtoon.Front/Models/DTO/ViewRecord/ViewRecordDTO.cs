﻿using System;
using BSWebtoon.Front.Models.DTO.Comic;

namespace BSWebtoon.Front.Models.DTO.ViewRecord
{
    public class ViewRecordDTO:ComicCardDto
    {
        public int MemberId { get; set; }
        public int ViewRecorId { get; set; }
        
        public int EpContentId { get; set; }
        public string ComicChineseName { get; set; }
        public string ComicEnglishName { get; set; }
        public string BgColor { get; set; }
        public string EpTitle { get; set; }
        public DateTime ViewTime { get; set; }
        public bool IsDelete { get; set; }

    }
}
