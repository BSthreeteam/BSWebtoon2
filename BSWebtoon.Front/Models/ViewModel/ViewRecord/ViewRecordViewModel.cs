using System.Collections.Generic;
using BSWebtoon.Front.Models.DTO.Comic;

namespace BSWebtoon.Front.Models.ViewModel.ViewRecord
{

    public class ViewRecordViewModel
    {
        //public ViewRecordData ViewRecordList { get; set; }
        public List<ViewRecordData> ViewRecordListAll { get; set; }

        public class ViewRecordData : ComicCardDto
        {
            public int ViewRecorId { get; set; }
            public string EpTitle { get; set; }
        }
    }
}
