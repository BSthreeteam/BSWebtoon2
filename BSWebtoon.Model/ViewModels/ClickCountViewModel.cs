using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSWebtoon.Model.ViewModels
{
    public class ClickCountViewModel
    {
        [Key]
        public int ComicId { get; set; }
        public int Count { get; set; }

    }
}
