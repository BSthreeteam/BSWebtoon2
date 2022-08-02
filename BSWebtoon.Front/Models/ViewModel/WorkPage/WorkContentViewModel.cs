using System.Collections.Generic;

namespace BSWebtoon.Front.Models.ViewModel.WorkPage
{

    public class WorkContentViewModel
    {

        public string EpTitle { get; set; }
        public List<Content> ContentList { get; set; }
        public List<EpData> EpList { get; set; }


        public class Content
        {

            public string ImagePath { get; set; }
            public int Page { get; set; }

        }

        public class EpData
        {
            public int EpId { get; set; }
            public int ComicId { get; set; }
            public string EpTitle { get; set; }
            public string EpCover { get; set; }
            public string UploadTime { get; set; }
            public bool IsCountdownCoupon { get; set; }
            public bool IsFree { get; set; }

        }

    }
}
