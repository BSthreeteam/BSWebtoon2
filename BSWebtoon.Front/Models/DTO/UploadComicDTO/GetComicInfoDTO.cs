using System.Collections.Generic;

namespace BSWebtoon.Front.Models.DTO.UploadComicDTO
{
    public class GetComicInfoInputDTO
    {
        public int MemberId { get; set; }
    }
    public class GetComicInfoOutputDTO:BaseOutputDTO
    {

        public List<ComicWithEpCount> MyComics_WithEpCount{ get; set; }

        public class ComicWithEpCount
        {
            public int ComicId { get; set; }
            public string ComicChineseName { get; set; }


            public int EpCount { get; set; }
            public string EpName { get; set; }
        }
    }
}
