using System.Collections.Generic;
using BSWebtoon.Front.Models.DTO.ViewRecord;

namespace BSWebtoon.Front.Service.RecordViewService
{
    public interface IRecordViewService
    {
        List<ViewRecordDTO> ReadRecordView();
        void ReadRecordViewUpdate(RemoveRecordViewInputDTO input);

    }
}
