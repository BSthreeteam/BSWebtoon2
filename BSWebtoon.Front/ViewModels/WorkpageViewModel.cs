using System;
using System.Collections.Generic;

namespace BSWebtoon.Front.ViewModels
{
    public class WorkpageViewModel
    {
        public string ComicChineseName { get; set; }
        public string ComicFigure { get; set; }
        public string BgCover { get; set; }
        public string Tag { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public int ReadTicket { get; set; }
        public IEnumerable<EpData> EpList { get; set; }

        public class EpData
        {
            public string EpTitle { get; set; }
            public string EpCover { get; set; }
            public DateTime UploadTime { get; set; }
        }
    }
}
