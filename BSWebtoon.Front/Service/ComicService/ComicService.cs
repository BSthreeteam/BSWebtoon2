using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System;
using System.Collections.Generic;

namespace BSWebtoon.Front.Service.ComicService
{
    public class ComicService : IComicService
    {
        private readonly BSWeBtoonContext _context;
        private readonly BSRepository _repository;

        public ComicService(BSWeBtoonContext context, BSRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        public void EpCreate()
        {
            var epList = new List<Episode>
            {
                new Episode(){ ComicId = 1, EpTitle = "第1話", EpCover = "http", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2022,05,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,05,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 1, EpTitle = "第2話", EpCover = "http", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2022,05,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,05,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                //new Episode(){ ComicId = 1, EpTitle = "第3話", EpCover = "http", UpdateTime=new DateTime(2022,05,06),UploadTime=new DateTime(2022,05,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,05,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                //new Episode(){ ComicId = 1, EpTitle = "第4話", EpCover = "http", UpdateTime=new DateTime(2022,05,06),UploadTime=new DateTime(2022,05,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,05,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                //new Episode(){ ComicId = 1, EpTitle = "第5話", EpCover = "http", UpdateTime=new DateTime(2022,05,07),UploadTime=new DateTime(2022,05,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,05,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                //new Episode(){ ComicId = 1, EpTitle = "第6話", EpCover = "http", UpdateTime=new DateTime(2022,05,07),UploadTime=new DateTime(2022,05,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,05,02),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                //new Episode(){ ComicId = 1, EpTitle = "第7話", EpCover = "http", UpdateTime=new DateTime(2022,05,08),UploadTime=new DateTime(2022,05,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,05,02),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                //new Episode(){ ComicId = 1, EpTitle = "第8話", EpCover = "http", UpdateTime=new DateTime(2022,05,08),UploadTime=new DateTime(2022,05,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,05,02),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                //new Episode(){ ComicId = 1, EpTitle = "第9話", EpCover = "http", UpdateTime=new DateTime(2022,05,09),UploadTime=new DateTime(2022,05,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,05,02),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                //new Episode(){ ComicId = 1, EpTitle = "第10話", EpCover = "http", UpdateTime=new DateTime(2022,05,09),UploadTime=new DateTime(2022,05,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,05,02),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
            };
            foreach (var episode in epList)
            {
                _repository.Create(episode);
            }
            _repository.SaveChange();
        }

        public void EpContentCreate()
        {
            var epContentList = new List<EpContent>
            {
                new EpContent(){ EpId=1, ImagePath="http", Page=1},
                new EpContent(){ EpId=1, ImagePath="http", Page=2},
            };
            foreach(var epContent in epContentList)
            {
                _repository.Create(epContent);
            }
            _repository.SaveChange();
        }
    }
}
