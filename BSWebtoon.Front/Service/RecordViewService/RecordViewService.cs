using BSWebtoon.Front.Models.DTO.ViewRecord;
using System.Collections.Generic;
using Dapper;
using Microsoft.Data.SqlClient;


namespace BSWebtoon.Front.Service.RecordViewService
{
    public class RecordViewService : IRecordViewService
    {
        private static string _connectionStr = "Data Source=bswebtoon.database.windows.net;Initial Catalog=BSWebtoonDb;User ID=bs;Password=P@ssword;Encrypt=True;Trusted_Connection=False;MultipleActiveResultSets=true;";

        public List<ViewRecordDTO> ReadRecordView(int id)
        {
            var result = new List<ViewRecordDTO>();
            using (SqlConnection conn = new SqlConnection(_connectionStr))
            {
                //觀看紀錄:從資料庫撈出需要的資料
                string sql = @$"SELECT * FROM (SELECT ROW_NUMBER() OVER (PARTITION BY E.ComicId ORDER BY V.ViewTime desc) AS row_id,
                                V.MemberId, E.ComicId, V.ViewTime ,E.EpTitle,
                                C.BgCover,C.ComicNameImage, C.ComicWeekFigure,V.IsDelete
                                FROM ViewRecord V
                                INNER JOIN Episode E ON E.EpId = V.EpId 
                                INNER JOIN Comic C ON C.ComicId = E.ComicId 
                                WHERE  MemberId = {id} and V.IsDelete = 0
                                ) AS newDB  WHERE row_id = 1 ";

                //篩選出資料全部 的結果後放到ViewRecordDTO的表中
                var MemberReacordComics = conn.Query<ViewRecordDTO>(sql);

                //藉由ViewRecordDTO表中的資料 去做跌代
                foreach (var item in MemberReacordComics)
                {
                    result.Add(new ViewRecordDTO
                    {
                        ComicId = item.ComicId,
                        ViewRecorId = item.ViewRecorId,
                        BgCover = item.BgCover,
                        EpTitle = item.EpTitle,
                        ComicWeekFigure = item.ComicWeekFigure,
                        ComicNameImage = item.ComicNameImage,
                        EpContentId = item.EpContentId,
                        ComicChineseName = item.ComicChineseName,
                        ComicEnglishName = item.ComicEnglishName,
                        ViewTime = item.ViewTime,
                        IsDelete = item.IsDelete
                    });
                }
            }
            return result;
        }

        public void ReadRecordViewUpdate(RemoveRecordViewInputDTO input)
        {
            var MemberId = input.MemberId;
            var ComicIds = input.ComicIdsToDelete.ToArray();
            using (SqlConnection conn = new SqlConnection(_connectionStr))
            {
                foreach (var ComicId in ComicIds)
                {
                    string sql = @$"UPDATE ViewRecord
                                       SET IsDelete = 1
                                    where EpId in (
	                                    SELECT EpId
	                                    FROM Episode 
	                                    where ComicId = {ComicId}  )
                                    and MemberId = {MemberId}";
                    conn.Query(sql);
                }
            }
        }
    }
}