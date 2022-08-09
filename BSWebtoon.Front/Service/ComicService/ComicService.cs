using BSWebtoon.Front.Models.DTO.WorkPage;
using BSWebtoon.Model;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using static BSWebtoon.Front.Models.DTO.WorkPage.WorkPageDTO;

namespace BSWebtoon.Front.Service.ComicService
{
    public class ComicService : IComicService
    {
        private readonly BSRepository _repository;

        public ComicService(BSRepository repository)
        {
            _repository = repository;
        }

        public void ComicTagCreate()
        {
            List<ComicTag> comictags = new List<ComicTag>
            {
                //主標籤 IsMainTag=true
                //副標籤 IsMainTag=false
                new ComicTag {TagName="奇幻"    ,IsMainTag=true ,IsDelete=false},
                new ComicTag {TagName="愛情"    ,IsMainTag=true ,IsDelete=false},
                new ComicTag {TagName="動作冒險",IsMainTag=true ,IsDelete=false},
                new ComicTag {TagName="劇情"    ,IsMainTag=true ,IsDelete=false},
                new ComicTag {TagName="BL/GL"  ,IsMainTag=true ,IsDelete=false},
                new ComicTag {TagName="懸疑恐怖",IsMainTag=true,IsDelete=false},
                new ComicTag {TagName="精采絕倫",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="奇幻愛情",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="專業",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="復仇",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="怦然心動",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="緊張刺激",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="淒美愛情",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="糾葛",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="三角關係",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="刻劃細膩",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="揪心",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="改變命運",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="欲罷不能",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="成長",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="大格局",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="食指大動",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="津津有味",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="爆笑",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="職場生活",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="浪漫喜劇",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="清新",IsMainTag=false,IsDelete=false},
                new ComicTag {TagName="活潑可愛",IsMainTag=false,IsDelete=false},


            };
            var ordertag = comictags.OrderByDescending(x => x.IsMainTag).ThenBy(x => x.TagName);
            foreach (var tags in ordertag)
            {
                _repository.Create(tags);
            }
            _repository.SaveChange();
        }
        public void ComicCreate()
        {
            List<Comic> comics = new List<Comic>
            {
                //星期列表與作品頁
                //星期一
                //1
                new Comic {

                            ComicChineseName="再次我的生活",ComicEnglishName="AgainMyLife"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604668/AgainMyLife/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656571331/AgainMyLife/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656570608/AgainMyLife/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656570608/AgainMyLife/1.webp"
                           ,BgColor       ="#1b2260",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,7,14),FinallyPublishDate=new DateTime(2021,7,10),UpdateWeek=1
                           ,Publisher     ="YJ Comics",Painter="SUN YONG MIN",Author="Lee hae nal"
                           ,Introduction  ="重生的熱血檢察官，審判絕對之惡!韓民國的熱血檢察官金熙宇，在調查凌駕於法律之上、玩弄著大韓民國的絕對權力者趙泰燮的貪汙案時，慘遭趙泰燮的同夥殺害並丟入海中。但金熙宇在黃泉路上遇見的陰間使者給了他重生的機會，於是他帶著前世的記憶回到了18歲的膽小鬼時期。重新變成高中生的熙宇利用前世得知的未來事件，開始為制裁趙泰燮做準備...!「比惡魔更過分的怪物才能抓到惡魔。」"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1657103466/AgainMyLife/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=3},

                //2
                new Comic {ComicChineseName="重生者的魔法一定要特別",ComicEnglishName="AReturner'sMagicShouldBeSpecial"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608088/AReturner%27sMagicShouldBeSpecial/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576416/AReturner%27sMagicShouldBeSpecial/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576348/AReturner%27sMagicShouldBeSpecial/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576218/AReturner%27sMagicShouldBeSpecial/1.webp"
                           ,BgColor       ="#402c3b",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,7,15),FinallyPublishDate=new DateTime(2021,7,10),UpdateWeek=1
                           ,Publisher     ="D&C WEBTOON Biz",Painter="Wookjakga",Author="Usonan"
                           ,Introduction  ="「既然已經回來了，就不能再次失去心愛的人們!」人類正面臨最可怕的災難——影之迷宮。戴基爾．阿曼德是迷宮裡最後的6名倖存者之一。他們試圖挑戰迷宮的最後關卡，然而卻以失敗告終，世界最終走向滅亡。當以為一切已經結束的那刻，戴基爾卻回到了13年前的過去?!當時的戴基爾正要進入帝國最強的魔法學院——赫布里溫學院就讀，並且與在迷宮中逝去的珍貴夥伴們重逢。為了拯救他心愛的人們與這個世界，他決心要改變過去...!距離影之世界出現的時間只剩3年了!快召集強悍的同伴一同拯救世界吧!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=3},


                new Comic {ComicChineseName="嗜血暴君的初戀",ComicEnglishName="ATyrant'sFirstLove"
                           ,ComicNameImage ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605209/ATyrant%27sFirstLove/5.png"
                           ,BgCover        ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576002/ATyrant%27sFirstLove/4.webp"
                           ,HotComicNameImage = ""
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://tw-a.kakaopagecdn.com/P/C/122/c2/2x/27658c20-605e-4c30-8b7f-0bcc44376857.webp"
                           ,ComicWeekFigure ="https://tw-a.kakaopagecdn.com/P/C/122/c2/2x/27658c20-605e-4c30-8b7f-0bcc44376857.webp"
                           ,BgColor       ="#310a0b",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2022,7,5),FinallyPublishDate=new DateTime(2022,7,1),UpdateWeek=1
                           ,Publisher     ="DAON STUDIO",Painter="CHIWA",Author="KIM SUO"
                           ,Introduction  ="喪失記憶的少女「迪雅」，原本在諾斯男爵府擔任女傭，日復一日地受盡折磨。沒想到，出了名殘酷的皇帝「凱勒」，竟在某天強行將迪雅帶至皇宮中，並詢問她認不認得自己。那天之後，迪雅便待在皇宮中，熟悉皇室的日常...某個月圓之夜，迪雅被一股神祕的力量牽引至城外，並撞見了渾身浴血的凱勒..."
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656575874/ATyrant%27sFirstLove/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656575948/ATyrant%27sFirstLove/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=1},

                //星期一有影片
                //4
                new Comic {ComicChineseName="留級玩家",ComicEnglishName="ThePlayerWhoCan'tLevelUp"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607506/ThePlayerWhoCan%27tLevelUp/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656581295/ThePlayerWhoCan%27tLevelUp/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580998/ThePlayerWhoCan%27tLevelUp/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657520006/ThePlayerWhoCan%27tLevelUp/9.webp"
                           ,BgColor       ="#351f29",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,7,22),FinallyPublishDate=new DateTime(2022,7,18),UpdateWeek=1
                           ,Publisher     ="DAON STUDIO",Painter="binu",Author="Siya"
                           ,Introduction  ="因為穿越進自己寫的小說，我成了欺負男主角的繼姐!別擔心，我一定會讓你變得幸福。因為這本小說的作者就是我!「我從來都沒把姐姐當成是我的家人。」雖然我覺得自己很認真在實踐讓男主角幸福的計畫，但為什麼他沒把我當成家人看呢?在他成為公爵前，我真的能順利活下來嗎?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656580720/ThePlayerWhoCan%27tLevelUp/1.webm"
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=3},
                //5
                new Comic {ComicChineseName="足跡消融之前",ComicEnglishName="BeforeFootprintAblation"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608041/BeforeFootprintAblation/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656599274/BeforeFootprintAblation/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656598550/BeforeFootprintAblation/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656598550/BeforeFootprintAblation/1.webp"
                           ,BgColor       ="##9b8263",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,7,20),FinallyPublishDate = new DateTime(2021,7,10),UpdateWeek=1
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Tess",Author="Tess"
                           ,Introduction  ="在假想的朝鮮時代，因世間種種而懷抱傷痛的人們交織而成的愛情故事。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656598837/BeforeFootprintAblation/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},
                //改字
                new Comic {ComicChineseName="凜冬暗夜",ComicEnglishName="BlackWinter"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605020/BlackWinter/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587899/BlackWinter/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587574/BlackWinter/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587574/BlackWinter/1.webp"
                           ,BgColor       ="#1a151e",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=1
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Tess",Author="Tess"
                           ,Introduction  ="在假想的朝鮮時代，因世間種種而懷抱傷痛的人們交織而成的愛情故事。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656587749/BlackWinter/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=3},

                new Comic {ComicChineseName="春日咖啡館",ComicEnglishName="Bom'sExpresso"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607321/Bom%27sExpresso/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579291/Bom%27sExpresso/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579187/Bom%27sExpresso/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579075/Bom%27sExpresso/1.webp"
                           ,BgColor       ="#646661",PublishDate=new DateTime(2021,6,30),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,25),UpdateWeek=1

                           ,Publisher     ="CARROTOON",Painter="Dolcenabi",Author="GwonDohee"
                           ,Introduction  ="結束經營9年的「春日咖啡館」，春率只好開始尋覓新的工作職缺。而求職時在因緣際會之下，春率成為了長相帥氣、實力高超卻非常難搞的Jake.K的助理，只是為什麼他看起來那麼眼熟...?春率的初次職場生活究竟能不能順利度過呢?「現在也差不多該想起來了吧?春日咖啡館、常客、高中生。」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,30),ComicStatus=3},
                //8
                new Comic {ComicChineseName="戀人未滿",ComicEnglishName="CrushOnYou"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656606356/CrushOnYou/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656585204/CrushOnYou/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584929/CrushOnYou/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584858/CrushOnYou/1.webp"
                           ,BgColor       ="#695350",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,20),UpdateWeek=1
                           ,Publisher     ="Comics family",Painter="gillzone",Author="gillzone"
                           ,Introduction  ="因為無法愛人，於是更加渴望愛情的武烈；愛意過於強烈，無法自拔的必浩；以及在兩個男人之間陷入兩難的敏希。是命運還是孽緣?答案不得而知。三人看似有結果卻又不然的三種暗戀——《戀人未滿》"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=3},

                new Comic {ComicChineseName="爸爸，請跟我結婚!",ComicEnglishName="DadPleaseMarryMe"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656784815/DadPleaseMarryMe/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656598156/DadPleaseMarryMe/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597992/DadPleaseMarryMe/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597992/DadPleaseMarryMe/1.webp"
                           ,BgColor       ="#2c3846",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,7,26),UpdateWeek=1
                           ,Publisher     ="Yeondam X DAON",Painter="via",Author="dalseul"
                           ,Introduction  ="車禍之後睜眼一看，才發現自己身在喜歡的網路小說世界裡，而且還是在原著主角們出生前——他們的父母世代。為了阻止一連串的悲劇發生，原本是想保護懷孕的姐姐被綁架，沒想到卻代替她遭到綁架了?!被綁走已經夠悲慘了，還因為不適應魔力，導致隨時可能喪命。但是...只要待在綁匪皇帝身邊，便會恢復元氣!對了!要想拯救那個和惡女結婚又慘遭親生兒子殺害的男人，以及對魔力毫無抵抗力的自己...只能我們結婚了!「爸爸，請和我結婚!」「公主，我還未婚，也沒有子嗣，為什麼老是喊我爸爸...」敬請期待直直砸向鐵壁皇帝的甜蜜求婚計畫!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656598086/DadPleaseMarryMe/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=3},
                //10
                new Comic {ComicChineseName="琉璃之壁",ComicEnglishName="GlassBlock"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607414/GlassBlock/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574627/GlassBlock/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574474/GlassBlock/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574474/GlassBlock/1.webp"
                           ,BgColor       ="#283e36",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,7,30),FinallyPublishDate= new DateTime(2022,7,26),UpdateWeek=1
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Joho",Author="Joho"
                           ,Introduction  ="富裕的貴族莉莉遇見他的那一刻，是一切的開端。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656574550/GlassBlock/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=3},

                new Comic {ComicChineseName="我想活下去",ComicEnglishName="I'mAllOutOfHealth"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607105/I%27mAllOutOfHealth/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593937/I%27mAllOutOfHealth/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593865/I%27mAllOutOfHealth/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593829/I%27mAllOutOfHealth/1.webp"
                           ,BgColor       ="#9b5975",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,7,30),FinallyPublishDate= new DateTime(2021,7,26),UpdateWeek=1
                           ,Publisher     ="Yeondam X Polarfox",Painter="Vanilla",Author="Lee Haron"
                           ,Introduction  ="穿越到被宣告今年冬天就會死掉的—— 最弱女配角「理涅娜」!別說運動了!就連散步、吃飯，只是待著都累到不行，這副脆弱的身體如同豆腐做成的玩偶，除此之外，還要擔心會被自己的爺爺暗殺。即使是這樣悲劇般的人生。「我!一定會變健康的!」。受到保護理涅娜的命令而出現在她身邊的「凱撒」。「您不會死的。暫時還不會。」還有...「天啊!主人竟然自己吃飯了!」雖然只有一點點進展，但我的身體確實漸漸好轉起來..."
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=3},
                 
                 //星期列表與作品頁
                //星期三(屬於星期一)

                //星期三(屬於星期一)有影片
                new Comic {ComicChineseName="今生我來當家主",ComicEnglishName="TodayIWillBeTheHeadOfTheHouse"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656998366/TodayIWillBeTheHeadOfTheHouse/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582961/MookHyangDarkLady/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,BgColor       ="#418ab3",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,7,26),UpdateWeek=1
                           ,Publisher     ="D&C WEBTOON Biz",Painter="Mon(Antstudio)",Author="Kim Roah"
                           ,Introduction  ="「...就試試吧，由我來當家主。」我轉世成了帝國第一大家族——倫巴第家的私生女費蓮緹雅。這個家族不但富甲天下，而且從外交到文化無一不精，堪稱帝國歷史的象徵!含著金湯匙中的金湯匙出生，簡直太幸運了!還以為將來等著我的是康莊大道...沒想到父親過世後，我被親戚趕出家門，最後連曾經鼎鼎有名的家族都毀於一旦!!悲憤交加的我小酌(?)幾杯後走在回家的路上，居然還被馬車撞上!「這也太過分了吧...」含冤而死的我一睜開眼卻回到了七歲的時候?!光是親愛的父親出現在眼前就已經令人難以置信，我竟然還有機會拯救父親與家族?連重生前的家族仇人——二皇子都像隻大型犬似地成天追著我跑?!好吧，既然如此，二皇子和家族都是我的了!轉世加重生，面對第三次人生的費蓮緹雅，為了當上家主而展開行動!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656594393/MasterVillainessTheInvincible/3.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1657034039/TodayIWillBeTheHeadOfTheHouse/2.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=3},


                new Comic {ComicChineseName="我有三個暴君哥哥",ComicEnglishName="MyThreeTyrantBrothers"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607226/MyThreeTyrantBrothers/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582063/MyThreeTyrantBrothers/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656581853/MyThreeTyrantBrothers/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656581853/MyThreeTyrantBrothers/1.webp"
                           ,BgColor       ="#9fa925",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,7,26),UpdateWeek=1
                           ,Publisher     ="DAON STUDIO",Painter="Parkha, Eun Du",Author="jomil​"
                           ,Introduction  ="我是個連名字都沒有的星期奴隸，代號「星期三」，當我因為反抗主人，性命不保的時候...「——終於找到妳了。」一夕之間多了三個哥哥，他們還說我是解除亞斯卡尼爾皇室詛咒的唯一鑰匙?!「妳一定要健健康康地長大，長到現在身上的衣服緊到再也穿不下，這是妳的第一項課題。」「別擔心，小不點。那些壞人，哥哥會幫妳狠狠教訓他們一頓。」「這孩子像隻小雞一樣，既嬌小又柔弱。我想要守護她，我會守護她。」被大家稱作暴君的哥哥們，怎麼只對我這麼溫柔!?從天而降的寵妹狂魔哥哥們和我的故事——《我有三個暴君哥哥》!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656581977/MyThreeTyrantBrothers/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=3},



                new Comic {ComicChineseName="廢墟中的皇女",ComicEnglishName="PrincessInTheRough"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605651/PrincessInTheRough/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577313/PrincessInTheRough/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576943/PrincessInTheRough/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576943/PrincessInTheRough/1.webp"
                           ,BgColor       ="#605342",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,7,26),UpdateWeek=1
                           ,Publisher     ="Mstoryhub",Painter="HAERUA",Author="HARASYO"
                           ,Introduction  ="被皇帝遺忘的孩子，獨自一人生活在森林裡的廢棄城堡。「我討厭說謊的騙子，就算是一個人，我也可以過得好好的。」她經過漫長的等待，終於盼到皇帝來，但孩子的心扉早已緊緊關上了。「我來為妳取個名字。」「名字?」「艾斯特蕾拉，這就是妳的名字了...很抱歉讓妳久等了，孩子。」艾斯特蕾拉是一個擁有著特別能力的孩子，她的家人該如何療癒那顆破碎的心呢?"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656577015/PrincessInTheRough/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656577184/PrincessInTheRough/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=3},

                //15
                new Comic {ComicChineseName="小不點皇后",ComicEnglishName="OurLittleEmpress"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605394/OurLittleEmpress/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579483/OurLittleEmpress/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579407/OurLittleEmpress/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579370/OurLittleEmpress/1.webp"
                           ,BgColor       ="#434f4c",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,7,26),UpdateWeek=1
                           ,Publisher     ="People&Story",Painter="Maryang",Author="Yusoi"
                           ,Introduction  ="預言之女是為拯救世界而誕生的。「若想拯救人類就必須結婚?那我願意!」要成為我丈夫的皇帝是一位年輕而單純的男孩，但...「我不會把女兒嫁給你!她不會成為皇后的。」 父親干涉了我的婚姻!「我妹妹是我的玩具。」就連哥哥也反對!我真的能夠拯救世界嗎?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=3},

                new Comic {ComicChineseName="婚禮復仇記",ComicEnglishName="RevengeWedding"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605358/RevengeWedding/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575576/RevengeWedding/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575339/RevengeWedding/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575339/RevengeWedding/1.webp"
                           ,BgColor       ="#28202b",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,7,26),UpdateWeek=1
                           ,Publisher     ="DAON STUDIO",Painter="SaRyong​",Author="ByulSatangYang"
                           ,Introduction  ="集外貌、財富、地位於一身的完美女子——梅勒凱蒂亞．沙夏，暈倒後醒來發現自己位在一艘巨大的船上，身上還穿著婚紗。「蛤?我要結婚了嗎?是誰這麼大膽敢打我的主意?我一定要讓你打消結婚的念頭!」但沒想到...我的丈夫初次見面竟然就拿劍抵著我的脖子?他是帝國最偉大的戰爭英雄——戴枚德利奧．吉普洛沙。可是，他看起來一點都不像來結婚的啊?「我還想說是誰把我帶到這裡來的...只要殺了妳，我就可以回去了嗎?」「真是不好意思，我也是被綁架的好嗎?」我們兩人被綁架來結婚，甚至還要一起在無人島上求生存?!眼前的首要任務，就是逃出這座荒島!終極任務，要跟這個仇人離婚!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656575410/RevengeWedding/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656575490/RevengeWedding/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=3},

                new Comic {ComicChineseName="結了婚再說",ComicEnglishName="SaveItForTheHoneymoon"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607844/SaveItForTheHoneymoon/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579729/SaveItForTheHoneymoon/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579693/SaveItForTheHoneymoon/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579622/SaveItForTheHoneymoon/1.webp"
                           ,BgColor       ="#646a90",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,7,26),UpdateWeek=1
                           ,Publisher     ="Feelyeon management",Painter="Bopamine",Author="Kangdalkong"
                           ,Introduction  ="莫雅是堅持這輩子不結婚的不婚主義者，然而某天，她卻意外一絲不掛地...和平時以冷酷嚴格出名的上司建厚裸裎相見。是說......那怎麼可能是人類的身材啊!面對建厚如藝術品般完美的身材，莫雅瞬間忘記羞愧，視線無法從他身上移開。自從看到建厚的完美裸體，莫雅出現了嚴重的後遺症——不論在哪裡、做什麼都會回想起建厚的赤身裸體。 深受困擾的莫雅在某個喝醉的夜晚，向建厚說出了爆炸性發言——「那個…組長，你要和我睡一次嗎？」在清醒狀態絕對無法說出口的告白，莫雅說出口的那一瞬間就後悔不已。不過，此時建厚居然說出了更震撼的回應—— 「很抱歉，我只會和結婚對象發生關係。」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=3},

                new Comic {ComicChineseName="SSS級死而復生的獵人",ComicEnglishName="SSS-ClassRevivalHunter"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604749/SSS-ClassRevivalHunter/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580517/SSS-ClassRevivalHunter/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580224/SSS-ClassRevivalHunter/1.png"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580224/SSS-ClassRevivalHunter/1.png"
                           ,BgColor       ="#1c1f26",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,7,26),UpdateWeek=1
                           ,Publisher     ="Fansia",Painter="Bill K",Author="Sinnoa"
                           ,Introduction  ="身處F級底層的獵人「金孔子」長久以來一直羨慕著排行第一的獵人「炎帝」。某天，他竟突然獲得了S+級的技能。不料，短暫開心過後，他發現這個技能有些古怪?!「複製對方的其中一種技能」到這裡都還不錯...「什麼?竟然要我死了才能發動?!」重生獵人的人生樂章——《SSS級死而復生的獵人》"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656580385/SSS-ClassRevivalHunter/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656580450/SSS-ClassRevivalHunter/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=3},

                new Comic {ComicChineseName="侍女小姐想活命",ComicEnglishName="SurvivingAsAMaid"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604961/SurvivingAsAMaid/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577647/SurvivingAsAMaid/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577566/SurvivingAsAMaid/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577485/SurvivingAsAMaid/1.webp"
                           ,BgColor       ="#1d0000",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,7,26),UpdateWeek=1
                           ,Publisher     ="CARROTOON",Painter="Hee-seo",Author="cloudwhale soap"
                           ,Introduction  ="只不過是煮著泡麵，下一秒睜開眼，竟發現自己進入國王、後宮、騎士、臣子、圖書管理員都是GAY的BL小說中，成為一名受到冷落的王妃的侍女。身為主角卻沒有任何BUFF加持的平凡侍女亞絲，究竟能不能平安活下去?《侍女小姐想活命》!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=3},

                //20
                new Comic {ComicChineseName="穆艾拉的調查官",ComicEnglishName="TheDetectiveOfMuiella"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607783/TheDetectiveOfMuiella/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656586950/TheDetectiveOfMuiella/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656586848/TheDetectiveOfMuiella/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656586761/TheDetectiveOfMuiella/1.webp"
                           ,BgColor       ="#435245",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,7,26),UpdateWeek=1
                           ,Publisher     ="Dreamtoon",Painter="Ssol",Author="Kiarne"
                           ,Introduction  ="穆艾拉——排斥魔法師與魔女的國家。而凱特是一名在穆艾拉鄉村領地——亞拉納戴爾宅邸中工作的女傭。某日，戴爾男爵家新進一名可疑的新僕人——伊恩。伊恩有著與僕人身分格格不入的高大身形和俊美相貌，第一天就吸引了眾人目光，然而凱特卻不喜歡處處與自己作對的伊恩。另一方面，凱特工作的戴爾男爵家開始發生一連串詭譎的事件..."
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=1},

                //21
                new Comic {ComicChineseName="與惡魔共舞",ComicEnglishName="TheDevil'sTango"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607940/TheDevil%27sTango/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575227/TheDevil%27sTango/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575128/TheDevil%27sTango/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574814/TheDevil%27sTango/1.webp"
                           ,BgColor       ="#513b46",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,7,26),UpdateWeek=1
                           ,Publisher     ="Polarfox",Painter="Chickenmeat",Author="Chickenmeat"
                           ,Introduction  ="「嗨，朋友!」跨越世紀只為找到「你」的惡魔，與無論「你」是不是惡魔，都想愛「你」的寂寞人類——邀您與三對人類♥惡魔情侶共舞!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=3},

                //22
                new Comic {ComicChineseName="繁花清風圓舞曲",ComicEnglishName="TheFlowerDancesAndTheWindSings"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607886/TheFlowerDancesAndTheWindSings/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578788/TheFlowerDancesAndTheWindSings/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578916/TheFlowerDancesAndTheWindSings/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578646/TheFlowerDancesAndTheWindSings/1.webp"
                           ,BgColor       ="#167a43",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,7,26),UpdateWeek=1
                           ,Publisher     ="CARROTOON",Painter="Sang Hang",Author="lanella"
                           ,Introduction  ="埃爾塞拉原本過著令眾人羨慕不已的奢華生活，卻年紀輕輕就因病去世了。她這一生最後悔的事就是沒有成為一位好母親，可不知道為什麼，死後的她竟回到了3年前。於是重生後的埃爾塞拉決心這次要做一位溫柔稱職的母親。但一切還是太遲了嗎?「現在才做這些，只會讓我感到厭惡罷了。」兒子只是一味地抗拒她。而她也意識到了，自己重生前一直以為融洽的夫妻關係，其實也只是她的錯覺罷了..."
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=3},


                //星期列表與作品頁
                //星期二

                //星期二有影片
                //23
                new Comic {ComicChineseName="盜墓王",ComicEnglishName="TombRaiderKing"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607700/TombRaiderKing/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656572963/TombRaiderKing/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657520466/TombRaiderKing/9.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657520466/TombRaiderKing/9.webp"
                           ,BgColor       ="#575a6f",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2022,7,20),UpdateWeek=2
                           ,Publisher     ="Polarfox",Painter="Yooani",Author="Will Bright"
                           ,Introduction  ="「不但不是主角，還偏偏是書裡最惡毒的女人...」為了擺脫租屋生活而開始閱讀武俠小說《南宮世家少主》，卻穿越成為了小說裡最惡毒的女人——唐海媛。唐海媛這個天下第一惡女為了得到欽慕的男人，不惜毒殺思慕之人的情人、挑撥武林高手們、成為魔教的走狗並導致武林動盪。「絕不能和原本的故事內容一樣，白白送死!!」偶然吃了萬年參而變成小說世界裡的最強者，武俠小說最強惡女「唐海媛」的重生記!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656572710/TombRaiderKing/1.webm"
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656572903/TombRaiderKing/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=3},

                new Comic {ComicChineseName="我成了反派的繼母",ComicEnglishName="IBecameTheVillain'sMother"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607155/IBecameTheVillain%27sMother/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584749/IBecameTheVillain%27sMother/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584432/IBecameTheVillain%27sMother/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584432/IBecameTheVillain%27sMother/1.webp"
                           ,BgColor       ="#225040",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,20),UpdateWeek=2
                           ,Publisher     ="DAON STUDIO",Painter="Iro",Author="Yulji"
                           ,Introduction  ="我成了小說裡最終的反派角色「艾因斯潘納」的繼母。而且還是小時候虐待他，長大後第一個被他殺害的壞心繼母。在我思考該如何逃離這悲慘命運時，仍一無所知、天真無邪的未來反派潛力股映入眼簾，但是...「等等，這孩子就連胖嘟嘟的小手都這麼可愛!誰捨得虐待他啊!」在我眼前的是個和反派完全沾不上邊的可愛小孩。好，我決定了，交給我吧!我會守護你!所以長大後拜託饒我一命吧!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656584573/IBecameTheVillain%27sMother/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656584694/IBecameTheVillain%27sMother/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,22),ComicStatus=3},

                //25
                new Comic {ComicChineseName="目標是成為長命百歲的千金大小姐",ComicEnglishName="IDreamOfHealthWealthAndALongLife"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607743/IDreamOfHealthWealthAndALongLife/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577934/IDreamOfHealthWealthAndALongLife/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577876/IDreamOfHealthWealthAndALongLife/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577753/IDreamOfHealthWealthAndALongLife/1.webp"
                           ,BgColor       ="#3b3f0e",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,15),FinallyPublishDate= new DateTime(2021,7,10),UpdateWeek=2
                           ,Publisher     ="intime",Painter="GalaxyJellyfish",Author="Cheong Song-A"
                           ,Introduction  ="「好不容易含著金湯匙出生，居然要慘遭殺害?我一定要生存下來，並且長命百歲!」雖然轉生成了喜歡的小說中男主角的妹妹，卻註定會在十七歲時被繼母投毒殺害。哥哥正在和女主角一起冒險，我必須自己想辦法活下去...!我對這個世界非常了解，書裡的眾多角色當中肯定有能幫助我的人!我，阿德莉安娜計畫擺脫慘死的命運，並成為千金大小姐過上好日子，而此時帝國的皇子、可疑的商行主人，還有更可疑的魔族開始接近我了!沒錯，我不能就這樣乖乖等死!我要活下來!「因為我的目標是成為長命百歲的千金大小姐!!」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=3},


                new Comic {ComicChineseName="原來都是誤會一場",ComicEnglishName="ItWasAllAMistake"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605156/ItWasAllAMistake/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578279/ItWasAllAMistake/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578176/ItWasAllAMistake/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578102/ItWasAllAMistake/1.webp"
                           ,BgColor       ="#191a2e",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,20),UpdateWeek=2
                           ,Publisher     ="Dasan Books",Painter="MIM",Author="G-ANNE"
                           ,Introduction  ="我轉世到書裡，變成了凡洛斯家的二女兒度露雅，在回顧書中的內容時，些部分的記憶出了差錯。度露雅是小說中嫉妒女主角艾莉絲的惡女，並被男主角諾頓以火刑處死。為了活下去，度露雅刻意接近諾頓．埃德加，但不知怎麼回事，諾頓是個疑心非常重的人。即使度露雅想盡辦法接近他，諾頓仍不停考驗她存在的價值。「凡洛斯，再來玩吧。」儘管如此，諾頓還是很希望度露雅能夠留在自己身旁...「諾頓．埃德加是個非常惡毒的壞人!」本來應該在那段時間，和男主角好好相處的女主角艾莉絲．里莫蘭特，卻叫度露雅避開諾頓。「要與我結婚嗎?」度露雅甚至與男二亞倫．克萊莫爾訂了婚。在這一片無法預知未來的混亂中，度露雅究竟能否擺脫原作結局，守護自己?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=1},


                new Comic {ComicChineseName="就離開我吧",ComicEnglishName="JustLeaveMe"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605448/JustLeaveMe/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597845/JustLeaveMe/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597626/JustLeaveMe/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597626/JustLeaveMe/1.webp"
                           ,BgColor       ="#121212",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,20),UpdateWeek=2
                           ,Publisher     ="Yeondam X DAON",Painter="chero",Author="JAEUNHYANG"
                           ,Introduction  ="因罕見疾病而死亡的公爵之女，阿黛兒成了她的替身，雖然用盡一切努力想得到家人們的愛，卻還是於妹妹一出生時就遭到拋棄，在前往政治聯姻的路途中被不明的刺客暗殺。「...難道這是夢?」但在她睜開眼後，卻發現自己回到了3年前!想著反正只要妹妹一出生就會遭到拋棄的自己，阿黛兒決定這次的人生要操之在己，可惜依舊不斷遭遇苦難。「難道您不是對我有興趣嗎?」再加上一個身分不明的黑色騎士老是接近她..."
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656597726/JustLeaveMe/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656597781/JustLeaveMe/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=1},


                new Comic {ComicChineseName="千金大廚來上菜",ComicEnglishName="LadyChefRoyale"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605055/LadyChefRoyale/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656591172/LadyChefRoyale/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656590985/LadyChefRoyale/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656590985/LadyChefRoyale/1.webp"
                           ,BgColor       ="#dd6b79",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,23),UpdateWeek=2
                           ,Publisher     ="Dreamtoon",Painter="PAYA",Author="Lysha"
                           ,Introduction  ="我原是一位小餐廳的廚師，卻成為了一個連皇帝都害怕的貴族家——他們家的受氣包小女兒。本想存一些錢，然後逃跑的...真是奇怪。「跟你說對不起，是一件丟臉的事嗎?」「是啊，因為我是妳哥哥。」「妳不和我這個爺爺去散步嗎?」大家為什麼突然間對我這麼好?「為什麼我想要把那些看妳的人的眼睛挖出來?」試圖逃跑的我以及緊緊抓住我的人，只是做了料理而已，為什麼會這樣...「愛死她的家人們 / 想逃跑的她 / 她專屬的僕人們」即將登場!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656591037/LadyChefRoyale/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656591103/LadyChefRoyale/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=3},
                
                 //29
                new Comic {ComicChineseName="交界地帶的動物醫院",ComicEnglishName="LegendaryBeastsAnimalHospital"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604897/LegendaryBeastsAnimalHospital/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594171/LegendaryBeastsAnimalHospital/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594113/LegendaryBeastsAnimalHospital/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594074/LegendaryBeastsAnimalHospital/1.webp"
                           ,BgColor       ="#786769",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2022,7,15),UpdateWeek=2
                           ,Publisher     ="CONTENTSLABBLUE",Painter="Choi-Palho",Author="Ecira"
                           ,Introduction  ="空無一人的動物醫院獸醫竟搖身一變成為神獸的名醫!負債累累的動物醫院院長——金亞瑛，某天接到一通電話...「你們有在替爬蟲類看診嗎?」為了生計的她只好咬牙接客。「呃...龍也是爬蟲類，對吧?」沒想到來的竟然是一隻青龍!心驚膽顫地治療完青龍之後牠居然幫亞瑛動物醫院大肆宣傳，使得神獸病人不斷上門。但恐懼也只是一時的，當亞瑛收到那些不諳世事的神獸所給的豐厚報酬時...「怪物?青龍?通通放馬過來!錢才是王道!」獸醫亞瑛於是毫不畏懼地開通靈眼，她能夠順利地治療這些特殊病患，再回歸她平靜的日常生活嗎?神獸診療記，開診!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=1},

                //30
                new Comic {ComicChineseName="與神共進",ComicEnglishName="LevelUpWithTheGods"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607981/LevelUpWithTheGods/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656591446/LevelUpWithTheGods/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656591381/LevelUpWithTheGods/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656591257/LevelUpWithTheGods/1.webp"
                           ,BgColor       ="#121212",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,14),UpdateWeek=2
                           ,Publisher     ="D&C WEBTOON Biz",Painter="Ohyeon",Author="B. Ain"
                           ,Introduction  ="異世界的神——外神(Outer God)封鎖天際的絕望、深陷沼澤的挫折、無法降生者，以及愚昧的混沌...普通人即使只是多看一眼都會丟掉性命的存在們正在控制著這個世界...經過數年的戰爭後，最後的倖存者們得出了一個結論。「內神(Inner)永遠都打不過外神(Outer)。」此刻，掌控時間的神明克洛諾斯透過犧牲自己啟動了時間的發條。「沒錯，至少現在...你們確實打不過他們。」「回到原先的世界線去，然後重新開始吧。」這時候，有一個人被眾神指定為最終候選人並回到了過去。他就是最後一個爬上塔，直到最後都在與神戰鬥的人類——金宥元。「內神(Inner)永遠都打不過外神(Outer)，那麼...」「最後的勝利者就是我。」他能否召集一起奮戰到最後的夥伴，並且在與外神(Outer)的戰鬥中取得勝利呢?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=3},

                new Comic {ComicChineseName="魔彈射手",ComicEnglishName="MadanNoShashu"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608240/MadanNoShashu/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582317/MadanNoShashu/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582133/MadanNoShashu/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582133/MadanNoShashu/1.webp"
                           ,BgColor       ="#060b28",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,13),UpdateWeek=2
                           ,Publisher     ="intime",Painter="GLPI",Author="Respect"
                           ,Introduction  ="「何中士，你又全中了啊!」即將成為軍官的神射手，何里夏中士，因一起意外事故，導致下半身癱瘓，成為了一個被世界遺棄的孤兒。在陷入絕望之際，虛擬實境遊戲「米德爾斯」橫空出世，賦予了他嶄新的人生。而在「米德爾斯」裡賺取的錢財，竟然可以成為現實世界中的財產!但因一開始的失誤，何里夏選擇了能力值最低的角色。眼看他就要被當成沙包打了!「我和你們不一樣，我已經無路可退了!」用火藥、鋼珠、推彈杆，讓你們看看什麼是真正的神槍手!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656582250/MadanNoShashu/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=3},

                new Comic {ComicChineseName="女俠當家",ComicEnglishName="MasterVillainessTheInvincible"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605317/MasterVillainessTheInvincible/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594548/MasterVillainessTheInvincible/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594300/MasterVillainessTheInvincible/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594266/MasterVillainessTheInvincible/1.webp"
                           ,BgColor       ="#575a6f",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2022,7,20),UpdateWeek=2
                           ,Publisher     ="Polarfox",Painter="Yooani",Author="Will Bright"
                           ,Introduction  ="「不但不是主角，還偏偏是書裡最惡毒的女人...」為了擺脫租屋生活而開始閱讀武俠小說《南宮世家少主》，卻穿越成為了小說裡最惡毒的女人——唐海媛。唐海媛這個天下第一惡女為了得到欽慕的男人，不惜毒殺思慕之人的情人、挑撥武林高手們、成為魔教的走狗並導致武林動盪。「絕不能和原本的故事內容一樣，白白送死!!」偶然吃了萬年參而變成小說世界裡的最強者，武俠小說最強惡女「唐海媛」的重生記!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656594393/MasterVillainessTheInvincible/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=3},


                new Comic {ComicChineseName="墨劍留香",ComicEnglishName="MookHyangDarkLady"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605276/MookHyangDarkLady/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582961/MookHyangDarkLady/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,BgColor       ="#1a0c19",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2022,7,20),UpdateWeek=2
                           ,Publisher     ="Polarfox",Painter="Yooani",Author="Will Bright"
                           ,Introduction  ="「不但不是主角，還偏偏是書裡最惡毒的女人...」為了擺脫租屋生活而開始閱讀武俠小說《南宮世家少主》，卻穿越成為了小說裡最惡毒的女人——唐海媛。唐海媛這個天下第一惡女為了得到欽慕的男人，不惜毒殺思慕之人的情人、挑撥武林高手們、成為魔教的走狗並導致武林動盪。「絕不能和原本的故事內容一樣，白白送死!!」偶然吃了萬年參而變成小說世界裡的最強者，武俠小說最強惡女「唐海媛」的重生記!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656594393/MasterVillainessTheInvincible/3.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656788146/MookHyangDarkLady/3MP4.mp4"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=3},


                //星期列表與作品頁
                //星期四(屬於星期二)

                //星期四(屬於星期二)有影片
                //34
                new Comic {ComicChineseName="短命媳婦的逃跑計畫",ComicEnglishName="ShortLivedDaughterInLaw'sEscapePlan"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656999779/ShortLivedDaughterInLaw%27sEscapePlan/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656999287/ShortLivedDaughterInLaw%27sEscapePlan/4.jpg"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1658203980/ShortLivedDaughterInLaw%27sEscapePlan/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1658203980/ShortLivedDaughterInLaw%27sEscapePlan/1.webp"
                           ,BgColor       ="#3a6052",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,13),UpdateWeek=2
                           ,Publisher     ="Yeondam",Painter="BASAK",Author="Yunajin"
                           ,Introduction  ="為什麼偏偏穿越到這種小說裡啊?!我就是小說中那位父母留下繁重債務後就死於事故，並且還注定在成年時便因病身亡的可憐少女——拉莉亞。這部小說的幕後黑手依卡勒德公爵為了欺瞞那些牽制自己的勢力，將我帶回家當他媳婦。我還是在偷偷存錢之後，找機會逃跑吧!可是治病的方法找到了、逃跑的資金也準備充足了...我的丈夫卻不知為何對我超執著?!他不是對誰都毫無感情的冷血之人嗎?而且我不是公公手上用完就丟的牌嗎?他為什麼會突然想救活我?!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656999981/ShortLivedDaughterInLaw%27sEscapePlan/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=3},

                //35
                new Comic {ComicChineseName="偉大的夙願",ComicEnglishName="TheGreatWish"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656606723/TheGreatWish/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587434/TheGreatWish/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587082/TheGreatWish/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587082/TheGreatWish/1.webp"
                           ,BgColor       ="#11242e",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,13),UpdateWeek=2
                           ,Publisher     ="Dreamtoon",Painter="Skye",Author="Skye"
                           ,Introduction  ="詩埃娜．阿爾傑特是神聖帝國唯一的皇女，從出生那一刻起便擁有了一切，智慧、美貌、才能，甚至是皇位繼承人的身分，無所不有。二十歲生日前夕，她開始夢見數十年後的自己，並認為這是神賜予她的預知能力而雀躍不已，為此向神致上謝意。但是在夢中預見的未來愈來愈奇怪，跟詩埃娜憧憬的未來大相逕庭。過去視為半吊子而瞧不起的同父異母兄長，展開了反擊；曾經以為會永遠站在自己這一方的母親，露出了隱藏的面目；還有，無論在現實或夢境中，都帶給詩埃娜巨大影響的男人，出現在眼前...詩埃娜周遭的一切，急速發生巨變，而她身上，也逐漸產生變化。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656587202/TheGreatWish/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656587373/TheGreatWish/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=3},
                //36
                new Comic {ComicChineseName="魔咒情人",ComicEnglishName="TheJinx'sLover"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608208/TheJinx%27sLover/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588311/TheJinx%27sLover/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588126/TheJinx%27sLover/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588126/TheJinx%27sLover/1.webp"
                           ,BgColor       ="#ab9a9f",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,13),UpdateWeek=2
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Koo seul",Author="Koo seul"
                           ,Introduction  ="被有錢人家藏匿的幸運女神來到了窮困潦倒又倒楣透頂的我身邊。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656588228/TheJinx%27sLover/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=3},
                //37
                new Comic {ComicChineseName="英雄大人滿級回歸",ComicEnglishName="TheMaxLeveHeroStrikesBack"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608010/TheMaxLeveHeroStrikesBack/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574093/TheMaxLeveHeroStrikesBack/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656573894/TheMaxLeveHeroStrikesBack/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656573894/TheMaxLeveHeroStrikesBack/1.webp"
                           ,BgColor       ="#394b78",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,13),UpdateWeek=2
                           ,Publisher     ="golemfactory",Painter="Yudo",Author="Devil's tail"
                           ,Introduction  ="無權無勢、被打入冷宮的王子戴伊比，在他陷入昏迷後靈魂出竅，來到了充滿各個英雄之靈的巨大迴廊。經過千年的洗禮，他成為滿級的英雄大人回歸了!所有人，給我等著吧，我一定會給你們好看!戴伊比的復仇記和宮廷生活，即將開始!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656574015/TheMaxLeveHeroStrikesBack/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=3},
                //38
                new Comic {ComicChineseName="永恆世界歸還者",ComicEnglishName="TheMaxLevelReturner"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607372/TheMaxLevelReturner/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593728/TheMaxLevelReturner/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593513/TheMaxLevelReturner/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593513/TheMaxLevelReturner/1.webp"
                           ,BgColor       ="#273961",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,13),UpdateWeek=2
                           ,Publisher     ="golemfactory",Painter="Vertwo",Author="Honey"
                           ,Introduction  ="全世界有1億2千萬人消失了。「開始執行完成最終任務的獎勵『回歸』。」睽違22年，尹尚赫結束了一場最爛的生存遊戲。被稱為一人軍團、最強玩家的他，帶著任何人都沒能得到的獎勵回歸了。「假面君主，回歸。」我獨自滿等、獨自通關、獨自暗爽!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656593634/TheMaxLevelReturner/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=3},
                //39
                new Comic {ComicChineseName="皇女殿下的娃娃屋",ComicEnglishName="ThePrincess'sDollShop"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607589/ThePrincess%27sDollShop/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594895/ThePrincess%27sDollShop/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594840/ThePrincess%27sDollShop/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594677/ThePrincess%27sDollShop/1.webp"
                           ,BgColor       ="#4894d4",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,13),UpdateWeek=2
                           ,Publisher     ="DAON STUDIO",Painter="POMPOMMELO",Author="On Uyeon"
                           ,Introduction  ="「我只是有個小小的心願想出宮去完成。」「......出宮嗎?」戴恩莫名欲言又止，似乎比剛才卡希雅跟他要一個國家時反應更大。因為心願即將實現而雀躍不已的卡希雅並沒有發現戴恩的不對勁，反而用閃閃發亮的眼神逼迫戴恩繼續問她詳情。「妳的心願是什麼呢?」結果戴恩一提問，論美貌在當今帝國大概無人能及的女孩嫣然一笑，大聲說道：「我想開娃娃屋!」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=3},
                //40
                new Comic {ComicChineseName="我在馴服暴君後落跑了",ComicEnglishName="TheTamingOfTheTyrant"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607049/TheTamingOfTheTyrant/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582603/TheTamingOfTheTyrant/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582513/TheTamingOfTheTyrant/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582408/TheTamingOfTheTyrant/1.webp"
                           ,BgColor       ="#422786",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,13),UpdateWeek=2
                           ,Publisher     ="DAON STUDIO",Painter="Melting",Author="yusoy"
                           ,Introduction  ="神給了我第二次機會，讓我回到四百年前。回到過去的我下定決心要徹底摧毀這個帝國， 「沒有任何一位國民，會以帝國為傲。」為了達成復仇計畫，我決定將天才皇子親手調教為暴君。「一切都將如妳所願。」他為我吞噬了整個帝國，而實現目標的我拋下了他，遠走高飛。幾年後，迪倫成了完美的暴君。我卻不知他居然為了找我，尋遍帝國上下。「為何馴服我之後就跑了?」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=3},

                new Comic {ComicChineseName="體弱惡女的幸福任務",ComicEnglishName="TheVillainess'sDaysAreNumbered"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608168/TheVillainess%27sDaysAreNumbered/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593336/TheVillainess%27sDaysAreNumbered/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593185/TheVillainess%27sDaysAreNumbered/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593096/TheVillainess%27sDaysAreNumbered/1.webp"
                           ,BgColor       ="#141f40",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,13),UpdateWeek=2
                           ,Publisher     ="Mstoryhub",Painter="Salmon",Author="HARASYO"
                           ,Introduction  ="「你只要和我度過6個月的契約婚姻生活，我就把家族的所有財產全部給你!」轉世為世界觀中最強的惡女，竟然得和冷漠無情的他度過幸福的婚姻生活?!在意外中死去後，我成了這世界裡最強的惡女「克萊亞」。雖然魔王答應要送我回原本的世界，但條件是必須和艾薩克．迪特羅伊大公度過幸福的婚姻生活。可是...第一，艾薩克．迪特羅伊大公討厭我。第二，我的身體虛弱得像隻翻車魚。走一步就會被扣生命值1點，而生命值一旦下降1/3就會開始咳血。我真的能以這副身體，展現幸福的婚姻生活給魔王看嗎?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=3},

                new Comic {ComicChineseName="星隕之地的守候",ComicEnglishName="WaitWhereTheShootingStarFalls"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607267/WaitWhereTheShootingStarFalls/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656589140/WaitWhereTheShootingStarFalls/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588444/WaitWhereTheShootingStarFalls/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588444/WaitWhereTheShootingStarFalls/1.webp"
                           ,BgColor       ="#171918",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,13),UpdateWeek=2
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Mr.General Store",Author="Mr.General Store"
                           ,Introduction  ="尋覓流星蹤跡的魔女與貓咪的故事。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656588686/WaitWhereTheShootingStarFalls/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=3},

                new Comic {ComicChineseName="不可告人戀愛情事",ComicEnglishName="WeeklyBoys'Romance"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656606634/WeeklyBoys%27Romance/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580011/WeeklyBoys%27Romance/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579975/WeeklyBoys%27Romance/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579914/WeeklyBoys%27Romance/1.webp"
                            ,BgColor       ="#38334d",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,13),UpdateWeek=2
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="See-in Park",Author="See-in Park"
                           ,Introduction  ="同住一個屋簷下的五位高中生，他們各自的「畸形愛情故事」，每週一與您相見。"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656580073/WeeklyBoys%27Romance/3.webm"
                           ,HotVideo = ""
                            ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=1},

                //44
                new Comic {ComicChineseName="忠犬的行動準則",ComicEnglishName="Woman'sBestFriend"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656606868/Woman%27sBestFriend/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656590842/Woman%27sBestFriend/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656589219/Woman%27sBestFriend/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656589219/Woman%27sBestFriend/1.webp"
                            ,BgColor       ="#e45850",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,13),UpdateWeek=2
                           ,Publisher     ="Dreamtoon",Painter="Dodam",Author="Hyun Sung Lee"
                           ,Introduction  ="在城云出版社裡，有個名為「瘋狗」的存在。他是徐禹俊，毫無變化的表情、沒有抑揚頓挫的語調、冰冷銳利的眼神，以及挑剔的個性是他的標誌。但是這男人，真的是瘋狗沒錯嗎?「別熄滅妳內在的光芒，也別輕易讓任何人熄滅它，妳可以再更有自信一點。」比起瘋狗，禹俊更像是忠犬般溫柔地對待泰齡，讓在情場上失利、工作不順，甚至連家庭都不溫暖的她怎麼也摸不著頭緒。該拿這個既像忠心的杜賓犬，又像可愛瑪爾濟斯的男人怎麼辦?時而輕柔、時而強烈地觸動人心的戀愛故事——《忠犬的行動準則》。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656589799/Woman%27sBestFriend/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656590753/Woman%27sBestFriend/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=3},


                //星期列表與作品頁
                //星期三

                //星期三有影片
                //45
                new Comic {ComicChineseName="今生我來當家主",ComicEnglishName="TodayIWillBeTheHeadOfTheHouse"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656998366/TodayIWillBeTheHeadOfTheHouse/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582961/MookHyangDarkLady/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,BgColor       ="#418ab3",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="D&C WEBTOON Biz",Painter="Mon(Antstudio)",Author="Kim Roah"
                           ,Introduction  ="「...就試試吧，由我來當家主。」我轉世成了帝國第一大家族——倫巴第家的私生女費蓮緹雅。這個家族不但富甲天下，而且從外交到文化無一不精，堪稱帝國歷史的象徵!含著金湯匙中的金湯匙出生，簡直太幸運了!還以為將來等著我的是康莊大道...沒想到父親過世後，我被親戚趕出家門，最後連曾經鼎鼎有名的家族都毀於一旦!!悲憤交加的我小酌(?)幾杯後走在回家的路上，居然還被馬車撞上!「這也太過分了吧...」含冤而死的我一睜開眼卻回到了七歲的時候?!光是親愛的父親出現在眼前就已經令人難以置信，我竟然還有機會拯救父親與家族?連重生前的家族仇人——二皇子都像隻大型犬似地成天追著我跑?!好吧，既然如此，二皇子和家族都是我的了!轉世加重生，面對第三次人生的費蓮緹雅，為了當上家主而展開行動!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656594393/MasterVillainessTheInvincible/3.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1657034039/TodayIWillBeTheHeadOfTheHouse/2.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=3},



                new Comic {ComicChineseName="我有三個暴君哥哥",ComicEnglishName="MyThreeTyrantBrothers"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607226/MyThreeTyrantBrothers/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582063/MyThreeTyrantBrothers/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656581853/MyThreeTyrantBrothers/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656581853/MyThreeTyrantBrothers/1.webp"
                           ,BgColor       ="#9fa925",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="DAON STUDIO",Painter="Parkha, Eun Du",Author="jomil​"
                           ,Introduction  ="我是個連名字都沒有的星期奴隸，代號「星期三」，當我因為反抗主人，性命不保的時候...「——終於找到妳了。」一夕之間多了三個哥哥，他們還說我是解除亞斯卡尼爾皇室詛咒的唯一鑰匙?!「妳一定要健健康康地長大，長到現在身上的衣服緊到再也穿不下，這是妳的第一項課題。」「別擔心，小不點。那些壞人，哥哥會幫妳狠狠教訓他們一頓。」「這孩子像隻小雞一樣，既嬌小又柔弱。我想要守護她，我會守護她。」被大家稱作暴君的哥哥們，怎麼只對我這麼溫柔!?從天而降的寵妹狂魔哥哥們和我的故事——《我有三個暴君哥哥》!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656581977/MyThreeTyrantBrothers/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=3},



                new Comic {ComicChineseName="廢墟中的皇女",ComicEnglishName="PrincessInTheRough"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605651/PrincessInTheRough/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577313/PrincessInTheRough/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576943/PrincessInTheRough/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576943/PrincessInTheRough/1.webp"
                           ,BgColor       ="#605342",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="Mstoryhub",Painter="HAERUA",Author="HARASYO"
                           ,Introduction  ="被皇帝遺忘的孩子，獨自一人生活在森林裡的廢棄城堡。「我討厭說謊的騙子，就算是一個人，我也可以過得好好的。」她經過漫長的等待，終於盼到皇帝來，但孩子的心扉早已緊緊關上了。「我來為妳取個名字。」「名字?」「艾斯特蕾拉，這就是妳的名字了...很抱歉讓妳久等了，孩子。」艾斯特蕾拉是一個擁有著特別能力的孩子，她的家人該如何療癒那顆破碎的心呢?"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656577015/PrincessInTheRough/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656577184/PrincessInTheRough/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=3},


                new Comic {ComicChineseName="小不點皇后",ComicEnglishName="OurLittleEmpress"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605394/OurLittleEmpress/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579483/OurLittleEmpress/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579407/OurLittleEmpress/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579370/OurLittleEmpress/1.webp"
                           ,BgColor       ="#434f4c",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="People&Story",Painter="Maryang",Author="Yusoi"
                           ,Introduction  ="預言之女是為拯救世界而誕生的。「若想拯救人類就必須結婚?那我願意!」要成為我丈夫的皇帝是一位年輕而單純的男孩，但...「我不會把女兒嫁給你!她不會成為皇后的。」 父親干涉了我的婚姻!「我妹妹是我的玩具。」就連哥哥也反對!我真的能夠拯救世界嗎?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=3},



                new Comic {ComicChineseName="婚禮復仇記",ComicEnglishName="RevengeWedding"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605358/RevengeWedding/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575576/RevengeWedding/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575339/RevengeWedding/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575339/RevengeWedding/1.webp"
                           ,BgColor       ="#28202b",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="DAON STUDIO",Painter="SaRyong​",Author="ByulSatangYang"
                           ,Introduction  ="集外貌、財富、地位於一身的完美女子——梅勒凱蒂亞．沙夏，暈倒後醒來發現自己位在一艘巨大的船上，身上還穿著婚紗。「蛤?我要結婚了嗎?是誰這麼大膽敢打我的主意?我一定要讓你打消結婚的念頭!」但沒想到...我的丈夫初次見面竟然就拿劍抵著我的脖子?他是帝國最偉大的戰爭英雄——戴枚德利奧．吉普洛沙。可是，他看起來一點都不像來結婚的啊?「我還想說是誰把我帶到這裡來的...只要殺了妳，我就可以回去了嗎?」「真是不好意思，我也是被綁架的好嗎?」我們兩人被綁架來結婚，甚至還要一起在無人島上求生存?!眼前的首要任務，就是逃出這座荒島!終極任務，要跟這個仇人離婚!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656575410/RevengeWedding/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656575490/RevengeWedding/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=3},



                new Comic {ComicChineseName="結了婚再說",ComicEnglishName="SaveItForTheHoneymoon"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607844/SaveItForTheHoneymoon/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579729/SaveItForTheHoneymoon/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579693/SaveItForTheHoneymoon/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579622/SaveItForTheHoneymoon/1.webp"
                           ,BgColor       ="#646a90",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,20),FinallyPublishDate= new DateTime(2021,8,15),UpdateWeek=3
                           ,Publisher     ="Feelyeon management",Painter="Bopamine",Author="Kangdalkong"
                           ,Introduction  ="莫雅是堅持這輩子不結婚的不婚主義者，然而某天，她卻意外一絲不掛地...和平時以冷酷嚴格出名的上司建厚裸裎相見。是說......那怎麼可能是人類的身材啊!面對建厚如藝術品般完美的身材，莫雅瞬間忘記羞愧，視線無法從他身上移開。自從看到建厚的完美裸體，莫雅出現了嚴重的後遺症——不論在哪裡、做什麼都會回想起建厚的赤身裸體。 深受困擾的莫雅在某個喝醉的夜晚，向建厚說出了爆炸性發言——「那個…組長，你要和我睡一次嗎？」在清醒狀態絕對無法說出口的告白，莫雅說出口的那一瞬間就後悔不已。不過，此時建厚居然說出了更震撼的回應—— 「很抱歉，我只會和結婚對象發生關係。」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=3},

                new Comic {ComicChineseName="SSS級死而復生的獵人",ComicEnglishName="SSS-ClassRevivalHunter"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604749/SSS-ClassRevivalHunter/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580517/SSS-ClassRevivalHunter/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580224/SSS-ClassRevivalHunter/1.png"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580224/SSS-ClassRevivalHunter/1.png"
                           ,BgColor       ="#1c1f26",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="Fansia",Painter="Bill K",Author="Sinnoa"
                           ,Introduction  ="身處F級底層的獵人「金孔子」長久以來一直羨慕著排行第一的獵人「炎帝」。某天，他竟突然獲得了S+級的技能。不料，短暫開心過後，他發現這個技能有些古怪?!「複製對方的其中一種技能」到這裡都還不錯...「什麼?竟然要我死了才能發動?!」重生獵人的人生樂章——《SSS級死而復生的獵人》"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656580385/SSS-ClassRevivalHunter/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656580450/SSS-ClassRevivalHunter/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=3},

                new Comic {ComicChineseName="侍女小姐想活命",ComicEnglishName="SurvivingAsAMaid"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604961/SurvivingAsAMaid/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577647/SurvivingAsAMaid/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577566/SurvivingAsAMaid/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577485/SurvivingAsAMaid/1.webp"
                           ,BgColor       ="#1d0000",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="CARROTOON",Painter="Hee-seo",Author="cloudwhale soap"
                           ,Introduction  ="只不過是煮著泡麵，下一秒睜開眼，竟發現自己進入國王、後宮、騎士、臣子、圖書管理員都是GAY的BL小說中，成為一名受到冷落的王妃的侍女。身為主角卻沒有任何BUFF加持的平凡侍女亞絲，究竟能不能平安活下去?《侍女小姐想活命》!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=3},

                new Comic {ComicChineseName="穆艾拉的調查官",ComicEnglishName="TheDetectiveOfMuiella"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607783/TheDetectiveOfMuiella/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656586950/TheDetectiveOfMuiella/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656586848/TheDetectiveOfMuiella/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656586761/TheDetectiveOfMuiella/1.webp"
                           ,BgColor       ="#435245",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="Dreamtoon",Painter="Ssol",Author="Kiarne"
                           ,Introduction  ="穆艾拉——排斥魔法師與魔女的國家。而凱特是一名在穆艾拉鄉村領地——亞拉納戴爾宅邸中工作的女傭。某日，戴爾男爵家新進一名可疑的新僕人——伊恩。伊恩有著與僕人身分格格不入的高大身形和俊美相貌，第一天就吸引了眾人目光，然而凱特卻不喜歡處處與自己作對的伊恩。另一方面，凱特工作的戴爾男爵家開始發生一連串詭譎的事件..."
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=1},

                new Comic {ComicChineseName="與惡魔共舞",ComicEnglishName="TheDevil'sTango"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607940/TheDevil%27sTango/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575227/TheDevil%27sTango/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575128/TheDevil%27sTango/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574814/TheDevil%27sTango/1.webp"
                           ,BgColor       ="#513b46",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="Polarfox",Painter="Chickenmeat",Author="Chickenmeat"
                           ,Introduction  ="「嗨，朋友!」跨越世紀只為找到「你」的惡魔，與無論「你」是不是惡魔，都想愛「你」的寂寞人類——邀您與三對人類♥惡魔情侶共舞!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=3},

                //55
                new Comic {ComicChineseName="繁花清風圓舞曲",ComicEnglishName="TheFlowerDancesAndTheWindSings"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607886/TheFlowerDancesAndTheWindSings/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578788/TheFlowerDancesAndTheWindSings/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578916/TheFlowerDancesAndTheWindSings/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578646/TheFlowerDancesAndTheWindSings/1.webp"
                           ,BgColor       ="#167a43",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="CARROTOON",Painter="Sang Hang",Author="lanella"
                           ,Introduction  ="埃爾塞拉原本過著令眾人羨慕不已的奢華生活，卻年紀輕輕就因病去世了。她這一生最後悔的事就是沒有成為一位好母親，可不知道為什麼，死後的她竟回到了3年前。於是重生後的埃爾塞拉決心這次要做一位溫柔稱職的母親。但一切還是太遲了嗎?「現在才做這些，只會讓我感到厭惡罷了。」兒子只是一味地抗拒她。而她也意識到了，自己重生前一直以為融洽的夫妻關係，其實也只是她的錯覺罷了..."
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=3},



                //星期列表與作品頁
                //星期一(屬於星期三)
                new Comic {

                            ComicChineseName="再次我的生活",ComicEnglishName="AgainMyLife"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604668/AgainMyLife/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656571331/AgainMyLife/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656570608/AgainMyLife/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656570608/AgainMyLife/1.webp"
                           ,BgColor       ="#1b2260",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="YJ Comics",Painter="SUN YONG MIN",Author="Lee hae nal"
                           ,Introduction  ="重生的熱血檢察官，審判絕對之惡!韓民國的熱血檢察官金熙宇，在調查凌駕於法律之上、玩弄著大韓民國的絕對權力者趙泰燮的貪汙案時，慘遭趙泰燮的同夥殺害並丟入海中。但金熙宇在黃泉路上遇見的陰間使者給了他重生的機會，於是他帶著前世的記憶回到了18歲的膽小鬼時期。重新變成高中生的熙宇利用前世得知的未來事件，開始為制裁趙泰燮做準備...!「比惡魔更過分的怪物才能抓到惡魔。」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656571157/AgainMyLife/2.webm"
                           ,HotVideo = ""
                           ,AuditType =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=3},


                new Comic {ComicChineseName="重生者的魔法一定要特別",ComicEnglishName="AReturner'sMagicShouldBeSpecial"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608088/AReturner%27sMagicShouldBeSpecial/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576416/AReturner%27sMagicShouldBeSpecial/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576348/AReturner%27sMagicShouldBeSpecial/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576218/AReturner%27sMagicShouldBeSpecial/1.webp"
                           ,BgColor       ="#402c3b",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="D&C WEBTOON Biz",Painter="Wookjakga",Author="Usonan"
                           ,Introduction  ="「既然已經回來了，就不能再次失去心愛的人們!」人類正面臨最可怕的災難——影之迷宮。戴基爾．阿曼德是迷宮裡最後的6名倖存者之一。他們試圖挑戰迷宮的最後關卡，然而卻以失敗告終，世界最終走向滅亡。當以為一切已經結束的那刻，戴基爾卻回到了13年前的過去?!當時的戴基爾正要進入帝國最強的魔法學院——赫布里溫學院就讀，並且與在迷宮中逝去的珍貴夥伴們重逢。為了拯救他心愛的人們與這個世界，他決心要改變過去...!距離影之世界出現的時間只剩3年了!快召集強悍的同伴一同拯救世界吧!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=3},


                new Comic {ComicChineseName="嗜血暴君的初戀",ComicEnglishName="ATyrant'sFirstLove"
                           ,ComicNameImage ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605209/ATyrant%27sFirstLove/5.png"
                           ,BgCover        ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576002/ATyrant%27sFirstLove/4.webp"
                           ,HotComicNameImage = ""
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://tw-a.kakaopagecdn.com/P/C/122/c2/2x/27658c20-605e-4c30-8b7f-0bcc44376857.webp"
                           ,ComicWeekFigure ="https://tw-a.kakaopagecdn.com/P/C/122/c2/2x/27658c20-605e-4c30-8b7f-0bcc44376857.webp"
                           ,BgColor       ="#310a0b",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="DAON STUDIO",Painter="CHIWA",Author="KIM SUO"
                           ,Introduction  ="喪失記憶的少女「迪雅」，原本在諾斯男爵府擔任女傭，日復一日地受盡折磨。沒想到，出了名殘酷的皇帝「凱勒」，竟在某天強行將迪雅帶至皇宮中，並詢問她認不認得自己。那天之後，迪雅便待在皇宮中，熟悉皇室的日常...某個月圓之夜，迪雅被一股神祕的力量牽引至城外，並撞見了渾身浴血的凱勒..."
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656575874/ATyrant%27sFirstLove/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656575948/ATyrant%27sFirstLove/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=1},

                //星期一(屬於星期三)有影片
                new Comic {ComicChineseName="留級玩家",ComicEnglishName="Recording Hall"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607506/ThePlayerWhoCan%27tLevelUp/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656581295/ThePlayerWhoCan%27tLevelUp/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580998/ThePlayerWhoCan%27tLevelUp/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657520006/ThePlayerWhoCan%27tLevelUp/9.webp"
                           ,BgColor       ="#351f29",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="DAON STUDIO",Painter="binu",Author="Siya"
                           ,Introduction  ="因為穿越進自己寫的小說，我成了欺負男主角的繼姐!別擔心，我一定會讓你變得幸福。因為這本小說的作者就是我!「我從來都沒把姐姐當成是我的家人。」雖然我覺得自己很認真在實踐讓男主角幸福的計畫，但為什麼他沒把我當成家人看呢?在他成為公爵前，我真的能順利活下來嗎?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656580720/ThePlayerWhoCan%27tLevelUp/1.webm"
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=3},

                new Comic {ComicChineseName="足跡消融之前",ComicEnglishName="BeforeFootprintAblation"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608041/BeforeFootprintAblation/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656599274/BeforeFootprintAblation/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656598550/BeforeFootprintAblation/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656598550/BeforeFootprintAblation/1.webp"
                           ,BgColor       ="##9b8263",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Tess",Author="Tess"
                           ,Introduction  ="在假想的朝鮮時代，因世間種種而懷抱傷痛的人們交織而成的愛情故事。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656598837/BeforeFootprintAblation/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},
                //改字
                new Comic {ComicChineseName="凜冬暗夜",ComicEnglishName="BlackWinter"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605020/BlackWinter/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587899/BlackWinter/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587574/BlackWinter/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587574/BlackWinter/1.webp"
                           ,BgColor       ="#1a151e",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Tess",Author="Tess"
                           ,Introduction  ="在假想的朝鮮時代，因世間種種而懷抱傷痛的人們交織而成的愛情故事。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656587749/BlackWinter/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=3},

                new Comic {ComicChineseName="春日咖啡館",ComicEnglishName="Bom'sExpresso"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607321/Bom%27sExpresso/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579291/Bom%27sExpresso/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579187/Bom%27sExpresso/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579075/Bom%27sExpresso/1.webp"
                           ,BgColor       ="#646661",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3

                           ,Publisher     ="CARROTOON",Painter="Dolcenabi",Author="GwonDohee"
                           ,Introduction  ="結束經營9年的「春日咖啡館」，春率只好開始尋覓新的工作職缺。而求職時在因緣際會之下，春率成為了長相帥氣、實力高超卻非常難搞的Jake.K的助理，只是為什麼他看起來那麼眼熟...?春率的初次職場生活究竟能不能順利度過呢?「現在也差不多該想起來了吧?春日咖啡館、常客、高中生。」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=3},

                new Comic {ComicChineseName="戀人未滿",ComicEnglishName="CrushOnYou"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656606356/CrushOnYou/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656585204/CrushOnYou/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584929/CrushOnYou/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584858/CrushOnYou/1.webp"
                           ,BgColor       ="#695350",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="Comics family",Painter="gillzone",Author="gillzone"
                           ,Introduction  ="因為無法愛人，於是更加渴望愛情的武烈；愛意過於強烈，無法自拔的必浩；以及在兩個男人之間陷入兩難的敏希。是命運還是孽緣?答案不得而知。三人看似有結果卻又不然的三種暗戀——《戀人未滿》"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=3},

                new Comic {ComicChineseName="爸爸，請跟我結婚!",ComicEnglishName="DadPleaseMarryMe"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656784815/DadPleaseMarryMe/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656598156/DadPleaseMarryMe/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597992/DadPleaseMarryMe/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597992/DadPleaseMarryMe/1.webp"
                           ,BgColor       ="#2c3846",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="Yeondam X DAON",Painter="via",Author="dalseul"
                           ,Introduction  ="車禍之後睜眼一看，才發現自己身在喜歡的網路小說世界裡，而且還是在原著主角們出生前——他們的父母世代。為了阻止一連串的悲劇發生，原本是想保護懷孕的姐姐被綁架，沒想到卻代替她遭到綁架了?!被綁走已經夠悲慘了，還因為不適應魔力，導致隨時可能喪命。但是...只要待在綁匪皇帝身邊，便會恢復元氣!對了!要想拯救那個和惡女結婚又慘遭親生兒子殺害的男人，以及對魔力毫無抵抗力的自己...只能我們結婚了!「爸爸，請和我結婚!」「公主，我還未婚，也沒有子嗣，為什麼老是喊我爸爸...」敬請期待直直砸向鐵壁皇帝的甜蜜求婚計畫!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656598086/DadPleaseMarryMe/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=3},

                new Comic {ComicChineseName="琉璃之壁",ComicEnglishName="GlassBlock"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607414/GlassBlock/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574627/GlassBlock/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574474/GlassBlock/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574474/GlassBlock/1.webp"
                           ,BgColor       ="#283e36",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Joho",Author="Joho"
                           ,Introduction  ="富裕的貴族莉莉遇見他的那一刻，是一切的開端。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656574550/GlassBlock/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=3},
                //66
                new Comic {ComicChineseName="我想活下去",ComicEnglishName="I'mAllOutOfHealth"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607105/I%27mAllOutOfHealth/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593937/I%27mAllOutOfHealth/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593865/I%27mAllOutOfHealth/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593829/I%27mAllOutOfHealth/1.webp"
                           ,BgColor       ="#9b5975",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="Yeondam X Polarfox",Painter="Vanilla",Author="Lee Haron"
                           ,Introduction  ="穿越到被宣告今年冬天就會死掉的—— 最弱女配角「理涅娜」!別說運動了!就連散步、吃飯，只是待著都累到不行，這副脆弱的身體如同豆腐做成的玩偶，除此之外，還要擔心會被自己的爺爺暗殺。即使是這樣悲劇般的人生。「我!一定會變健康的!」。受到保護理涅娜的命令而出現在她身邊的「凱撒」。「您不會死的。暫時還不會。」還有...「天啊!主人竟然自己吃飯了!」雖然只有一點點進展，但我的身體確實漸漸好轉起來..."
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=3},






                //星期列表與作品頁
                //星期四

                //星期四有影片
                new Comic {ComicChineseName="短命媳婦的逃跑計畫",ComicEnglishName="ShortLivedDaughterInLaw'sEscapePlan"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656999779/ShortLivedDaughterInLaw%27sEscapePlan/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656999287/ShortLivedDaughterInLaw%27sEscapePlan/4.jpg"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1658203980/ShortLivedDaughterInLaw%27sEscapePlan/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1658203980/ShortLivedDaughterInLaw%27sEscapePlan/1.webp"
                           ,BgColor       ="#3a6052",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="Yeondam",Painter="BASAK",Author="Yunajin"
                           ,Introduction  ="為什麼偏偏穿越到這種小說裡啊?!我就是小說中那位父母留下繁重債務後就死於事故，並且還注定在成年時便因病身亡的可憐少女——拉莉亞。這部小說的幕後黑手依卡勒德公爵為了欺瞞那些牽制自己的勢力，將我帶回家當他媳婦。我還是在偷偷存錢之後，找機會逃跑吧!可是治病的方法找到了、逃跑的資金也準備充足了...我的丈夫卻不知為何對我超執著?!他不是對誰都毫無感情的冷血之人嗎?而且我不是公公手上用完就丟的牌嗎?他為什麼會突然想救活我?!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656999981/ShortLivedDaughterInLaw%27sEscapePlan/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=3},

                new Comic {ComicChineseName="偉大的夙願",ComicEnglishName="TheGreatWish"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656606723/TheGreatWish/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587434/TheGreatWish/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587082/TheGreatWish/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587082/TheGreatWish/1.webp"
                           ,BgColor       ="#11242e",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="Dreamtoon",Painter="Skye",Author="Skye"
                           ,Introduction  ="詩埃娜．阿爾傑特是神聖帝國唯一的皇女，從出生那一刻起便擁有了一切，智慧、美貌、才能，甚至是皇位繼承人的身分，無所不有。二十歲生日前夕，她開始夢見數十年後的自己，並認為這是神賜予她的預知能力而雀躍不已，為此向神致上謝意。但是在夢中預見的未來愈來愈奇怪，跟詩埃娜憧憬的未來大相逕庭。過去視為半吊子而瞧不起的同父異母兄長，展開了反擊；曾經以為會永遠站在自己這一方的母親，露出了隱藏的面目；還有，無論在現實或夢境中，都帶給詩埃娜巨大影響的男人，出現在眼前...詩埃娜周遭的一切，急速發生巨變，而她身上，也逐漸產生變化。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656587202/TheGreatWish/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656587373/TheGreatWish/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=3},

                new Comic {ComicChineseName="魔咒情人",ComicEnglishName="TheJinx'sLover"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608208/TheJinx%27sLover/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588311/TheJinx%27sLover/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588126/TheJinx%27sLover/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588126/TheJinx%27sLover/1.webp"
                           ,BgColor       ="#ab9a9f",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Koo seul",Author="Koo seul"
                           ,Introduction  ="被有錢人家藏匿的幸運女神來到了窮困潦倒又倒楣透頂的我身邊。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656588228/TheJinx%27sLover/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=3},

                new Comic {ComicChineseName="英雄大人滿級回歸",ComicEnglishName="TheMaxLeveHeroStrikesBack"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608010/TheMaxLeveHeroStrikesBack/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574093/TheMaxLeveHeroStrikesBack/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656573894/TheMaxLeveHeroStrikesBack/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656573894/TheMaxLeveHeroStrikesBack/1.webp"
                           ,BgColor       ="#394b78",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="golemfactory",Painter="Yudo",Author="Devil's tail"
                           ,Introduction  ="無權無勢、被打入冷宮的王子戴伊比，在他陷入昏迷後靈魂出竅，來到了充滿各個英雄之靈的巨大迴廊。經過千年的洗禮，他成為滿級的英雄大人回歸了!所有人，給我等著吧，我一定會給你們好看!戴伊比的復仇記和宮廷生活，即將開始!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656574015/TheMaxLeveHeroStrikesBack/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=3},

                new Comic {ComicChineseName="永恆世界歸還者",ComicEnglishName="TheMaxLevelReturner"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607372/TheMaxLevelReturner/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593728/TheMaxLevelReturner/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593513/TheMaxLevelReturner/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593513/TheMaxLevelReturner/1.webp"
                           ,BgColor       ="#273961",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="golemfactory",Painter="Vertwo",Author="Honey"
                           ,Introduction  ="全世界有1億2千萬人消失了。「開始執行完成最終任務的獎勵『回歸』。」睽違22年，尹尚赫結束了一場最爛的生存遊戲。被稱為一人軍團、最強玩家的他，帶著任何人都沒能得到的獎勵回歸了。「假面君主，回歸。」我獨自滿等、獨自通關、獨自暗爽!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656593634/TheMaxLevelReturner/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=3},

                new Comic {ComicChineseName="皇女殿下的娃娃屋",ComicEnglishName="ThePrincess'sDollShop"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607589/ThePrincess%27sDollShop/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594895/ThePrincess%27sDollShop/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594840/ThePrincess%27sDollShop/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594677/ThePrincess%27sDollShop/1.webp"
                           ,BgColor       ="#4894d4",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="DAON STUDIO",Painter="POMPOMMELO",Author="On Uyeon"
                           ,Introduction  ="「我只是有個小小的心願想出宮去完成。」「......出宮嗎?」戴恩莫名欲言又止，似乎比剛才卡希雅跟他要一個國家時反應更大。因為心願即將實現而雀躍不已的卡希雅並沒有發現戴恩的不對勁，反而用閃閃發亮的眼神逼迫戴恩繼續問她詳情。「妳的心願是什麼呢?」結果戴恩一提問，論美貌在當今帝國大概無人能及的女孩嫣然一笑，大聲說道：「我想開娃娃屋!」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=3},

                new Comic {ComicChineseName="我在馴服暴君後落跑了",ComicEnglishName="TheTamingOfTheTyrant"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607049/TheTamingOfTheTyrant/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582603/TheTamingOfTheTyrant/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582513/TheTamingOfTheTyrant/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582408/TheTamingOfTheTyrant/1.webp"
                           ,BgColor       ="#422786",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="DAON STUDIO",Painter="Melting",Author="yusoy"
                           ,Introduction  ="神給了我第二次機會，讓我回到四百年前。回到過去的我下定決心要徹底摧毀這個帝國， 「沒有任何一位國民，會以帝國為傲。」為了達成復仇計畫，我決定將天才皇子親手調教為暴君。「一切都將如妳所願。」他為我吞噬了整個帝國，而實現目標的我拋下了他，遠走高飛。幾年後，迪倫成了完美的暴君。我卻不知他居然為了找我，尋遍帝國上下。「為何馴服我之後就跑了?」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=3},

                new Comic {ComicChineseName="體弱惡女的幸福任務",ComicEnglishName="TheVillainess'sDaysAreNumbered"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608168/TheVillainess%27sDaysAreNumbered/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593336/TheVillainess%27sDaysAreNumbered/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593185/TheVillainess%27sDaysAreNumbered/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593096/TheVillainess%27sDaysAreNumbered/1.webp"
                           ,BgColor       ="#141f40",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="Mstoryhub",Painter="Salmon",Author="HARASYO"
                           ,Introduction  ="「你只要和我度過6個月的契約婚姻生活，我就把家族的所有財產全部給你!」轉世為世界觀中最強的惡女，竟然得和冷漠無情的他度過幸福的婚姻生活?!在意外中死去後，我成了這世界裡最強的惡女「克萊亞」。雖然魔王答應要送我回原本的世界，但條件是必須和艾薩克．迪特羅伊大公度過幸福的婚姻生活。可是...第一，艾薩克．迪特羅伊大公討厭我。第二，我的身體虛弱得像隻翻車魚。走一步就會被扣生命值1點，而生命值一旦下降1/3就會開始咳血。我真的能以這副身體，展現幸福的婚姻生活給魔王看嗎?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=3},

                new Comic {ComicChineseName="星隕之地的守候",ComicEnglishName="WaitWhereTheShootingStarFalls"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607267/WaitWhereTheShootingStarFalls/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656589140/WaitWhereTheShootingStarFalls/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588444/WaitWhereTheShootingStarFalls/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588444/WaitWhereTheShootingStarFalls/1.webp"
                           ,BgColor       ="#171918",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Mr.General Store",Author="Mr.General Store"
                           ,Introduction  ="尋覓流星蹤跡的魔女與貓咪的故事。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656588686/WaitWhereTheShootingStarFalls/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=3},

                new Comic {ComicChineseName="不可告人戀愛情事",ComicEnglishName="WeeklyBoys'Romance"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656606634/WeeklyBoys%27Romance/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580011/WeeklyBoys%27Romance/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579975/WeeklyBoys%27Romance/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579914/WeeklyBoys%27Romance/1.webp"
                            ,BgColor       ="#38334d",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="See-in Park",Author="See-in Park"
                           ,Introduction  ="同住一個屋簷下的五位高中生，他們各自的「畸形愛情故事」，每週一與您相見。"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656580073/WeeklyBoys%27Romance/3.webm"
                           ,HotVideo = ""
                            ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=1},

                //77
                new Comic {ComicChineseName="忠犬的行動準則",ComicEnglishName="Woman'sBestFriend"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656606868/Woman%27sBestFriend/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656590842/Woman%27sBestFriend/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656589219/Woman%27sBestFriend/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656589219/Woman%27sBestFriend/1.webp"
                            ,BgColor       ="#e45850",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="Dreamtoon",Painter="Dodam",Author="Hyun Sung Lee"
                           ,Introduction  ="在城云出版社裡，有個名為「瘋狗」的存在。他是徐禹俊，毫無變化的表情、沒有抑揚頓挫的語調、冰冷銳利的眼神，以及挑剔的個性是他的標誌。但是這男人，真的是瘋狗沒錯嗎?「別熄滅妳內在的光芒，也別輕易讓任何人熄滅它，妳可以再更有自信一點。」比起瘋狗，禹俊更像是忠犬般溫柔地對待泰齡，讓在情場上失利、工作不順，甚至連家庭都不溫暖的她怎麼也摸不著頭緒。該拿這個既像忠心的杜賓犬，又像可愛瑪爾濟斯的男人怎麼辦?時而輕柔、時而強烈地觸動人心的戀愛故事——《忠犬的行動準則》。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656589799/Woman%27sBestFriend/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656590753/Woman%27sBestFriend/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=3},



                //星期列表與作品頁
                //星期二(屬於星期四)

                //星期二(屬於星期四)有影片
                //
                new Comic {ComicChineseName="盜墓王",ComicEnglishName="TombRaiderKing"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607700/TombRaiderKing/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656572963/TombRaiderKing/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657520466/TombRaiderKing/9.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657520466/TombRaiderKing/9.webp"
                           ,BgColor       ="#575a6f",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="Polarfox",Painter="Yooani",Author="Will Bright"
                           ,Introduction  ="「不但不是主角，還偏偏是書裡最惡毒的女人...」為了擺脫租屋生活而開始閱讀武俠小說《南宮世家少主》，卻穿越成為了小說裡最惡毒的女人——唐海媛。唐海媛這個天下第一惡女為了得到欽慕的男人，不惜毒殺思慕之人的情人、挑撥武林高手們、成為魔教的走狗並導致武林動盪。「絕不能和原本的故事內容一樣，白白送死!!」偶然吃了萬年參而變成小說世界裡的最強者，武俠小說最強惡女「唐海媛」的重生記!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656572710/TombRaiderKing/1.webm"
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656572903/TombRaiderKing/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=3},

                new Comic {ComicChineseName="我成了反派的繼母",ComicEnglishName="IBecameTheVillain'sMother"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607155/IBecameTheVillain%27sMother/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584749/IBecameTheVillain%27sMother/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584432/IBecameTheVillain%27sMother/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584432/IBecameTheVillain%27sMother/1.webp"
                           ,BgColor       ="#225040",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="DAON STUDIO",Painter="Iro",Author="Yulji"
                           ,Introduction  ="我成了小說裡最終的反派角色「艾因斯潘納」的繼母。而且還是小時候虐待他，長大後第一個被他殺害的壞心繼母。在我思考該如何逃離這悲慘命運時，仍一無所知、天真無邪的未來反派潛力股映入眼簾，但是...「等等，這孩子就連胖嘟嘟的小手都這麼可愛!誰捨得虐待他啊!」在我眼前的是個和反派完全沾不上邊的可愛小孩。好，我決定了，交給我吧!我會守護你!所以長大後拜託饒我一命吧!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656584573/IBecameTheVillain%27sMother/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656584694/IBecameTheVillain%27sMother/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,22),ComicStatus=3},
                //80
                new Comic {ComicChineseName="目標是成為長命百歲的千金大小姐",ComicEnglishName="IDreamOfHealthWealthAndALongLife"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607743/IDreamOfHealthWealthAndALongLife/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577934/IDreamOfHealthWealthAndALongLife/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577876/IDreamOfHealthWealthAndALongLife/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577753/IDreamOfHealthWealthAndALongLife/1.webp"
                           ,BgColor       ="#3b3f0e",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="intime",Painter="GalaxyJellyfish",Author="Cheong Song-A"
                           ,Introduction  ="「好不容易含著金湯匙出生，居然要慘遭殺害?我一定要生存下來，並且長命百歲!」雖然轉生成了喜歡的小說中男主角的妹妹，卻註定會在十七歲時被繼母投毒殺害。哥哥正在和女主角一起冒險，我必須自己想辦法活下去...!我對這個世界非常了解，書裡的眾多角色當中肯定有能幫助我的人!我，阿德莉安娜計畫擺脫慘死的命運，並成為千金大小姐過上好日子，而此時帝國的皇子、可疑的商行主人，還有更可疑的魔族開始接近我了!沒錯，我不能就這樣乖乖等死!我要活下來!「因為我的目標是成為長命百歲的千金大小姐!!」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=3},

                new Comic {ComicChineseName="原來都是誤會一場",ComicEnglishName="ItWasAllAMistake"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605156/ItWasAllAMistake/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578279/ItWasAllAMistake/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578176/ItWasAllAMistake/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578102/ItWasAllAMistake/1.webp"
                           ,BgColor       ="#191a2e",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="Dasan Books",Painter="MIM",Author="G-ANNE"
                           ,Introduction  ="我轉世到書裡，變成了凡洛斯家的二女兒度露雅，在回顧書中的內容時，些部分的記憶出了差錯。度露雅是小說中嫉妒女主角艾莉絲的惡女，並被男主角諾頓以火刑處死。為了活下去，度露雅刻意接近諾頓．埃德加，但不知怎麼回事，諾頓是個疑心非常重的人。即使度露雅想盡辦法接近他，諾頓仍不停考驗她存在的價值。「凡洛斯，再來玩吧。」儘管如此，諾頓還是很希望度露雅能夠留在自己身旁...「諾頓．埃德加是個非常惡毒的壞人!」本來應該在那段時間，和男主角好好相處的女主角艾莉絲．里莫蘭特，卻叫度露雅避開諾頓。「要與我結婚嗎?」度露雅甚至與男二亞倫．克萊莫爾訂了婚。在這一片無法預知未來的混亂中，度露雅究竟能否擺脫原作結局，守護自己?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=1},

                new Comic {ComicChineseName="就離開我吧",ComicEnglishName="JustLeaveMe"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605448/JustLeaveMe/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597845/JustLeaveMe/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597626/JustLeaveMe/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597626/JustLeaveMe/1.webp"
                           ,BgColor       ="#121212",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="Yeondam X DAON",Painter="chero",Author="JAEUNHYANG"
                           ,Introduction  ="因罕見疾病而死亡的公爵之女，阿黛兒成了她的替身，雖然用盡一切努力想得到家人們的愛，卻還是於妹妹一出生時就遭到拋棄，在前往政治聯姻的路途中被不明的刺客暗殺。「...難道這是夢?」但在她睜開眼後，卻發現自己回到了3年前!想著反正只要妹妹一出生就會遭到拋棄的自己，阿黛兒決定這次的人生要操之在己，可惜依舊不斷遭遇苦難。「難道您不是對我有興趣嗎?」再加上一個身分不明的黑色騎士老是接近她..."
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656597726/JustLeaveMe/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656597781/JustLeaveMe/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=1},

                new Comic {ComicChineseName="千金大廚來上菜",ComicEnglishName="LadyChefRoyale"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605055/LadyChefRoyale/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656591172/LadyChefRoyale/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656590985/LadyChefRoyale/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656590985/LadyChefRoyale/1.webp"
                           ,BgColor       ="#dd6b79",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="Dreamtoon",Painter="PAYA",Author="Lysha"
                           ,Introduction  ="我原是一位小餐廳的廚師，卻成為了一個連皇帝都害怕的貴族家——他們家的受氣包小女兒。本想存一些錢，然後逃跑的...真是奇怪。「跟你說對不起，是一件丟臉的事嗎?」「是啊，因為我是妳哥哥。」「妳不和我這個爺爺去散步嗎?」大家為什麼突然間對我這麼好?「為什麼我想要把那些看妳的人的眼睛挖出來?」試圖逃跑的我以及緊緊抓住我的人，只是做了料理而已，為什麼會這樣...「愛死她的家人們 / 想逃跑的她 / 她專屬的僕人們」即將登場!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656591037/LadyChefRoyale/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656591103/LadyChefRoyale/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=3},

                new Comic {ComicChineseName="交界地帶的動物醫院",ComicEnglishName="LegendaryBeastsAnimalHospital"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604897/LegendaryBeastsAnimalHospital/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594171/LegendaryBeastsAnimalHospital/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594113/LegendaryBeastsAnimalHospital/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594074/LegendaryBeastsAnimalHospital/1.webp"
                           ,BgColor       ="#786769",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="CONTENTSLABBLUE",Painter="Choi-Palho",Author="Ecira"
                           ,Introduction  ="空無一人的動物醫院獸醫竟搖身一變成為神獸的名醫!負債累累的動物醫院院長——金亞瑛，某天接到一通電話...「你們有在替爬蟲類看診嗎?」為了生計的她只好咬牙接客。「呃...龍也是爬蟲類，對吧?」沒想到來的竟然是一隻青龍!心驚膽顫地治療完青龍之後牠居然幫亞瑛動物醫院大肆宣傳，使得神獸病人不斷上門。但恐懼也只是一時的，當亞瑛收到那些不諳世事的神獸所給的豐厚報酬時...「怪物?青龍?通通放馬過來!錢才是王道!」獸醫亞瑛於是毫不畏懼地開通靈眼，她能夠順利地治療這些特殊病患，再回歸她平靜的日常生活嗎?神獸診療記，開診!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=1},
                //85
                new Comic {ComicChineseName="與神共進",ComicEnglishName="LevelUpWithTheGods"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607981/LevelUpWithTheGods/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656591446/LevelUpWithTheGods/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656591381/LevelUpWithTheGods/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656591257/LevelUpWithTheGods/1.webp"
                           ,BgColor       ="#121212",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="D&C WEBTOON Biz",Painter="Ohyeon",Author="B. Ain"
                           ,Introduction  ="異世界的神——外神(Outer God)封鎖天際的絕望、深陷沼澤的挫折、無法降生者，以及愚昧的混沌...普通人即使只是多看一眼都會丟掉性命的存在們正在控制著這個世界...經過數年的戰爭後，最後的倖存者們得出了一個結論。「內神(Inner)永遠都打不過外神(Outer)。」此刻，掌控時間的神明克洛諾斯透過犧牲自己啟動了時間的發條。「沒錯，至少現在...你們確實打不過他們。」「回到原先的世界線去，然後重新開始吧。」這時候，有一個人被眾神指定為最終候選人並回到了過去。他就是最後一個爬上塔，直到最後都在與神戰鬥的人類——金宥元。「內神(Inner)永遠都打不過外神(Outer)，那麼...」「最後的勝利者就是我。」他能否召集一起奮戰到最後的夥伴，並且在與外神(Outer)的戰鬥中取得勝利呢?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=3},

                new Comic {ComicChineseName="魔彈射手",ComicEnglishName="MadanNoShashu"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608240/MadanNoShashu/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582317/MadanNoShashu/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582133/MadanNoShashu/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582133/MadanNoShashu/1.webp"
                           ,BgColor       ="#060b28",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="intime",Painter="GLPI",Author="Respect"
                           ,Introduction  ="「何中士，你又全中了啊!」即將成為軍官的神射手，何里夏中士，因一起意外事故，導致下半身癱瘓，成為了一個被世界遺棄的孤兒。在陷入絕望之際，虛擬實境遊戲「米德爾斯」橫空出世，賦予了他嶄新的人生。而在「米德爾斯」裡賺取的錢財，竟然可以成為現實世界中的財產!但因一開始的失誤，何里夏選擇了能力值最低的角色。眼看他就要被當成沙包打了!「我和你們不一樣，我已經無路可退了!」用火藥、鋼珠、推彈杆，讓你們看看什麼是真正的神槍手!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656582250/MadanNoShashu/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=3},

                new Comic {ComicChineseName="女俠當家",ComicEnglishName="MasterVillainessTheInvincible"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605317/MasterVillainessTheInvincible/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594548/MasterVillainessTheInvincible/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594300/MasterVillainessTheInvincible/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594266/MasterVillainessTheInvincible/1.webp"
                           ,BgColor       ="#575a6f",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="Polarfox",Painter="Yooani",Author="Will Bright"
                           ,Introduction  ="「不但不是主角，還偏偏是書裡最惡毒的女人...」為了擺脫租屋生活而開始閱讀武俠小說《南宮世家少主》，卻穿越成為了小說裡最惡毒的女人——唐海媛。唐海媛這個天下第一惡女為了得到欽慕的男人，不惜毒殺思慕之人的情人、挑撥武林高手們、成為魔教的走狗並導致武林動盪。「絕不能和原本的故事內容一樣，白白送死!!」偶然吃了萬年參而變成小說世界裡的最強者，武俠小說最強惡女「唐海媛」的重生記!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656594393/MasterVillainessTheInvincible/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=3},

                //88
                new Comic {ComicChineseName="墨劍留香",ComicEnglishName="MookHyangDarkLady"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605276/MookHyangDarkLady/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582961/MookHyangDarkLady/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,BgColor       ="#1a0c19",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="Polarfox",Painter="Yooani",Author="Will Bright"
                           ,Introduction  ="「不但不是主角，還偏偏是書裡最惡毒的女人...」為了擺脫租屋生活而開始閱讀武俠小說《南宮世家少主》，卻穿越成為了小說裡最惡毒的女人——唐海媛。唐海媛這個天下第一惡女為了得到欽慕的男人，不惜毒殺思慕之人的情人、挑撥武林高手們、成為魔教的走狗並導致武林動盪。「絕不能和原本的故事內容一樣，白白送死!!」偶然吃了萬年參而變成小說世界裡的最強者，武俠小說最強惡女「唐海媛」的重生記!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656594393/MasterVillainessTheInvincible/3.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656788146/MookHyangDarkLady/3MP4.mp4"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=3},



                //星期列表與作品頁
                //星期五(星期一)
                new Comic {

                            ComicChineseName="再次我的生活",ComicEnglishName="AgainMyLife"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604668/AgainMyLife/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656571331/AgainMyLife/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656570608/AgainMyLife/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656570608/AgainMyLife/1.webp"
                           ,BgColor       ="#1b2260",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="YJ Comics",Painter="SUN YONG MIN",Author="Lee hae nal"
                           ,Introduction  ="重生的熱血檢察官，審判絕對之惡!韓民國的熱血檢察官金熙宇，在調查凌駕於法律之上、玩弄著大韓民國的絕對權力者趙泰燮的貪汙案時，慘遭趙泰燮的同夥殺害並丟入海中。但金熙宇在黃泉路上遇見的陰間使者給了他重生的機會，於是他帶著前世的記憶回到了18歲的膽小鬼時期。重新變成高中生的熙宇利用前世得知的未來事件，開始為制裁趙泰燮做準備...!「比惡魔更過分的怪物才能抓到惡魔。」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656571157/AgainMyLife/2.webm"
                           ,HotVideo = ""
                           ,AuditType =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=3},


                new Comic {ComicChineseName="重生者的魔法一定要特別",ComicEnglishName="AReturner'sMagicShouldBeSpecial"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608088/AReturner%27sMagicShouldBeSpecial/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576416/AReturner%27sMagicShouldBeSpecial/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576348/AReturner%27sMagicShouldBeSpecial/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576218/AReturner%27sMagicShouldBeSpecial/1.webp"
                           ,BgColor       ="#402c3b",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="D&C WEBTOON Biz",Painter="Wookjakga",Author="Usonan"
                           ,Introduction  ="「既然已經回來了，就不能再次失去心愛的人們!」人類正面臨最可怕的災難——影之迷宮。戴基爾．阿曼德是迷宮裡最後的6名倖存者之一。他們試圖挑戰迷宮的最後關卡，然而卻以失敗告終，世界最終走向滅亡。當以為一切已經結束的那刻，戴基爾卻回到了13年前的過去?!當時的戴基爾正要進入帝國最強的魔法學院——赫布里溫學院就讀，並且與在迷宮中逝去的珍貴夥伴們重逢。為了拯救他心愛的人們與這個世界，他決心要改變過去...!距離影之世界出現的時間只剩3年了!快召集強悍的同伴一同拯救世界吧!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=3},


                new Comic {ComicChineseName="嗜血暴君的初戀",ComicEnglishName="ATyrant'sFirstLove"
                           ,ComicNameImage ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605209/ATyrant%27sFirstLove/5.png"
                           ,BgCover        ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576002/ATyrant%27sFirstLove/4.webp"
                           ,HotComicNameImage = ""
                           ,HotBgCover = ""
                           ,ComicFigure ="https://tw-a.kakaopagecdn.com/P/C/122/c2/2x/27658c20-605e-4c30-8b7f-0bcc44376857.webp"
                           ,ComicWeekFigure ="https://tw-a.kakaopagecdn.com/P/C/122/c2/2x/27658c20-605e-4c30-8b7f-0bcc44376857.webp"
                           ,BgColor       ="#310a0b",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="DAON STUDIO",Painter="CHIWA",Author="KIM SUO"
                           ,Introduction  ="喪失記憶的少女「迪雅」，原本在諾斯男爵府擔任女傭，日復一日地受盡折磨。沒想到，出了名殘酷的皇帝「凱勒」，竟在某天強行將迪雅帶至皇宮中，並詢問她認不認得自己。那天之後，迪雅便待在皇宮中，熟悉皇室的日常...某個月圓之夜，迪雅被一股神祕的力量牽引至城外，並撞見了渾身浴血的凱勒..."
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656575874/ATyrant%27sFirstLove/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656575948/ATyrant%27sFirstLove/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=1},

                //星期五有影片(星期一)
                new Comic {ComicChineseName="留級玩家",ComicEnglishName="Recording Hall"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607506/ThePlayerWhoCan%27tLevelUp/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656581295/ThePlayerWhoCan%27tLevelUp/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580998/ThePlayerWhoCan%27tLevelUp/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657520006/ThePlayerWhoCan%27tLevelUp/9.webp"
                           ,BgColor       ="#351f29",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="DAON STUDIO",Painter="binu",Author="Siya"
                           ,Introduction  ="因為穿越進自己寫的小說，我成了欺負男主角的繼姐!別擔心，我一定會讓你變得幸福。因為這本小說的作者就是我!「我從來都沒把姐姐當成是我的家人。」雖然我覺得自己很認真在實踐讓男主角幸福的計畫，但為什麼他沒把我當成家人看呢?在他成為公爵前，我真的能順利活下來嗎?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656580720/ThePlayerWhoCan%27tLevelUp/1.webm"
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=3},

                new Comic {ComicChineseName="足跡消融之前",ComicEnglishName="BeforeFootprintAblation"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608041/BeforeFootprintAblation/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656599274/BeforeFootprintAblation/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656598550/BeforeFootprintAblation/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656598550/BeforeFootprintAblation/1.webp"
                           ,BgColor       ="#9b8263",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Tess",Author="Tess"
                           ,Introduction  ="在假想的朝鮮時代，因世間種種而懷抱傷痛的人們交織而成的愛情故事。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656598837/BeforeFootprintAblation/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=2},
                //改字
                new Comic {ComicChineseName="凜冬暗夜",ComicEnglishName="BlackWinter"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605020/BlackWinter/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587899/BlackWinter/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587574/BlackWinter/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587574/BlackWinter/1.webp"
                           ,BgColor       ="#1a151e",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Tess",Author="Tess"
                           ,Introduction  ="在假想的朝鮮時代，因世間種種而懷抱傷痛的人們交織而成的愛情故事。"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656587749/BlackWinter/2.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=3},

                new Comic {ComicChineseName="春日咖啡館",ComicEnglishName="Bom'sExpresso"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607321/Bom%27sExpresso/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579291/Bom%27sExpresso/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579187/Bom%27sExpresso/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579075/Bom%27sExpresso/1.webp"
                           ,BgColor       ="#646661",PublishDate=new DateTime(2021,10,30),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5

                           ,Publisher     ="CARROTOON",Painter="Dolcenabi",Author="GwonDohee"
                           ,Introduction  ="結束經營9年的「春日咖啡館」，春率只好開始尋覓新的工作職缺。而求職時在因緣際會之下，春率成為了長相帥氣、實力高超卻非常難搞的Jake.K的助理，只是為什麼他看起來那麼眼熟...?春率的初次職場生活究竟能不能順利度過呢?「現在也差不多該想起來了吧?春日咖啡館、常客、高中生。」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,30),ComicStatus=3},

                new Comic {ComicChineseName="戀人未滿",ComicEnglishName="CrushOnYou"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656606356/CrushOnYou/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656585204/CrushOnYou/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584929/CrushOnYou/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584858/CrushOnYou/1.webp"
                           ,BgColor       ="#695350",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="Comics family",Painter="gillzone",Author="gillzone"
                           ,Introduction  ="因為無法愛人，於是更加渴望愛情的武烈；愛意過於強烈，無法自拔的必浩；以及在兩個男人之間陷入兩難的敏希。是命運還是孽緣?答案不得而知。三人看似有結果卻又不然的三種暗戀——《戀人未滿》"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=3},

                new Comic {ComicChineseName="爸爸，請跟我結婚!",ComicEnglishName="DadPleaseMarryMe"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656784815/DadPleaseMarryMe/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656598156/DadPleaseMarryMe/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597992/DadPleaseMarryMe/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597992/DadPleaseMarryMe/1.webp"
                           ,BgColor       ="#2c3846",PublishDate=new DateTime(2021,10,30),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="Yeondam X DAON",Painter="via",Author="dalseul"
                           ,Introduction  ="車禍之後睜眼一看，才發現自己身在喜歡的網路小說世界裡，而且還是在原著主角們出生前——他們的父母世代。為了阻止一連串的悲劇發生，原本是想保護懷孕的姐姐被綁架，沒想到卻代替她遭到綁架了?!被綁走已經夠悲慘了，還因為不適應魔力，導致隨時可能喪命。但是...只要待在綁匪皇帝身邊，便會恢復元氣!對了!要想拯救那個和惡女結婚又慘遭親生兒子殺害的男人，以及對魔力毫無抵抗力的自己...只能我們結婚了!「爸爸，請和我結婚!」「公主，我還未婚，也沒有子嗣，為什麼老是喊我爸爸...」敬請期待直直砸向鐵壁皇帝的甜蜜求婚計畫!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656598086/DadPleaseMarryMe/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,30),ComicStatus=3},

                new Comic {ComicChineseName="琉璃之壁",ComicEnglishName="GlassBlock"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607414/GlassBlock/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574627/GlassBlock/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574474/GlassBlock/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574474/GlassBlock/1.webp"
                           ,BgColor       ="#283e36",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Joho",Author="Joho"
                           ,Introduction  ="富裕的貴族莉莉遇見他的那一刻，是一切的開端。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656574550/GlassBlock/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=3},
                //99
                new Comic {ComicChineseName="我想活下去",ComicEnglishName="I'mAllOutOfHealth"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607105/I%27mAllOutOfHealth/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593937/I%27mAllOutOfHealth/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593865/I%27mAllOutOfHealth/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593829/I%27mAllOutOfHealth/1.webp"
                           ,BgColor       ="#9b5975",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="Yeondam X Polarfox",Painter="Vanilla",Author="Lee Haron"
                           ,Introduction  ="穿越到被宣告今年冬天就會死掉的—— 最弱女配角「理涅娜」!別說運動了!就連散步、吃飯，只是待著都累到不行，這副脆弱的身體如同豆腐做成的玩偶，除此之外，還要擔心會被自己的爺爺暗殺。即使是這樣悲劇般的人生。「我!一定會變健康的!」。受到保護理涅娜的命令而出現在她身邊的「凱撒」。「您不會死的。暫時還不會。」還有...「天啊!主人竟然自己吃飯了!」雖然只有一點點進展，但我的身體確實漸漸好轉起來..."
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=3},


                //星期列表與作品頁
                //星期三(屬於星期五)

                //星期三(屬於星期五)有影片
                new Comic {ComicChineseName="今生我來當家主",ComicEnglishName="TodayIWillBeTheHeadOfTheHouse"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656998366/TodayIWillBeTheHeadOfTheHouse/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582961/MookHyangDarkLady/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,BgColor       ="#418ab3",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="D&C WEBTOON Biz",Painter="Mon(Antstudio)",Author="Kim Roah"
                           ,Introduction  ="「...就試試吧，由我來當家主。」我轉世成了帝國第一大家族——倫巴第家的私生女費蓮緹雅。這個家族不但富甲天下，而且從外交到文化無一不精，堪稱帝國歷史的象徵!含著金湯匙中的金湯匙出生，簡直太幸運了!還以為將來等著我的是康莊大道...沒想到父親過世後，我被親戚趕出家門，最後連曾經鼎鼎有名的家族都毀於一旦!!悲憤交加的我小酌(?)幾杯後走在回家的路上，居然還被馬車撞上!「這也太過分了吧...」含冤而死的我一睜開眼卻回到了七歲的時候?!光是親愛的父親出現在眼前就已經令人難以置信，我竟然還有機會拯救父親與家族?連重生前的家族仇人——二皇子都像隻大型犬似地成天追著我跑?!好吧，既然如此，二皇子和家族都是我的了!轉世加重生，面對第三次人生的費蓮緹雅，為了當上家主而展開行動!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656594393/MasterVillainessTheInvincible/3.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1657034039/TodayIWillBeTheHeadOfTheHouse/2.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=3},



                new Comic {ComicChineseName="我有三個暴君哥哥",ComicEnglishName="MyThreeTyrantBrothers"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607226/MyThreeTyrantBrothers/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582063/MyThreeTyrantBrothers/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656581853/MyThreeTyrantBrothers/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656581853/MyThreeTyrantBrothers/1.webp"
                           ,BgColor       ="#9fa925",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="DAON STUDIO",Painter="Parkha, Eun Du",Author="jomil​"
                           ,Introduction  ="我是個連名字都沒有的星期奴隸，代號「星期三」，當我因為反抗主人，性命不保的時候...「——終於找到妳了。」一夕之間多了三個哥哥，他們還說我是解除亞斯卡尼爾皇室詛咒的唯一鑰匙?!「妳一定要健健康康地長大，長到現在身上的衣服緊到再也穿不下，這是妳的第一項課題。」「別擔心，小不點。那些壞人，哥哥會幫妳狠狠教訓他們一頓。」「這孩子像隻小雞一樣，既嬌小又柔弱。我想要守護她，我會守護她。」被大家稱作暴君的哥哥們，怎麼只對我這麼溫柔!?從天而降的寵妹狂魔哥哥們和我的故事——《我有三個暴君哥哥》!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656581977/MyThreeTyrantBrothers/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=3},



                new Comic {ComicChineseName="廢墟中的皇女",ComicEnglishName="PrincessInTheRough"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605651/PrincessInTheRough/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577313/PrincessInTheRough/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576943/PrincessInTheRough/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576943/PrincessInTheRough/1.webp"
                           ,BgColor       ="#605342",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="Mstoryhub",Painter="HAERUA",Author="HARASYO"
                           ,Introduction  ="被皇帝遺忘的孩子，獨自一人生活在森林裡的廢棄城堡。「我討厭說謊的騙子，就算是一個人，我也可以過得好好的。」她經過漫長的等待，終於盼到皇帝來，但孩子的心扉早已緊緊關上了。「我來為妳取個名字。」「名字?」「艾斯特蕾拉，這就是妳的名字了...很抱歉讓妳久等了，孩子。」艾斯特蕾拉是一個擁有著特別能力的孩子，她的家人該如何療癒那顆破碎的心呢?"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656577015/PrincessInTheRough/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656577184/PrincessInTheRough/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=3},


                new Comic {ComicChineseName="小不點皇后",ComicEnglishName="OurLittleEmpress"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605394/OurLittleEmpress/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579483/OurLittleEmpress/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579407/OurLittleEmpress/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579370/OurLittleEmpress/1.webp"
                           ,BgColor       ="#434f4c",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="People&Story",Painter="Maryang",Author="Yusoi"
                           ,Introduction  ="預言之女是為拯救世界而誕生的。「若想拯救人類就必須結婚?那我願意!」要成為我丈夫的皇帝是一位年輕而單純的男孩，但...「我不會把女兒嫁給你!她不會成為皇后的。」 父親干涉了我的婚姻!「我妹妹是我的玩具。」就連哥哥也反對!我真的能夠拯救世界嗎?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=3},


                new Comic {ComicChineseName="婚禮復仇記",ComicEnglishName="RevengeWedding"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605358/RevengeWedding/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575576/RevengeWedding/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575339/RevengeWedding/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575339/RevengeWedding/1.webp"
                           ,BgColor       ="#28202b",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="DAON STUDIO",Painter="SaRyong​",Author="ByulSatangYang"
                           ,Introduction  ="集外貌、財富、地位於一身的完美女子——梅勒凱蒂亞．沙夏，暈倒後醒來發現自己位在一艘巨大的船上，身上還穿著婚紗。「蛤?我要結婚了嗎?是誰這麼大膽敢打我的主意?我一定要讓你打消結婚的念頭!」但沒想到...我的丈夫初次見面竟然就拿劍抵著我的脖子?他是帝國最偉大的戰爭英雄——戴枚德利奧．吉普洛沙。可是，他看起來一點都不像來結婚的啊?「我還想說是誰把我帶到這裡來的...只要殺了妳，我就可以回去了嗎?」「真是不好意思，我也是被綁架的好嗎?」我們兩人被綁架來結婚，甚至還要一起在無人島上求生存?!眼前的首要任務，就是逃出這座荒島!終極任務，要跟這個仇人離婚!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656575410/RevengeWedding/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656575490/RevengeWedding/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=3},


                new Comic {ComicChineseName="結了婚再說",ComicEnglishName="SaveItForTheHoneymoon"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607844/SaveItForTheHoneymoon/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579729/SaveItForTheHoneymoon/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579693/SaveItForTheHoneymoon/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579622/SaveItForTheHoneymoon/1.webp"
                           ,BgColor       ="#646a90",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="Feelyeon management",Painter="Bopamine",Author="Kangdalkong"
                           ,Introduction  ="莫雅是堅持這輩子不結婚的不婚主義者，然而某天，她卻意外一絲不掛地...和平時以冷酷嚴格出名的上司建厚裸裎相見。是說......那怎麼可能是人類的身材啊!面對建厚如藝術品般完美的身材，莫雅瞬間忘記羞愧，視線無法從他身上移開。自從看到建厚的完美裸體，莫雅出現了嚴重的後遺症——不論在哪裡、做什麼都會回想起建厚的赤身裸體。 深受困擾的莫雅在某個喝醉的夜晚，向建厚說出了爆炸性發言——「那個…組長，你要和我睡一次嗎？」在清醒狀態絕對無法說出口的告白，莫雅說出口的那一瞬間就後悔不已。不過，此時建厚居然說出了更震撼的回應—— 「很抱歉，我只會和結婚對象發生關係。」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=3},

                new Comic {ComicChineseName="SSS級死而復生的獵人",ComicEnglishName="SSS-ClassRevivalHunter"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604749/SSS-ClassRevivalHunter/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580517/SSS-ClassRevivalHunter/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580224/SSS-ClassRevivalHunter/1.png"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580224/SSS-ClassRevivalHunter/1.png"
                           ,BgColor       ="#1c1f26",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="Fansia",Painter="Bill K",Author="Sinnoa"
                           ,Introduction  ="身處F級底層的獵人「金孔子」長久以來一直羨慕著排行第一的獵人「炎帝」。某天，他竟突然獲得了S+級的技能。不料，短暫開心過後，他發現這個技能有些古怪?!「複製對方的其中一種技能」到這裡都還不錯...「什麼?竟然要我死了才能發動?!」重生獵人的人生樂章——《SSS級死而復生的獵人》"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656580385/SSS-ClassRevivalHunter/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656580450/SSS-ClassRevivalHunter/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=3},

                new Comic {ComicChineseName="侍女小姐想活命",ComicEnglishName="SurvivingAsAMaid"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604961/SurvivingAsAMaid/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577647/SurvivingAsAMaid/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577566/SurvivingAsAMaid/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577485/SurvivingAsAMaid/1.webp"
                           ,BgColor       ="#1d0000",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="CARROTOON",Painter="Hee-seo",Author="cloudwhale soap"
                           ,Introduction  ="只不過是煮著泡麵，下一秒睜開眼，竟發現自己進入國王、後宮、騎士、臣子、圖書管理員都是GAY的BL小說中，成為一名受到冷落的王妃的侍女。身為主角卻沒有任何BUFF加持的平凡侍女亞絲，究竟能不能平安活下去?《侍女小姐想活命》!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=3},

                new Comic {ComicChineseName="穆艾拉的調查官",ComicEnglishName="TheDetectiveOfMuiella"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607783/TheDetectiveOfMuiella/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656586950/TheDetectiveOfMuiella/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656586848/TheDetectiveOfMuiella/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656586761/TheDetectiveOfMuiella/1.webp"
                           ,BgColor       ="#435245",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="Dreamtoon",Painter="Ssol",Author="Kiarne"
                           ,Introduction  ="穆艾拉——排斥魔法師與魔女的國家。而凱特是一名在穆艾拉鄉村領地——亞拉納戴爾宅邸中工作的女傭。某日，戴爾男爵家新進一名可疑的新僕人——伊恩。伊恩有著與僕人身分格格不入的高大身形和俊美相貌，第一天就吸引了眾人目光，然而凱特卻不喜歡處處與自己作對的伊恩。另一方面，凱特工作的戴爾男爵家開始發生一連串詭譎的事件..."
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=1},

                new Comic {ComicChineseName="與惡魔共舞",ComicEnglishName="TheDevil'sTango"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607940/TheDevil%27sTango/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575227/TheDevil%27sTango/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575128/TheDevil%27sTango/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574814/TheDevil%27sTango/1.webp"
                           ,BgColor       ="#513b46",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="Polarfox",Painter="Chickenmeat",Author="Chickenmeat"
                           ,Introduction  ="「嗨，朋友!」跨越世紀只為找到「你」的惡魔，與無論「你」是不是惡魔，都想愛「你」的寂寞人類——邀您與三對人類♥惡魔情侶共舞!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=3},

                //110
                new Comic {ComicChineseName="繁花清風圓舞曲",ComicEnglishName="TheFlowerDancesAndTheWindSings"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607886/TheFlowerDancesAndTheWindSings/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578788/TheFlowerDancesAndTheWindSings/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578916/TheFlowerDancesAndTheWindSings/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578646/TheFlowerDancesAndTheWindSings/1.webp"
                           ,BgColor       ="#167a43",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="CARROTOON",Painter="Sang Hang",Author="lanella"
                           ,Introduction  ="埃爾塞拉原本過著令眾人羨慕不已的奢華生活，卻年紀輕輕就因病去世了。她這一生最後悔的事就是沒有成為一位好母親，可不知道為什麼，死後的她竟回到了3年前。於是重生後的埃爾塞拉決心這次要做一位溫柔稱職的母親。但一切還是太遲了嗎?「現在才做這些，只會讓我感到厭惡罷了。」兒子只是一味地抗拒她。而她也意識到了，自己重生前一直以為融洽的夫妻關係，其實也只是她的錯覺罷了..."
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=3},




                //星期列表與作品頁
                //星期六

                //星期六有影片
                new Comic {ComicChineseName="盜墓王",ComicEnglishName="TombRaiderKing"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607700/TombRaiderKing/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656572963/TombRaiderKing/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657520466/TombRaiderKing/9.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657520466/TombRaiderKing/9.webp"
                           ,BgColor       ="#575a6f",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="Polarfox",Painter="Yooani",Author="Will Bright"
                           ,Introduction  ="「不但不是主角，還偏偏是書裡最惡毒的女人...」為了擺脫租屋生活而開始閱讀武俠小說《南宮世家少主》，卻穿越成為了小說裡最惡毒的女人——唐海媛。唐海媛這個天下第一惡女為了得到欽慕的男人，不惜毒殺思慕之人的情人、挑撥武林高手們、成為魔教的走狗並導致武林動盪。「絕不能和原本的故事內容一樣，白白送死!!」偶然吃了萬年參而變成小說世界裡的最強者，武俠小說最強惡女「唐海媛」的重生記!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656572710/TombRaiderKing/1.webm"
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656572903/TombRaiderKing/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=3},

                new Comic {ComicChineseName="我成了反派的繼母",ComicEnglishName="IBecameTheVillain'sMother"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607155/IBecameTheVillain%27sMother/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584749/IBecameTheVillain%27sMother/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584432/IBecameTheVillain%27sMother/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584432/IBecameTheVillain%27sMother/1.webp"
                           ,BgColor       ="#225040",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="DAON STUDIO",Painter="Iro",Author="Yulji"
                           ,Introduction  ="我成了小說裡最終的反派角色「艾因斯潘納」的繼母。而且還是小時候虐待他，長大後第一個被他殺害的壞心繼母。在我思考該如何逃離這悲慘命運時，仍一無所知、天真無邪的未來反派潛力股映入眼簾，但是...「等等，這孩子就連胖嘟嘟的小手都這麼可愛!誰捨得虐待他啊!」在我眼前的是個和反派完全沾不上邊的可愛小孩。好，我決定了，交給我吧!我會守護你!所以長大後拜託饒我一命吧!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656584573/IBecameTheVillain%27sMother/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656584694/IBecameTheVillain%27sMother/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=3},

                new Comic {ComicChineseName="目標是成為長命百歲的千金大小姐",ComicEnglishName="IDreamOfHealthWealthAndALongLife"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607743/IDreamOfHealthWealthAndALongLife/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577934/IDreamOfHealthWealthAndALongLife/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577876/IDreamOfHealthWealthAndALongLife/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577753/IDreamOfHealthWealthAndALongLife/1.webp"
                           ,BgColor       ="#3b3f0e",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="intime",Painter="GalaxyJellyfish",Author="Cheong Song-A"
                           ,Introduction  ="「好不容易含著金湯匙出生，居然要慘遭殺害?我一定要生存下來，並且長命百歲!」雖然轉生成了喜歡的小說中男主角的妹妹，卻註定會在十七歲時被繼母投毒殺害。哥哥正在和女主角一起冒險，我必須自己想辦法活下去...!我對這個世界非常了解，書裡的眾多角色當中肯定有能幫助我的人!我，阿德莉安娜計畫擺脫慘死的命運，並成為千金大小姐過上好日子，而此時帝國的皇子、可疑的商行主人，還有更可疑的魔族開始接近我了!沒錯，我不能就這樣乖乖等死!我要活下來!「因為我的目標是成為長命百歲的千金大小姐!!」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=3},

                new Comic {ComicChineseName="原來都是誤會一場",ComicEnglishName="ItWasAllAMistake"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605156/ItWasAllAMistake/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578279/ItWasAllAMistake/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578176/ItWasAllAMistake/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578102/ItWasAllAMistake/1.webp"
                           ,BgColor       ="#191a2e",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="Dasan Books",Painter="MIM",Author="G-ANNE"
                           ,Introduction  ="我轉世到書裡，變成了凡洛斯家的二女兒度露雅，在回顧書中的內容時，些部分的記憶出了差錯。度露雅是小說中嫉妒女主角艾莉絲的惡女，並被男主角諾頓以火刑處死。為了活下去，度露雅刻意接近諾頓．埃德加，但不知怎麼回事，諾頓是個疑心非常重的人。即使度露雅想盡辦法接近他，諾頓仍不停考驗她存在的價值。「凡洛斯，再來玩吧。」儘管如此，諾頓還是很希望度露雅能夠留在自己身旁...「諾頓．埃德加是個非常惡毒的壞人!」本來應該在那段時間，和男主角好好相處的女主角艾莉絲．里莫蘭特，卻叫度露雅避開諾頓。「要與我結婚嗎?」度露雅甚至與男二亞倫．克萊莫爾訂了婚。在這一片無法預知未來的混亂中，度露雅究竟能否擺脫原作結局，守護自己?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=1},

                new Comic {ComicChineseName="就離開我吧",ComicEnglishName="JustLeaveMe"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605448/JustLeaveMe/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597845/JustLeaveMe/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597626/JustLeaveMe/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597626/JustLeaveMe/1.webp"
                           ,BgColor       ="#121212",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="Yeondam X DAON",Painter="chero",Author="JAEUNHYANG"
                           ,Introduction  ="因罕見疾病而死亡的公爵之女，阿黛兒成了她的替身，雖然用盡一切努力想得到家人們的愛，卻還是於妹妹一出生時就遭到拋棄，在前往政治聯姻的路途中被不明的刺客暗殺。「...難道這是夢?」但在她睜開眼後，卻發現自己回到了3年前!想著反正只要妹妹一出生就會遭到拋棄的自己，阿黛兒決定這次的人生要操之在己，可惜依舊不斷遭遇苦難。「難道您不是對我有興趣嗎?」再加上一個身分不明的黑色騎士老是接近她..."
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656597726/JustLeaveMe/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656597781/JustLeaveMe/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=1},

                new Comic {ComicChineseName="千金大廚來上菜",ComicEnglishName="LadyChefRoyale"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605055/LadyChefRoyale/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656591172/LadyChefRoyale/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656590985/LadyChefRoyale/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656590985/LadyChefRoyale/1.webp"
                           ,BgColor       ="#dd6b79",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="Dreamtoon",Painter="PAYA",Author="Lysha"
                           ,Introduction  ="我原是一位小餐廳的廚師，卻成為了一個連皇帝都害怕的貴族家——他們家的受氣包小女兒。本想存一些錢，然後逃跑的...真是奇怪。「跟你說對不起，是一件丟臉的事嗎?」「是啊，因為我是妳哥哥。」「妳不和我這個爺爺去散步嗎?」大家為什麼突然間對我這麼好?「為什麼我想要把那些看妳的人的眼睛挖出來?」試圖逃跑的我以及緊緊抓住我的人，只是做了料理而已，為什麼會這樣...「愛死她的家人們 / 想逃跑的她 / 她專屬的僕人們」即將登場!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656591037/LadyChefRoyale/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656591103/LadyChefRoyale/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=3},

                new Comic {ComicChineseName="交界地帶的動物醫院",ComicEnglishName="LegendaryBeastsAnimalHospital"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604897/LegendaryBeastsAnimalHospital/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594171/LegendaryBeastsAnimalHospital/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594113/LegendaryBeastsAnimalHospital/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594074/LegendaryBeastsAnimalHospital/1.webp"
                           ,BgColor       ="#786769",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="CONTENTSLABBLUE",Painter="Choi-Palho",Author="Ecira"
                           ,Introduction  ="空無一人的動物醫院獸醫竟搖身一變成為神獸的名醫!負債累累的動物醫院院長——金亞瑛，某天接到一通電話...「你們有在替爬蟲類看診嗎?」為了生計的她只好咬牙接客。「呃...龍也是爬蟲類，對吧?」沒想到來的竟然是一隻青龍!心驚膽顫地治療完青龍之後牠居然幫亞瑛動物醫院大肆宣傳，使得神獸病人不斷上門。但恐懼也只是一時的，當亞瑛收到那些不諳世事的神獸所給的豐厚報酬時...「怪物?青龍?通通放馬過來!錢才是王道!」獸醫亞瑛於是毫不畏懼地開通靈眼，她能夠順利地治療這些特殊病患，再回歸她平靜的日常生活嗎?神獸診療記，開診!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=1},

                new Comic {ComicChineseName="與神共進",ComicEnglishName="LevelUpWithTheGods"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607981/LevelUpWithTheGods/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656591446/LevelUpWithTheGods/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656591381/LevelUpWithTheGods/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656591257/LevelUpWithTheGods/1.webp"
                           ,BgColor       ="#121212",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="D&C WEBTOON Biz",Painter="Ohyeon",Author="B. Ain"
                           ,Introduction  ="異世界的神——外神(Outer God)封鎖天際的絕望、深陷沼澤的挫折、無法降生者，以及愚昧的混沌...普通人即使只是多看一眼都會丟掉性命的存在們正在控制著這個世界...經過數年的戰爭後，最後的倖存者們得出了一個結論。「內神(Inner)永遠都打不過外神(Outer)。」此刻，掌控時間的神明克洛諾斯透過犧牲自己啟動了時間的發條。「沒錯，至少現在...你們確實打不過他們。」「回到原先的世界線去，然後重新開始吧。」這時候，有一個人被眾神指定為最終候選人並回到了過去。他就是最後一個爬上塔，直到最後都在與神戰鬥的人類——金宥元。「內神(Inner)永遠都打不過外神(Outer)，那麼...」「最後的勝利者就是我。」他能否召集一起奮戰到最後的夥伴，並且在與外神(Outer)的戰鬥中取得勝利呢?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=3},

                new Comic {ComicChineseName="魔彈射手",ComicEnglishName="MadanNoShashu"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608240/MadanNoShashu/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582317/MadanNoShashu/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582133/MadanNoShashu/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582133/MadanNoShashu/1.webp"
                           ,BgColor       ="#060b28",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="intime",Painter="GLPI",Author="Respect"
                           ,Introduction  ="「何中士，你又全中了啊!」即將成為軍官的神射手，何里夏中士，因一起意外事故，導致下半身癱瘓，成為了一個被世界遺棄的孤兒。在陷入絕望之際，虛擬實境遊戲「米德爾斯」橫空出世，賦予了他嶄新的人生。而在「米德爾斯」裡賺取的錢財，竟然可以成為現實世界中的財產!但因一開始的失誤，何里夏選擇了能力值最低的角色。眼看他就要被當成沙包打了!「我和你們不一樣，我已經無路可退了!」用火藥、鋼珠、推彈杆，讓你們看看什麼是真正的神槍手!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656582250/MadanNoShashu/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=3},

                new Comic {ComicChineseName="女俠當家",ComicEnglishName="MasterVillainessTheInvincible"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605317/MasterVillainessTheInvincible/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594548/MasterVillainessTheInvincible/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594300/MasterVillainessTheInvincible/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594266/MasterVillainessTheInvincible/1.webp"
                           ,BgColor       ="#575a6f",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="Polarfox",Painter="Yooani",Author="Will Bright"
                           ,Introduction  ="「不但不是主角，還偏偏是書裡最惡毒的女人...」為了擺脫租屋生活而開始閱讀武俠小說《南宮世家少主》，卻穿越成為了小說裡最惡毒的女人——唐海媛。唐海媛這個天下第一惡女為了得到欽慕的男人，不惜毒殺思慕之人的情人、挑撥武林高手們、成為魔教的走狗並導致武林動盪。「絕不能和原本的故事內容一樣，白白送死!!」偶然吃了萬年參而變成小說世界裡的最強者，武俠小說最強惡女「唐海媛」的重生記!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656594393/MasterVillainessTheInvincible/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=3},

                //121
                new Comic {ComicChineseName="墨劍留香",ComicEnglishName="MookHyangDarkLady"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605276/MookHyangDarkLady/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582961/MookHyangDarkLady/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,BgColor       ="#1a0c19",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="Polarfox",Painter="Yooani",Author="Will Bright"
                           ,Introduction  ="「不但不是主角，還偏偏是書裡最惡毒的女人...」為了擺脫租屋生活而開始閱讀武俠小說《南宮世家少主》，卻穿越成為了小說裡最惡毒的女人——唐海媛。唐海媛這個天下第一惡女為了得到欽慕的男人，不惜毒殺思慕之人的情人、挑撥武林高手們、成為魔教的走狗並導致武林動盪。「絕不能和原本的故事內容一樣，白白送死!!」偶然吃了萬年參而變成小說世界裡的最強者，武俠小說最強惡女「唐海媛」的重生記!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656594393/MasterVillainessTheInvincible/3.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656788146/MookHyangDarkLady/3MP4.mp4"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=3},



                //星期列表與作品頁
                //星期四(屬於星期六)

                //星期四(屬於星期六)有影片
                new Comic {ComicChineseName="短命媳婦的逃跑計畫",ComicEnglishName="ShortLivedDaughterInLaw'sEscapePlan"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656999779/ShortLivedDaughterInLaw%27sEscapePlan/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656999287/ShortLivedDaughterInLaw%27sEscapePlan/4.jpg"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656999028/ShortLivedDaughterInLaw%27sEscapePlan/1.webm"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656999028/ShortLivedDaughterInLaw%27sEscapePlan/1.webm"
                           ,BgColor       ="#3a6052",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="Yeondam",Painter="BASAK",Author="Yunajin"
                           ,Introduction  ="為什麼偏偏穿越到這種小說裡啊?!我就是小說中那位父母留下繁重債務後就死於事故，並且還注定在成年時便因病身亡的可憐少女——拉莉亞。這部小說的幕後黑手依卡勒德公爵為了欺瞞那些牽制自己的勢力，將我帶回家當他媳婦。我還是在偷偷存錢之後，找機會逃跑吧!可是治病的方法找到了、逃跑的資金也準備充足了...我的丈夫卻不知為何對我超執著?!他不是對誰都毫無感情的冷血之人嗎?而且我不是公公手上用完就丟的牌嗎?他為什麼會突然想救活我?!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656999981/ShortLivedDaughterInLaw%27sEscapePlan/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=3},

                new Comic {ComicChineseName="偉大的夙願",ComicEnglishName="TheGreatWish"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656606723/TheGreatWish/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587434/TheGreatWish/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587082/TheGreatWish/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587082/TheGreatWish/1.webp"
                           ,BgColor       ="#11242e",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="Dreamtoon",Painter="Skye",Author="Skye"
                           ,Introduction  ="詩埃娜．阿爾傑特是神聖帝國唯一的皇女，從出生那一刻起便擁有了一切，智慧、美貌、才能，甚至是皇位繼承人的身分，無所不有。二十歲生日前夕，她開始夢見數十年後的自己，並認為這是神賜予她的預知能力而雀躍不已，為此向神致上謝意。但是在夢中預見的未來愈來愈奇怪，跟詩埃娜憧憬的未來大相逕庭。過去視為半吊子而瞧不起的同父異母兄長，展開了反擊；曾經以為會永遠站在自己這一方的母親，露出了隱藏的面目；還有，無論在現實或夢境中，都帶給詩埃娜巨大影響的男人，出現在眼前...詩埃娜周遭的一切，急速發生巨變，而她身上，也逐漸產生變化。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656587202/TheGreatWish/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656587373/TheGreatWish/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=3},

                new Comic {ComicChineseName="魔咒情人",ComicEnglishName="TheJinx'sLover"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608208/TheJinx%27sLover/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588311/TheJinx%27sLover/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588126/TheJinx%27sLover/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588126/TheJinx%27sLover/1.webp"
                           ,BgColor       ="#ab9a9f",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Koo seul",Author="Koo seul"
                           ,Introduction  ="被有錢人家藏匿的幸運女神來到了窮困潦倒又倒楣透頂的我身邊。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656588228/TheJinx%27sLover/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=3},

                new Comic {ComicChineseName="英雄大人滿級回歸",ComicEnglishName="TheMaxLeveHeroStrikesBack"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608010/TheMaxLeveHeroStrikesBack/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574093/TheMaxLeveHeroStrikesBack/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656573894/TheMaxLeveHeroStrikesBack/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656573894/TheMaxLeveHeroStrikesBack/1.webp"
                           ,BgColor       ="#394b78",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="golemfactory",Painter="Yudo",Author="Devil's tail"
                           ,Introduction  ="無權無勢、被打入冷宮的王子戴伊比，在他陷入昏迷後靈魂出竅，來到了充滿各個英雄之靈的巨大迴廊。經過千年的洗禮，他成為滿級的英雄大人回歸了!所有人，給我等著吧，我一定會給你們好看!戴伊比的復仇記和宮廷生活，即將開始!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656574015/TheMaxLeveHeroStrikesBack/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=3},

                new Comic {ComicChineseName="永恆世界歸還者",ComicEnglishName="TheMaxLevelReturner"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607372/TheMaxLevelReturner/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593728/TheMaxLevelReturner/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593513/TheMaxLevelReturner/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593513/TheMaxLevelReturner/1.webp"
                           ,BgColor       ="#273961",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="golemfactory",Painter="Vertwo",Author="Honey"
                           ,Introduction  ="全世界有1億2千萬人消失了。「開始執行完成最終任務的獎勵『回歸』。」睽違22年，尹尚赫結束了一場最爛的生存遊戲。被稱為一人軍團、最強玩家的他，帶著任何人都沒能得到的獎勵回歸了。「假面君主，回歸。」我獨自滿等、獨自通關、獨自暗爽!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656593634/TheMaxLevelReturner/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=3},

                new Comic {ComicChineseName="皇女殿下的娃娃屋",ComicEnglishName="ThePrincess'sDollShop"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607589/ThePrincess%27sDollShop/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594895/ThePrincess%27sDollShop/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594840/ThePrincess%27sDollShop/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594677/ThePrincess%27sDollShop/1.webp"
                           ,BgColor       ="#4894d4",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="DAON STUDIO",Painter="POMPOMMELO",Author="On Uyeon"
                           ,Introduction  ="「我只是有個小小的心願想出宮去完成。」「......出宮嗎?」戴恩莫名欲言又止，似乎比剛才卡希雅跟他要一個國家時反應更大。因為心願即將實現而雀躍不已的卡希雅並沒有發現戴恩的不對勁，反而用閃閃發亮的眼神逼迫戴恩繼續問她詳情。「妳的心願是什麼呢?」結果戴恩一提問，論美貌在當今帝國大概無人能及的女孩嫣然一笑，大聲說道：「我想開娃娃屋!」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=3},

                new Comic {ComicChineseName="我在馴服暴君後落跑了",ComicEnglishName="TheTamingOfTheTyrant"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607049/TheTamingOfTheTyrant/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582603/TheTamingOfTheTyrant/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582513/TheTamingOfTheTyrant/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582408/TheTamingOfTheTyrant/1.webp"
                           ,BgColor       ="#422786",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="DAON STUDIO",Painter="Melting",Author="yusoy"
                           ,Introduction  ="神給了我第二次機會，讓我回到四百年前。回到過去的我下定決心要徹底摧毀這個帝國， 「沒有任何一位國民，會以帝國為傲。」為了達成復仇計畫，我決定將天才皇子親手調教為暴君。「一切都將如妳所願。」他為我吞噬了整個帝國，而實現目標的我拋下了他，遠走高飛。幾年後，迪倫成了完美的暴君。我卻不知他居然為了找我，尋遍帝國上下。「為何馴服我之後就跑了?」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=3},

                new Comic {ComicChineseName="體弱惡女的幸福任務",ComicEnglishName="TheVillainess'sDaysAreNumbered"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608168/TheVillainess%27sDaysAreNumbered/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593336/TheVillainess%27sDaysAreNumbered/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593185/TheVillainess%27sDaysAreNumbered/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593096/TheVillainess%27sDaysAreNumbered/1.webp"
                           ,BgColor       ="#141f40",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="Mstoryhub",Painter="Salmon",Author="HARASYO"
                           ,Introduction  ="「你只要和我度過6個月的契約婚姻生活，我就把家族的所有財產全部給你!」轉世為世界觀中最強的惡女，竟然得和冷漠無情的他度過幸福的婚姻生活?!在意外中死去後，我成了這世界裡最強的惡女「克萊亞」。雖然魔王答應要送我回原本的世界，但條件是必須和艾薩克．迪特羅伊大公度過幸福的婚姻生活。可是...第一，艾薩克．迪特羅伊大公討厭我。第二，我的身體虛弱得像隻翻車魚。走一步就會被扣生命值1點，而生命值一旦下降1/3就會開始咳血。我真的能以這副身體，展現幸福的婚姻生活給魔王看嗎?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=3},

                new Comic {ComicChineseName="星隕之地的守候",ComicEnglishName="WaitWhereTheShootingStarFalls"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607267/WaitWhereTheShootingStarFalls/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656589140/WaitWhereTheShootingStarFalls/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588444/WaitWhereTheShootingStarFalls/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588444/WaitWhereTheShootingStarFalls/1.webp"
                           ,BgColor       ="#171918",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Mr.General Store",Author="Mr.General Store"
                           ,Introduction  ="尋覓流星蹤跡的魔女與貓咪的故事。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656588686/WaitWhereTheShootingStarFalls/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=3},

                new Comic {ComicChineseName="不可告人戀愛情事",ComicEnglishName="WeeklyBoys'Romance"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656606634/WeeklyBoys%27Romance/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580011/WeeklyBoys%27Romance/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579975/WeeklyBoys%27Romance/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579914/WeeklyBoys%27Romance/1.webp"
                            ,BgColor       ="#38334d",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="See-in Park",Author="See-in Park"
                           ,Introduction  ="同住一個屋簷下的五位高中生，他們各自的「畸形愛情故事」，每週一與您相見。"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656580073/WeeklyBoys%27Romance/3.webm"
                           ,HotVideo = ""
                            ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=1},

                //132
                new Comic {ComicChineseName="忠犬的行動準則",ComicEnglishName="Woman'sBestFriend"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656606868/Woman%27sBestFriend/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656590842/Woman%27sBestFriend/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656589219/Woman%27sBestFriend/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656589219/Woman%27sBestFriend/1.webp"
                            ,BgColor       ="#e45850",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="Dreamtoon",Painter="Dodam",Author="Hyun Sung Lee"
                           ,Introduction  ="在城云出版社裡，有個名為「瘋狗」的存在。他是徐禹俊，毫無變化的表情、沒有抑揚頓挫的語調、冰冷銳利的眼神，以及挑剔的個性是他的標誌。但是這男人，真的是瘋狗沒錯嗎?「別熄滅妳內在的光芒，也別輕易讓任何人熄滅它，妳可以再更有自信一點。」比起瘋狗，禹俊更像是忠犬般溫柔地對待泰齡，讓在情場上失利、工作不順，甚至連家庭都不溫暖的她怎麼也摸不著頭緒。該拿這個既像忠心的杜賓犬，又像可愛瑪爾濟斯的男人怎麼辦?時而輕柔、時而強烈地觸動人心的戀愛故事——《忠犬的行動準則》。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656589799/Woman%27sBestFriend/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656590753/Woman%27sBestFriend/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=3},




                //星期列表與作品頁
                //星期日

                //星期日有影片
                new Comic {ComicChineseName="今生我來當家主",ComicEnglishName="TodayIWillBeTheHeadOfTheHouse"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656998366/TodayIWillBeTheHeadOfTheHouse/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582961/MookHyangDarkLady/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,BgColor       ="#418ab3",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="D&C WEBTOON Biz",Painter="Mon(Antstudio)",Author="Kim Roah"
                           ,Introduction  ="「...就試試吧，由我來當家主。」我轉世成了帝國第一大家族——倫巴第家的私生女費蓮緹雅。這個家族不但富甲天下，而且從外交到文化無一不精，堪稱帝國歷史的象徵!含著金湯匙中的金湯匙出生，簡直太幸運了!還以為將來等著我的是康莊大道...沒想到父親過世後，我被親戚趕出家門，最後連曾經鼎鼎有名的家族都毀於一旦!!悲憤交加的我小酌(?)幾杯後走在回家的路上，居然還被馬車撞上!「這也太過分了吧...」含冤而死的我一睜開眼卻回到了七歲的時候?!光是親愛的父親出現在眼前就已經令人難以置信，我竟然還有機會拯救父親與家族?連重生前的家族仇人——二皇子都像隻大型犬似地成天追著我跑?!好吧，既然如此，二皇子和家族都是我的了!轉世加重生，面對第三次人生的費蓮緹雅，為了當上家主而展開行動!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656594393/MasterVillainessTheInvincible/3.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1657034039/TodayIWillBeTheHeadOfTheHouse/2.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},



                new Comic {ComicChineseName="我有三個暴君哥哥",ComicEnglishName="MyThreeTyrantBrothers"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607226/MyThreeTyrantBrothers/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582063/MyThreeTyrantBrothers/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656581853/MyThreeTyrantBrothers/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656581853/MyThreeTyrantBrothers/1.webp"
                           ,BgColor       ="#9fa925",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="DAON STUDIO",Painter="Parkha, Eun Du",Author="jomil​"
                           ,Introduction  ="我是個連名字都沒有的星期奴隸，代號「星期三」，當我因為反抗主人，性命不保的時候...「——終於找到妳了。」一夕之間多了三個哥哥，他們還說我是解除亞斯卡尼爾皇室詛咒的唯一鑰匙?!「妳一定要健健康康地長大，長到現在身上的衣服緊到再也穿不下，這是妳的第一項課題。」「別擔心，小不點。那些壞人，哥哥會幫妳狠狠教訓他們一頓。」「這孩子像隻小雞一樣，既嬌小又柔弱。我想要守護她，我會守護她。」被大家稱作暴君的哥哥們，怎麼只對我這麼溫柔!?從天而降的寵妹狂魔哥哥們和我的故事——《我有三個暴君哥哥》!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656581977/MyThreeTyrantBrothers/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},



                new Comic {ComicChineseName="廢墟中的皇女",ComicEnglishName="PrincessInTheRough"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605651/PrincessInTheRough/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577313/PrincessInTheRough/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576943/PrincessInTheRough/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576943/PrincessInTheRough/1.webp"
                           ,BgColor       ="#605342",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="Mstoryhub",Painter="HAERUA",Author="HARASYO"
                           ,Introduction  ="被皇帝遺忘的孩子，獨自一人生活在森林裡的廢棄城堡。「我討厭說謊的騙子，就算是一個人，我也可以過得好好的。」她經過漫長的等待，終於盼到皇帝來，但孩子的心扉早已緊緊關上了。「我來為妳取個名字。」「名字?」「艾斯特蕾拉，這就是妳的名字了...很抱歉讓妳久等了，孩子。」艾斯特蕾拉是一個擁有著特別能力的孩子，她的家人該如何療癒那顆破碎的心呢?"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656577015/PrincessInTheRough/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656577184/PrincessInTheRough/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},


                new Comic {ComicChineseName="小不點皇后",ComicEnglishName="OurLittleEmpress"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605394/OurLittleEmpress/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579483/OurLittleEmpress/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579407/OurLittleEmpress/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579370/OurLittleEmpress/1.webp"
                           ,BgColor       ="#434f4c",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="People&Story",Painter="Maryang",Author="Yusoi"
                           ,Introduction  ="預言之女是為拯救世界而誕生的。「若想拯救人類就必須結婚?那我願意!」要成為我丈夫的皇帝是一位年輕而單純的男孩，但...「我不會把女兒嫁給你!她不會成為皇后的。」 父親干涉了我的婚姻!「我妹妹是我的玩具。」就連哥哥也反對!我真的能夠拯救世界嗎?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},



                new Comic {ComicChineseName="婚禮復仇記",ComicEnglishName="RevengeWedding"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605358/RevengeWedding/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575576/RevengeWedding/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575339/RevengeWedding/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575339/RevengeWedding/1.webp"
                           ,BgColor       ="#28202b",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="DAON STUDIO",Painter="SaRyong​",Author="ByulSatangYang"
                           ,Introduction  ="集外貌、財富、地位於一身的完美女子——梅勒凱蒂亞．沙夏，暈倒後醒來發現自己位在一艘巨大的船上，身上還穿著婚紗。「蛤?我要結婚了嗎?是誰這麼大膽敢打我的主意?我一定要讓你打消結婚的念頭!」但沒想到...我的丈夫初次見面竟然就拿劍抵著我的脖子?他是帝國最偉大的戰爭英雄——戴枚德利奧．吉普洛沙。可是，他看起來一點都不像來結婚的啊?「我還想說是誰把我帶到這裡來的...只要殺了妳，我就可以回去了嗎?」「真是不好意思，我也是被綁架的好嗎?」我們兩人被綁架來結婚，甚至還要一起在無人島上求生存?!眼前的首要任務，就是逃出這座荒島!終極任務，要跟這個仇人離婚!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656575410/RevengeWedding/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656575490/RevengeWedding/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},



                new Comic {ComicChineseName="結了婚再說",ComicEnglishName="SaveItForTheHoneymoon"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607844/SaveItForTheHoneymoon/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579729/SaveItForTheHoneymoon/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579693/SaveItForTheHoneymoon/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656579622/SaveItForTheHoneymoon/1.webp"
                           ,BgColor       ="#646a90",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="Feelyeon management",Painter="Bopamine",Author="Kangdalkong"
                           ,Introduction  ="莫雅是堅持這輩子不結婚的不婚主義者，然而某天，她卻意外一絲不掛地...和平時以冷酷嚴格出名的上司建厚裸裎相見。是說......那怎麼可能是人類的身材啊!面對建厚如藝術品般完美的身材，莫雅瞬間忘記羞愧，視線無法從他身上移開。自從看到建厚的完美裸體，莫雅出現了嚴重的後遺症——不論在哪裡、做什麼都會回想起建厚的赤身裸體。 深受困擾的莫雅在某個喝醉的夜晚，向建厚說出了爆炸性發言——「那個…組長，你要和我睡一次嗎？」在清醒狀態絕對無法說出口的告白，莫雅說出口的那一瞬間就後悔不已。不過，此時建厚居然說出了更震撼的回應—— 「很抱歉，我只會和結婚對象發生關係。」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},

                new Comic {ComicChineseName="SSS級死而復生的獵人",ComicEnglishName="SSS-ClassRevivalHunter"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604749/SSS-ClassRevivalHunter/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580517/SSS-ClassRevivalHunter/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580224/SSS-ClassRevivalHunter/1.png"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580224/SSS-ClassRevivalHunter/1.png"
                           ,BgColor       ="#1c1f26",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="Fansia",Painter="Bill K",Author="Sinnoa"
                           ,Introduction  ="身處F級底層的獵人「金孔子」長久以來一直羨慕著排行第一的獵人「炎帝」。某天，他竟突然獲得了S+級的技能。不料，短暫開心過後，他發現這個技能有些古怪?!「複製對方的其中一種技能」到這裡都還不錯...「什麼?竟然要我死了才能發動?!」重生獵人的人生樂章——《SSS級死而復生的獵人》"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656580385/SSS-ClassRevivalHunter/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656580450/SSS-ClassRevivalHunter/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},

                new Comic {ComicChineseName="侍女小姐想活命",ComicEnglishName="SurvivingAsAMaid"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604961/SurvivingAsAMaid/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577647/SurvivingAsAMaid/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577566/SurvivingAsAMaid/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577485/SurvivingAsAMaid/1.webp"
                           ,BgColor       ="#1d0000",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="CARROTOON",Painter="Hee-seo",Author="cloudwhale soap"
                           ,Introduction  ="只不過是煮著泡麵，下一秒睜開眼，竟發現自己進入國王、後宮、騎士、臣子、圖書管理員都是GAY的BL小說中，成為一名受到冷落的王妃的侍女。身為主角卻沒有任何BUFF加持的平凡侍女亞絲，究竟能不能平安活下去?《侍女小姐想活命》!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},

                new Comic {ComicChineseName="穆艾拉的調查官",ComicEnglishName="TheDetectiveOfMuiella"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607783/TheDetectiveOfMuiella/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656586950/TheDetectiveOfMuiella/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656586848/TheDetectiveOfMuiella/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656586761/TheDetectiveOfMuiella/1.webp"
                           ,BgColor       ="#435245",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="Dreamtoon",Painter="Ssol",Author="Kiarne"
                           ,Introduction  ="穆艾拉——排斥魔法師與魔女的國家。而凱特是一名在穆艾拉鄉村領地——亞拉納戴爾宅邸中工作的女傭。某日，戴爾男爵家新進一名可疑的新僕人——伊恩。伊恩有著與僕人身分格格不入的高大身形和俊美相貌，第一天就吸引了眾人目光，然而凱特卻不喜歡處處與自己作對的伊恩。另一方面，凱特工作的戴爾男爵家開始發生一連串詭譎的事件..."
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=1},

                new Comic {ComicChineseName="與惡魔共舞",ComicEnglishName="TheDevil'sTango"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607940/TheDevil%27sTango/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575227/TheDevil%27sTango/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575128/TheDevil%27sTango/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574814/TheDevil%27sTango/1.webp"
                           ,BgColor       ="#513b46",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="Polarfox",Painter="Chickenmeat",Author="Chickenmeat"
                           ,Introduction  ="「嗨，朋友!」跨越世紀只為找到「你」的惡魔，與無論「你」是不是惡魔，都想愛「你」的寂寞人類——邀您與三對人類♥惡魔情侶共舞!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},

                //143
                new Comic {ComicChineseName="繁花清風圓舞曲",ComicEnglishName="TheFlowerDancesAndTheWindSings"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607886/TheFlowerDancesAndTheWindSings/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578788/TheFlowerDancesAndTheWindSings/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578916/TheFlowerDancesAndTheWindSings/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578646/TheFlowerDancesAndTheWindSings/1.webp"
                           ,BgColor       ="#167a43",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="CARROTOON",Painter="Sang Hang",Author="lanella"
                           ,Introduction  ="埃爾塞拉原本過著令眾人羨慕不已的奢華生活，卻年紀輕輕就因病去世了。她這一生最後悔的事就是沒有成為一位好母親，可不知道為什麼，死後的她竟回到了3年前。於是重生後的埃爾塞拉決心這次要做一位溫柔稱職的母親。但一切還是太遲了嗎?「現在才做這些，只會讓我感到厭惡罷了。」兒子只是一味地抗拒她。而她也意識到了，自己重生前一直以為融洽的夫妻關係，其實也只是她的錯覺罷了..."
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},



                //星期列表與作品頁
                //星期二

                //星期二有影片
                new Comic {ComicChineseName="盜墓王",ComicEnglishName="TombRaiderKing"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607700/TombRaiderKing/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656572963/TombRaiderKing/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657520466/TombRaiderKing/9.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657520466/TombRaiderKing/9.webp"
                           ,BgColor       ="#575a6f",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="Polarfox",Painter="Yooani",Author="Will Bright"
                           ,Introduction  ="「不但不是主角，還偏偏是書裡最惡毒的女人...」為了擺脫租屋生活而開始閱讀武俠小說《南宮世家少主》，卻穿越成為了小說裡最惡毒的女人——唐海媛。唐海媛這個天下第一惡女為了得到欽慕的男人，不惜毒殺思慕之人的情人、挑撥武林高手們、成為魔教的走狗並導致武林動盪。「絕不能和原本的故事內容一樣，白白送死!!」偶然吃了萬年參而變成小說世界裡的最強者，武俠小說最強惡女「唐海媛」的重生記!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656572710/TombRaiderKing/1.webm"
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656572903/TombRaiderKing/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},

                new Comic {ComicChineseName="我成了反派的繼母",ComicEnglishName="IBecameTheVillain'sMother"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607155/IBecameTheVillain%27sMother/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584749/IBecameTheVillain%27sMother/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584432/IBecameTheVillain%27sMother/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584432/IBecameTheVillain%27sMother/1.webp"
                           ,BgColor       ="#225040",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="DAON STUDIO",Painter="Iro",Author="Yulji"
                           ,Introduction  ="我成了小說裡最終的反派角色「艾因斯潘納」的繼母。而且還是小時候虐待他，長大後第一個被他殺害的壞心繼母。在我思考該如何逃離這悲慘命運時，仍一無所知、天真無邪的未來反派潛力股映入眼簾，但是...「等等，這孩子就連胖嘟嘟的小手都這麼可愛!誰捨得虐待他啊!」在我眼前的是個和反派完全沾不上邊的可愛小孩。好，我決定了，交給我吧!我會守護你!所以長大後拜託饒我一命吧!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656584573/IBecameTheVillain%27sMother/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656584694/IBecameTheVillain%27sMother/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},

                new Comic {ComicChineseName="目標是成為長命百歲的千金大小姐",ComicEnglishName="IDreamOfHealthWealthAndALongLife"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607743/IDreamOfHealthWealthAndALongLife/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577934/IDreamOfHealthWealthAndALongLife/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577876/IDreamOfHealthWealthAndALongLife/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577753/IDreamOfHealthWealthAndALongLife/1.webp"
                           ,BgColor       ="#3b3f0e",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="intime",Painter="GalaxyJellyfish",Author="Cheong Song-A"
                           ,Introduction  ="「好不容易含著金湯匙出生，居然要慘遭殺害?我一定要生存下來，並且長命百歲!」雖然轉生成了喜歡的小說中男主角的妹妹，卻註定會在十七歲時被繼母投毒殺害。哥哥正在和女主角一起冒險，我必須自己想辦法活下去...!我對這個世界非常了解，書裡的眾多角色當中肯定有能幫助我的人!我，阿德莉安娜計畫擺脫慘死的命運，並成為千金大小姐過上好日子，而此時帝國的皇子、可疑的商行主人，還有更可疑的魔族開始接近我了!沒錯，我不能就這樣乖乖等死!我要活下來!「因為我的目標是成為長命百歲的千金大小姐!!」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},

                new Comic {ComicChineseName="原來都是誤會一場",ComicEnglishName="ItWasAllAMistake"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605156/ItWasAllAMistake/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578279/ItWasAllAMistake/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578176/ItWasAllAMistake/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656578102/ItWasAllAMistake/1.webp"
                           ,BgColor       ="#191a2e",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="Dasan Books",Painter="MIM",Author="G-ANNE"
                           ,Introduction  ="我轉世到書裡，變成了凡洛斯家的二女兒度露雅，在回顧書中的內容時，些部分的記憶出了差錯。度露雅是小說中嫉妒女主角艾莉絲的惡女，並被男主角諾頓以火刑處死。為了活下去，度露雅刻意接近諾頓．埃德加，但不知怎麼回事，諾頓是個疑心非常重的人。即使度露雅想盡辦法接近他，諾頓仍不停考驗她存在的價值。「凡洛斯，再來玩吧。」儘管如此，諾頓還是很希望度露雅能夠留在自己身旁...「諾頓．埃德加是個非常惡毒的壞人!」本來應該在那段時間，和男主角好好相處的女主角艾莉絲．里莫蘭特，卻叫度露雅避開諾頓。「要與我結婚嗎?」度露雅甚至與男二亞倫．克萊莫爾訂了婚。在這一片無法預知未來的混亂中，度露雅究竟能否擺脫原作結局，守護自己?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=1},

                new Comic {ComicChineseName="就離開我吧",ComicEnglishName="JustLeaveMe"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605448/JustLeaveMe/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597845/JustLeaveMe/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597626/JustLeaveMe/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597626/JustLeaveMe/1.webp"
                           ,BgColor       ="#121212",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="Yeondam X DAON",Painter="chero",Author="JAEUNHYANG"
                           ,Introduction  ="因罕見疾病而死亡的公爵之女，阿黛兒成了她的替身，雖然用盡一切努力想得到家人們的愛，卻還是於妹妹一出生時就遭到拋棄，在前往政治聯姻的路途中被不明的刺客暗殺。「...難道這是夢?」但在她睜開眼後，卻發現自己回到了3年前!想著反正只要妹妹一出生就會遭到拋棄的自己，阿黛兒決定這次的人生要操之在己，可惜依舊不斷遭遇苦難。「難道您不是對我有興趣嗎?」再加上一個身分不明的黑色騎士老是接近她..."
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656597726/JustLeaveMe/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656597781/JustLeaveMe/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=1},

                new Comic {ComicChineseName="千金大廚來上菜",ComicEnglishName="LadyChefRoyale"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605055/LadyChefRoyale/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656591172/LadyChefRoyale/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656590985/LadyChefRoyale/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656590985/LadyChefRoyale/1.webp"
                           ,BgColor       ="#dd6b79",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="Dreamtoon",Painter="PAYA",Author="Lysha"
                           ,Introduction  ="我原是一位小餐廳的廚師，卻成為了一個連皇帝都害怕的貴族家——他們家的受氣包小女兒。本想存一些錢，然後逃跑的...真是奇怪。「跟你說對不起，是一件丟臉的事嗎?」「是啊，因為我是妳哥哥。」「妳不和我這個爺爺去散步嗎?」大家為什麼突然間對我這麼好?「為什麼我想要把那些看妳的人的眼睛挖出來?」試圖逃跑的我以及緊緊抓住我的人，只是做了料理而已，為什麼會這樣...「愛死她的家人們 / 想逃跑的她 / 她專屬的僕人們」即將登場!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656591037/LadyChefRoyale/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656591103/LadyChefRoyale/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},

                new Comic {ComicChineseName="交界地帶的動物醫院",ComicEnglishName="LegendaryBeastsAnimalHospital"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604897/LegendaryBeastsAnimalHospital/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594171/LegendaryBeastsAnimalHospital/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594113/LegendaryBeastsAnimalHospital/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594074/LegendaryBeastsAnimalHospital/1.webp"
                           ,BgColor       ="#786769",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="CONTENTSLABBLUE",Painter="Choi-Palho",Author="Ecira"
                           ,Introduction  ="空無一人的動物醫院獸醫竟搖身一變成為神獸的名醫!負債累累的動物醫院院長——金亞瑛，某天接到一通電話...「你們有在替爬蟲類看診嗎?」為了生計的她只好咬牙接客。「呃...龍也是爬蟲類，對吧?」沒想到來的竟然是一隻青龍!心驚膽顫地治療完青龍之後牠居然幫亞瑛動物醫院大肆宣傳，使得神獸病人不斷上門。但恐懼也只是一時的，當亞瑛收到那些不諳世事的神獸所給的豐厚報酬時...「怪物?青龍?通通放馬過來!錢才是王道!」獸醫亞瑛於是毫不畏懼地開通靈眼，她能夠順利地治療這些特殊病患，再回歸她平靜的日常生活嗎?神獸診療記，開診!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=1},

                new Comic {ComicChineseName="與神共進",ComicEnglishName="LevelUpWithTheGods"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607981/LevelUpWithTheGods/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656591446/LevelUpWithTheGods/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656591381/LevelUpWithTheGods/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656591257/LevelUpWithTheGods/1.webp"
                           ,BgColor       ="#121212",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="D&C WEBTOON Biz",Painter="Ohyeon",Author="B. Ain"
                           ,Introduction  ="異世界的神——外神(Outer God)封鎖天際的絕望、深陷沼澤的挫折、無法降生者，以及愚昧的混沌...普通人即使只是多看一眼都會丟掉性命的存在們正在控制著這個世界...經過數年的戰爭後，最後的倖存者們得出了一個結論。「內神(Inner)永遠都打不過外神(Outer)。」此刻，掌控時間的神明克洛諾斯透過犧牲自己啟動了時間的發條。「沒錯，至少現在...你們確實打不過他們。」「回到原先的世界線去，然後重新開始吧。」這時候，有一個人被眾神指定為最終候選人並回到了過去。他就是最後一個爬上塔，直到最後都在與神戰鬥的人類——金宥元。「內神(Inner)永遠都打不過外神(Outer)，那麼...」「最後的勝利者就是我。」他能否召集一起奮戰到最後的夥伴，並且在與外神(Outer)的戰鬥中取得勝利呢?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},

                new Comic {ComicChineseName="魔彈射手",ComicEnglishName="MadanNoShashu"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608240/MadanNoShashu/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582317/MadanNoShashu/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582133/MadanNoShashu/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582133/MadanNoShashu/1.webp"
                           ,BgColor       ="#060b28",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="intime",Painter="GLPI",Author="Respect"
                           ,Introduction  ="「何中士，你又全中了啊!」即將成為軍官的神射手，何里夏中士，因一起意外事故，導致下半身癱瘓，成為了一個被世界遺棄的孤兒。在陷入絕望之際，虛擬實境遊戲「米德爾斯」橫空出世，賦予了他嶄新的人生。而在「米德爾斯」裡賺取的錢財，竟然可以成為現實世界中的財產!但因一開始的失誤，何里夏選擇了能力值最低的角色。眼看他就要被當成沙包打了!「我和你們不一樣，我已經無路可退了!」用火藥、鋼珠、推彈杆，讓你們看看什麼是真正的神槍手!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656582250/MadanNoShashu/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},

                new Comic {ComicChineseName="女俠當家",ComicEnglishName="MasterVillainessTheInvincible"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605317/MasterVillainessTheInvincible/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594548/MasterVillainessTheInvincible/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594300/MasterVillainessTheInvincible/2.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656594266/MasterVillainessTheInvincible/1.webp"
                           ,BgColor       ="#575a6f",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="Polarfox",Painter="Yooani",Author="Will Bright"
                           ,Introduction  ="「不但不是主角，還偏偏是書裡最惡毒的女人...」為了擺脫租屋生活而開始閱讀武俠小說《南宮世家少主》，卻穿越成為了小說裡最惡毒的女人——唐海媛。唐海媛這個天下第一惡女為了得到欽慕的男人，不惜毒殺思慕之人的情人、挑撥武林高手們、成為魔教的走狗並導致武林動盪。「絕不能和原本的故事內容一樣，白白送死!!」偶然吃了萬年參而變成小說世界裡的最強者，武俠小說最強惡女「唐海媛」的重生記!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656594393/MasterVillainessTheInvincible/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},

                //154
                new Comic {ComicChineseName="墨劍留香",ComicEnglishName="MookHyangDarkLady"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605276/MookHyangDarkLady/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582961/MookHyangDarkLady/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,BgColor       ="#1a0c19",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="Polarfox",Painter="Yooani",Author="Will Bright"
                           ,Introduction  ="「不但不是主角，還偏偏是書裡最惡毒的女人...」為了擺脫租屋生活而開始閱讀武俠小說《南宮世家少主》，卻穿越成為了小說裡最惡毒的女人——唐海媛。唐海媛這個天下第一惡女為了得到欽慕的男人，不惜毒殺思慕之人的情人、挑撥武林高手們、成為魔教的走狗並導致武林動盪。「絕不能和原本的故事內容一樣，白白送死!!」偶然吃了萬年參而變成小說世界裡的最強者，武俠小說最強惡女「唐海媛」的重生記!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656594393/MasterVillainessTheInvincible/3.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656788146/MookHyangDarkLady/3MP4.mp4"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},





                //新作 2部
                //155
                new Comic {ComicChineseName="如何藏匿皇帝的孩子",ComicEnglishName="HowToHideTheEmperor'sChildren"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657111700/HowToHideTheEmperor%27sChildren/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657111754/HowToHideTheEmperor%27sChildren/4.jpg"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657111833/HowToHideTheEmperor%27sChildren/2.png"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657111596/HowToHideTheEmperor%27sChildren/1.webp"
                           ,BgColor       ="#256573",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=1
                           ,Publisher     ="C&C Revolution Inc.",Painter="SSAL",Author="Lee Yeonseon "
                           ,Introduction  ="廢后雅絲黛爾生了皇子為了保護他不受傷害得把這個孩子藏起來!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=4},

                //156
                new Comic {ComicChineseName="男主角的頭號情敵",ComicEnglishName="TheHero'sNumberOneRival"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657112418/TheHero%27sNumberOneRival/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657112472/TheHero%27sNumberOneRival/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657112629/TheHero%27sNumberOneRival/2.png"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657112570/TheHero%27sNumberOneRival/1.webp"
                           ,BgColor       ="#3e7957",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=2
                           ,Publisher     ="SEOUL MEDIA COMICS, INC.",Painter="Matte",Author="Sol Leesu"
                           ,Introduction  ="被人渣男主角當情敵不想死又得守護女主角一邊還有戀情萌芽中?!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=4},


                


                //強檔鉅獻 5部
                //157
                new Comic {ComicChineseName="綠蔭之冠",ComicEnglishName="TheViridescentTiara"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657168578/TheViridescentTiara/5.png"
                           ,HotComicNameImage = "https://res.cloudinary.com/dmns6twmt/image/upload/v1657172141/TheViridescentTiara/6.png"
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657168802/TheViridescentTiara/4.jpg"
                           ,HotBgCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1657172309/TheViridescentTiara/8.jpg"
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657172501/TheViridescentTiara/2.png"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657168644/TheViridescentTiara/1.webp"
                           ,BgColor       ="#6789b4",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="DAON STUDIO",Painter="Siya",Author="Siya"
                           ,Introduction  ="因為穿越進自己寫的小說，我成了欺負男主角的繼姐!別擔心，我一定會讓你變得幸福。因為這本小說的作者就是我!「我從來都沒把姐姐當成是我的家人。」雖然我覺得自己很認真在實踐讓男主角幸福的計畫，但為什麼他沒把我當成家人看呢?在他成為公爵前，我真的能順利活下來嗎?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = "https://res.cloudinary.com/dmns6twmt/video/upload/v1657172254/TheViridescentTiara/7.webm"
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},


                //158
                new Comic {ComicChineseName="我獨自升級",ComicEnglishName="IUpgradeAlone"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657101816/IUpgradeAlone/5.png"
                           ,HotComicNameImage = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656961648/IUpgradeAlone/6.png"
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657101892/IUpgradeAlone/4.jpg"
                           ,HotBgCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656961763/IUpgradeAlone/8.jpg"
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657101751/IUpgradeAlone/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657101751/IUpgradeAlone/1.webp"
                           ,BgColor       ="#0d192d",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="D&C WEBTOON Biz",Painter="DUBU(REDICE STUDIO)",Author="Chugong"
                           ,Introduction  ="十幾年前，世界上出現了連接異次元與這個世界的通道「傳送門」， 而人群中還出現了覺醒之人。 在傳送門裡狩獵魔物的覺醒者們，又被稱為「獵人」。然而並不是所有獵人都很強。我叫成振宇， 是個E級獵人。我是連在低級地下城裡都得拼命才能死裡逃生的「人類最弱兵器」。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1657102004/IUpgradeAlone/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656961724/IUpgradeAlone/7.webm"
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=1},

                //159
                new Comic {ComicChineseName="驅魔麵館",ComicEnglishName="ExorcismNoodleShop"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657100910/ExorcismNoodleShop/5.png"
                           ,HotComicNameImage = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656961381/ExorcismNoodleShop/6.png"
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657100986/ExorcismNoodleShop/4.webp"
                           ,HotBgCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656961476/ExorcismNoodleShop/8.jpg"
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657100843/ExorcismNoodleShop/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657100843/ExorcismNoodleShop/1.webp"
                           ,BgColor       ="#122023",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=4
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Jang E",Author="Jang E"
                           ,Introduction  ="死後世界的各個邪惡靈魂為了永生不滅來到地球，一群驅魔人將會負責消滅它們。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1657101107/ExorcismNoodleShop/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656961436/ExorcismNoodleShop/7.webm"
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=1},


                //160
                new Comic {ComicChineseName="Dr.BRAIN",ComicEnglishName="Dr.BRAIN"
                           ,ComicNameImage=""
                           ,HotComicNameImage = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656960787/Dr.BRAIN/6.png"
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657099341/Dr.BRAIN/4.jpg"
                           ,HotBgCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656960950/Dr.BRAIN/8.jpg"
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657099231/Dr.BRAIN/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657099231/Dr.BRAIN/1.webp"
                           ,BgColor       ="#2b323c",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Hongjacga",Author="Hongjacga"
                           ,Introduction  ="天才腦科學家連接上亡者的大腦後，經歷了一連串的事件。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1657099633/Dr.BRAIN/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656960878/Dr.BRAIN/7.webm"
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},



                //161
                new Comic {ComicChineseName="我和社長相親相愛",ComicEnglishName="I'mLoveBoss"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1657176277/I%27mLoveBoss/5.png"
                           ,HotComicNameImage = "https://res.cloudinary.com/dmns6twmt/image/upload/v1657176804/I%27mLoveBoss/6.png"
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657176491/I%27mLoveBoss/4.jpg"
                           ,HotBgCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1657176849/I%27mLoveBoss/8.jpg"
                           ,ComicFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657176399/I%27mLoveBoss/1.webp"
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1657176399/I%27mLoveBoss/1.webp"
                           ,BgColor       ="#362d41",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=5
                           ,Publisher     ="Yeondam",Painter="NARAK",Author="Haehwa"
                           ,Introduction  ="「我們結婚吧。」扮成男女通吃的性感小野貓並代替朋友去相親的申荷莉，目標只有一個——徹底被甩掉!「姜泰武先生，你在哪裡工作?」「我是成云集團的社長。」「成云集團?我跟那裡很熟，因為——」因為...那是我公司!!!!!我到底為什麼會跟自己公司的社長相親啊?!而且他為什麼突然就跟我求婚了?!!!聽說他超級討厭說謊，要是穿幫就會馬上被開除!(可是...我還有貸款要繳啊...)這次的相親，會在公司刮起什麼腥風血雨呢?"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1657176618/I%27mLoveBoss/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = "https://res.cloudinary.com/dmns6twmt/video/upload/v1657176900/I%27mLoveBoss/7.webm"
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=3},


            };

            var ordercomic = comics.OrderBy(x => x.ComicChineseName);
            foreach (var c in ordercomic)
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
                new ComicTagList {TagId=11,ComicId=92},
                new ComicTagList {TagId=19,ComicId=92},
                new ComicTagList {TagId=26,ComicId=92},
                new ComicTagList {TagId=5,ComicId=92},

                new ComicTagList {TagId=11,ComicId=82},
                new ComicTagList {TagId=19,ComicId=82},
                new ComicTagList {TagId=26,ComicId=82},
                new ComicTagList {TagId=5,ComicId=82},

                new ComicTagList {TagId=10,ComicId=11},
                new ComicTagList {TagId=19,ComicId=11},
                new ComicTagList {TagId=20,ComicId=11},

                new ComicTagList {TagId=11,ComicId=26},
                new ComicTagList {TagId=19,ComicId=26},
                new ComicTagList {TagId=5,ComicId=26},
                new ComicTagList {TagId=2,ComicId=26},

                new ComicTagList {TagId=10,ComicId=153},
                new ComicTagList {TagId=20,ComicId=153},
                new ComicTagList {TagId=7,ComicId=153},
                new ComicTagList {TagId=21,ComicId=153},

                new ComicTagList {TagId=10,ComicId=63},
                new ComicTagList {TagId=20,ComicId=63},
                new ComicTagList {TagId=7,ComicId=63},
                new ComicTagList {TagId=21,ComicId=63},


                new ComicTagList {TagId=10,ComicId=128},
                new ComicTagList {TagId=20,ComicId=128},
                new ComicTagList {TagId=12,ComicId=128},
                new ComicTagList {TagId=14,ComicId=128},

                new ComicTagList {TagId=10,ComicId=50},
                new ComicTagList {TagId=15,ComicId=50},
                new ComicTagList {TagId=18,ComicId=50},
                new ComicTagList {TagId=4,ComicId=50},

                new ComicTagList {TagId=10,ComicId=23},
                new ComicTagList {TagId=7,ComicId=23},
                new ComicTagList {TagId=18,ComicId=23},
                new ComicTagList {TagId=17,ComicId=23},

                new ComicTagList {TagId=10,ComicId=148},
                new ComicTagList {TagId=19,ComicId=148},
                new ComicTagList {TagId=4,ComicId=148},
                new ComicTagList {TagId=17,ComicId=148},

                new ComicTagList {TagId=8,ComicId=112},
                new ComicTagList {TagId=3,ComicId=112},
                new ComicTagList {TagId=19,ComicId=112},
                new ComicTagList {TagId=17,ComicId=112},

                new ComicTagList {TagId=8,ComicId=143},
                new ComicTagList {TagId=3,ComicId=143},
                new ComicTagList {TagId=2,ComicId=143},
                new ComicTagList {TagId=18,ComicId=143},

                new ComicTagList {TagId=8,ComicId=66},
                new ComicTagList {TagId=1,ComicId=66},
                new ComicTagList {TagId=16,ComicId=66},
                new ComicTagList {TagId=15,ComicId=66},

                new ComicTagList {TagId=8,ComicId=101},
                new ComicTagList {TagId=16,ComicId=101},
                new ComicTagList {TagId=15,ComicId=101},
                new ComicTagList {TagId=14,ComicId=101},

                new ComicTagList {TagId=11,ComicId=32},
                new ComicTagList {TagId=1,ComicId=32},
                new ComicTagList {TagId=15,ComicId=32},
                new ComicTagList {TagId=5,ComicId=32},

                new ComicTagList {TagId=10,ComicId=7},
                new ComicTagList {TagId=20,ComicId=7},
                new ComicTagList {TagId=19,ComicId=7},
                new ComicTagList {TagId=1,ComicId=7},

                new ComicTagList {TagId=9,ComicId=56},
                new ComicTagList {TagId=3,ComicId=56},
                new ComicTagList {TagId=1,ComicId=56},
                new ComicTagList {TagId=18,ComicId=56},

                new ComicTagList {TagId=12,ComicId=156},
                new ComicTagList {TagId=2,ComicId=156},
                new ComicTagList {TagId=18,ComicId=156},
                new ComicTagList {TagId=3,ComicId=156},

                new ComicTagList {TagId=12,ComicId=74},
                new ComicTagList {TagId=19,ComicId=74},
                new ComicTagList {TagId=2,ComicId=74},
                new ComicTagList {TagId=18,ComicId=74},

                new ComicTagList {TagId=13,ComicId=39},
                new ComicTagList {TagId=15,ComicId=39},
                new ComicTagList {TagId=18,ComicId=39},
                new ComicTagList {TagId=21,ComicId=39},

                new ComicTagList {TagId=8,ComicId=59},
                new ComicTagList {TagId=17,ComicId=59},
                new ComicTagList {TagId=15,ComicId=59},
                new ComicTagList {TagId=18,ComicId=59},

                new ComicTagList {TagId=12,ComicId=2},
                new ComicTagList {TagId=26,ComicId=2},
                new ComicTagList {TagId=5,ComicId=2},
                new ComicTagList {TagId=2,ComicId=2},

                new ComicTagList {TagId=8,ComicId=100},
                new ComicTagList {TagId=17,ComicId=100},
                new ComicTagList {TagId=18,ComicId=100},
                new ComicTagList {TagId=1,ComicId=100},

                new ComicTagList {TagId=8,ComicId=104},
                new ComicTagList {TagId=20,ComicId=104},
                new ComicTagList {TagId=19,ComicId=104},


                new ComicTagList {TagId=2,ComicId=22},
                new ComicTagList {TagId=17,ComicId=22},
                new ComicTagList {TagId=21,ComicId=22},
                new ComicTagList {TagId=4,ComicId=22},

                new ComicTagList {TagId=11,ComicId=21},
                new ComicTagList {TagId=4,ComicId=21},
                new ComicTagList {TagId=19,ComicId=21},
                new ComicTagList {TagId=16,ComicId=21},

                new ComicTagList {TagId=8,ComicId=86},
                new ComicTagList {TagId=16,ComicId=86},
                new ComicTagList {TagId=22,ComicId=86},
                new ComicTagList {TagId=15,ComicId=86},

                new ComicTagList {TagId=11,ComicId=1},
                new ComicTagList {TagId=28,ComicId=1},
                new ComicTagList {TagId=27,ComicId=1},
                new ComicTagList {TagId=3,ComicId=1},

                new ComicTagList {TagId=9,ComicId=15},
                new ComicTagList {TagId=17,ComicId=15},
                new ComicTagList {TagId=1,ComicId=15},
                new ComicTagList {TagId=15,ComicId=15},

                new ComicTagList {TagId=9,ComicId=45},
                new ComicTagList {TagId=2,ComicId=45},
                new ComicTagList {TagId=17,ComicId=45},
                new ComicTagList {TagId=16,ComicId=45},

                new ComicTagList {TagId=11,ComicId=83},
                new ComicTagList {TagId=28,ComicId=83},
                new ComicTagList {TagId=17,ComicId=83},
                new ComicTagList {TagId=16,ComicId=83},

                new ComicTagList {TagId=9,ComicId=70},
                new ComicTagList {TagId=22,ComicId=70},
                new ComicTagList {TagId=15,ComicId=70},
                new ComicTagList {TagId=3,ComicId=70},

                new ComicTagList {TagId=12,ComicId=4},
                new ComicTagList {TagId=2,ComicId=4},
                new ComicTagList {TagId=17,ComicId=4},
                new ComicTagList {TagId=5,ComicId=4},

                new ComicTagList {TagId=8,ComicId=30},
                new ComicTagList {TagId=1,ComicId=30},
                new ComicTagList {TagId=16,ComicId=30},
                new ComicTagList {TagId=15,ComicId=30},

                new ComicTagList {TagId=10,ComicId=42},
                new ComicTagList {TagId=25,ComicId=42},
                new ComicTagList {TagId=6,ComicId=42},
                new ComicTagList {TagId=23,ComicId=42},

                new ComicTagList {TagId=9,ComicId=134},
                new ComicTagList {TagId=5,ComicId=134},
                new ComicTagList {TagId=3,ComicId=134},
                new ComicTagList {TagId=2,ComicId=134},

                new ComicTagList {TagId=9,ComicId=108},
                new ComicTagList {TagId=2,ComicId=108},
                new ComicTagList {TagId=3,ComicId=108},
                new ComicTagList {TagId=1,ComicId=108},

                new ComicTagList {TagId=11,ComicId=132},
                new ComicTagList {TagId=17,ComicId=132},
                new ComicTagList {TagId=16,ComicId=132},
                new ComicTagList {TagId=15,ComicId=132},

                new ComicTagList {TagId=12,ComicId=96},
                new ComicTagList {TagId=14,ComicId=96},
                new ComicTagList {TagId=5,ComicId=96},
                new ComicTagList {TagId=3,ComicId=96},

                new ComicTagList {TagId=8,ComicId=52},
                new ComicTagList {TagId=25,ComicId=52},
                new ComicTagList {TagId=6,ComicId=52},
                new ComicTagList {TagId=1,ComicId=52},

                new ComicTagList {TagId=11,ComicId=125},
                new ComicTagList {TagId=19,ComicId=125},
                new ComicTagList {TagId=18,ComicId=125},
                new ComicTagList {TagId=25,ComicId=125},

                new ComicTagList {TagId=13,ComicId=115},
                new ComicTagList {TagId=4,ComicId=115},
                new ComicTagList {TagId=3,ComicId=115},
                new ComicTagList {TagId=21,ComicId=115},

                new ComicTagList {TagId=10,ComicId=140},
                new ComicTagList {TagId=20,ComicId=140},
                new ComicTagList {TagId=27,ComicId=140},
                new ComicTagList {TagId=25,ComicId=140},


                new ComicTagList {TagId=11,ComicId=152},
                new ComicTagList {TagId=23,ComicId=152},
                new ComicTagList {TagId=16,ComicId=152},
                new ComicTagList {TagId=18,ComicId=152},


                new ComicTagList {TagId=11,ComicId=95},
                new ComicTagList {TagId=20,ComicId=95},
                new ComicTagList {TagId=19,ComicId=95},
                new ComicTagList {TagId=1,ComicId=95},

                new ComicTagList {TagId=11,ComicId=14},
                new ComicTagList {TagId=3,ComicId=14},
                new ComicTagList {TagId=17,ComicId=14},
                new ComicTagList {TagId=4,ComicId=14},

                new ComicTagList {TagId=11,ComicId=151},
                new ComicTagList {TagId=15,ComicId=151},
                new ComicTagList {TagId=16,ComicId=151},
                new ComicTagList {TagId=3,ComicId=151},

                new ComicTagList {TagId=9,ComicId=49},
                new ComicTagList {TagId=3,ComicId=49},
                new ComicTagList {TagId=2,ComicId=49},
                new ComicTagList {TagId=22,ComicId=49},

                new ComicTagList {TagId=11,ComicId=55},
                new ComicTagList {TagId=3,ComicId=55},
                new ComicTagList {TagId=2,ComicId=55},
                new ComicTagList {TagId=1,ComicId=55},

                new ComicTagList {TagId=10,ComicId=147},
                new ComicTagList {TagId=20,ComicId=147},
                new ComicTagList {TagId=25,ComicId=147},
                new ComicTagList {TagId=23,ComicId=147},

            };
            var ordertagList = comictaglists.OrderBy(x => x.ComicId).ThenBy(x => x.TagId);
            foreach (var list in ordertagList)
            {
                _repository.Create(list);
            }
            _repository.SaveChange();

        }
        public void ComicTagListUpdate()
        {
            //var updateTagList = _repository.GetAll<ComicTagList>().Where(x => x.TageListId == 2).FirstOrDefault();
            var updateComic   = _repository.GetAll<Comic>().Where(x => x.ComicId == 11).FirstOrDefault();
            var updateComic1  = _repository.GetAll<Comic>().Where(x => x.ComicId == 12).FirstOrDefault();
            var updateComic2  = _repository.GetAll<Comic>().Where(x => x.ComicId == 13).FirstOrDefault();
            updateComic  .ComicStatus = 3;
            updateComic1 .ComicStatus = 3;
            updateComic2.ComicStatus = 3;
           
            //_repository.Update(updateTagList);
            _repository.Update(updateComic  );
            _repository.Update(updateComic1 );
            _repository.Update(updateComic2 );
            
            _repository.SaveChange();

        }

        //[Http]
        public void EpCreate(/*int Comicid*/)
        {
            var epList = new List<Episode>
            {
                //EpId =1, 
                  new Episode(){ ComicId = 1, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 1, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 1, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 1, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 1, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 1, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                  new Episode(){ ComicId = 1, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                  new Episode(){ ComicId = 1, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                  new Episode(){ ComicId = 1, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                  new Episode(){ ComicId = 1, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

                  new Episode(){ ComicId = 2, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 2, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 2, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 2, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 2, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 2, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                  new Episode(){ ComicId = 2, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                  new Episode(){ ComicId = 2, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                  new Episode(){ ComicId = 2, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                  new Episode(){ ComicId = 2, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

                  new Episode(){ ComicId = 3, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 3, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 3, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 3, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 3, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 3, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                  new Episode(){ ComicId = 3, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                  new Episode(){ ComicId = 3, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                  new Episode(){ ComicId = 3, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                  new Episode(){ ComicId = 3, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

                  new Episode(){ ComicId = 4, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 4, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 4, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 4, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 4, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 4, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                  new Episode(){ ComicId = 4, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                  new Episode(){ ComicId = 4, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                  new Episode(){ ComicId = 4, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                  new Episode(){ ComicId = 4, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


                  new Episode(){ ComicId = 5, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 5, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 5, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 5, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 5, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                  new Episode(){ ComicId = 5, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                  new Episode(){ ComicId = 5, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                  new Episode(){ ComicId = 5, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                  new Episode(){ ComicId = 5, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                  new Episode(){ ComicId = 5, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

                    new Episode(){ ComicId = 6, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                    new Episode(){ ComicId = 6, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                    new Episode(){ ComicId = 6, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                    new Episode(){ ComicId = 6, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                    new Episode(){ ComicId = 6, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                    new Episode(){ ComicId = 6, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                    new Episode(){ ComicId = 6, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                    new Episode(){ ComicId = 6, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                    new Episode(){ ComicId = 6, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                    new Episode(){ ComicId = 6, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

                     new Episode(){ ComicId = 7, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                     new Episode(){ ComicId = 7, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                     new Episode(){ ComicId = 7, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                     new Episode(){ ComicId = 7, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                     new Episode(){ ComicId = 7, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                     new Episode(){ ComicId = 7, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                     new Episode(){ ComicId = 7, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                     new Episode(){ ComicId = 7, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                     new Episode(){ ComicId = 7, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                     new Episode(){ ComicId = 7, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

                     new Episode(){ ComicId = 8, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                     new Episode(){ ComicId = 8, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                     new Episode(){ ComicId = 8, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                     new Episode(){ ComicId = 8, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                     new Episode(){ ComicId = 8, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                     new Episode(){ ComicId = 8, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                     new Episode(){ ComicId = 8, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                     new Episode(){ ComicId = 8, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                     new Episode(){ ComicId = 8, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                     new Episode(){ ComicId = 8, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

                     new Episode(){ ComicId = 9, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                     new Episode(){ ComicId = 9, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                     new Episode(){ ComicId = 9, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                     new Episode(){ ComicId = 9, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                     new Episode(){ ComicId = 9, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                     new Episode(){ ComicId = 9, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                     new Episode(){ ComicId = 9, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                     new Episode(){ ComicId = 9, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                     new Episode(){ ComicId = 9, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                     new Episode(){ ComicId = 9, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

                       new Episode(){ ComicId = 10, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                       new Episode(){ ComicId = 10, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                       new Episode(){ ComicId = 10, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                       new Episode(){ ComicId = 10, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                       new Episode(){ ComicId = 10, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                       new Episode(){ ComicId = 10, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                       new Episode(){ ComicId = 10, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                       new Episode(){ ComicId = 10, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                       new Episode(){ ComicId = 10, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                       new Episode(){ ComicId = 10, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
             
                           //11
                       new Episode(){ ComicId = 11, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                       new Episode(){ ComicId = 11, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                       new Episode(){ ComicId = 11, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                       new Episode(){ ComicId = 11, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                       new Episode(){ ComicId = 11, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                       new Episode(){ ComicId = 11, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                       new Episode(){ ComicId = 11, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                       new Episode(){ ComicId = 11, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                       new Episode(){ ComicId = 11, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                       new Episode(){ ComicId = 11, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


                       new Episode(){ ComicId = 12, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                       new Episode(){ ComicId = 12, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                       new Episode(){ ComicId = 12, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                       new Episode(){ ComicId = 12, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                       new Episode(){ ComicId = 12, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                       new Episode(){ ComicId = 12, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                       new Episode(){ ComicId = 12, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                       new Episode(){ ComicId = 12, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                       new Episode(){ ComicId = 12, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                       new Episode(){ ComicId = 12, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

                   new Episode(){ ComicId = 13, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 13, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 13, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 13, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 13, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 13, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 13, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 13, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 13, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 13, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

           new Episode(){ ComicId = 14, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
           new Episode(){ ComicId = 14, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
           new Episode(){ ComicId = 14, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
           new Episode(){ ComicId = 14, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 14, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 14, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 14, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 14, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 14, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 14, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

           new Episode(){ ComicId = 15, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
           new Episode(){ ComicId = 15, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
           new Episode(){ ComicId = 15, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
           new Episode(){ ComicId = 15, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 15, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 15, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 15, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 15, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 15, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 15, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

           new Episode(){ ComicId = 16, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
           new Episode(){ ComicId = 16, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
           new Episode(){ ComicId = 16, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
           new Episode(){ ComicId = 16, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 16, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 16, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 16, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 16, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 16, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 16, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

           new Episode(){ ComicId = 17, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
           new Episode(){ ComicId = 17, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
           new Episode(){ ComicId = 17, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
           new Episode(){ ComicId = 17, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 17, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 17, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 17, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 17, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 17, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 17, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

           new Episode(){ ComicId = 18, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
           new Episode(){ ComicId = 18, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
           new Episode(){ ComicId = 18, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
           new Episode(){ ComicId = 18, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 18, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 18, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 18, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 18, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 18, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           new Episode(){ ComicId = 18, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

              new Episode(){ ComicId = 19, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 19, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 19, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 19, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 19, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 19, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 19, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 19, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 19, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 19, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


              new Episode(){ ComicId = 20, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 20, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 20, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 20, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 20, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 20, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 20, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 20, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 20, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 20, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           
                //21
             new Episode(){ ComicId = 21, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
             new Episode(){ ComicId = 21, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
             new Episode(){ ComicId = 21, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
             new Episode(){ ComicId = 21, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
             new Episode(){ ComicId = 21, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
             new Episode(){ ComicId = 21, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
             new Episode(){ ComicId = 21, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
             new Episode(){ ComicId = 21, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
             new Episode(){ ComicId = 21, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
             new Episode(){ ComicId = 21, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

             new Episode(){ ComicId = 22, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,06,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,06,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
             new Episode(){ ComicId = 22, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,06,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
             new Episode(){ ComicId = 22, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
             new Episode(){ ComicId = 22, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
             new Episode(){ ComicId = 22, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
             new Episode(){ ComicId = 22, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
             new Episode(){ ComicId = 22, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
             new Episode(){ ComicId = 22, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
             new Episode(){ ComicId = 22, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
             new Episode(){ ComicId = 22, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           
           
           
           
           
           
                //23
              new Episode(){ ComicId = 23, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 23, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 23, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 23, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 23, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 23, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 23, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 23, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 23, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 23, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

              new Episode(){ ComicId = 24, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 24, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 24, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 24, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 24, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 24, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 24, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 24, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 24, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 24, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


              new Episode(){ ComicId = 25, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 25, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 25, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 25, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 25, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 25, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 25, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 25, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 25, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 25, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

              new Episode(){ ComicId = 26, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 26, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 26, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 26, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 26, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 26, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 26, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 26, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 26, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 26, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},



              new Episode(){ ComicId = 27, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 27, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 27, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 27, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 27, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 27, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 27, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 27, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 27, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 27, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


              new Episode(){ ComicId = 28, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 28, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 28, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 28, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 28, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 28, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 28, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 28, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 28, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 28, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


              new Episode(){ ComicId = 29, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 29, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 29, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 29, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 29, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 29, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 29, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 29, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 29, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 29, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              
              //30
              new Episode(){ ComicId = 30, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 30, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 30, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 30, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 30, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 30, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 30, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 30, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 30, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 30, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


              new Episode(){ ComicId = 31, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 31, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 31, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 31, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 31, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 31, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 31, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 31, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 31, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 31, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

              new Episode(){ ComicId = 32, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 32, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 32, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 32, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 32, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 32, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 32, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 32, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 32, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 32, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

              new Episode(){ ComicId = 33, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 33, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 33, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 33, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 33, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 33, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 33, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 33, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 33, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 33, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

              new Episode(){ ComicId = 34, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 34, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 34, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 34, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 34, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 34, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 34, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 34, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 34, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 34, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              
              
              
              
              //35
              new Episode(){ ComicId = 35, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 35, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 35, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 35, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 35, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 35, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 35, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 35, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 35, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 35, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


              new Episode(){ ComicId = 36, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 36, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 36, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 36, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 36, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 36, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 36, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 36, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 36, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 36, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

              new Episode(){ ComicId = 37, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 37, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 37, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 37, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 37, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 37, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 37, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 37, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 37, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 37, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


              new Episode(){ ComicId = 38, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 38, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 38, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 38, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 38, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 38, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 38, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 38, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 38, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 38, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

              new Episode(){ ComicId = 39, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 39, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 39, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 39, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 39, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 39, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 39, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 39, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 39, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 39, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              
              //40
              new Episode(){ ComicId = 40, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 40, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 40, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 40, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 40, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 40, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 40, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 40, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 40, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 40, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           
              ////41
              new Episode(){ ComicId = 41, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 41, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 41, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 41, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 41, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 41, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 41, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 41, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 41, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 41, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              
              
              
              //42
              new Episode(){ ComicId = 42, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 42, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 42, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 42, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 42, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 42, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 42, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 42, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 42, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 42, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              
              //改
              //////43
              new Episode(){ ComicId = 43, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 43, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 43, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 43, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 43, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 43, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 43, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 43, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 43, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 43, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              
               //44
              new Episode(){ ComicId = 44, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,07,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,07,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 44, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,07,03),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,07,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 44, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 44, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 44, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 44, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 44, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 44, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 44, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 44, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           
           
           
           
           
           
           
           
           
              ////45
              new Episode(){ ComicId = 45, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 45, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 45, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 45, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 45, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 45, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 45, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 45, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 45, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 45, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              
              
              //46
              new Episode(){ ComicId = 46, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 46, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 46, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 46, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 46, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 46, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 46, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 46, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 46, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 46, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              
              
               //////47
              new Episode(){ ComicId = 47, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 47, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 47, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 47, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 47, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 47, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 47, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 47, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 47, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 47, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              
              
               //48
              new Episode(){ ComicId = 48, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 48, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 48, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 48, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 48, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 48, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 48, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 48, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 48, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 48, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
           
           
           
              /////49
              new Episode(){ ComicId = 49, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 49, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 49, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 49, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 49, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 49, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 49, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 49, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 49, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 49, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              
              
               //50
              new Episode(){ ComicId = 50, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 50, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 50, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 50, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 50, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
              new Episode(){ ComicId = 50, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 50, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 50, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 50, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
              new Episode(){ ComicId = 50, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


                ////51
                new Episode(){ ComicId = 51, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 51, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 51, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 51, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 51, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 51, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 51, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 51, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 51, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 51, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                
                
                 //52
                new Episode(){ ComicId = 52, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 52, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 52, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 52, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 52, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 52, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 52, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 52, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 52, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 52, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


                ////53
                new Episode(){ ComicId = 53, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 53, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 53, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 53, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 53, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 53, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 53, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 53, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 53, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 53, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                
                
                
                 //54
                new Episode(){ ComicId = 54, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 54, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 54, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 54, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 54, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 54, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 54, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 54, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 54, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 54, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                
                
                //////55
                new Episode(){ ComicId = 55, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 55, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 55, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 55, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 55, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 55, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 55, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 55, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 55, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 55, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                
                
                //56
                new Episode(){ ComicId = 56, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 56, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 56, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 56, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 56, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 56, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 56, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 56, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 56, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 56, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


                ////57
                new Episode(){ ComicId = 57, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 57, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 57, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 57, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 57, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 57, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 57, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 57, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 57, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 57, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                
                
                //58
                new Episode(){ ComicId = 58, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 58, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 58, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 58, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 58, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 58, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 58, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 58, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 58, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 58, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                
                
                //////59
                new Episode(){ ComicId = 59, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 59, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 59, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 59, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 59, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 59, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 59, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 59, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 59, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 59, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                
                
                //60
                new Episode(){ ComicId = 60, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 60, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 60, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 60, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 60, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 60, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 60, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 60, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 60, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 60, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


                ////61
                new Episode(){ ComicId = 61, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 61, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 61, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 61, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 61, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 61, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 61, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 61, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 61, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 61, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                
                
                 //62
                new Episode(){ ComicId = 62, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 62, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 62, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 62, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 62, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 62, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 62, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 62, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 62, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 62, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                
                
                //////63
                new Episode(){ ComicId = 63, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 63, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 63, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 63, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 63, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 63, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 63, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 63, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 63, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 63, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                
                
                //64
                new Episode(){ ComicId = 64, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 64, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 64, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 64, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 64, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 64, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 64, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 64, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 64, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 64, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


                ////65
                new Episode(){ ComicId = 65, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 65, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 65, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 65, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 65, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 65, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 65, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 65, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 65, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 65, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                
                
                
                //66
                new Episode(){ ComicId = 66, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,08,02),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new DateTime(2021,08,02),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 66, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 66, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 66, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 66, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 66, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 66, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 66, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 66, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                new Episode(){ ComicId = 66, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},













                     //阿傑
                    //////67
                   new Episode(){ ComicId = 67, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 67, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 67, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 67, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 67, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 67, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 67, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 67, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 67, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 67, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   //68
                   new Episode(){ ComicId = 68, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 68, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 68, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 68, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 68, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 68, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 68, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 68, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 68, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 68, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


                   //////69
                   new Episode(){ ComicId = 69, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 69, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 69, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 69, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 69, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 69, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 69, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 69, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 69, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 69, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                
                
                    //70
                   new Episode(){ ComicId = 70, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 70, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 70, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 70, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 70, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 70, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 70, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 70, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 70, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 70, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                
                
                   //////71
                   new Episode(){ ComicId = 71, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 71, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 71, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 71, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 71, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 71, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 71, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 71, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 71, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 71, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                
                
                
                   //72
                   new Episode(){ ComicId = 72, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 72, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 72, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 72, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 72, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 72, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 72, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 72, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 72, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 72, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},



                   ////73
                   new Episode(){ ComicId = 73, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 73, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 73, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 73, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 73, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 73, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 73, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 73, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 73, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 73, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   //74
                   new Episode(){ ComicId = 74, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 74, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 74, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 74, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 74, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 74, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 74, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 74, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 74, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 74, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   ///////75
                   new Episode(){ ComicId = 75, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 75, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 75, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 75, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 75, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 75, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 75, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 75, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 75, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 75, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   //76
                   new Episode(){ ComicId = 76, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 76, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 76, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 76, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 76, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 76, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 76, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 76, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 76, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 76, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   ///////77
                   new Episode(){ ComicId = 77, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 77, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 77, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 77, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 77, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 77, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 77, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 77, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 77, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 77, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


                   //78
                   new Episode(){ ComicId = 78, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 78, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 78, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 78, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 78, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 78, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 78, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 78, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 78, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 78, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   ///////79
                   new Episode(){ ComicId = 79, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 79, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 79, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 79, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 79, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 79, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 79, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 79, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 79, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 79, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                    //80
                   new Episode(){ ComicId = 80, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 80, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 80, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 80, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 80, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 80, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 80, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 80, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 80, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 80, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   ///////81
                   new Episode(){ ComicId = 81, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 81, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 81, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 81, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 81, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 81, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 81, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 81, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 81, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 81, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   //82
                   new Episode(){ ComicId = 82, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 82, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 82, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 82, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 82, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 82, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 82, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 82, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 82, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 82, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


                   ///////83
                   new Episode(){ ComicId = 83, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 83, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 83, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 83, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 83, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 83, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 83, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 83, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 83, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 83, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   //84
                   new Episode(){ ComicId = 84, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 84, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 84, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 84, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 84, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 84, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 84, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 84, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 84, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 84, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   ///////85
                   new Episode(){ ComicId = 85, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 85, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 85, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 85, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 85, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 85, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 85, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 85, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 85, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 85, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   //86
                   new Episode(){ ComicId = 86, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 86, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 86, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 86, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 86, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 86, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 86, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 86, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 86, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 86, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                    ///////87
                   new Episode(){ ComicId = 87, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 87, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 87, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 87, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 87, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 87, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 87, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 87, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 87, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 87, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


                    //88                                                                                                                                                                                                                  //88
                   new Episode(){ ComicId = 88, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,09,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new  DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 88, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,05),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new  DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 88, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new  DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 88, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 88, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 88, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 88, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 88, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 88, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 88, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},










                    ///////89
                   new Episode(){ ComicId = 89, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new  DateTime(2021,12,03),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 89, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new  DateTime(2021,01,03),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 89, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new  DateTime(2021,02,03),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 89, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new  DateTime(2021,03,03),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 89, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new  DateTime(2021,04,03),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 89, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new  DateTime(2021,05,03),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 89, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new  DateTime(2021,06,03),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 89, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new  DateTime(2021,01,03),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 89, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new  DateTime(2021,12,03),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 89, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,03),AuditType=1,AuditEmployeeId=5,AuditTime=new   DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   //90
                   new Episode(){ ComicId = 90, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new  DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 90, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new  DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 90, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new  DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 90, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new  DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 90, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 90, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 90, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 90, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 90, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 90, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   ///////91
                   new Episode(){ ComicId = 91, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 91, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 91, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 91, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 91, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 91, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 91, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 91, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 91, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 91, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   //92
                   new Episode(){ ComicId = 92, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 92, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 92, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 92, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 92, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 92, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 92, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 92, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 92, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 92, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new  DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   ///////93
                   new Episode(){ ComicId = 93, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  (2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 93, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  (2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 93, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  (2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 93, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  (2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 93, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  (2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 93, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  (2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 93, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  (2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 93, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  (2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 93, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  (2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 93, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new (2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   //94
                   new Episode(){ ComicId = 94, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 94, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 94, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 94, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 94, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 94, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 94, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 94, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 94, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 94, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new  DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   ///////95
                   new Episode(){ ComicId = 95, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 95, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 95, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 95, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 95, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 95, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 95, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 95, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 95, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 95, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   //96
                   new Episode(){ ComicId = 96, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 96, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 96, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 96, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 96, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 96, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 96, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 96, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 96, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 96, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new  DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   ///97
                   new Episode(){ ComicId = 97, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new   DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 97, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new   DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 97, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new   DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 97, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new  DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 97, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 97, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new  DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 97, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new  DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 97, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new  DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 97, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new   DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 97, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new   DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   //98
                   new Episode(){ ComicId = 98, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 98, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 98, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 98, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 98, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 98, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 98, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 98, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 98, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 98, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new  DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   ///////99
                   new Episode(){ ComicId = 99, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 99, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 99, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 99, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 99, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 99, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 99, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 99, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 99, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 99, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   //100
                   new Episode(){ ComicId = 100, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 100, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 100, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 100, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 100, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 100, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 100, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 100, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 100, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 100, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new  DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                    ///////101
                   new Episode(){ ComicId = 101, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 101, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 101, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 101, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 101, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 101, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 101, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 101, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 101, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 101, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   //102
                   new Episode(){ ComicId = 102, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 102, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 102, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 102, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 102, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 102, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 102, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 102, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 102, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 102, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new  DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   //////103
                   new Episode(){ ComicId = 103, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 103, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 103, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 103, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 103, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 103, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 103, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 103, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 103, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 103, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   //104
                   new Episode(){ ComicId = 104, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 104, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 104, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 104, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 104, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 104, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 104, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 104, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 104, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 104, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new  DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   ///////105
                   new Episode(){ ComicId = 105, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 105, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 105, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 105, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 105, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 105, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 105, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 105, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 105, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 105, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   //106
                   new Episode(){ ComicId = 106, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 106, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 106, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 106, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 106, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 106, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 106, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 106, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 106, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 106, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new  DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   ///////107
                   new Episode(){ ComicId = 107, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 107, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 107, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 107, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 107, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 107, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 107, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 107, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 107, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 107, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   //108
                   new Episode(){ ComicId = 108, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 108, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 108, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 108, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 108, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 108, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 108, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 108, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 108, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 108, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new  DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   ///////109
                   new Episode(){ ComicId = 109, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 109, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 109, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 109, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 109, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 109, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 109, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 109, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 109, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 109, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   //110                                                                                                                                                                             //110                                                                         //110
                   new Episode(){ ComicId = 110, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,10,28),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,10,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 110, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,10,29),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,10,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 110, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,11,28),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2021,11,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 110, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,11,29),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2021,11,29),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 110, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,28),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,01,28),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 110, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,28),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,02,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 110, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,28),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,03,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 110, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,28),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,04,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 110, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,28),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,05,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 110, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,28),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new  DateTime(2022,06,28),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   ///////111
                   new Episode(){ ComicId = 111, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 111, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 111, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 111, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 111, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 111, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 111, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 111, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 111, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 111, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   //112
                   new Episode(){ ComicId = 112, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new  DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new  DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 112, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new  DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new  DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 112, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new  DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new  DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 112, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new  DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new  DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 112, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new  DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 112, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new  DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 112, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new  DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 112, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new  DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 112, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new  DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 112, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

                   //////113
                   new Episode(){ ComicId = 113, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 113, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 113, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 113, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 113, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 113, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 113, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 113, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 113, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 113, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new  DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   //114
                   new Episode(){ ComicId = 114, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 114, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 114, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 114, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 114, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 114, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 114, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 114, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 114, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 114, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                    ///////115
                   new Episode(){ ComicId = 115, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 115, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 115, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 115, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 115, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 115, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 115, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 115, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 115, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 115, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                    //116
                   new Episode(){ ComicId = 116, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 116, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 116, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 116, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 116, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 116, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 116, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 116, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 116, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 116, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                     ///////117
                   new Episode(){ ComicId = 117, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 117, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 117, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 117, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 117, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 117, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 117, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 117, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 117, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 117, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   
                    //118
                   new Episode(){ ComicId = 118, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 118, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 118, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 118, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 118, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 118, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 118, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 118, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 118, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 118, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   ///////119
                   new Episode(){ ComicId = 119, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 119, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 119, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 119, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 119, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 119, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 119, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 119, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 119, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 119, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   //120
                   new Episode(){ ComicId = 120, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 120, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 120, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 120, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 120, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 120, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 120, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 120, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 120, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 120, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                    ///////121
                   new Episode(){ ComicId = 121, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 121, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 121, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 121, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 121, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 121, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 121, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 121, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 121, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 121, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   //122
                   new Episode(){ ComicId = 122, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 122, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 122, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 122, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 122, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 122, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 122, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 122, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 122, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 122, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


                   ///////123
                   new Episode(){ ComicId = 123, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 123, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 123, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 123, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 123, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 123, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 123, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 123, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 123, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 123, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                    //124
                   new Episode(){ ComicId = 124, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 124, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 124, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 124, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 124, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 124, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 124, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 124, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 124, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 124, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   
                   ///////125
                   new Episode(){ ComicId = 125, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 125, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 125, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 125, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 125, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 125, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 125, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 125, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 125, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 125, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   
                    //126
                   new Episode(){ ComicId = 126, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 126, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 126, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 126, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 126, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 126, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 126, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 126, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 126, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 126, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   ///////127
                   new Episode(){ ComicId = 127, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 127, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 127, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 127, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 127, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 127, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 127, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 127, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 127, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 127, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                    //128
                   new Episode(){ ComicId = 128, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 128, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 128, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 128, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 128, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 128, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 128, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 128, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 128, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 128, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   ///////129
                   new Episode(){ ComicId = 129, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 129, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 129, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 129, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 129, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 129, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 129, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 129, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 129, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 129, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   //130
                   new Episode(){ ComicId = 130, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 130, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 130, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 130, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 130, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 130, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 130, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 130, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 130, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 130, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                    ///////131
                   new Episode(){ ComicId = 131, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 131, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 131, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 131, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 131, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 131, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 131, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 131, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 131, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 131, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   
                   //132                                                                                                                                                                             //132                                                                         //132
                   new Episode(){ ComicId = 132, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,11,03),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,11,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 132, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,11,04),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,11,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 132, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,12,03),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2021,12,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 132, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,12,04),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2021,12,04),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 132, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,01,03),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,01,03),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 132, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,02,03),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,02,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 132, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,03,03),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,03,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 132, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,04,03),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,04,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 132, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,05,03),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,05,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 132, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,06,03),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,06,03),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},



                   //////133
                   new Episode(){ ComicId = 133, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new  DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 133, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new  DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 133, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new  DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 133, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new  DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 133, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new  DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 133, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new  DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 133, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new  DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 133, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new  DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 133, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new  DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 133, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new  DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                    //134
                   new Episode(){ ComicId = 134, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 134, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 134, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 134, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 134, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 134, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 134, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 134, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 134, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 134, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                    ///////135
                   new Episode(){ ComicId = 135, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 135, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 135, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 135, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 135, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 135, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 135, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 135, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 135, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 135, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   //136
                   new Episode(){ ComicId = 136, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 136, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 136, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 136, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 136, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 136, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 136, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 136, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 136, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 136, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   ///////137
                   new Episode(){ ComicId = 137, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 137, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 137, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 137, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 137, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 137, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 137, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 137, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 137, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 137, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   //138
                   new Episode(){ ComicId = 138, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 138, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 138, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 138, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 138, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 138, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 138, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 138, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 138, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 138, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   ///////139
                   new Episode(){ ComicId = 139, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 139, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 139, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 139, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 139, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 139, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 139, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 139, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 139, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 139, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                    //140
                   new Episode(){ ComicId = 140, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 140, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 140, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 140, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 140, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 140, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 140, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 140, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 140, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 140, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                    ///////141
                   new Episode(){ ComicId = 141, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 141, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 141, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 141, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 141, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 141, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 141, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 141, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 141, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 141, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                    //142
                   new Episode(){ ComicId = 142, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 142, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 142, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 142, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 142, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 142, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 142, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 142, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 142, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 142, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

                   //////143
                   new Episode(){ ComicId = 143, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 143, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 143, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 143, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 143, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 143, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 143, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 143, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 143, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 143, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   //144
                   new Episode(){ ComicId = 144, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 144, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 144, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 144, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 144, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 144, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 144, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 144, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 144, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 144, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   ///////145
                   new Episode(){ ComicId = 145, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 145, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 145, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 145, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 145, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 145, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 145, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 145, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 145, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 145, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                    //146
                   new Episode(){ ComicId = 146, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 146, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 146, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 146, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 146, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 146, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 146, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 146, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 146, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 146, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                    ///////147
                   new Episode(){ ComicId = 147, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 147, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 147, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 147, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 147, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 147, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 147, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 147, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 147, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 147, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   //148
                   new Episode(){ ComicId = 148, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 148, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 148, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 148, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 148, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 148, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 148, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 148, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 148, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 148, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                    ///////149
                   new Episode(){ ComicId = 149, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 149, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 149, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 149, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 149, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 149, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 149, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 149, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 149, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 149, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                   
                   //150
                   new Episode(){ ComicId = 150, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 150, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 150, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 150, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 150, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 150, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 150, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 150, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 150, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 150, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   
                    ///////151
                   new Episode(){ ComicId = 151, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 151, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 151, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 151, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 151, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 151, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 151, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 151, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 151, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 151, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   
                   //152
                   new Episode(){ ComicId = 152, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 152, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 152, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 152, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 152, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 152, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 152, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 152, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 152, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 152, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

                   ///////153
                   new Episode(){ ComicId = 153, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 153, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 153, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 153, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 153, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 153, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 153, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 153, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 153, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 153, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

                    //154
                   new Episode(){ ComicId = 154, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 154, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 154, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 154, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 154, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 154, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 154, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 154, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 154, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 154, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

                    ///////155
                   new Episode(){ ComicId = 155, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 155, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 155, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 155, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 155, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 155, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 155, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 155, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 155, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 155, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


                    //156
                   new Episode(){ ComicId = 156, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 156, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 156, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 156, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 156, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 156, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 156, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 156, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 156, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 156, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

                    ///////157
                   new Episode(){ ComicId = 157, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 157, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 157, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 157, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 157, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 157, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 157, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 157, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 157, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 157, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},

                    //158
                   new Episode(){ ComicId = 158, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=4,AuditTime=new   DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 158, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=7,AuditTime=new   DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 158, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=8,AuditTime=new   DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 158, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=9,AuditTime=new   DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 158, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=12,AuditTime=new  DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 158, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=13,AuditTime=new  DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 158, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=16,AuditTime=new  DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 158, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=15,AuditTime=new  DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 158, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=14,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 158, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},


                    ///////159
                   new Episode(){ ComicId = 159, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 159, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 159, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 159, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 159, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 159, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 159, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 159, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 159, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 159, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},



                ///////160
                   new Episode(){ ComicId = 160, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 160, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 160, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 160, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 160, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 160, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 160, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 160, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 160, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 160, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},



                    ///////161                                                                                                                                                                             //161                                                                         //161
                   new Episode(){ ComicId = 161, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2021,04,20),AuditType=1,AuditEmployeeId=1,AuditTime=new  DateTime(2021,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 161, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,12,06),UploadTime=new DateTime(2021,05,01),AuditType=1,AuditEmployeeId=6,AuditTime=new  DateTime(2021,12,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 161, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2021,06,01),AuditType=1,AuditEmployeeId=2,AuditTime=new  DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 161, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2022,01,06),UploadTime=new DateTime(2021,07,01),AuditType=1,AuditEmployeeId=10,AuditTime=new DateTime(2022,01,06),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 161, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2021,08,01),AuditType=1,AuditEmployeeId=13,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                   new Episode(){ ComicId = 161, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2022,03,05),UploadTime=new DateTime(2021,09,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,03,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 161, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2022,04,05),UploadTime=new DateTime(2021,10,01),AuditType=1,AuditEmployeeId=19,AuditTime=new DateTime(2022,04,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 161, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2022,05,05),UploadTime=new DateTime(2021,11,01),AuditType=1,AuditEmployeeId=11,AuditTime=new DateTime(2022,05,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 161, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,06,05),UploadTime=new DateTime(2021,12,01),AuditType=1,AuditEmployeeId=3,AuditTime=new  DateTime(2022,06,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},
                   new Episode(){ ComicId = 161, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,07,05),UploadTime=new DateTime(2022,01,01),AuditType=1,AuditEmployeeId=5,AuditTime=new DateTime(2022,07,05),AuditFailReason="",IsCountdownCoupon=true,IsFree=false},





            };
            var comicSource = _repository.GetAll<Comic>()/*.Where(c => c.ComicId == Comicid).FirstOrDefault()*/;
            if (comicSource == null)
            {
                //return null;
            }

            foreach (var episode in epList)
            {
                _repository.Create(episode);
            }
            _repository.SaveChange();
        }
        //阿傑的
        public void EpContentCreate()
        {
            //var start = 1790;

            var epContentList = new List<EpContent>
            {
                //第1~10部漫畫內頁
                //new EpContent(){ /*EpContentId=1,  */EpId=1,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=2,  */EpId=1,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=3,  */EpId=2,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=4,  */EpId=2,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=5,  */EpId=3,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=6,  */EpId=3,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=7,  */EpId=4,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=8,  */EpId=4,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=9,  */EpId=5,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=10, */EpId=5,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=11, */EpId=6,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=12, */EpId=6,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=13, */EpId=7,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=14, */EpId=7,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=15, */EpId=8,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=16, */EpId=8,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=17, */EpId=9,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=18, */EpId=9,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=19, */EpId=10, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=20, */EpId=10, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                //第11~20部漫畫內/*頁*/
                //new EpContent(){ /*EpContentId=21, */EpId=start+11, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=22, */EpId=start+11, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=23, */EpId=start+12, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=24, */EpId=start+12, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=25, */EpId=start+13, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=26, */EpId=start+13, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=27, */EpId=start+14, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=28, */EpId=start+14, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=29, */EpId=start+15, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=30, */EpId=start+15, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=31, */EpId=start+16, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=32, */EpId=start+16, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=33, */EpId=start+17, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=34, */EpId=start+17, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=35, */EpId=start+18, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=36, */EpId=start+18, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=37, */EpId=start+19, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=38, */EpId=start+19, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=39, */EpId=start+20, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=40, */EpId=start+20, ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                ////第21~30部漫畫內/*頁*/
                //new EpContent(){ /*EpContentId=41, */ EpId=start+21,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=42, */ EpId=start+21,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=43, */ EpId=start+22,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=44, */ EpId=start+22,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=45, */ EpId=start+23,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=46, */ EpId=start+23,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=47, */ EpId=start+24,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=48, */ EpId=start+24,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=49, */ EpId=start+25,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=50, */ EpId=start+25,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=51, */ EpId=start+26,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=52, */ EpId=start+26,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=53, */ EpId=start+27,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=54, */ EpId=start+27,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=55, */ EpId=start+28,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=56, */ EpId=start+28,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=57, */ EpId=start+29,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=58, */ EpId=start+29,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=59, */ EpId=start+30,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=60, */ EpId=start+30,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                ////第31~40部漫畫內/*頁*/
                //new EpContent(){ /*EpContentId=61, */ EpId=start+31,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=62, */ EpId=start+31,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=63, */ EpId=start+32,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=64, */ EpId=start+32,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=65, */ EpId=start+33,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=66, */ EpId=start+33,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=67, */ EpId=start+34,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=68, */ EpId=start+34,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=69, */ EpId=start+35,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=70, */ EpId=start+35,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=71, */ EpId=start+36,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=72, */ EpId=start+36,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=73, */ EpId=start+37,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=74, */ EpId=start+37,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=75, */ EpId=start+38,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=76, */ EpId=start+38,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=77, */ EpId=start+39,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=78, */ EpId=start+39,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=79, */ EpId=start+40,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=80, */ EpId=start+40,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                ////第41~50部漫畫內/*頁*/
                //new EpContent(){ /*EpContentId=81, */ EpId=start+41,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=82, */ EpId=start+41,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=83, */ EpId=start+42,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=84, */ EpId=start+42,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=85, */ EpId=start+43,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=86, */ EpId=start+43,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=87, */ EpId=start+44,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=88, */ EpId=start+44,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=89, */ EpId=start+45,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=90, */ EpId=start+45,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=91, */ EpId=start+46,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=92, */ EpId=start+46,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=93, */ EpId=start+47,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=94, */ EpId=start+47,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=95, */ EpId=start+48,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=96, */ EpId=start+48,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=97, */ EpId=start+49,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=98, */ EpId=start+49,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=99, */ EpId=start+50,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=100,*/ EpId=start+50,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                ////第51~60部漫畫內/*頁*/
                //new EpContent(){ /*EpContentId=101,*/  EpId=start+51,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=102,*/  EpId=start+51,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=103,*/  EpId=start+52,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=104,*/  EpId=start+52,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=105,*/  EpId=start+53,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=106,*/  EpId=start+53,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=107,*/  EpId=start+54,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=108,*/  EpId=start+54,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=109,*/  EpId=start+55,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=110,*/  EpId=start+55,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=111,*/  EpId=start+56,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=112,*/  EpId=start+56,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=113,*/  EpId=start+57,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=114,*/  EpId=start+57,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=115,*/  EpId=start+58,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=116,*/  EpId=start+58,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=117,*/  EpId=start+59,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=118,*/  EpId=start+59,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=119,*/  EpId=start+60,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=120,*/  EpId=start+60,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                ////第61~70部漫畫內/*頁*/
                //new EpContent(){ /*EpContentId=121,*/  EpId=start+61,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=122,*/  EpId=start+61,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=123,*/  EpId=start+62,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=124,*/  EpId=start+62,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=125,*/  EpId=start+63,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=126,*/  EpId=start+63,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=127,*/  EpId=start+64,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=128,*/  EpId=start+64,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=129,*/  EpId=start+65,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=130,*/  EpId=start+65,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=131,*/  EpId=start+66,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=132,*/  EpId=start+66,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=133,*/  EpId=start+67,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=134,*/  EpId=start+67,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=135,*/  EpId=start+68,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=136,*/  EpId=start+68,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=137,*/  EpId=start+69,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=138,*/  EpId=start+69,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=139,*/  EpId=start+70,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=140,*/  EpId=start+70,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                ////第71~80部漫畫內/*頁*/
                //new EpContent(){ /*EpContentId=141,*/  EpId=start+71,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=142,*/  EpId=start+71,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=143,*/  EpId=start+72,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=144,*/  EpId=start+72,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=145,*/  EpId=start+73,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=146,*/  EpId=start+73,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=147,*/  EpId=start+74,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=148,*/  EpId=start+74,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=149,*/  EpId=start+75,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=150,*/  EpId=start+75,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=151,*/  EpId=start+76,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=152,*/  EpId=start+76,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=153,*/  EpId=start+77,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=154,*/  EpId=start+77,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=155,*/  EpId=start+78,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=156,*/  EpId=start+78,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=157,*/  EpId=start+79,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=158,*/  EpId=start+79,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=159,*/  EpId=start+80,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=160,*/  EpId=start+80,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                ////第81~90部漫畫內/*頁*/
                //new EpContent(){ /*EpContentId=161,*/  EpId=start+81,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=162,*/  EpId=start+81,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=163,*/  EpId=start+82,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=164,*/  EpId=start+82,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=165,*/  EpId=start+83,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=166,*/  EpId=start+83,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=167,*/  EpId=start+84,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=168,*/  EpId=start+84,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=169,*/  EpId=start+85,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=170,*/  EpId=start+85,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=171,*/  EpId=start+86,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=172,*/  EpId=start+86,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=173,*/  EpId=start+87,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=174,*/  EpId=start+87,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=175,*/  EpId=start+88,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=176,*/  EpId=start+88,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=177,*/  EpId=start+89,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=178,*/  EpId=start+89,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=179,*/  EpId=start+90,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=180,*/  EpId=start+90,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                ////第91~100部漫畫內/*頁*/
                //new EpContent(){ /*EpContentId=181,*/  EpId=start+91,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=182,*/  EpId=start+91,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=183,*/  EpId=start+92,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=184,*/  EpId=start+92,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=185,*/  EpId=start+93,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=186,*/  EpId=start+93,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=187,*/  EpId=start+94,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=188,*/  EpId=start+94,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=189,*/  EpId=start+95,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=190,*/  EpId=start+95,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=191,*/  EpId=start+96,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=192,*/  EpId=start+96,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=193,*/  EpId=start+97,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=194,*/  EpId=start+97,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=195,*/  EpId=start+98,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=196,*/  EpId=start+98,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=197,*/  EpId=start+99,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=198,*/  EpId=start+99,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=199,*/  EpId=start+100,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=200,*/  EpId=start+100,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                ////第101~110部漫畫/*內頁*/
                //new EpContent(){ /*EpContentId=201,*/  EpId=start+101,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=202,*/  EpId=start+101,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=203,*/  EpId=start+102,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=204,*/  EpId=start+102,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=205,*/  EpId=start+103,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=206,*/  EpId=start+103,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=207,*/  EpId=start+104,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=208,*/  EpId=start+104,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=209,*/  EpId=start+105,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=210,*/  EpId=start+105,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=211,*/  EpId=start+106,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=212,*/  EpId=start+106,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=213,*/  EpId=start+107,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=214,*/  EpId=start+107,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=215,*/  EpId=start+108,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=216,*/  EpId=start+108,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=217,*/  EpId=start+109,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=218,*/  EpId=start+109,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=219,*/  EpId=start+110,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=220,*/  EpId=start+110,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                ////第111~120部漫畫/*內頁*/
                //new EpContent(){ /*EpContentId=221,*/  EpId=start+111,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=222,*/  EpId=start+111,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=223,*/  EpId=start+112,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=224,*/  EpId=start+112,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=225,*/  EpId=start+113,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=226,*/  EpId=start+113,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=227,*/  EpId=start+114,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=228,*/  EpId=start+114,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=229,*/  EpId=start+115,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=230,*/  EpId=start+115,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=231,*/  EpId=start+116,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=232,*/  EpId=start+116,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=233,*/  EpId=start+117,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=234,*/  EpId=start+117,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=235,*/  EpId=start+118,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=236,*/  EpId=start+118,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=237,*/  EpId=start+119,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=238,*/  EpId=start+119,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=239,*/  EpId=start+120,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=240,*/  EpId=start+120,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                ////第121~130部漫畫/*內頁*/
                //new EpContent(){ /*EpContentId=241,*/  EpId=start+121,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=242,*/  EpId=start+121,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=243,*/  EpId=start+122,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=244,*/  EpId=start+122,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=245,*/  EpId=start+123,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=246,*/  EpId=start+123,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=247,*/  EpId=start+124,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=248,*/  EpId=start+124,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=249,*/  EpId=start+125,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=250,*/  EpId=start+125,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=251,*/  EpId=start+126,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=252,*/  EpId=start+126,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=253,*/  EpId=start+127,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=254,*/  EpId=start+127,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=255,*/  EpId=start+128,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=256,*/  EpId=start+128,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=257,*/  EpId=start+129,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=258,*/  EpId=start+129,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=259,*/  EpId=start+130,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=260,*/  EpId=start+130,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                ////第131~140部漫畫/*內頁*/
                //new EpContent(){ /*EpContentId=261,*/  EpId=start+131,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=262,*/  EpId=start+131,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=263,*/  EpId=start+132,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=264,*/  EpId=start+132,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=265,*/  EpId=start+133,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=266,*/  EpId=start+133,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=267,*/  EpId=start+134,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=268,*/  EpId=start+134,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=269,*/  EpId=start+135,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=270,*/  EpId=start+135,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=271,*/  EpId=start+136,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=272,*/  EpId=start+136,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=273,*/  EpId=start+137,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=274,*/  EpId=start+137,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=275,*/  EpId=start+138,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=276,*/  EpId=start+138,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=277,*/  EpId=start+139,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=278,*/  EpId=start+139,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=279,*/  EpId=start+140,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=280,*/  EpId=start+140,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                ////第141~150部漫畫/*內頁*/
                //new EpContent(){ /*EpContentId=281,*/  EpId=start+141,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=282,*/  EpId=start+141,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=283,*/  EpId=start+142,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=284,*/  EpId=start+142,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=285,*/  EpId=start+143,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=286,*/  EpId=start+143,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=287,*/  EpId=start+144,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=288,*/  EpId=start+144,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=289,*/  EpId=start+145,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=290,*/  EpId=start+145,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=291,*/  EpId=start+146,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=292,*/  EpId=start+146,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=293,*/  EpId=start+147,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=294,*/  EpId=start+147,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=295,*/  EpId=start+148,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=296,*/  EpId=start+148,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=297,*/  EpId=start+149,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=298,*/  EpId=start+149,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=299,*/  EpId=start+150,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=300,*/  EpId=start+150,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},

                ////第151~159部漫畫/*內頁*/
                //new EpContent(){ /*EpContentId=301,*/  EpId=start+151,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=302,*/  EpId=start+151,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=303,*/  EpId=start+152,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=304,*/  EpId=start+152,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=305,*/  EpId=start+153,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=306,*/  EpId=start+153,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=307,*/  EpId=start+154,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=308,*/  EpId=start+154,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=309,*/  EpId=start+155,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=310,*/  EpId=start+155,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=311,*/  EpId=start+156,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=312,*/  EpId=start+156,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=313,*/  EpId=start+157,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=314,*/  EpId=start+157,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=315,*/  EpId=start+158,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=316,*/  EpId=start+158,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                //new EpContent(){ /*EpContentId=317,*/  EpId=start+159,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png", Page=1},
                //new EpContent(){ /*EpContentId=318,*/  EpId=start+159,  ImagePath="https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png", Page=2},
                ////new EpContent(){ EpContentId=319,  EpId=start+160,  ImagePath="", Page=1},
                ////new EpContent(){ EpContentId=320,  EpId=start+160,  ImagePath="", Page=2},
            };

            //foreach (var epContent in epContentList)
            //{
            //    _repository.Create(epContent);
            //}


            var eps = _repository.GetAll<Episode>();
            foreach (var ep in eps)
            {

                _repository.Create(
                    new EpContent()
                    { /*EpContentId=1,  */
                        EpId = ep.EpId,
                        ImagePath = "https://res.cloudinary.com/dmns6twmt/image/upload/v1657124292/Activity/EC01.png",
                        Page = 1
                    }
                );
                _repository.Create(
                    new EpContent()
                    { /*EpContentId=2,  */
                        EpId = ep.EpId,
                        ImagePath = "https://res.cloudinary.com/dmns6twmt/image/upload/v1657124335/Activity/EC02.png",
                        Page = 2
                    }
                );
            }

            _repository.SaveChange();
        }


        public WorkPageDTO WorkPageRead(int comicId, int memberId)
        {
            //倒數券 我的最愛 觀看紀錄 點擊數 留言
            //comicId = 108;
            //審核 1通過 2未審核 3失敗 4審核中
            //userName = "林淑芬";
            //var memberId = _repository.GetAll<Member>().Where(m => m.AccountName == userName).Select(m => m.MemberId).FirstOrDefault();
            var comicSource = _repository.GetAll<Comic>().Where(c => c.AuditType == 1).First(x => x.ComicId == comicId);
            var tagList = _repository.GetAll<ComicTagList>().Where(x => x.ComicId == comicSource.ComicId).Select(x => x.TagId).ToList();
            var tagnames = _repository.GetAll<ComicTag>().Where(x => tagList.Contains( x.TagId)).ToList();
            //這邊主Tag有的漫畫沒有，有些功能會報錯(要注意!!)
            var mainTag = tagnames.FirstOrDefault(x => x.IsMainTag); 
            var couponTest = _repository.GetAll<Coupon>();
            // 1通用券 2閱讀券 3倒數券 券有可能沒有 都沒有的話就只有倒數券
            var readCouponSource = _repository.GetAll<Coupon>().Where(x => x.CouponTypeId == 2 && x.MemberId == memberId && x.ComicId == comicId).Select(x => x.Quantity).FirstOrDefault();
            //var CDCouponSource = _repository.GetAll<Coupon>().First(x => x.CouponTypeId == 3 && x.MemberId == memberId && x.ComicId == comicId);

            var epSource = _repository.GetAll<Episode>().Where(x => x.AuditType == 1 && x.ComicId == comicId).OrderBy(x => x.UploadTime);

            // 漫畫所有話次留言
            var commentSource = _repository.GetAll<Comment>().Where(c => epSource.Any(e => e.EpId == c.EpId));
            int ComicLikeCount = 0;

            var commentLikeSource = _repository.GetAll<CommentLikeRecord>().GroupBy(g => g.CommentId).Where(g => commentSource.Any(c => c.CommentId == g.Key)).Select(c => new CommentData { CommentId = c.Key, CommentLikeCount = c.Count() });
            foreach (var like in commentLikeSource)
            {
                ComicLikeCount = ComicLikeCount + like.CommentLikeCount;
            };

            var commentReplySourceHaveNull = commentSource.Where(c => c.ReplyToCommentId != null).Select(c => c);

            var commentReplySource = commentReplySourceHaveNull.GroupBy(g => g.ReplyToCommentId).Select(c => new CommentData { CommentId = (int)c.Key, ReplyToCommentCount = c.Count() });

            var viewRecordSource = _repository.GetAll<ViewRecord>().Where(v => v.IsDelete == false && epSource.Any(ep => ep.EpId == v.EpId)).OrderByDescending(v => v.ViewTime).FirstOrDefault();
            string ViewRecordEpTitle;
            if (viewRecordSource == null)
            {
                ViewRecordEpTitle = "去看 第1話";
            }
            else
            {
                ViewRecordEpTitle = $"繼續看 {_repository.GetAll<Episode>().Where(v => viewRecordSource.EpId == v.EpId).Select(v => v.EpTitle).FirstOrDefault().Trim()}";
            }


            var clickCount = _repository.GetAll<ClickRecord>().Where(c => c.ComicId == comicId).Count();

            var comicIsLike = _repository.GetAll<Favorite>().Any(f => f.ComicId == comicId && f.MemberId == memberId);

            var CommentReportCount = _repository.GetAll<Report>().Where(r => r.AuditType == 1).GroupBy(g => g.CommentId).Select(c => new CommentData { CommentId = (int)c.Key, CommentReportCount = c.Count() });

            
            CreateClickRecord(comicId, memberId);

            return new WorkPageDTO()
            {
                MemberId = memberId,
                ComicId = comicSource.ComicId,
                ComicChineseName = comicSource.ComicChineseName,
                BgCover = comicSource.BgCover,
                ComicFigure = comicSource.ComicFigure,
                BgColor = comicSource.BgColor,
                BannerVideoWeb = comicSource.BannerVideoWeb,
                ComicVideoWeb = comicSource.ComicVideoWeb,
                ReadTicket = readCouponSource /*+ CDCouponSource.Quantity*/,
                IslikeComic = comicIsLike,
                MainTagName = mainTag.TagName,
                TagNames = tagnames.Select(t => t.TagName).ToList(),
                ClickCount = clickCount,
                ComicLikeCount = ComicLikeCount,
                ViewRecordEpTitle = ViewRecordEpTitle,

                Publisher = comicSource.Publisher,
                Painter = comicSource.Painter,
                Author = comicSource.Author,

                ComicStatus = comicSource.ComicStatus,
                UpdateWeek = comicSource.UpdateWeek,
                Introduction = comicSource.Introduction,

                EpList = epSource.Select(ep => new EpData
                {
                    EpId = ep.EpId,
                    ComicId = ep.ComicId,
                    EpTitle = ep.EpTitle,
                    EpCover = ep.EpCover,
                    UploadTime = ep.UploadTime.ToShortDateString(),
                    IsCountdownCoupon = ep.IsCountdownCoupon,
                    IsFree = ep.IsFree
                }).ToList(),

                CommentList = commentSource.Select(c => new CommentData
                {
                    CommentId = c.CommentId,
                    CommentMemberName = _repository.GetAll<Member>().Where(m => m.MemberId == c.MemberId).Select(m => m.NickName).First(),
                    EpId = c.EpId,
                    ReplyToCommentCount = commentReplySource.Where(cr => c.CommentId == cr.CommentId).Select(cr => cr.ReplyToCommentCount).FirstOrDefault(),
                    IsSpoiler = c.IsSpoiler,
                    CreateTime = c.CreateTime,
                    Context = c.Context,
                    IsDelete = c.IsDelete,
                    CommentLikeCount = commentLikeSource.Where(cl => c.CommentId == cl.CommentId).Select(cl => cl.CommentLikeCount).FirstOrDefault(),
                    CommentReportCount = CommentReportCount.Where(cr => c.CommentId == cr.CommentId).Select(cr => cr.CommentReportCount).FirstOrDefault()
                }).ToList()
            };
        }
        public void CreateClickRecord(int comicId, int memberId)
        {
            if (memberId == 0)
            {
                _repository.Create(new ClickRecord()
                {
                    ComicId = comicId,
                    CreateTime = DateTime.UtcNow.AddHours(8),
                });
            }
            else
            {
                _repository.Create(new ClickRecord()
                {
                    ComicId = comicId,
                    MemberId = memberId,
                    CreateTime = DateTime.UtcNow.AddHours(8),
                });
            }
            _repository.SaveChange();
        }


        public ReadworkContentOutputDTO ReadworkContent(int epId, int memberId)
        {
            //先判斷集數類型
            //1.免費:直接開啟漫畫
            //2.倒數:只能使用在能使用倒數卷的漫畫上，能使用三種卷(倒數，
            //  閱讀，通用)
            //3.最新五話:只能使用  閱讀，通用

            //註 => 既是倒數
            //類型 又是 最新五話?

            var result = new ReadworkContentOutputDTO
            {
                //WorkContents = null,
            };
            //1.
            var EpSource = _repository.GetAll<Episode>().Where(e => e.AuditType == 1).FirstOrDefault(e => e.EpId == epId);//找出點的那一集的所有資料
            var EpContentsSource = _repository.GetAll<EpContent>().Where(c => c.EpId == epId);


            result.ComicId = EpSource.ComicId;
            ;
            //登入者的所有券
            var couponSource = _repository.GetAll<Coupon>()
                .Where(p => p.MemberId == memberId)
                .OrderByDescending(p => p.CreateTime);  //最新 ....

            //這部漫畫的 倒數卷 
            var countdownCoupon_forThisComic = couponSource.FirstOrDefault(p =>
                p.CouponTypeId == (int)CouponType.countdownCoupon
                && p.ComicId == EpSource.ComicId
            );
            bool countdownCoupon_valid = countdownCoupon_forThisComic.Quantity == 1;

            //這部漫畫的 閱讀卷
            var readCoupon = couponSource.FirstOrDefault(p =>
                p.CouponTypeId == (int)CouponType.readCoupon
                && p.ComicId == EpSource.ComicId
            );
            bool readCoupon_valid = readCoupon != null && readCoupon.Quantity > 0;

            //通用卷
            var universalCoupon = couponSource.FirstOrDefault(p =>
                p.CouponTypeId == (int)CouponType.universalCoupon);
            bool universalCoupon_valid = universalCoupon != null && universalCoupon.Quantity > 0;


            //非免費且 所有券全皆無 
            if (!EpSource.IsFree
                && !countdownCoupon_valid
                && !readCoupon_valid
                && !universalCoupon_valid
            ) return result;

            result.WorkContents = Read(EpSource, EpContentsSource);
            result.EpList = ReadEpTable(EpSource.ComicId);
            ViewRecordCreate(epId, memberId);

            //判斷那一集是否免費
            if (EpSource.IsFree)
            {
                // 免費就沒有用券
                return result;
            }

            //已確定要用券
            Coupon UseCoupon;

            //集數類型 是倒數
            if (EpSource.IsCountdownCoupon)
            {
                if (countdownCoupon_valid) //一定會有倒數券資料 => 不用檢查null
                {
                    UseCoupon = countdownCoupon_forThisComic;
                    CouponUsedRecordCreate(epId, memberId, UseCoupon);
                    return result;
                }
            }

            if (readCoupon_valid)
            {
                UseCoupon = readCoupon;
                CouponUsedRecordCreate(epId, memberId, UseCoupon);
                return result;
            }

            //if (universalCoupon_valid)
            //{
            UseCoupon = universalCoupon;
            CouponUsedRecordCreate(epId, memberId, UseCoupon);
            return result;
            //}



        }


        private List<WorkContent> Read(Episode epSource, IQueryable<EpContent> content)
        {
            //var aLLEpSource = _repository.GetAll<Episode>().Where(x => x.AuditType == 1 && x.ComicId == epSource.ComicId).OrderBy(x => x.UploadTime);

            var readResult = content.Select(c => new WorkContent()
            {
                ComicId = epSource.ComicId,
                EpId = epSource.EpId,
                EpTitle = epSource.EpTitle,
                EpContentId = c.EpContentId,
                ImagePath = c.ImagePath,
                Page = c.Page,

            }).ToList();


            return readResult;

        }

        public List<WorkContentEpData> ReadEpTable(int comicId)
        {
            var aLLEpSource = _repository.GetAll<Episode>().Where(x => x.ComicId == comicId).OrderBy(x => x.UploadTime);
            var result = new List<WorkContentEpData>();


            result = aLLEpSource.Select(ep => new WorkContentEpData
            {
                EpId = ep.EpId,
                ComicId = ep.ComicId,
                EpTitle = ep.EpTitle,
                EpCover = ep.EpCover,
                UploadTime = ep.UploadTime.ToShortDateString(),
                IsCountdownCoupon = ep.IsCountdownCoupon,
                IsFree = ep.IsFree

            }).ToList();


            return result;
        }



        public void ViewRecordCreate(int EpId, int memberId)
        {
            var viewRecord = new ViewRecord() { MemberId = memberId, EpId = EpId, ViewTime = DateTime.Now, IsDelete = false };//EpContentId要改
            _repository.Create(viewRecord);

            _repository.SaveChange();
        }



        //public ReadworkContentOutputDTO ReadworkContent(int epId, int memberId)
        //{
        //    //先判斷集數類型
        //    //1.免費:直接開啟漫畫
        //    //2.倒數:只能使用在能使用倒數卷的漫畫上，能使用三種卷(倒數，
        //    //  閱讀，通用)
        //    //3.最新五話:只能使用  閱讀，通用

        //    //註 => 既是倒數
        //    //類型 又是 最新五話?

        //    var result = new ReadworkContentOutputDTO
        //    {
        //        //WorkContents = null,
        //    };
        //    //1.
        //    var EpSource = _repository.GetAll<Episode>().Where(e => e.AuditType == 1).FirstOrDefault(e => e.EpId == epId);//找出點的那一集的所有資料
        //    var EpContentsSource = _repository.GetAll<EpContent>().Where(c => c.EpId == epId);


        //    result.ComicId = EpSource.ComicId;
        //    ;
        //    //登入者的所有券
        //    var couponSource = _repository.GetAll<Coupon>()
        //        .Where(p => p.MemberId == memberId)
        //        .OrderByDescending(p => p.CreateTime);  //最新 ....

        //    //這部漫畫的 倒數卷 
        //    var countdownCoupon_forThisComic = couponSource.FirstOrDefault(p =>
        //        p.CouponTypeId == (int)CouponType.countdownCoupon
        //        && p.ComicId == EpSource.ComicId
        //    );
        //    bool countdownCoupon_valid = countdownCoupon_forThisComic.Quantity == 1;

        //    //這部漫畫的 閱讀卷
        //    var readCoupon = couponSource.FirstOrDefault(p =>
        //        p.CouponTypeId == (int)CouponType.readCoupon
        //        && p.ComicId == EpSource.ComicId
        //    );
        //    bool readCoupon_valid = readCoupon != null && readCoupon.Quantity > 0;

        //    //通用卷
        //    var universalCoupon = couponSource.FirstOrDefault(p =>
        //        p.CouponTypeId == (int)CouponType.universalCoupon);
        //    bool universalCoupon_valid = universalCoupon != null && universalCoupon.Quantity > 0;


        //    //非免費且 所有券全皆無 
        //    if (!EpSource.IsFree
        //        && !countdownCoupon_valid
        //        && !readCoupon_valid
        //        && !universalCoupon_valid
        //    ) return result;

        //    result.WorkContents = Read(EpSource, EpContentsSource);
        //    result.EpList = ReadEpTable(EpSource.ComicId);
        //    ViewRecordCreate(epId, memberId);

        //    //判斷那一集是否免費
        //    if (EpSource.IsFree)
        //    {
        //        // 免費就沒有用券
        //        return result;
        //    }

        //    //已確定要用券
        //    Coupon UseCoupon;

        //    //集數類型 是倒數
        //    if (EpSource.IsCountdownCoupon)
        //    {
        //        if (countdownCoupon_valid) //一定會有倒數券資料 => 不用檢查null
        //        {
        //            UseCoupon = countdownCoupon_forThisComic;
        //            CouponUsedRecordCreate(epId, memberId, UseCoupon);
        //            return result;
        //        }
        //    }

        //    if (readCoupon_valid)
        //    {
        //        UseCoupon = readCoupon;
        //        CouponUsedRecordCreate(epId, memberId, UseCoupon);
        //        return result;
        //    }

        //    //if (universalCoupon_valid)
        //    //{
        //    UseCoupon = universalCoupon;
        //    CouponUsedRecordCreate(epId, memberId, UseCoupon);
        //    return result;
        //    //}

        //}


        //private List<WorkContent> Read(Episode epSource, IQueryable<EpContent> content)
        //{
        //    //var aLLEpSource = _repository.GetAll<Episode>().Where(x => x.AuditType == 1 && x.ComicId == epSource.ComicId).OrderBy(x => x.UploadTime);

        //    var readResult = content.Select(c => new WorkContent()
        //    {
        //        ComicId = epSource.ComicId,
        //        EpId = epSource.EpId,
        //        EpTitle = epSource.EpTitle,
        //        EpContentId = c.EpContentId,
        //        ImagePath = c.ImagePath,
        //        Page = c.Page,

        //    }).ToList();


        //    return readResult;

        //}

        //public List<WorkContentEpData> ReadEpTable(int comicId)
        //{
        //    var aLLEpSource = _repository.GetAll<Episode>().Where(x => x.ComicId == comicId).OrderBy(x => x.UploadTime);
        //    var result = new List<WorkContentEpData>();


        //    result = aLLEpSource.Select(ep => new WorkContentEpData
        //    {
        //        EpId = ep.EpId,
        //        ComicId = ep.ComicId,
        //        EpTitle = ep.EpTitle,
        //        EpCover = ep.EpCover,
        //        UploadTime = ep.UploadTime.ToShortDateString(),
        //        IsCountdownCoupon = ep.IsCountdownCoupon,
        //        IsFree = ep.IsFree

        //    }).ToList();


        //    return result;
        //}



        //public void ViewRecordCreate(int EpId, int memberId)
        //{
        //    var viewRecord = new ViewRecord() { MemberId = memberId, EpId = EpId, ViewTime = DateTime.Now, IsDelete = false };//EpContentId要改
        //    _repository.Create(viewRecord);

        //    _repository.SaveChange();
        //}

        public void CouponUsedRecordCreate(int EpId, int memberId, Coupon UsedCoupon)
        {
            var now = DateTime.UtcNow.AddHours(8);
            var couponUsed = new CouponUsedRecord()
            {
                MemberId = memberId,
                EpId = EpId,
                CouponId = UsedCoupon.CouponId,

                StartReadTime = now,
                EndReadTime = now.AddDays(7),
            };

            _repository.Create(couponUsed);
            UsedCoupon.Quantity -= 1;

            _repository.SaveChange();
        }


        public List<CommentDTO> GetComment(int EpId)
        {
            var commentSourse = _repository.GetAll<Comment>().Where(c => c.EpId == EpId).OrderBy(c=>c.CreateTime);
            var commentLikeSourse = _repository.GetAll<CommentLikeRecord>().Where(c => c.CommentId == commentSourse.Select(c => c.CommentId).First());
            var memberName = _repository.GetAll<Member>();
            var result = new List<CommentDTO>();

            result = commentSourse.Select(c => new CommentDTO
            {
                CommentId = c.CommentId,
                Context = c.Context,
                CreateTime = c.CreateTime,
                IsSpoiler = c.IsSpoiler,
                EpId = c.EpId,
                MemberName = memberName.Where(m => m.MemberId == c.MemberId).Select(m => m.AccountName).First(),
                ReplyToCommentId = c.ReplyToCommentId,
            }).ToList();

            return result;


        }
        public void CreateComment(CommentDTO comment)
        {
            var entity = new CommentDTO()
            {

            };


        }
    }
}