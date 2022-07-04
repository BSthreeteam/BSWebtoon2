using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BSWebtoon.Front.Service.ComicService
{
    public class ComicService : IComicService
    {
        private readonly BSWebtoonContext _context;
        private readonly BSRepository _repository;

        public ComicService(BSWebtoonContext context, BSRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        public void ComicTagCreate()
        {
            List<ComicTag> comictags = new List<ComicTag>
            {
                new ComicTag {TagName="愛情"    ,IsMainTag=true ,IsDelete=false,AuditEmployeeId=1,AuditDate=new DateTime(2021,6,21)},
                new ComicTag {TagName="奇幻愛情",IsMainTag=false,IsDelete=false,AuditEmployeeId=2,AuditDate=new DateTime(2021,6,22)},

                new ComicTag {TagName="動作冒險",IsMainTag=true ,IsDelete=false,AuditEmployeeId=1,AuditDate=new DateTime(2021,6,23)},
                new ComicTag {TagName="劇情"    ,IsMainTag=true ,IsDelete=false,AuditEmployeeId=1,AuditDate=new DateTime(2021,6,23)},

                new ComicTag {TagName="BL/GL"  ,IsMainTag=true ,IsDelete=false,AuditEmployeeId=2,AuditDate=new DateTime(2021,6,24)},
                new ComicTag {TagName="懸疑恐怖",IsMainTag=false,IsDelete=false,AuditEmployeeId=2,AuditDate=new DateTime(2021,6,24)},

            };
            foreach (var tags in comictags)
            {
                _repository.Create(tags);
            }
            _repository.SaveChange();
        }
        public void ComicCreate()
        {
            List<Comic> comics = new List<Comic>
            {
                new Comic {ComicChineseName="綠蔭之冠",ComicEnglishName="Recording Hall"
                           ,ComicNameImage="https://tw-a.kakaopagecdn.com/P/C/83/t2/2x/ccced92c-9b74-41be-9a7f-09065168657c.webp"
                           ,BgCover       ="https://tw-a.kakaopagecdn.com/P/C/83/bg/1x/bfd6d1d2-da14-4310-9c40-b8cdb1365acd.jpg"
                           ,ComicFigure   ="https://tw-a.kakaopagecdn.com/P/C/83/c2/2x/4d40f5b3-3f03-4dc2-bedb-c40962905027.png"
                           ,BgColor       ="#6789b4",PublishDate=new DateTime(2021,6,30),LastPublishDate=new DateTime(2022,4,26),UpdateWeek=3
                           ,Publisher     ="DAON STUDIO",Painter="binu",Author="Siya"
                           ,Introduction  ="因為穿越進自己寫的小說，我成了欺負男主角的繼姐!別擔心，我一定會讓你變得幸福。因為這本小說的作者就是我!「我從來都沒把姐姐當成是我的家人。」雖然我覺得自己很認真在實踐讓男主角幸福的計畫，但為什麼他沒把我當成家人看呢?在他成為公爵前，我真的能順利活下來嗎?"
                           ,ComicVideoWeb ="https://tw-a.kakaopagecdn.com/P/C/83/ip1/e8a88d55-959c-47cd-8471-2bca2840f078.webm"
                           ,ComicVideoMp4 ="https://tw-a.kakaopagecdn.com/P/C/83/ip2/78e58ee7-b469-4f46-8a74-7b4ed5489390.mp4"
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},

                new Comic {ComicChineseName="Lady Baby",ComicEnglishName="Lady Baby"
                           ,ComicNameImage ="https://tw-a.kakaopagecdn.com/P/C/205/t2/2x/8848e3ef-a605-412f-9d37-d544e22af515.png"
                           ,BgCover        ="https://tw-a.kakaopagecdn.com/P/C/205/bg/2x/8b7650b5-9a50-466b-ae3d-3924bafffae1.jpg"
                           ,ComicFigure    ="https://tw-a.kakaopagecdn.com/P/C/205/c1/2x/8d946661-f169-4029-8b92-ea9149a25585.webp"
                           ,BgColor        ="#445023",PublishDate=new DateTime(2022,2,28),LastPublishDate=new DateTime(2022,6,28)
                           ,UpdateWeek     =3,Publisher="CHOCO MEDIA",Painter="Pinkmint",Author="HÆON"
                           ,Introduction   ="家人一個個不斷喪命，戰爭又隨之而來，就連卡莉歐佩最終也難逃一死。但是——「哇啊!」哇...啊?!嬰兒哭聲?卡莉歐佩竟然回到了剛出生的時候?!為了不再重演前世的悲劇，卡莉歐佩努力鍛鍊自己的小肌肉，並違背了物理法則(重力)，學會翻身，還因為要培養溝通能力，認真地咿呀學語(ㄅㄆㄇㄈ)。在忙著長大的過程中，為了和家人共度幸福的每一天，她也毫不保留地表現出自己的感情...可是怎麼好像家人更愛她...?卡莉歐佩光是呼吸都被家人覺得可愛，大家疼愛她的模樣既讓她感到負擔，卻又同時幸福。而隨著她的變化，開始有人接近她...未來正在改變。但浮上檯面的陰謀也越來越大...究竟卡莉佩歐能否揭露害家人慘死的陰謀真相，順利改變未來呢?"
                           ,AuditType      =1,AuditEmployeeId=2,AuditTime=new DateTime(2021,2,26),ComicStatus=3},

                 new Comic {ComicChineseName="骨灰級菜鳥玩家",ComicEnglishName="Worn And Torn Newbie"
                           ,ComicNameImage ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608141/WornAndTornNewbie/5.png"
                           ,BgCover        ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656573183/WornAndTornNewbie/4.webp"
                           ,ComicFigure    ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656573080/WornAndTornNewbie/1.webp"
                           ,BgColor        ="#95896f",PublishDate=new DateTime(2022,3,2),LastPublishDate=new DateTime(2022,6,26)
                           ,UpdateWeek     =3,Publisher="REDICE STUDIO",Painter="BONIEE",Author="Step on a LEGO"
                           ,Introduction   ="這款遊戲將在15年後終止服務，只有我知道遊戲的結局。 「我是骨灰級玩家。」"
                           ,AuditType      =1,AuditEmployeeId=2,AuditTime=new DateTime(2021,3,1),ComicStatus=3},

            };
            foreach (var c in comics)
            {
                _repository.Create(c);
            }
            _repository.SaveChange();
            //var employees = new Employee() {EmployeeId=2 ,EmployeeName = "Kei", HireDate = new DateTime(2022, 6, 27), Account = "lkk975036543@hmail.com", Password = "098765432zxcvbn" };
            //_repository.Delete(employees);
        }

        public void ComicTagListCreate()
        {
            List<ComicTagList> comictaglists = new List<ComicTagList>
            {
                new ComicTagList {TagId=1,ComicId=1},
                new ComicTagList {TagId=2,ComicId=2}
            };
            foreach (var list in comictaglists)
            {
                _repository.Create(list);
            }
            _repository.SaveChange();

        }

        public void ComicTagListUpdate()
        {
            var updateTagList = _repository.GetAll<ComicTagList>().Where(x => x.TageListId == 2).FirstOrDefault();
            updateTagList.ComicId = 2;
            _repository.Update(updateTagList);
            _repository.SaveChange();

        }

        public void EpCreate()
        {
            var epList = new List<Episode>
            {
                new Episode(){ ComicId = 1, EpTitle = "第1話", EpCover = "http", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2022,05,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,05,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 1, EpTitle = "第2話", EpCover = "http", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2022,05,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,05,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 2, EpTitle = "第1話", EpCover = "http", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2022,05,02),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 2, EpTitle = "第2話", EpCover = "http", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2022,05,02),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,05,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
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
                new EpContent(){ EpId=2, ImagePath="http", Page=1},
                new EpContent(){ EpId=2, ImagePath="http", Page=2},
                new EpContent(){ EpId=3, ImagePath="http", Page=1},
                new EpContent(){ EpId=3, ImagePath="http", Page=2},
                new EpContent(){ EpId=4, ImagePath="http", Page=1},
                new EpContent(){ EpId=4, ImagePath="http", Page=2},
            };
            foreach (var epContent in epContentList)
            {
                _repository.Create(epContent);
            }
            _repository.SaveChange();
        }



    }
}
