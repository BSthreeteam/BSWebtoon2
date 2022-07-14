using System.Collections.Generic;

namespace BSWebtoon.Front.Models.ViewModel.ViewRecord
{

    public class ViewRecordViewModel
    {
        public IEnumerable<ViewRecordData> ViewRecordList { get; set; }

        public class ViewRecordData
        {
            public string ComicNameImage { get; set; }
            public string ComicFigure { get; set; }
            public string BgColor { get; set; }
            public string EpTitle { get; set; }
        }
    }
}
