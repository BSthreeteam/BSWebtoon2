using BSWebtoon.Admin.IDapperRepository;
using BSWebtoon.Model;
using Coravel.Invocable;
using System;
using System.Threading.Tasks;

namespace BSWebtoon.Admin.Service.JobService
{
    public class NewWorkToSerialize : IInvocable
    {
        private readonly IDapperUpdateComicStatusRepository _dapperUpdateComicStatusRepository;

        public NewWorkToSerialize(IDapperUpdateComicStatusRepository dapperUpdateComicStatusRepository)
        {
            _dapperUpdateComicStatusRepository = dapperUpdateComicStatusRepository;
        }

        public async Task Invoke()
        {
            //新作 => 連載
            //上架時間加上兩個禮拜小於現在時間
            var comics = _dapperUpdateComicStatusRepository.SelectAll();

            foreach (var comic in comics)
            {
                if(comic.ComicStatus == (int)ComicState.newWork && comic.AuditType == (int)AuditType.auditPass && comic.PublishDate.AddDays(14) < DateTime.UtcNow)
                {
                    comic.ComicStatus = (int)ComicState.serialize;
                    _dapperUpdateComicStatusRepository.Update(comic);
                }
            }
            await Task.CompletedTask;
        }
    }
}
