using BSWebtoon.Front.Models.DTO.Search;
using System.Collections.Generic;

namespace BSWebtoon.Front.Service.SearchService
{
    public interface ISearchService
    {
        List<SearchDTO> FindComic(string searchcomic);
    }
}
