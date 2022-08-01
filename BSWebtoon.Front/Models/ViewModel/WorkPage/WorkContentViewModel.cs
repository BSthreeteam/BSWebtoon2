using System.Collections.Generic;

namespace BSWebtoon.Front.Models.ViewModel.WorkPage
{

    public class WorkContentViewModel
    {

        public string EpTitle { get; set; }
        public List<Content> ContentList { get; set; }


        public class Content
        {

            public string ImagePath { get; set; }
            public int Page { get; set; }

        }
    }
}
