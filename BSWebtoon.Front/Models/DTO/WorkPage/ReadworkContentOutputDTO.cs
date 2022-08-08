using System.Collections.Generic;

namespace BSWebtoon.Front.Models.DTO.WorkPage
{

    public class ReadworkContentOutputDTO : BaseOutputDTO
    {
        public int ComicId { get; set; }
        public List<WorkContent> WorkContents { get; set; }

        public List<WorkContentEpData> EpList { get; set; }


    }

    public class WorkContent
    {
        public int ComicId { get; set; }
        public int EpContentId { get; set; }
        public string EpTitle { get; set; }

        public int EpId { get; set; }
        public string ImagePath { get; set; }
        public int Page { get; set; }

    }

    public class WorkContentEpData
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
