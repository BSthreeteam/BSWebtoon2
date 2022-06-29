using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;

namespace BSWebtoon.Front.Service.ComicService
{
    public class ComicService:IComicService
    {
        private readonly BSWeBtoonContext _context;
        private readonly BSRepository _repository;

        public ComicService(BSWeBtoonContext context, BSRepository repository)
        {
            _context = context;
            _repository = repository;
        } 
    }
}
