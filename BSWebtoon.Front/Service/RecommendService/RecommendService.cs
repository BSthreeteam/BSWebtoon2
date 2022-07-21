//using BSWebtoon.Model.ViewModels;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BSWebtoon.Front.Service.RecommendService;
using BSWebtoon.Front.Models.DTO.Rcommend;

namespace BSWebtoon.Front.Service.RecommendService
{
    public class RecommendService : IRecommendService
    {
        private readonly BSWebtoonContext _context;
        private readonly BSRepository _repository;
        public RecommendService(BSWebtoonContext context, BSRepository repository)
        {
            _context = context;
            _repository = repository;
            //ActivityCreate();
        }
        public void ActivityCreate()
        {
            var activityList = new List<Activity> {
                new Activity { ActivityName = "端午佳節",ActivityStartTime=new DateTime(2022,06,03),ActivityEndTime=new DateTime(2022,09,20),ActivityImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657047931/ActivityIMG/AT02.png",ActivityBgColor="#517664",ActivityContent="<h2>禮輕情意粽</h2><br><p>端午節放假!<br>看本漫畫放鬆自己吧!</p>",PrincipalEmployee=19,CreateTime=new DateTime(2022,05,22),IsDelete = false},
                new Activity { ActivityName = "BuildSchoolDEMO",ActivityStartTime=new DateTime(2022,06,05),ActivityEndTime=new DateTime(2022,09,30),ActivityImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657047961/ActivityIMG/AT03.png",ActivityBgColor="#CF9B68",ActivityContent="<h2>DEMO Day</h2><br><p>祝大家有個美好的未來!</p>",PrincipalEmployee=2,CreateTime=new DateTime(2022,05,28),IsDelete = false},
                new Activity { ActivityName = "中秋節",ActivityStartTime=new DateTime(2022,06,01),ActivityEndTime=new DateTime(2022,09,25),ActivityImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657047891/ActivityIMG/AT01.png",ActivityBgColor="#CF9B68",ActivityContent="<h2>過中秋</h2><br><p>各位有吃到~~~好吃的麻糬嗎?</p>",PrincipalEmployee=16,CreateTime=new DateTime(2022,05,26),IsDelete = false},


                new Activity { ActivityName = "元旦",ActivityStartTime=new DateTime(2021,12,28),ActivityEndTime=new DateTime(2022,01,05),ActivityImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657047891/ActivityIMG/AT01.png",ActivityBgColor="#517664",ActivityContent="<h2>元旦囉!</h2><br><p>大家有去跨年嗎?</p>",PrincipalEmployee=1,CreateTime=new DateTime(2021,12,15),IsDelete = true},
                new Activity { ActivityName = "春節連假",ActivityStartTime=new DateTime(2022,01,29),ActivityEndTime=new DateTime(2022,02,06),ActivityImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657047931/ActivityIMG/AT02.png",ActivityBgColor="#517664",ActivityContent="<h2>大吉大利過新年，事業成功輝煌年！</h2><br><p>過新年~<br>放鬆一下吧!</p>",PrincipalEmployee=1,CreateTime=new DateTime(2022,01,15),IsDelete = true},
                new Activity { ActivityName = "除夕",ActivityStartTime=new DateTime(2022,01,27),ActivityEndTime=new DateTime(2022,02,05),ActivityImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657047961/ActivityIMG/AT03.png",ActivityBgColor="#CF9B68",ActivityContent="<h2>除夕夜</h2><br><p>農曆過年來休閒看漫畫吧!</p>",PrincipalEmployee=2,CreateTime=new DateTime(2022,01,15),IsDelete = true},
                new Activity { ActivityName = "西洋情人節",ActivityStartTime=new DateTime(2022,02,08),ActivityEndTime=new DateTime(2022,02,24),ActivityImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657047891/ActivityIMG/AT01.png",ActivityBgColor="#517664",ActivityContent="<h2>情人節</h2><br><p>花無言，愛有語，浪漫七夕大酬賓!</p>",PrincipalEmployee=3,CreateTime=new DateTime(2022,02,02),IsDelete = true},
                new Activity { ActivityName = "元宵節",ActivityStartTime=new DateTime(2022,02,11),ActivityEndTime=new DateTime(2022,02,18),ActivityImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657047931/ActivityIMG/AT02.png",ActivityBgColor="#517664",ActivityContent="<h2>過元宵</h2><br><p>提著燈籠賞燈趣!</p>",PrincipalEmployee=5,CreateTime=new DateTime(2022,02,08),IsDelete = true},
                new Activity { ActivityName = "愚人節",ActivityStartTime=new DateTime(2022,03,28),ActivityEndTime=new DateTime(2022,04,8),ActivityImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657047961/ActivityIMG/AT03.png",ActivityBgColor="#517664",ActivityContent="<h2>愚人節</h2><br><p>今天被騙不能生氣喔!</p>",PrincipalEmployee=2,CreateTime=new DateTime(2022,03,20),IsDelete = true},
                new Activity { ActivityName = "兒童節",ActivityStartTime=new DateTime(2022,04,01),ActivityEndTime=new DateTime(2022,04,07),ActivityImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657047891/ActivityIMG/AT01.png",ActivityBgColor="#CF9B68",ActivityContent="<h2>兒童&清明節</h2><br><p>大家在活動時要注意安全喔!</p>",PrincipalEmployee=15,CreateTime=new DateTime(2022,03,20),IsDelete = true},
                new Activity { ActivityName = "勞動節",ActivityStartTime=new DateTime(2022,04,26),ActivityEndTime=new DateTime(2022,05,03),ActivityImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657047931/ActivityIMG/AT02.png",ActivityBgColor="#CF9B68",ActivityContent="<h2>勞動節</h2><br><p>辛苦了!給自己放個假吧!</p>",PrincipalEmployee=7,CreateTime=new DateTime(2022,04,22),IsDelete = true},
                new Activity { ActivityName = "母親節",ActivityStartTime=new DateTime(2022,05,05),ActivityEndTime=new DateTime(2022,05,12),ActivityImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657047961/ActivityIMG/AT03.png",ActivityBgColor="#CF9B68",ActivityContent="<h2>母親節</h2><br><p>感謝全天下的母親吧~~~</p>",PrincipalEmployee=10,CreateTime=new DateTime(2022,05,02),IsDelete = true},
                new Activity { ActivityName = "中元節",ActivityStartTime=new DateTime(2022,08,06),ActivityEndTime=new DateTime(2022,08,16),ActivityImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657047891/ActivityIMG/AT01.png",ActivityBgColor="#CF9B68",ActivityContent="<h2>中元!中元!</h2><br><p>普渡拜拜用乖乖，大家才會「乖」!</p>",PrincipalEmployee=14,CreateTime=new DateTime(2022,08,03),IsDelete = true},
                new Activity { ActivityName = "父親節",ActivityStartTime=new DateTime(2022,08,02),ActivityEndTime=new DateTime(2022,08,16),ActivityImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657047931/ActivityIMG/AT02.png",ActivityBgColor="#CF9B68",ActivityContent="<h2>給親愛的父親的話~</h2><br><p>你用慈愛，醞釀家的甜蜜!感謝您~~</p>",PrincipalEmployee=2,CreateTime=new DateTime(2022,07,28),IsDelete = true},
                new Activity { ActivityName = "教師節",ActivityStartTime=new DateTime(2022,09,24),ActivityEndTime=new DateTime(2022,09,30),ActivityImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657047891/ActivityIMG/AT01.png",ActivityBgColor="#CF9B68",ActivityContent="<h2>教師們~</h2><br><p>勤勤懇懇育桃李，兢兢業業做園丁!</p>",PrincipalEmployee=11,CreateTime=new DateTime(2022,09,13),IsDelete = true},
                new Activity { ActivityName = "重陽節",ActivityStartTime=new DateTime(2022,10,01),ActivityEndTime=new DateTime(2022,10,12),ActivityImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657047931/ActivityIMG/AT02.png",ActivityBgColor="#CF9B68",ActivityContent="<h2>重陽節</h2><br><p>待到重陽日，還來就菊花</p>",PrincipalEmployee=8,CreateTime=new DateTime(2022,09,27),IsDelete = true},
                new Activity { ActivityName = "雙十國慶日",ActivityStartTime=new DateTime(2022,10,05),ActivityEndTime=new DateTime(2022,10,12),ActivityImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657047961/ActivityIMG/AT03.png",ActivityBgColor="#CF9B68",ActivityContent="<h2>國慶!國慶!</h2><br><p>建國紀念看漫畫!</p>",PrincipalEmployee=4,CreateTime=new DateTime(2022,10,01),IsDelete = true},
                new Activity { ActivityName = "光復節",ActivityStartTime=new DateTime(2022,10,20),ActivityEndTime=new DateTime(2022,10,30),ActivityImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657047891/ActivityIMG/AT01.png",ActivityBgColor="#CF9B68",ActivityContent="<h2>光復節</h2><br><p>沒有放假真可惜!</p>",PrincipalEmployee=6,CreateTime=new DateTime(2022,10,11),IsDelete = true},
                new Activity { ActivityName = "萬聖節",ActivityStartTime=new DateTime(2022,10,26),ActivityEndTime=new DateTime(2022,11,06),ActivityImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657047931/ActivityIMG/AT02.png",ActivityBgColor="#CF9B68",ActivityContent="<h2>萬聖節</h2><br><p>萬聖節魔幻禮品，漫畫任你看~等待大膽的你!</p>",PrincipalEmployee=17,CreateTime=new DateTime(2022,10,22),IsDelete = true},
                new Activity { ActivityName = "聖誕節",ActivityStartTime=new DateTime(2022,12,20),ActivityEndTime=new DateTime(2022,12,31),ActivityImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657047961/ActivityIMG/AT03.png",ActivityBgColor="#CF9B68",ActivityContent="<h2>聖誕節</h2><br><p>華麗聖誕狂響曲~喜迎新春獻賀禮</p>",PrincipalEmployee=16,CreateTime=new DateTime(2022,12,15),IsDelete = true},
            };
            //var data = new Activity() { ActivityName = "BuildSchoolDEMO", ActivityStartTime = new DateTime(2022, 08, 01), ActivityEndTime = new DateTime(2022, 08, 15), ActivityImage = "jpg", ActivityBgColor = "#CF9B68", ActivityContent = "<h2>DEMO Day</h2><br><p>祝大家有個美好的未來!</p>", PrincipalEmployee = 2, CreateTime = new DateTime(2022, 08, 01), IsDelete = false };
            foreach (Activity activity in activityList)
            {
                _repository.Create(activity);

            }

            //_repository.Delete(data);
            _repository.SaveChange();
        }



        //public IEnumerable<ActivityViewModel> ActivityRead()
        //{
        //    foreach (var vr in _repository.GetAll<Activity>())
        //    {
        //        var data = new ActivityViewModel()
        //        {
        //            //ActivityName = _repository.GetAll<Coupon>().First(m => m.ActivityId == vr.ActivityId).ActivityName,
        //            //ActivityId = _repository.GetAll<Coupon>().First(m => m.ActivityId == vr.ActivityId).ActivityName,
        //            ActivityName = vr.ActivityName,
        //            ActivityStartTime = vr.ActivityStartTime,
        //            ActivityEndTime = vr.ActivityEndTime,
        //            CreateTime = vr.CreateTime,
        //        };
        //        yield return data;
        //    }
        //}


        public void ViewRecordCreate()
        {
            var viewRecordList = new List<ViewRecord>()
            {
                new ViewRecord(){ /*ViewRecorId=1,*/ MemberId=1,EpContentId=4,ViewTime=new DateTime(2022,06,01),IsDelete=false},
                new ViewRecord(){ /*ViewRecorId=2,*/MemberId=2,EpContentId=8,ViewTime=new DateTime(2022,08,13),IsDelete=false},
                new ViewRecord(){ /*ViewRecorId=3,*/ MemberId=10,EpContentId=16,ViewTime=new DateTime(2022,03,05),IsDelete=true},
                new ViewRecord(){ /*ViewRecorId=4,*/MemberId=16,EpContentId=6,ViewTime=new DateTime(2022,05,06),IsDelete=false},
                new ViewRecord(){ /*ViewRecorId=5,*/ MemberId=20,EpContentId=3,ViewTime=new DateTime(2022,04,08),IsDelete=false},
                new ViewRecord(){ /*ViewRecorId=6,*/MemberId=19,EpContentId=10,ViewTime=new DateTime(2022,06,14),IsDelete=false},
                new ViewRecord(){ /*ViewRecorId=7,*/ MemberId=13,EpContentId=6,ViewTime=new DateTime(2022,06,25),IsDelete=false},
                new ViewRecord(){ /*ViewRecorId=8,*/MemberId=5,EpContentId=4,ViewTime=new DateTime(2022,03,21),IsDelete=false},
                new ViewRecord(){ /*ViewRecorId=9,*/ MemberId=3,EpContentId=18,ViewTime=new DateTime(2022,07,6),IsDelete=false},
                new ViewRecord(){ /*ViewRecorId=10,*/MemberId=13,EpContentId=13,ViewTime=new DateTime(2022,07,31),IsDelete=false},
                new ViewRecord(){ /*ViewRecorId=11,*/ MemberId=14,EpContentId=3,ViewTime=new DateTime(2022,07,25),IsDelete=true},
                new ViewRecord(){ /*ViewRecorId=12,*/MemberId=19,EpContentId=9,ViewTime=new DateTime(2022,03,24),IsDelete=false},
                new ViewRecord(){ /*ViewRecorId=13,*/ MemberId=6,EpContentId=12,ViewTime=new DateTime(2022,04,18),IsDelete=false},
                new ViewRecord(){ /*ViewRecorId=14,*/MemberId=7,EpContentId=13,ViewTime=new DateTime(2022,03,09),IsDelete=false},
                new ViewRecord(){ /*ViewRecorId=15,*/ MemberId=15,EpContentId=16,ViewTime=new DateTime(2022,05,15),IsDelete=true},
                new ViewRecord(){ /*ViewRecorId=16,*/MemberId=13,EpContentId=15,ViewTime=new DateTime(2022,05,26),IsDelete=true},
                new ViewRecord(){ /*ViewRecorId=17,*/ MemberId=10,EpContentId=9,ViewTime=new DateTime(2022,03,31),IsDelete=false},
                new ViewRecord(){ /*ViewRecorId=18,*/MemberId=17,EpContentId=10,ViewTime=new DateTime(2022,07,12),IsDelete=false},
                new ViewRecord(){ /*ViewRecorId=19,*/ MemberId=14,EpContentId=16,ViewTime=new DateTime(2022,08,01),IsDelete=false},
                new ViewRecord(){ /*ViewRecorId=20,*/MemberId=16,EpContentId=17,ViewTime=new DateTime(2022,02,20),IsDelete=false},
            };
            foreach (ViewRecord record in viewRecordList)
            {
                _repository.Create(record);
            }
            _repository.SaveChange();
        }

        public void CommentCreate()
        {
            var commentList = new List<Comment>()
            {
                new Comment(){MemberId=1,EpId=1,ReplyToCommentId=null,IsSpoiler=false,CreateTime=new DateTime(2022,01,15,13,45,07),Context="超好看!!!老師太厲害了!",IsDelete=false},
                new Comment(){MemberId=2,EpId=2,ReplyToCommentId=null,IsSpoiler=true,CreateTime=new DateTime(2022,02,15,18,30,16),Context="女主角超心機  不過我喜歡<br>哈哈哈",IsDelete=false},
                new Comment(){MemberId=5,EpId=6,ReplyToCommentId=null,IsSpoiler=false,CreateTime=new DateTime(2022,03,01,18,59,56),Context="這部男女主角是寫得很慘沒錯，但女主的行動邏輯真的很難達成共鳴，甚至我覺得有些雙標（小聲大部分都是靠嘴遁帶過，有點莫名奇妙就變團寵",IsDelete=false},
                new Comment(){MemberId=19,EpId=5,ReplyToCommentId=null,IsSpoiler=true,CreateTime=new DateTime(2022,03,04,20,12,05),Context="公爵人渣欸 出軌還囚禁正妻把自己女兒丟去育幼院 好扯的開局",IsDelete=true},
                new Comment(){MemberId=12,EpId=6,ReplyToCommentId=3,IsSpoiler=false,CreateTime=new DateTime(2022,02,24,22,54,15),Context="超好看!!!老師太厲害了!",IsDelete=false},
                new Comment(){MemberId=20,EpId=4,ReplyToCommentId=null,IsSpoiler=false,CreateTime=new DateTime(2022,01,31,23,32,56),Context="好過分喔，這什麼小説(´；ω；｀) ，憑甚麼渣爸就能擁有美滿結局?",IsDelete=false},
                new Comment(){MemberId=2,EpId=1,ReplyToCommentId=1,IsSpoiler=false,CreateTime=new DateTime(2022,04,01,13,47,23),Context="梅麗莎大人可以娶我嗎",IsDelete=false},
                new Comment(){MemberId=7,EpId=5,ReplyToCommentId=null,IsSpoiler=false,CreateTime=new DateTime(2022,02,08,10,22,54),Context="原著的故事如果從尤斯托的視角來看應該更悲傷吧⋯一心一意追隨的女皇因為一些原因墮落成這個樣子，而自己為了帝國只能親手殺了她😢那個落寞的眼神，分明就是喜歡尤莉婭的",IsDelete=false},
                new Comment(){MemberId=6,EpId=6,ReplyToCommentId=null,IsSpoiler=false,CreateTime=new DateTime(2022,04,13,01,56,23),Context="最近的穿越方式越來越簡單了啊，喝酒就可以了🤣",IsDelete=false},
                new Comment(){MemberId=18,EpId=4,ReplyToCommentId=6,IsSpoiler=false,CreateTime=new DateTime(2022,03,29,21,45,59),Context="卡車司機終於要失業了嗎",IsDelete=false},
                new Comment(){MemberId=10,EpId=1,ReplyToCommentId=null,IsSpoiler=false,CreateTime=new DateTime(2022,01,16,16,21,50),Context="話說這部前面會讓我想到隔壁 絕色公主，穿越前的角色都玩很“大”呢",IsDelete=false},
                new Comment(){MemberId=15,EpId=5,ReplyToCommentId=4,IsSpoiler=false,CreateTime=new DateTime(2022,02,10,17,10,01),Context="封面好帥(´ ▽｀).。ｏ♡",IsDelete=false},
                new Comment(){MemberId=12,EpId=5,ReplyToCommentId=12,IsSpoiler=false,CreateTime=new DateTime(2022,02,01,07,23,00),Context="大家到底怎麼憑小說描述就可以知道主角長怎樣的",IsDelete=false},
                new Comment(){MemberId=5,EpId=2,ReplyToCommentId=null,IsSpoiler=true,CreateTime=new DateTime(2022,02,22,02,01,03),Context="「如染上鮮血般嫣紅的雙唇」不是，妳一看就不符合啊！",IsDelete=false},
                new Comment(){MemberId=7,EpId=4,ReplyToCommentId=null,IsSpoiler=false,CreateTime=new DateTime(2022,03,03,15,15,14),Context="主角“塔瑪”超可愛!!",IsDelete=false},
                new Comment(){MemberId=8,EpId=5,ReplyToCommentId=8,IsSpoiler=false,CreateTime=new DateTime(2022,03,31,16,29,26),Context="黑髮紅眼就是香！",IsDelete=false},
                new Comment(){MemberId=13,EpId=6,ReplyToCommentId=null,IsSpoiler=false,CreateTime=new DateTime(2022,02,27,20,44,43),Context="要看之前可以先Google搜尋一下「我是這家的孩子」，Dcard那邊有討論原版劇情。總之就是原版小說後面的發展很雷！漫畫不知是否會改動，要花金幣之前最好慎思……",IsDelete=true},
                new Comment(){MemberId=6,EpId=8,ReplyToCommentId=null,IsSpoiler=false,CreateTime=new DateTime(2022,01,25,18,36,21),Context="女主好乖，乖巧地說自己叫粉紅瞳孔好可愛❤️",IsDelete=false},
                new Comment(){MemberId=14,EpId=2,ReplyToCommentId=null,IsSpoiler=false,CreateTime=new DateTime(2022,01,29,10,53,50),Context="翻譯太妙了wwww",IsDelete=false},
                new Comment(){MemberId=20,EpId=8,ReplyToCommentId=null,IsSpoiler=false,CreateTime=new DateTime(2022,01,11,18,06,24),Context="希望劇情不要跟小說一樣雷",IsDelete=false},
            };
            foreach (Comment comment in commentList)
            {
                _repository.Create(comment);
            }
            _repository.SaveChange();
        }

        public void CommentLikeCreate()
        {
            var likeList = new List<CommentLikeRecord>
            {
                new CommentLikeRecord(){ MemberId=1, CommentId=1, CreateTime=new DateTime(2022,05,01,05,47,02), IsLike = true},
                new CommentLikeRecord(){ MemberId=5, CommentId=2, CreateTime=new DateTime(2022,05,04,18,35,00), IsLike = true},
                new CommentLikeRecord(){ MemberId=6, CommentId=11, CreateTime=new DateTime(2022,08,01,13,47,15), IsLike = true},
                new CommentLikeRecord(){ MemberId=5, CommentId=20, CreateTime=new DateTime(2022,06,04,19,15,51), IsLike = true},
                new CommentLikeRecord(){ MemberId=15, CommentId=15, CreateTime=new DateTime(2022,07,01,20,52,22), IsLike = true},
                new CommentLikeRecord(){ MemberId=3, CommentId=15, CreateTime=new DateTime(2022,05,04,12,06,55), IsLike = true},
                new CommentLikeRecord(){ MemberId=18, CommentId=12, CreateTime=new DateTime(2022,06,01,11,04,04), IsLike = true},
                new CommentLikeRecord(){ MemberId=2, CommentId=14, CreateTime=new DateTime(2022,06,04,10,39,16), IsLike = true},
                new CommentLikeRecord(){ MemberId=4, CommentId=16, CreateTime=new DateTime(2022,07,01,20,26,45), IsLike = true},
                new CommentLikeRecord(){ MemberId=8, CommentId=5, CreateTime=new DateTime(2022,08,04,15,31,28), IsLike = true},
                new CommentLikeRecord(){ MemberId=4, CommentId=10, CreateTime=new DateTime(2022,08,01,17,59,58), IsLike = true},
                new CommentLikeRecord(){ MemberId=9, CommentId=5, CreateTime=new DateTime(2022,06,04,16,35,51), IsLike = true},
                new CommentLikeRecord(){ MemberId=10, CommentId=6, CreateTime=new DateTime(2022,06,01,14,15,23), IsLike = true},
                new CommentLikeRecord(){ MemberId=18, CommentId=4, CreateTime=new DateTime(2022,06,04,13,53,54), IsLike = true},
                new CommentLikeRecord(){ MemberId=13, CommentId=3, CreateTime=new DateTime(2022,05,01,17,46,05), IsLike = true},
                new CommentLikeRecord(){ MemberId=20, CommentId=5, CreateTime=new DateTime(2022,06,04,12,28,06), IsLike = true},
                new CommentLikeRecord(){ MemberId=16, CommentId=19, CreateTime=new DateTime(2022,05,01,12,46,59), IsLike = true},
                new CommentLikeRecord(){ MemberId=5, CommentId=13, CreateTime=new DateTime(2022,05,04,22,35,21), IsLike = true},
                new CommentLikeRecord(){ MemberId=3, CommentId=14, CreateTime=new DateTime(2022,06,01,23,44,49), IsLike = true},
                new CommentLikeRecord(){ MemberId=6, CommentId=11, CreateTime=new DateTime(2022,07,04,12,38,54), IsLike = true},
            };
            foreach (CommentLikeRecord Like in likeList)
            {
                _repository.Create(Like);
            }
            _repository.SaveChange();
        }

        public void ReportCreate()
        {
            var reportList = new List<Report>
            {
                new Report(){ /*ReportId=1,*/CommentId=1,CreateTime=new DateTime(2022,07,05,12,20,00),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,07,16,10,00,00),Reason="我看他不爽!!!"},
                new Report(){ /*ReportId=2,*/CommentId=2,CreateTime=new DateTime(2022,07,16,16,25,11),AuditType=4,AuditEmployeeId=15,AuditTime=new DateTime(2022,07,16,16,20,03),Reason="廣告訊息"},
                new Report(){ /*ReportId=3,*/CommentId=3,CreateTime=new DateTime(2022,07,11,16,26,46),AuditType=5,AuditEmployeeId=14,AuditTime=new DateTime(2022,07,20,16,23,04),Reason="我看他不爽!!!"},
                new Report(){ /*ReportId=4,*/CommentId=4,CreateTime=new DateTime(2022,07,15,15,56,26),AuditType=3,AuditEmployeeId=15,AuditTime=new DateTime(2022,07,22,16,21,51),Reason="我看他不爽!!!"},
                new Report(){ /*ReportId=5,*/CommentId=5,CreateTime=new DateTime(2022,07,05,22,15,15),AuditType=2,AuditEmployeeId=5,AuditTime=new DateTime(2022,07,26,16,06,50),Reason="非法資訊"},
                new Report(){ /*ReportId=6,*/CommentId=6,CreateTime=new DateTime(2022,07,12,23,59,56),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,07,16,16,05,16),Reason="裸露/煽情"},
                new Report(){ /*ReportId=7,*/CommentId=7,CreateTime=new DateTime(2022,07,12,05,26,55),AuditType=3,AuditEmployeeId=2,AuditTime=new DateTime(2022,07,18,16,15,16),Reason="暴力/騷擾/仇恨言論"},
                new Report(){ /*ReportId=8,*/CommentId=8,CreateTime=new DateTime(2022,07,14,15,22,12),AuditType=2,AuditEmployeeId=3,AuditTime=new DateTime(2022,07,19,16,21,00),Reason="個資外流"},
                new Report(){ /*ReportId=9,*/CommentId=9,CreateTime=new DateTime(2022,07,06,20,15,45),AuditType=5,AuditEmployeeId=2,AuditTime=new DateTime(2022,07,20,16,23,05),Reason="洗版"},
                new Report(){ /*ReportId=10,*/CommentId=10,CreateTime=new DateTime(2022,07,12,10,09,41),AuditType=4,AuditEmployeeId=16,AuditTime=new DateTime(2022,07,25,21,15,01),Reason="我看他不爽!!!"},
                new Report(){ /*ReportId=11,*/CommentId=11,CreateTime=new DateTime(2022,07,19,05,46,30),AuditType=4,AuditEmployeeId=15,AuditTime=new DateTime(2022,07,31,09,16,15),Reason="非法資訊"},
                new Report(){ /*ReportId=12,*/CommentId=12,CreateTime=new DateTime(2022,07,18,01,18,06),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2022,07,29,10,00,00),Reason="非法資訊"},
                new Report(){ /*ReportId=13,*/CommentId=13,CreateTime=new DateTime(2022,07,16,15,46,16),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,07,25,16,03,43),Reason="廣告訊息"},
                new Report(){ /*ReportId=14,*/CommentId=14,CreateTime=new DateTime(2022,07,09,12,45,40),AuditType=3,AuditEmployeeId=10,AuditTime=new DateTime(2022,07,20,18,08,34),Reason="廣告訊息"},
                new Report(){ /*ReportId=15,*/CommentId=15,CreateTime=new DateTime(2022,07,15,06,21,10),AuditType=3,AuditEmployeeId=19,AuditTime=new DateTime(2022,07,27,17,10,29),Reason="非法資訊"},
                new Report(){ /*ReportId=16,*/CommentId=16,CreateTime=new DateTime(2022,07,13,05,26,05),AuditType=1,AuditEmployeeId=20,AuditTime=new DateTime(2022,07,30,12,05,55),Reason="我看他不爽!!!"},
                new Report(){ /*ReportId=17,*/CommentId=17,CreateTime=new DateTime(2022,07,06,22,09,06),AuditType=2,AuditEmployeeId=11,AuditTime=new DateTime(2022,07,16,12,01,02),Reason="洗版"},
                new Report(){ /*ReportId=18,*/CommentId=18,CreateTime=new DateTime(2022,07,16,01,08,55),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,07,15,23,59,00),Reason="洗版"},
                new Report(){ /*ReportId=19,*/CommentId=19,CreateTime=new DateTime(2022,07,06,13,14,59),AuditType=2,AuditEmployeeId=8,AuditTime=new DateTime(2022,07,16,15,51,21),Reason="洗版"},
                new Report(){ /*ReportId=20,*/CommentId=20,CreateTime=new DateTime(2022,07,05,16,10,31),AuditType=3,AuditEmployeeId=7,AuditTime=new DateTime(2022,07,23,03,05,56),Reason="對小孩有負面影響"},
            };
            foreach (Report report in reportList)
            {
                _repository.Create(report);
            }
            _repository.SaveChange();
        }

        public IEnumerable<RecommendDTO> ReadRecommend()
        {
            // 活動 新作 人氣

            // 活動 軟刪除
            var activityList = _repository.GetAll<Activity>().Where(a => a.IsDelete == false)/*.Where(a => a.ActivityStartTime < DateTime.Now && a.ActivityEndTime > DateTime.Now)*//*.ToList()*/;

            //// 確保有影片
            //var filterComics = _repository.GetAll<Comic>().Where(c => c.BannerVideoWeb != "");

            // 新作 ComicStatus == 4
            var newWorkList = _repository.GetAll<Comic>().Where(c => c.ComicStatus == 4)/*.ToList()*/;

            // 人氣
            var popularityGroupBy = _repository.GetAll<ClickRecord>().GroupBy(c => c.ComicId).OrderByDescending(c => c.Count(gp => gp.ComicId == c.Key)).ThenBy(c => c.Key).Select(c => c.Key);
            var popularityList = _repository.GetAll<Comic>().Where(c => popularityGroupBy.Any(g => g == c.ComicId))/*.ToList()*/;

            var result = new List<RecommendDTO>();

            List<RecommendDTO> addActivityList = activityList.Select(c => new RecommendDTO { 
                RecommendTag = "活動",
                Introduction = c.ActivityContent,
                Name = c.ActivityName,
                ActivityBgColor = c.ActivityBgColor,
                ActivityImage = c.ActivityImage,
            }).ToList();

            List<RecommendDTO> addNewWorkList = newWorkList.Select(c => new RecommendDTO { 
                RecommendTag = "新作",
                Introduction = $"{c.Introduction.Substring(0, 50)}...",
                Name = c.ComicChineseName,
                NameImage = c.ComicNameImage,
                ComicBgCover = c.BgCover,
                BannerVideoWeb = c.BannerVideoWeb,
                ComicFigure = c.ComicFigure,
            }).ToList();

            List<RecommendDTO> addPopularityList = popularityList.Select(c => new RecommendDTO {
                RecommendTag = "人氣",
                Introduction = $"{c.Introduction.Substring(0, 50)}...",
                Name = c.ComicChineseName,
                NameImage = c.ComicNameImage,
                ComicBgCover = c.BgCover,
                BannerVideoWeb = c.BannerVideoWeb,
                ComicFigure= c.ComicFigure,
            }).ToList();

            result.AddRange(addActivityList);
            result.AddRange(addNewWorkList);
            result.AddRange(addPopularityList);

            return result;
        }

        public IEnumerable<HitWorkDTO> ReadHitWork()
        {
            var hitWorkList = _repository.GetAll<Comic>().Where(c => c.HotComicNameImage != "" && c.HotBgCover != "" && c.HotVideo != "");

            var result = new List<HitWorkDTO>();

            result = hitWorkList.Select(c => new HitWorkDTO { 
                ComicId = c.ComicId,
                ComicChineseName = c.ComicChineseName,
                HotComicNameImage = c.HotComicNameImage,
                HotBgCover = c.HotBgCover,
                HotVideo = c.HotVideo
            }).ToList();

            return result;
        }

        //public async Task<List<ClickCountViewModel>> ClickCount()
        //{
        //    var query = (await _context.ClickRecord.ToListAsync()).GroupBy(comic => comic.ComicId).Select(g => new ClickCountViewModel { ComicId = g.Key, Count = g.Count() });

        //    return query.ToList();
        //}
    }
}
