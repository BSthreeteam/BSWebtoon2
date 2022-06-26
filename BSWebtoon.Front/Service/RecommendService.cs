using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BSWebtoon.Front.Service
{
    public class RecommendService
    {
        private readonly BSWeBtoonContext _context;
        private readonly BSRepository _repository;
        public RecommendService(BSWeBtoonContext context, BSRepository repository)
        {
            _context = context;
            _repository = repository;
        }
        //public async Task<List<Comic>> ComicRecommend()
        //{
        //    var query=from comic in await _context.Comics.ToListAsync()
        //              group comic by comic.C
        //}
    }
}
