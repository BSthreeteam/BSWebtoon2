using System.Collections.Generic;
using System.Linq;
using BSWebtoon.Front.Models.DTO.ViewRecord;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using Dapper; //T-SQL
using Microsoft.Data.SqlClient;

namespace BSWebtoon.Front.Service.RecordViewService
{
    public class RecordView : IRecordView
    {
        private readonly BSRepository _repository;
        private static string _connectionStr = "Server=(localdb)\\mssqllocaldb;Database=BS;Trusted_Connection=True;MultipleActiveResultSets=true";

        //public List<ViewRecordDTO> ReadRecordView()
        //{
        //    throw new System.NotImplementedException();
        //}


        public List<ViewRecordDTO> ReadRecordView(int id)
        {

            var result = new List<ViewRecordDTO>();

            using (SqlConnection conn = new SqlConnection(_connectionStr))
            {
                //選出
                //看過漫畫的背景圖片、人物圖、名稱圖片
                string sql = @$"SELECT V.*,E.EpTitle,E.ComicId,C.ComicWeekFigure,C.ComicNameImage,C.BgCover
                             FROM ViewRecord V
                             INNER JOIN Episode E ON E.EpId = V.EpId 
                             INNER JOIN Comic C on C.ComicId = E.ComicId where V.MemberId = {id} ";
            
            }
                throw new System.NotImplementedException();
        }

        public List<ViewRecordDTO> ReadRecordView()
        {
            throw new System.NotImplementedException();
        }
    }
}