using BSWebtoon.Front.ViewModels;
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
                //第1~10部漫畫內頁
                new EpContent(){ EpContentId=1,  EpId=1,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=2,  EpId=1,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=3,  EpId=2,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=4,  EpId=2,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=5,  EpId=3,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=6,  EpId=3,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=7,  EpId=4,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=8,  EpId=4,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=9,  EpId=5,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=10, EpId=5,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=11, EpId=6,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=12, EpId=6,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=13, EpId=7,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=14, EpId=7,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=15, EpId=8,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=16, EpId=8,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=17, EpId=9,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=18, EpId=9,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=19, EpId=10, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=20, EpId=10, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                //第11~20部漫畫內頁
                new EpContent(){ EpContentId=21, EpId=11, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=22, EpId=11, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=23, EpId=12, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=24, EpId=12, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=25, EpId=13, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=26, EpId=13, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=27, EpId=14, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=28, EpId=14, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=29, EpId=15, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=30, EpId=15, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=31, EpId=16, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=32, EpId=16, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=33, EpId=17, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=34, EpId=17, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=35, EpId=18, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=36, EpId=18, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=37, EpId=19, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=38, EpId=19, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=39, EpId=20, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=40, EpId=20, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                //第21~30部漫畫內頁
                new EpContent(){ EpContentId=41,  EpId=21,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=42,  EpId=21,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=43,  EpId=22,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=44,  EpId=22,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=45,  EpId=23,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=46,  EpId=23,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=47,  EpId=24,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=48,  EpId=24,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=49,  EpId=25,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=50,  EpId=25,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=51,  EpId=26,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=52,  EpId=26,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=53,  EpId=27,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=54,  EpId=27,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=55,  EpId=28,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=56,  EpId=28,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=57,  EpId=29,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=58,  EpId=29,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=59,  EpId=30,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=60,  EpId=30,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                //第31~40部漫畫內頁
                new EpContent(){ EpContentId=61,  EpId=31,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=62,  EpId=31,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=63,  EpId=32,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=64,  EpId=32,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=65,  EpId=33,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=66,  EpId=33,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=67,  EpId=34,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=68,  EpId=34,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=69,  EpId=35,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=70,  EpId=35,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=71,  EpId=36,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=72,  EpId=36,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=73,  EpId=37,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=74,  EpId=37,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=75,  EpId=38,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=76,  EpId=38,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=77,  EpId=39,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=78,  EpId=39,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=79,  EpId=40,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=80,  EpId=40,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                //第41~50部漫畫內頁
                new EpContent(){ EpContentId=81,  EpId=41,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=82,  EpId=41,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=83,  EpId=42,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=84,  EpId=42,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=85,  EpId=43,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=86,  EpId=43,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=87,  EpId=44,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=88,  EpId=44,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=89,  EpId=45,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=90,  EpId=45,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=91,  EpId=46,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=92,  EpId=46,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=93,  EpId=47,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=94,  EpId=47,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=95,  EpId=48,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=96,  EpId=48,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=97,  EpId=49,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=98,  EpId=49,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=99,  EpId=50,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=100, EpId=50,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                //第51~60部漫畫內頁
                new EpContent(){ EpContentId=101,  EpId=51,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=102,  EpId=51,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=103,  EpId=52,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=104,  EpId=52,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=105,  EpId=53,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=106,  EpId=53,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=107,  EpId=54,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=108,  EpId=54,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=109,  EpId=55,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=110,  EpId=55,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=111,  EpId=56,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=112,  EpId=56,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=113,  EpId=57,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=114,  EpId=57,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=115,  EpId=58,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=116,  EpId=58,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=117,  EpId=59,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=118,  EpId=59,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=119,  EpId=60,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=120,  EpId=60,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                //第61~70部漫畫內頁
                new EpContent(){ EpContentId=121,  EpId=61,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=122,  EpId=61,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=123,  EpId=62,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=124,  EpId=62,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=125,  EpId=63,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=126,  EpId=63,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=127,  EpId=64,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=128,  EpId=64,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=129,  EpId=65,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=130,  EpId=65,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=131,  EpId=66,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=132,  EpId=66,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=133,  EpId=67,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=134,  EpId=67,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=135,  EpId=68,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=136,  EpId=68,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=137,  EpId=69,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=138,  EpId=69,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=139,  EpId=70,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=140,  EpId=70,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                //第71~80部漫畫內頁
                new EpContent(){ EpContentId=141,  EpId=71,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=142,  EpId=71,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=143,  EpId=72,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=144,  EpId=72,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=145,  EpId=73,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=146,  EpId=73,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=147,  EpId=74,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=148,  EpId=74,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=149,  EpId=75,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=150,  EpId=75,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=151,  EpId=76,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=152,  EpId=76,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=153,  EpId=77,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=154,  EpId=77,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=155,  EpId=78,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=156,  EpId=78,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=157,  EpId=79,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=158,  EpId=79,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=159,  EpId=80,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=160,  EpId=80,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                //第81~90部漫畫內頁
                new EpContent(){ EpContentId=161,  EpId=81,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=162,  EpId=81,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=163,  EpId=82,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=164,  EpId=82,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=165,  EpId=83,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=166,  EpId=83,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=167,  EpId=84,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=168,  EpId=84,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=169,  EpId=85,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=170,  EpId=85,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=171,  EpId=86,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=172,  EpId=86,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=173,  EpId=87,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=174,  EpId=87,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=175,  EpId=88,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=176,  EpId=88,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=177,  EpId=89,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=178,  EpId=89,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=179,  EpId=90,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=180,  EpId=90,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                //第91~100部漫畫內頁
                new EpContent(){ EpContentId=181,  EpId=91,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=182,  EpId=91,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=183,  EpId=92,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=184,  EpId=92,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=185,  EpId=93,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=186,  EpId=93,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=187,  EpId=94,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=188,  EpId=94,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=189,  EpId=95,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=190,  EpId=95,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=191,  EpId=96,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=192,  EpId=96,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=193,  EpId=97,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=194,  EpId=97,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=195,  EpId=98,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=196,  EpId=98,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=197,  EpId=99,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=198,  EpId=99,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=199,  EpId=100,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=200,  EpId=100,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                //第101~110部漫畫內頁
                new EpContent(){ EpContentId=201,  EpId=101,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=202,  EpId=101,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=203,  EpId=102,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=204,  EpId=102,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=205,  EpId=103,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=206,  EpId=103,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=207,  EpId=104,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=208,  EpId=104,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=209,  EpId=105,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=210,  EpId=105,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=211,  EpId=106,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=212,  EpId=106,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=213,  EpId=107,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=214,  EpId=107,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=215,  EpId=108,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=216,  EpId=108,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=217,  EpId=109,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=218,  EpId=109,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=219,  EpId=110,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=220,  EpId=110,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                //第111~120部漫畫內頁
                new EpContent(){ EpContentId=221,  EpId=111,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=222,  EpId=111,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=223,  EpId=112,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=224,  EpId=112,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=225,  EpId=113,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=226,  EpId=113,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=227,  EpId=114,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=228,  EpId=114,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=229,  EpId=115,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=230,  EpId=115,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=231,  EpId=116,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=232,  EpId=116,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=233,  EpId=117,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=234,  EpId=117,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=235,  EpId=118,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=236,  EpId=118,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=237,  EpId=119,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=238,  EpId=119,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=239,  EpId=120,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=240,  EpId=120,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                //第121~130部漫畫內頁
                new EpContent(){ EpContentId=241,  EpId=121,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=242,  EpId=121,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=243,  EpId=122,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=244,  EpId=122,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=245,  EpId=123,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=246,  EpId=123,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=247,  EpId=124,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=248,  EpId=124,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=249,  EpId=125,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=250,  EpId=125,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=251,  EpId=126,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=252,  EpId=126,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=253,  EpId=127,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=254,  EpId=127,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=255,  EpId=128,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=256,  EpId=128,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=257,  EpId=129,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=258,  EpId=129,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=259,  EpId=130,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=260,  EpId=130,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                //第131~140部漫畫內頁
                new EpContent(){ EpContentId=261,  EpId=131,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=262,  EpId=131,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=263,  EpId=132,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=264,  EpId=132,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=265,  EpId=133,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=266,  EpId=133,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=267,  EpId=134,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=268,  EpId=134,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=269,  EpId=135,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=270,  EpId=135,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=271,  EpId=136,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=272,  EpId=136,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=273,  EpId=137,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=274,  EpId=137,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=275,  EpId=138,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=276,  EpId=138,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=277,  EpId=139,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=278,  EpId=139,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=279,  EpId=140,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=280,  EpId=140,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                //第141~150部漫畫內頁
                new EpContent(){ EpContentId=281,  EpId=141,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=282,  EpId=141,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=283,  EpId=142,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=284,  EpId=142,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=285,  EpId=143,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=286,  EpId=143,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=287,  EpId=144,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=288,  EpId=144,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=289,  EpId=145,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=290,  EpId=145,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=291,  EpId=146,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=292,  EpId=146,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=293,  EpId=147,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=294,  EpId=147,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=295,  EpId=148,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=296,  EpId=148,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=297,  EpId=149,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=298,  EpId=149,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=299,  EpId=150,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=300,  EpId=150,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                //第151~159部漫畫內頁
                new EpContent(){ EpContentId=301,  EpId=151,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=302,  EpId=151,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=303,  EpId=152,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=304,  EpId=152,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=305,  EpId=153,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=306,  EpId=153,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=307,  EpId=154,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=308,  EpId=154,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=309,  EpId=155,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=310,  EpId=155,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=311,  EpId=156,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=312,  EpId=156,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=313,  EpId=157,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=314,  EpId=157,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=315,  EpId=158,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=316,  EpId=158,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                new EpContent(){ EpContentId=317,  EpId=159,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                new EpContent(){ EpContentId=318,  EpId=159,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ EpContentId=319,  EpId=160,  ImagePath="", Page=1},
                //new EpContent(){ EpContentId=320,  EpId=160,  ImagePath="", Page=2},
            };
            foreach (var epContent in epContentList)
            {
                _repository.Create(epContent);
            }
            _repository.SaveChange();
        }


        public WorkpageViewModel WordPageRead(int comicId)
        {
            var comicSource = _repository.GetAll<Comic>().First(x => x.ComicId == comicId);
            var tagListSource = _repository.GetAll<ComicTagList>().Where(x => x.ComicId == comicSource.ComicId).ToList();
            var mainTag = _repository.GetAll<ComicTag>().Where(x => tagListSource.Any(y => y.TagId == x.TagId)).First(x => x.IsMainTag);
            var couponSource = _repository.GetAll<Coupon>().First(x => x.CouponTypeId == 1 && x.MemberId == 1 && x.ComicId == comicId);
            var epSource = _repository.GetAll<Episode>().Where(x => x.ComicId == comicId).ToList();

            return new WorkpageViewModel
            {
                ComicChineseName = comicSource.ComicChineseName,
                ComicFigure = comicSource.ComicFigure,
                Tag = mainTag.TagName,
                BgCover = comicSource.BgCover,
                Publisher = comicSource.Publisher,
                Author = comicSource.Author,
                ReadTicket = couponSource.Quantity,
                EpList = epSource.Select(x => new WorkpageViewModel.EpData())
            };


            //return from comic in _repository.GetAll<Comic>()
            //       join tag in _repository.GetAll<ComicTagList>()
            //       on comic.ComicId equals tag.ComicId
            //       join tagList in _repository.GetAll<ComicTag>()
            //       on tag.TagId equals tagList.TagId
            //       join coupon in _repository.GetAll<Coupon>()
            //       on comic.ComicId equals coupon.ComicId
            //       join member in _repository.GetAll<Member>()
            //       on coupon.MemberId equals member.MemberId
            //       join ep in _repository.GetAll<Episode>()
            //       on comic.ComicId equals ep.ComicId
            //       where coupon.MemberId == 1 && coupon.CouponTypeId == 1
            //       where tagList.IsMainTag == true
            //       select new WorkpageViewModel
            //       {
            //           ComicChineseName = comic.ComicChineseName,
            //           ComicFigure = comic.ComicFigure,
            //           Tag = tagList.TagName,
            //           BgCover = comic.BgCover,
            //           Publisher = comic.Publisher,
            //           Author = comic.Author,
            //           ReadTicket = coupon.Quantity,
            //           EpCover = ep.EpCover

            //       };
            //foreach(var item in _repository.GetAll<Comic>())
            //{
            //    yield return new WorkpageViewModel()
            //    {
            //        ComicChineseName = item.ComicChineseName,
            //        ComicFigure = item.ComicFigure,
            //        BgCover = item.BgCover,
            //        Publisher = item.Publisher,
            //        Author = item.Author,

            //    };
            //}
        }
        public void EpUpdate()
        {
            var p1 = _repository.GetAll<Episode>().Where(x => x.EpId == 1).FirstOrDefault();
            p1.EpCover = "https://tw-a.kakaopagecdn.com/P/EO/46/14940/tn/2x/ad6f27c3-0d1b-4402-9d23-a25dfb4adddd.jpg";
            var p2 = _repository.GetAll<Episode>().Where(x => x.EpId == 2).FirstOrDefault();
            p2.EpCover = "https://tw-a.kakaopagecdn.com/P/EO/46/14826/tn/2x/bbc85024-ca09-4084-8213-c92c7ec0dd27.jpg";

            _repository.SaveChange();
        }
    }
}
