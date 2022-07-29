using System.Collections.Generic;
using BSWebtoon.Front.Models.DTO.ViewRecord;

namespace BSWebtoon.Front.Service.RecordViewService
{
    public interface IRecordView
    {
        public List<ViewRecordDTO> ReadRecordView();
    }
}
