﻿using BSWebtoon.Model.Models;

namespace BSWebtoon.Admin.Models.DTO
{
    public class DashboardTopRankDTO : ClickRecord
    {
        public int TopNum { get; set; }
        public int ClickRecordCount { get; set; }
        public string ComicChineseName { get; set; }
    }
}
