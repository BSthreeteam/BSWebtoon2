using BSWebtoon.Front.Models.DTO.ViewRecord;
using BSWebtoon.Model.Models;
using System.Collections.Generic;
using System.Linq;
using BSWebtoon.Model.Repository;
using Dapper; //T-SQL
using Microsoft.Data.SqlClient;



namespace BSWebtoon.Front.Service.RecordViewService
{
    public class RecordViewService : IRecordViewService
    {
        private readonly BSRepository _repository;
        private static string _connectionStr = "Data Source=bswebtoon.database.windows.net;Initial Catalog=BSWebtoonDb;User ID=bs;Password=P@ssword;Encrypt=True;Trusted_Connection=False;MultipleActiveResultSets=true;";

        public List<ViewRecordDTO> ReadRecordView() /* int id  where V.MemberId = {id}*/
        {
            var result = new List<ViewRecordDTO>();
            using (SqlConnection conn = new SqlConnection(_connectionStr))
            {
                //看過漫畫的背景圖片、人物圖、名稱圖片
                string sql = @$"SELECT V.*,E.EpTitle,E.ComicId,C.ComicWeekFigure,C.ComicNameImage,C.BgCover
                             FROM ViewRecord V
                             INNER JOIN Episode E ON E.EpId = V.EpId 
                             INNER JOIN Comic C on C.ComicId = E.ComicId ";

                //篩選出資料全部 的結果後放到ViewRecordDTO的表中
                var MemberReacordComics = conn.Query<ViewRecordDTO>(sql);

                //var AllViewRecordList = new List<AllViewRecordDTO>();
                //藉由ViewRecordDTO表中的TagName,comic資料 去做跌代
                foreach (var item in MemberReacordComics)
                {
                    result.Add(new ViewRecordDTO
                    {
                        ComicId = item.ComicId,
                        ViewRecorId = item.ViewRecorId,
                        BgCover = item.BgColor,
                        EpTitle = item.EpTitle,
                        ComicFigure = item.ComicFigure,
                        ComicNameImage = item.ComicNameImage,
                        EpContentId = item.EpContentId,
                        //gp add
                        ComicChineseName = item.ComicChineseName,
                        ComicEnglishName = item.ComicEnglishName,
                        ViewTime = item.ViewTime,
                        IsDelete = item.IsDelete
                    });
                }
            }
            return result;
        }

        //public List<ViewRecordDTO> ReadRecordView()
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}