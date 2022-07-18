using BSWebtoon.Front.Models.DTO.Comic;
using System.Collections.Generic;

namespace BSWebtoon.Front.Models.ViewModel.Search
{
    public class SearchViewModel
    {
        public List<Search> SearchList { get; set; }

        public class Search: ComicCardDto
        {  
            public string TagName { get; set; }
        }
    }
}
