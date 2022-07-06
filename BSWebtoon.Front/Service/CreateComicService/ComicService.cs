﻿using BSWebtoon.Front.ViewModels;
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
                new ComicTag {TagName="奇幻"    ,IsMainTag=true ,IsDelete=false,AuditEmployeeId=1,AuditDate=new DateTime(2021,6,20)},

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
                //星期列表與作品頁
                //星期一
                new Comic {

                            ComicChineseName="再次我的生活",ComicEnglishName="AgainMyLife"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604668/AgainMyLife/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656571331/AgainMyLife/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656570608/AgainMyLife/1.webp"
                           ,BgColor       ="#1b2260",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,7,14),FinallyPublishDate=new DateTime(2021,7,10),UpdateWeek=1
                           ,Publisher     ="YJ Comics",Painter="SUN YONG MIN",Author="Lee hae nal"
                           ,Introduction  ="重生的熱血檢察官，審判絕對之惡!韓民國的熱血檢察官金熙宇，在調查凌駕於法律之上、玩弄著大韓民國的絕對權力者趙泰燮的貪汙案時，慘遭趙泰燮的同夥殺害並丟入海中。但金熙宇在黃泉路上遇見的陰間使者給了他重生的機會，於是他帶著前世的記憶回到了18歲的膽小鬼時期。重新變成高中生的熙宇利用前世得知的未來事件，開始為制裁趙泰燮做準備...!「比惡魔更過分的怪物才能抓到惡魔。」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656571157/AgainMyLife/2.webm"
                           ,HotVideo = ""
                           ,AuditType =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},


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
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},


                new Comic {ComicChineseName="嗜血暴君的初戀",ComicEnglishName="ATyrant'sFirstLove"
                           ,ComicNameImage ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605209/ATyrant%27sFirstLove/5.png"
                           ,BgCover        ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576002/ATyrant%27sFirstLove/4.webp"
                           ,HotComicNameImage = ""
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure =""
                           ,BgColor       ="#310a0b",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2022,7,5),FinallyPublishDate=new DateTime(2022,7,1),UpdateWeek=1
                           ,Publisher     ="DAON STUDIO",Painter="CHIWA",Author="KIM SUO"
                           ,Introduction  ="喪失記憶的少女「迪雅」，原本在諾斯男爵府擔任女傭，日復一日地受盡折磨。沒想到，出了名殘酷的皇帝「凱勒」，竟在某天強行將迪雅帶至皇宮中，並詢問她認不認得自己。那天之後，迪雅便待在皇宮中，熟悉皇室的日常...某個月圓之夜，迪雅被一股神祕的力量牽引至城外，並撞見了渾身浴血的凱勒..."
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656575874/ATyrant%27sFirstLove/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656575948/ATyrant%27sFirstLove/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},

                //星期一有影片
                new Comic {ComicChineseName="留級玩家",ComicEnglishName="Recording Hall"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607506/ThePlayerWhoCan%27tLevelUp/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656581295/ThePlayerWhoCan%27tLevelUp/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580998/ThePlayerWhoCan%27tLevelUp/2.webp"
                           ,ComicWeekFigure =""
                           ,BgColor       ="#351f29",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,7,22),FinallyPublishDate=new DateTime(2022,7,18),UpdateWeek=1
                           ,Publisher     ="DAON STUDIO",Painter="binu",Author="Siya"
                           ,Introduction  ="因為穿越進自己寫的小說，我成了欺負男主角的繼姐!別擔心，我一定會讓你變得幸福。因為這本小說的作者就是我!「我從來都沒把姐姐當成是我的家人。」雖然我覺得自己很認真在實踐讓男主角幸福的計畫，但為什麼他沒把我當成家人看呢?在他成為公爵前，我真的能順利活下來嗎?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656580720/ThePlayerWhoCan%27tLevelUp/1.webm"
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},

                new Comic {ComicChineseName="足跡消融之前",ComicEnglishName="BeforeFootprintAblation"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608041/BeforeFootprintAblation/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656599274/BeforeFootprintAblation/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
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
                new Comic {ComicChineseName="稜冬暗夜",ComicEnglishName="BlackWinter"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605020/BlackWinter/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587899/BlackWinter/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587574/BlackWinter/1.webp"
                           ,BgColor       ="#1a151e",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=1
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Tess",Author="Tess"
                           ,Introduction  ="在假想的朝鮮時代，因世間種種而懷抱傷痛的人們交織而成的愛情故事。"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656587749/BlackWinter/2.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,30),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},

                new Comic {ComicChineseName="爸爸，請跟我結婚!",ComicEnglishName="DadPleaseMarryMe"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656784815/DadPleaseMarryMe/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656598156/DadPleaseMarryMe/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597992/DadPleaseMarryMe/1.webp"
                           ,BgColor       ="#2c3846",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,7,26),UpdateWeek=1
                           ,Publisher     ="Yeondam X DAON",Painter="via",Author="dalseul"
                           ,Introduction  ="車禍之後睜眼一看，才發現自己身在喜歡的網路小說世界裡，而且還是在原著主角們出生前——他們的父母世代。為了阻止一連串的悲劇發生，原本是想保護懷孕的姐姐被綁架，沒想到卻代替她遭到綁架了?!被綁走已經夠悲慘了，還因為不適應魔力，導致隨時可能喪命。但是...只要待在綁匪皇帝身邊，便會恢復元氣!對了!要想拯救那個和惡女結婚又慘遭親生兒子殺害的男人，以及對魔力毫無抵抗力的自己...只能我們結婚了!「爸爸，請和我結婚!」「公主，我還未婚，也沒有子嗣，為什麼老是喊我爸爸...」敬請期待直直砸向鐵壁皇帝的甜蜜求婚計畫!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656598086/DadPleaseMarryMe/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},

                new Comic {ComicChineseName="琉璃之壁",ComicEnglishName="GlassBlock"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607414/GlassBlock/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574627/GlassBlock/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574474/GlassBlock/1.webp"
                           ,BgColor       ="#283e36",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,7,30),FinallyPublishDate= new DateTime(2022,7,26),UpdateWeek=1
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Joho",Author="Joho"
                           ,Introduction  ="富裕的貴族莉莉遇見他的那一刻，是一切的開端。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656574550/GlassBlock/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},
                //11
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
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},



                 //星期列表與作品頁
                //星期三(屬於星期一)

                //星期三(屬於星期一)有影片
                new Comic {ComicChineseName="今生我來當家主",ComicEnglishName="TodayIWillBeTheHeadOfTheHouse"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656998366/TodayIWillBeTheHeadOfTheHouse/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582961/MookHyangDarkLady/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,BgColor       ="#418ab3",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,7,26),UpdateWeek=1
                           ,Publisher     ="D&C WEBTOON Biz",Painter="Mon(Antstudio)",Author="Kim Roah"
                           ,Introduction  ="「...就試試吧，由我來當家主。」我轉世成了帝國第一大家族——倫巴第家的私生女費蓮緹雅。這個家族不但富甲天下，而且從外交到文化無一不精，堪稱帝國歷史的象徵!含著金湯匙中的金湯匙出生，簡直太幸運了!還以為將來等著我的是康莊大道...沒想到父親過世後，我被親戚趕出家門，最後連曾經鼎鼎有名的家族都毀於一旦!!悲憤交加的我小酌(?)幾杯後走在回家的路上，居然還被馬車撞上!「這也太過分了吧...」含冤而死的我一睜開眼卻回到了七歲的時候?!光是親愛的父親出現在眼前就已經令人難以置信，我竟然還有機會拯救父親與家族?連重生前的家族仇人——二皇子都像隻大型犬似地成天追著我跑?!好吧，既然如此，二皇子和家族都是我的了!轉世加重生，面對第三次人生的費蓮緹雅，為了當上家主而展開行動!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656594393/MasterVillainessTheInvincible/3.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1657034039/TodayIWillBeTheHeadOfTheHouse/2.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},



                new Comic {ComicChineseName="我有三個暴君哥哥",ComicEnglishName="MyThreeTyrantBrothers"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607226/MyThreeTyrantBrothers/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582063/MyThreeTyrantBrothers/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656581853/MyThreeTyrantBrothers/1.webp"
                           ,BgColor       ="#9fa925",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,7,26),UpdateWeek=1
                           ,Publisher     ="DAON STUDIO",Painter="Parkha, Eun Du",Author="jomil​"
                           ,Introduction  ="我是個連名字都沒有的星期奴隸，代號「星期三」，當我因為反抗主人，性命不保的時候...「——終於找到妳了。」一夕之間多了三個哥哥，他們還說我是解除亞斯卡尼爾皇室詛咒的唯一鑰匙?!「妳一定要健健康康地長大，長到現在身上的衣服緊到再也穿不下，這是妳的第一項課題。」「別擔心，小不點。那些壞人，哥哥會幫妳狠狠教訓他們一頓。」「這孩子像隻小雞一樣，既嬌小又柔弱。我想要守護她，我會守護她。」被大家稱作暴君的哥哥們，怎麼只對我這麼溫柔!?從天而降的寵妹狂魔哥哥們和我的故事——《我有三個暴君哥哥》!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656581977/MyThreeTyrantBrothers/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},



                new Comic {ComicChineseName="廢墟中的皇女",ComicEnglishName="PrincessInTheRough"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605651/PrincessInTheRough/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577313/PrincessInTheRough/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576943/PrincessInTheRough/1.webp"
                           ,BgColor       ="#605342",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,7,26),UpdateWeek=1
                           ,Publisher     ="Mstoryhub",Painter="HAERUA",Author="HARASYO"
                           ,Introduction  ="被皇帝遺忘的孩子，獨自一人生活在森林裡的廢棄城堡。「我討厭說謊的騙子，就算是一個人，我也可以過得好好的。」她經過漫長的等待，終於盼到皇帝來，但孩子的心扉早已緊緊關上了。「我來為妳取個名字。」「名字?」「艾斯特蕾拉，這就是妳的名字了...很抱歉讓妳久等了，孩子。」艾斯特蕾拉是一個擁有著特別能力的孩子，她的家人該如何療癒那顆破碎的心呢?"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656577015/PrincessInTheRough/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656577184/PrincessInTheRough/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},


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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},



                new Comic {ComicChineseName="婚禮復仇記",ComicEnglishName="RevengeWedding"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605358/RevengeWedding/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575576/RevengeWedding/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575339/RevengeWedding/1.webp"
                           ,BgColor       ="#28202b",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,7,26),UpdateWeek=1
                           ,Publisher     ="DAON STUDIO",Painter="SaRyong​",Author="ByulSatangYang"
                           ,Introduction  ="集外貌、財富、地位於一身的完美女子——梅勒凱蒂亞．沙夏，暈倒後醒來發現自己位在一艘巨大的船上，身上還穿著婚紗。「蛤?我要結婚了嗎?是誰這麼大膽敢打我的主意?我一定要讓你打消結婚的念頭!」但沒想到...我的丈夫初次見面竟然就拿劍抵著我的脖子?他是帝國最偉大的戰爭英雄——戴枚德利奧．吉普洛沙。可是，他看起來一點都不像來結婚的啊?「我還想說是誰把我帶到這裡來的...只要殺了妳，我就可以回去了嗎?」「真是不好意思，我也是被綁架的好嗎?」我們兩人被綁架來結婚，甚至還要一起在無人島上求生存?!眼前的首要任務，就是逃出這座荒島!終極任務，要跟這個仇人離婚!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656575410/RevengeWedding/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656575490/RevengeWedding/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},



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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},

                new Comic {ComicChineseName="SSS級死而復生的獵人",ComicEnglishName="SSS-ClassRevivalHunter"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604749/SSS-ClassRevivalHunter/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580517/SSS-ClassRevivalHunter/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580224/SSS-ClassRevivalHunter/1.png"
                           ,BgColor       ="#1c1f26",PublishDate=new DateTime(2021,6,28),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,7,26),UpdateWeek=1
                           ,Publisher     ="Fansia",Painter="Bill K",Author="Sinnoa"
                           ,Introduction  ="身處F級底層的獵人「金孔子」長久以來一直羨慕著排行第一的獵人「炎帝」。某天，他竟突然獲得了S+級的技能。不料，短暫開心過後，他發現這個技能有些古怪?!「複製對方的其中一種技能」到這裡都還不錯...「什麼?竟然要我死了才能發動?!」重生獵人的人生樂章——《SSS級死而復生的獵人》"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656580385/SSS-ClassRevivalHunter/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656580450/SSS-ClassRevivalHunter/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},





                //星期列表與作品頁
                //星期二

                //星期二有影片
                new Comic {ComicChineseName="盜墓王",ComicEnglishName="TombRaiderKing"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607700/TombRaiderKing/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656572963/TombRaiderKing/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure =""
                           ,BgColor       ="#575a6f",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2022,7,20),UpdateWeek=2
                           ,Publisher     ="Polarfox",Painter="Yooani",Author="Will Bright"
                           ,Introduction  ="「不但不是主角，還偏偏是書裡最惡毒的女人...」為了擺脫租屋生活而開始閱讀武俠小說《南宮世家少主》，卻穿越成為了小說裡最惡毒的女人——唐海媛。唐海媛這個天下第一惡女為了得到欽慕的男人，不惜毒殺思慕之人的情人、挑撥武林高手們、成為魔教的走狗並導致武林動盪。「絕不能和原本的故事內容一樣，白白送死!!」偶然吃了萬年參而變成小說世界裡的最強者，武俠小說最強惡女「唐海媛」的重生記!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656572710/TombRaiderKing/1.webm"
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656572903/TombRaiderKing/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},

                new Comic {ComicChineseName="我成了反派的繼母",ComicEnglishName="IBecameTheVillain'sMother"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607155/IBecameTheVillain%27sMother/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584749/IBecameTheVillain%27sMother/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584432/IBecameTheVillain%27sMother/1.webp"
                           ,BgColor       ="#225040",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,20),UpdateWeek=2
                           ,Publisher     ="DAON STUDIO",Painter="Iro",Author="Yulji"
                           ,Introduction  ="我成了小說裡最終的反派角色「艾因斯潘納」的繼母。而且還是小時候虐待他，長大後第一個被他殺害的壞心繼母。在我思考該如何逃離這悲慘命運時，仍一無所知、天真無邪的未來反派潛力股映入眼簾，但是...「等等，這孩子就連胖嘟嘟的小手都這麼可愛!誰捨得虐待他啊!」在我眼前的是個和反派完全沾不上邊的可愛小孩。好，我決定了，交給我吧!我會守護你!所以長大後拜託饒我一命吧!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656584573/IBecameTheVillain%27sMother/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656584694/IBecameTheVillain%27sMother/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,22),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},

                new Comic {ComicChineseName="就離開我吧",ComicEnglishName="JustLeaveMe"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605448/JustLeaveMe/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597845/JustLeaveMe/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597626/JustLeaveMe/1.webp"
                           ,BgColor       ="#121212",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,20),UpdateWeek=2
                           ,Publisher     ="Yeondam X DAON",Painter="chero",Author="JAEUNHYANG"
                           ,Introduction  ="因罕見疾病而死亡的公爵之女，阿黛兒成了她的替身，雖然用盡一切努力想得到家人們的愛，卻還是於妹妹一出生時就遭到拋棄，在前往政治聯姻的路途中被不明的刺客暗殺。「...難道這是夢?」但在她睜開眼後，卻發現自己回到了3年前!想著反正只要妹妹一出生就會遭到拋棄的自己，阿黛兒決定這次的人生要操之在己，可惜依舊不斷遭遇苦難。「難道您不是對我有興趣嗎?」再加上一個身分不明的黑色騎士老是接近她..."
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656597726/JustLeaveMe/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656597781/JustLeaveMe/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},

                new Comic {ComicChineseName="千金大廚來上菜",ComicEnglishName="LadyChefRoyale"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605055/LadyChefRoyale/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656591172/LadyChefRoyale/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656590985/LadyChefRoyale/1.webp"
                           ,BgColor       ="#dd6b79",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,23),UpdateWeek=2
                           ,Publisher     ="Dreamtoon",Painter="PAYA",Author="Lysha"
                           ,Introduction  ="我原是一位小餐廳的廚師，卻成為了一個連皇帝都害怕的貴族家——他們家的受氣包小女兒。本想存一些錢，然後逃跑的...真是奇怪。「跟你說對不起，是一件丟臉的事嗎?」「是啊，因為我是妳哥哥。」「妳不和我這個爺爺去散步嗎?」大家為什麼突然間對我這麼好?「為什麼我想要把那些看妳的人的眼睛挖出來?」試圖逃跑的我以及緊緊抓住我的人，只是做了料理而已，為什麼會這樣...「愛死她的家人們 / 想逃跑的她 / 她專屬的僕人們」即將登場!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656591037/LadyChefRoyale/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656591103/LadyChefRoyale/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},

                new Comic {ComicChineseName="魔彈射手",ComicEnglishName="MadanNoShashu"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608240/MadanNoShashu/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582317/MadanNoShashu/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582133/MadanNoShashu/1.webp"
                           ,BgColor       ="#060b28",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,13),UpdateWeek=2
                           ,Publisher     ="intime",Painter="GLPI",Author="Respect"
                           ,Introduction  ="「何中士，你又全中了啊!」即將成為軍官的神射手，何里夏中士，因一起意外事故，導致下半身癱瘓，成為了一個被世界遺棄的孤兒。在陷入絕望之際，虛擬實境遊戲「米德爾斯」橫空出世，賦予了他嶄新的人生。而在「米德爾斯」裡賺取的錢財，竟然可以成為現實世界中的財產!但因一開始的失誤，何里夏選擇了能力值最低的角色。眼看他就要被當成沙包打了!「我和你們不一樣，我已經無路可退了!」用火藥、鋼珠、推彈杆，讓你們看看什麼是真正的神槍手!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656582250/MadanNoShashu/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},

                //33
                new Comic {ComicChineseName="墨劍留香",ComicEnglishName="MookHyangDarkLady"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605276/MookHyangDarkLady/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582961/MookHyangDarkLady/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,BgColor       ="#1a0c19",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2022,7,20),UpdateWeek=2
                           ,Publisher     ="Polarfox",Painter="Yooani",Author="Will Bright"
                           ,Introduction  ="「不但不是主角，還偏偏是書裡最惡毒的女人...」為了擺脫租屋生活而開始閱讀武俠小說《南宮世家少主》，卻穿越成為了小說裡最惡毒的女人——唐海媛。唐海媛這個天下第一惡女為了得到欽慕的男人，不惜毒殺思慕之人的情人、挑撥武林高手們、成為魔教的走狗並導致武林動盪。「絕不能和原本的故事內容一樣，白白送死!!」偶然吃了萬年參而變成小說世界裡的最強者，武俠小說最強惡女「唐海媛」的重生記!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656594393/MasterVillainessTheInvincible/3.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656788146/MookHyangDarkLady/3MP4.mp4"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},


                //星期列表與作品頁
                //星期四(屬於星期二)

                //星期四(屬於星期二)有影片
                new Comic {ComicChineseName="短命媳婦的逃跑計畫",ComicEnglishName="ShortLivedDaughterInLaw'sEscapePlan"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656999779/ShortLivedDaughterInLaw%27sEscapePlan/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656999287/ShortLivedDaughterInLaw%27sEscapePlan/4.jpg"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656999028/ShortLivedDaughterInLaw%27sEscapePlan/1.webm"
                           ,BgColor       ="#3a6052",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,13),UpdateWeek=2
                           ,Publisher     ="Yeondam",Painter="BASAK",Author="Yunajin"
                           ,Introduction  ="為什麼偏偏穿越到這種小說裡啊?!我就是小說中那位父母留下繁重債務後就死於事故，並且還注定在成年時便因病身亡的可憐少女——拉莉亞。這部小說的幕後黑手依卡勒德公爵為了欺瞞那些牽制自己的勢力，將我帶回家當他媳婦。我還是在偷偷存錢之後，找機會逃跑吧!可是治病的方法找到了、逃跑的資金也準備充足了...我的丈夫卻不知為何對我超執著?!他不是對誰都毫無感情的冷血之人嗎?而且我不是公公手上用完就丟的牌嗎?他為什麼會突然想救活我?!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656999981/ShortLivedDaughterInLaw%27sEscapePlan/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},

                new Comic {ComicChineseName="偉大的夙願",ComicEnglishName="TheGreatWish"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656606723/TheGreatWish/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587434/TheGreatWish/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587082/TheGreatWish/1.webp"
                           ,BgColor       ="#11242e",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,13),UpdateWeek=2
                           ,Publisher     ="Dreamtoon",Painter="Skye",Author="Skye"
                           ,Introduction  ="詩埃娜．阿爾傑特是神聖帝國唯一的皇女，從出生那一刻起便擁有了一切，智慧、美貌、才能，甚至是皇位繼承人的身分，無所不有。二十歲生日前夕，她開始夢見數十年後的自己，並認為這是神賜予她的預知能力而雀躍不已，為此向神致上謝意。但是在夢中預見的未來愈來愈奇怪，跟詩埃娜憧憬的未來大相逕庭。過去視為半吊子而瞧不起的同父異母兄長，展開了反擊；曾經以為會永遠站在自己這一方的母親，露出了隱藏的面目；還有，無論在現實或夢境中，都帶給詩埃娜巨大影響的男人，出現在眼前...詩埃娜周遭的一切，急速發生巨變，而她身上，也逐漸產生變化。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656587202/TheGreatWish/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656587373/TheGreatWish/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},

                new Comic {ComicChineseName="魔咒情人",ComicEnglishName="TheJinx'sLover"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608208/TheJinx%27sLover/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588311/TheJinx%27sLover/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588126/TheJinx%27sLover/1.webp"
                           ,BgColor       ="#ab9a9f",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,13),UpdateWeek=2
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Koo seul",Author="Koo seul"
                           ,Introduction  ="被有錢人家藏匿的幸運女神來到了窮困潦倒又倒楣透頂的我身邊。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656588228/TheJinx%27sLover/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},

                new Comic {ComicChineseName="英雄大人滿級回歸",ComicEnglishName="TheMaxLeveHeroStrikesBack"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608010/TheMaxLeveHeroStrikesBack/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574093/TheMaxLeveHeroStrikesBack/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656573894/TheMaxLeveHeroStrikesBack/1.webp"
                           ,BgColor       ="#394b78",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,13),UpdateWeek=2
                           ,Publisher     ="golemfactory",Painter="Yudo",Author="Devil's tail"
                           ,Introduction  ="無權無勢、被打入冷宮的王子戴伊比，在他陷入昏迷後靈魂出竅，來到了充滿各個英雄之靈的巨大迴廊。經過千年的洗禮，他成為滿級的英雄大人回歸了!所有人，給我等著吧，我一定會給你們好看!戴伊比的復仇記和宮廷生活，即將開始!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656574015/TheMaxLeveHeroStrikesBack/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},

                new Comic {ComicChineseName="永恆世界歸還者",ComicEnglishName="TheMaxLevelReturner"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607372/TheMaxLevelReturner/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593728/TheMaxLevelReturner/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593513/TheMaxLevelReturner/1.webp"
                           ,BgColor       ="#273961",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,13),UpdateWeek=2
                           ,Publisher     ="golemfactory",Painter="Vertwo",Author="Honey"
                           ,Introduction  ="全世界有1億2千萬人消失了。「開始執行完成最終任務的獎勵『回歸』。」睽違22年，尹尚赫結束了一場最爛的生存遊戲。被稱為一人軍團、最強玩家的他，帶著任何人都沒能得到的獎勵回歸了。「假面君主，回歸。」我獨自滿等、獨自通關、獨自暗爽!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656593634/TheMaxLevelReturner/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},

                new Comic {ComicChineseName="星隕之地的守候",ComicEnglishName="WaitWhereTheShootingStarFalls"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607267/WaitWhereTheShootingStarFalls/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656589140/WaitWhereTheShootingStarFalls/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588444/WaitWhereTheShootingStarFalls/1.webp"
                           ,BgColor       ="#171918",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,13),UpdateWeek=2
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Mr.General Store",Author="Mr.General Store"
                           ,Introduction  ="尋覓流星蹤跡的魔女與貓咪的故事。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656588686/WaitWhereTheShootingStarFalls/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},

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
                            ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},

                //44
                new Comic {ComicChineseName="忠犬的行動準則",ComicEnglishName="Woman'sBestFriend"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656606868/Woman%27sBestFriend/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656590842/Woman%27sBestFriend/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656589219/Woman%27sBestFriend/1.webp"
                            ,BgColor       ="#e45850",PublishDate=new DateTime(2021,7,2),LastPublishDate=new DateTime(2021,7,26),FinallyPublishDate= new DateTime(2021,7,13),UpdateWeek=2
                           ,Publisher     ="Dreamtoon",Painter="Dodam",Author="Hyun Sung Lee"
                           ,Introduction  ="在城云出版社裡，有個名為「瘋狗」的存在。他是徐禹俊，毫無變化的表情、沒有抑揚頓挫的語調、冰冷銳利的眼神，以及挑剔的個性是他的標誌。但是這男人，真的是瘋狗沒錯嗎?「別熄滅妳內在的光芒，也別輕易讓任何人熄滅它，妳可以再更有自信一點。」比起瘋狗，禹俊更像是忠犬般溫柔地對待泰齡，讓在情場上失利、工作不順，甚至連家庭都不溫暖的她怎麼也摸不著頭緒。該拿這個既像忠心的杜賓犬，又像可愛瑪爾濟斯的男人怎麼辦?時而輕柔、時而強烈地觸動人心的戀愛故事——《忠犬的行動準則》。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656589799/Woman%27sBestFriend/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656590753/Woman%27sBestFriend/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,7,2),ComicStatus=2},







                //星期列表與作品頁
                //星期三

                //星期三有影片
                new Comic {ComicChineseName="今生我來當家主",ComicEnglishName="TodayIWillBeTheHeadOfTheHouse"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656998366/TodayIWillBeTheHeadOfTheHouse/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582961/MookHyangDarkLady/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,BgColor       ="#418ab3",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="D&C WEBTOON Biz",Painter="Mon(Antstudio)",Author="Kim Roah"
                           ,Introduction  ="「...就試試吧，由我來當家主。」我轉世成了帝國第一大家族——倫巴第家的私生女費蓮緹雅。這個家族不但富甲天下，而且從外交到文化無一不精，堪稱帝國歷史的象徵!含著金湯匙中的金湯匙出生，簡直太幸運了!還以為將來等著我的是康莊大道...沒想到父親過世後，我被親戚趕出家門，最後連曾經鼎鼎有名的家族都毀於一旦!!悲憤交加的我小酌(?)幾杯後走在回家的路上，居然還被馬車撞上!「這也太過分了吧...」含冤而死的我一睜開眼卻回到了七歲的時候?!光是親愛的父親出現在眼前就已經令人難以置信，我竟然還有機會拯救父親與家族?連重生前的家族仇人——二皇子都像隻大型犬似地成天追著我跑?!好吧，既然如此，二皇子和家族都是我的了!轉世加重生，面對第三次人生的費蓮緹雅，為了當上家主而展開行動!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656594393/MasterVillainessTheInvincible/3.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1657034039/TodayIWillBeTheHeadOfTheHouse/2.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},



                new Comic {ComicChineseName="我有三個暴君哥哥",ComicEnglishName="MyThreeTyrantBrothers"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607226/MyThreeTyrantBrothers/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582063/MyThreeTyrantBrothers/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656581853/MyThreeTyrantBrothers/1.webp"
                           ,BgColor       ="#9fa925",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="DAON STUDIO",Painter="Parkha, Eun Du",Author="jomil​"
                           ,Introduction  ="我是個連名字都沒有的星期奴隸，代號「星期三」，當我因為反抗主人，性命不保的時候...「——終於找到妳了。」一夕之間多了三個哥哥，他們還說我是解除亞斯卡尼爾皇室詛咒的唯一鑰匙?!「妳一定要健健康康地長大，長到現在身上的衣服緊到再也穿不下，這是妳的第一項課題。」「別擔心，小不點。那些壞人，哥哥會幫妳狠狠教訓他們一頓。」「這孩子像隻小雞一樣，既嬌小又柔弱。我想要守護她，我會守護她。」被大家稱作暴君的哥哥們，怎麼只對我這麼溫柔!?從天而降的寵妹狂魔哥哥們和我的故事——《我有三個暴君哥哥》!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656581977/MyThreeTyrantBrothers/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},



                new Comic {ComicChineseName="廢墟中的皇女",ComicEnglishName="PrincessInTheRough"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605651/PrincessInTheRough/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577313/PrincessInTheRough/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576943/PrincessInTheRough/1.webp"
                           ,BgColor       ="#605342",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="Mstoryhub",Painter="HAERUA",Author="HARASYO"
                           ,Introduction  ="被皇帝遺忘的孩子，獨自一人生活在森林裡的廢棄城堡。「我討厭說謊的騙子，就算是一個人，我也可以過得好好的。」她經過漫長的等待，終於盼到皇帝來，但孩子的心扉早已緊緊關上了。「我來為妳取個名字。」「名字?」「艾斯特蕾拉，這就是妳的名字了...很抱歉讓妳久等了，孩子。」艾斯特蕾拉是一個擁有著特別能力的孩子，她的家人該如何療癒那顆破碎的心呢?"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656577015/PrincessInTheRough/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656577184/PrincessInTheRough/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},


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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},



                new Comic {ComicChineseName="婚禮復仇記",ComicEnglishName="RevengeWedding"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605358/RevengeWedding/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575576/RevengeWedding/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575339/RevengeWedding/1.webp"
                           ,BgColor       ="#28202b",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="DAON STUDIO",Painter="SaRyong​",Author="ByulSatangYang"
                           ,Introduction  ="集外貌、財富、地位於一身的完美女子——梅勒凱蒂亞．沙夏，暈倒後醒來發現自己位在一艘巨大的船上，身上還穿著婚紗。「蛤?我要結婚了嗎?是誰這麼大膽敢打我的主意?我一定要讓你打消結婚的念頭!」但沒想到...我的丈夫初次見面竟然就拿劍抵著我的脖子?他是帝國最偉大的戰爭英雄——戴枚德利奧．吉普洛沙。可是，他看起來一點都不像來結婚的啊?「我還想說是誰把我帶到這裡來的...只要殺了妳，我就可以回去了嗎?」「真是不好意思，我也是被綁架的好嗎?」我們兩人被綁架來結婚，甚至還要一起在無人島上求生存?!眼前的首要任務，就是逃出這座荒島!終極任務，要跟這個仇人離婚!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656575410/RevengeWedding/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656575490/RevengeWedding/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},



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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},

                new Comic {ComicChineseName="SSS級死而復生的獵人",ComicEnglishName="SSS-ClassRevivalHunter"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604749/SSS-ClassRevivalHunter/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580517/SSS-ClassRevivalHunter/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580224/SSS-ClassRevivalHunter/1.png"
                           ,BgColor       ="#1c1f26",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="Fansia",Painter="Bill K",Author="Sinnoa"
                           ,Introduction  ="身處F級底層的獵人「金孔子」長久以來一直羨慕著排行第一的獵人「炎帝」。某天，他竟突然獲得了S+級的技能。不料，短暫開心過後，他發現這個技能有些古怪?!「複製對方的其中一種技能」到這裡都還不錯...「什麼?竟然要我死了才能發動?!」重生獵人的人生樂章——《SSS級死而復生的獵人》"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656580385/SSS-ClassRevivalHunter/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656580450/SSS-ClassRevivalHunter/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},



                //星期列表與作品頁
                //星期一(屬於星期三)
                new Comic {

                            ComicChineseName="再次我的生活",ComicEnglishName="AgainMyLife"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604668/AgainMyLife/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656571331/AgainMyLife/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656570608/AgainMyLife/1.webp"
                           ,BgColor       ="#1b2260",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="YJ Comics",Painter="SUN YONG MIN",Author="Lee hae nal"
                           ,Introduction  ="重生的熱血檢察官，審判絕對之惡!韓民國的熱血檢察官金熙宇，在調查凌駕於法律之上、玩弄著大韓民國的絕對權力者趙泰燮的貪汙案時，慘遭趙泰燮的同夥殺害並丟入海中。但金熙宇在黃泉路上遇見的陰間使者給了他重生的機會，於是他帶著前世的記憶回到了18歲的膽小鬼時期。重新變成高中生的熙宇利用前世得知的未來事件，開始為制裁趙泰燮做準備...!「比惡魔更過分的怪物才能抓到惡魔。」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656571157/AgainMyLife/2.webm"
                           ,HotVideo = ""
                           ,AuditType =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},


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
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},


                new Comic {ComicChineseName="嗜血暴君的初戀",ComicEnglishName="ATyrant'sFirstLove"
                           ,ComicNameImage ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605209/ATyrant%27sFirstLove/5.png"
                           ,BgCover        ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576002/ATyrant%27sFirstLove/4.webp"
                           ,HotComicNameImage = ""
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure =""
                           ,BgColor       ="#310a0b",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="DAON STUDIO",Painter="CHIWA",Author="KIM SUO"
                           ,Introduction  ="喪失記憶的少女「迪雅」，原本在諾斯男爵府擔任女傭，日復一日地受盡折磨。沒想到，出了名殘酷的皇帝「凱勒」，竟在某天強行將迪雅帶至皇宮中，並詢問她認不認得自己。那天之後，迪雅便待在皇宮中，熟悉皇室的日常...某個月圓之夜，迪雅被一股神祕的力量牽引至城外，並撞見了渾身浴血的凱勒..."
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656575874/ATyrant%27sFirstLove/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656575948/ATyrant%27sFirstLove/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},

                //星期一(屬於星期三)有影片
                new Comic {ComicChineseName="留級玩家",ComicEnglishName="Recording Hall"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607506/ThePlayerWhoCan%27tLevelUp/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656581295/ThePlayerWhoCan%27tLevelUp/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580998/ThePlayerWhoCan%27tLevelUp/2.webp"
                           ,ComicWeekFigure =""
                           ,BgColor       ="#351f29",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="DAON STUDIO",Painter="binu",Author="Siya"
                           ,Introduction  ="因為穿越進自己寫的小說，我成了欺負男主角的繼姐!別擔心，我一定會讓你變得幸福。因為這本小說的作者就是我!「我從來都沒把姐姐當成是我的家人。」雖然我覺得自己很認真在實踐讓男主角幸福的計畫，但為什麼他沒把我當成家人看呢?在他成為公爵前，我真的能順利活下來嗎?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656580720/ThePlayerWhoCan%27tLevelUp/1.webm"
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},

                new Comic {ComicChineseName="足跡消融之前",ComicEnglishName="BeforeFootprintAblation"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608041/BeforeFootprintAblation/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656599274/BeforeFootprintAblation/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
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
                new Comic {ComicChineseName="稜冬暗夜",ComicEnglishName="BlackWinter"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605020/BlackWinter/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587899/BlackWinter/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587574/BlackWinter/1.webp"
                           ,BgColor       ="#1a151e",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Tess",Author="Tess"
                           ,Introduction  ="在假想的朝鮮時代，因世間種種而懷抱傷痛的人們交織而成的愛情故事。"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656587749/BlackWinter/2.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},

                new Comic {ComicChineseName="爸爸，請跟我結婚!",ComicEnglishName="DadPleaseMarryMe"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656784815/DadPleaseMarryMe/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656598156/DadPleaseMarryMe/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597992/DadPleaseMarryMe/1.webp"
                           ,BgColor       ="#2c3846",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="Yeondam X DAON",Painter="via",Author="dalseul"
                           ,Introduction  ="車禍之後睜眼一看，才發現自己身在喜歡的網路小說世界裡，而且還是在原著主角們出生前——他們的父母世代。為了阻止一連串的悲劇發生，原本是想保護懷孕的姐姐被綁架，沒想到卻代替她遭到綁架了?!被綁走已經夠悲慘了，還因為不適應魔力，導致隨時可能喪命。但是...只要待在綁匪皇帝身邊，便會恢復元氣!對了!要想拯救那個和惡女結婚又慘遭親生兒子殺害的男人，以及對魔力毫無抵抗力的自己...只能我們結婚了!「爸爸，請和我結婚!」「公主，我還未婚，也沒有子嗣，為什麼老是喊我爸爸...」敬請期待直直砸向鐵壁皇帝的甜蜜求婚計畫!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656598086/DadPleaseMarryMe/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},

                new Comic {ComicChineseName="琉璃之壁",ComicEnglishName="GlassBlock"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607414/GlassBlock/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574627/GlassBlock/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574474/GlassBlock/1.webp"
                           ,BgColor       ="#283e36",PublishDate=new DateTime(2021,8,2),LastPublishDate=new DateTime(2021,8,26),FinallyPublishDate= new DateTime(2021,8,20),UpdateWeek=3
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Joho",Author="Joho"
                           ,Introduction  ="富裕的貴族莉莉遇見他的那一刻，是一切的開端。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656574550/GlassBlock/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},
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
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,8,2),ComicStatus=2},






                //星期列表與作品頁
                //星期四

                //星期四有影片
                new Comic {ComicChineseName="短命媳婦的逃跑計畫",ComicEnglishName="ShortLivedDaughterInLaw'sEscapePlan"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656999779/ShortLivedDaughterInLaw%27sEscapePlan/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656999287/ShortLivedDaughterInLaw%27sEscapePlan/4.jpg"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656999028/ShortLivedDaughterInLaw%27sEscapePlan/1.webm"
                           ,BgColor       ="#3a6052",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="Yeondam",Painter="BASAK",Author="Yunajin"
                           ,Introduction  ="為什麼偏偏穿越到這種小說裡啊?!我就是小說中那位父母留下繁重債務後就死於事故，並且還注定在成年時便因病身亡的可憐少女——拉莉亞。這部小說的幕後黑手依卡勒德公爵為了欺瞞那些牽制自己的勢力，將我帶回家當他媳婦。我還是在偷偷存錢之後，找機會逃跑吧!可是治病的方法找到了、逃跑的資金也準備充足了...我的丈夫卻不知為何對我超執著?!他不是對誰都毫無感情的冷血之人嗎?而且我不是公公手上用完就丟的牌嗎?他為什麼會突然想救活我?!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656999981/ShortLivedDaughterInLaw%27sEscapePlan/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

                new Comic {ComicChineseName="偉大的夙願",ComicEnglishName="TheGreatWish"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656606723/TheGreatWish/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587434/TheGreatWish/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587082/TheGreatWish/1.webp"
                           ,BgColor       ="#11242e",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="Dreamtoon",Painter="Skye",Author="Skye"
                           ,Introduction  ="詩埃娜．阿爾傑特是神聖帝國唯一的皇女，從出生那一刻起便擁有了一切，智慧、美貌、才能，甚至是皇位繼承人的身分，無所不有。二十歲生日前夕，她開始夢見數十年後的自己，並認為這是神賜予她的預知能力而雀躍不已，為此向神致上謝意。但是在夢中預見的未來愈來愈奇怪，跟詩埃娜憧憬的未來大相逕庭。過去視為半吊子而瞧不起的同父異母兄長，展開了反擊；曾經以為會永遠站在自己這一方的母親，露出了隱藏的面目；還有，無論在現實或夢境中，都帶給詩埃娜巨大影響的男人，出現在眼前...詩埃娜周遭的一切，急速發生巨變，而她身上，也逐漸產生變化。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656587202/TheGreatWish/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656587373/TheGreatWish/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

                new Comic {ComicChineseName="魔咒情人",ComicEnglishName="TheJinx'sLover"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608208/TheJinx%27sLover/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588311/TheJinx%27sLover/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588126/TheJinx%27sLover/1.webp"
                           ,BgColor       ="#ab9a9f",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Koo seul",Author="Koo seul"
                           ,Introduction  ="被有錢人家藏匿的幸運女神來到了窮困潦倒又倒楣透頂的我身邊。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656588228/TheJinx%27sLover/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

                new Comic {ComicChineseName="英雄大人滿級回歸",ComicEnglishName="TheMaxLeveHeroStrikesBack"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608010/TheMaxLeveHeroStrikesBack/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574093/TheMaxLeveHeroStrikesBack/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656573894/TheMaxLeveHeroStrikesBack/1.webp"
                           ,BgColor       ="#394b78",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="golemfactory",Painter="Yudo",Author="Devil's tail"
                           ,Introduction  ="無權無勢、被打入冷宮的王子戴伊比，在他陷入昏迷後靈魂出竅，來到了充滿各個英雄之靈的巨大迴廊。經過千年的洗禮，他成為滿級的英雄大人回歸了!所有人，給我等著吧，我一定會給你們好看!戴伊比的復仇記和宮廷生活，即將開始!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656574015/TheMaxLeveHeroStrikesBack/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

                new Comic {ComicChineseName="永恆世界歸還者",ComicEnglishName="TheMaxLevelReturner"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607372/TheMaxLevelReturner/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593728/TheMaxLevelReturner/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593513/TheMaxLevelReturner/1.webp"
                           ,BgColor       ="#273961",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="golemfactory",Painter="Vertwo",Author="Honey"
                           ,Introduction  ="全世界有1億2千萬人消失了。「開始執行完成最終任務的獎勵『回歸』。」睽違22年，尹尚赫結束了一場最爛的生存遊戲。被稱為一人軍團、最強玩家的他，帶著任何人都沒能得到的獎勵回歸了。「假面君主，回歸。」我獨自滿等、獨自通關、獨自暗爽!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656593634/TheMaxLevelReturner/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

                new Comic {ComicChineseName="星隕之地的守候",ComicEnglishName="WaitWhereTheShootingStarFalls"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607267/WaitWhereTheShootingStarFalls/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656589140/WaitWhereTheShootingStarFalls/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588444/WaitWhereTheShootingStarFalls/1.webp"
                           ,BgColor       ="#171918",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Mr.General Store",Author="Mr.General Store"
                           ,Introduction  ="尋覓流星蹤跡的魔女與貓咪的故事。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656588686/WaitWhereTheShootingStarFalls/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

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
                            ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

                //77
                new Comic {ComicChineseName="忠犬的行動準則",ComicEnglishName="Woman'sBestFriend"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656606868/Woman%27sBestFriend/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656590842/Woman%27sBestFriend/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656589219/Woman%27sBestFriend/1.webp"
                            ,BgColor       ="#e45850",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="Dreamtoon",Painter="Dodam",Author="Hyun Sung Lee"
                           ,Introduction  ="在城云出版社裡，有個名為「瘋狗」的存在。他是徐禹俊，毫無變化的表情、沒有抑揚頓挫的語調、冰冷銳利的眼神，以及挑剔的個性是他的標誌。但是這男人，真的是瘋狗沒錯嗎?「別熄滅妳內在的光芒，也別輕易讓任何人熄滅它，妳可以再更有自信一點。」比起瘋狗，禹俊更像是忠犬般溫柔地對待泰齡，讓在情場上失利、工作不順，甚至連家庭都不溫暖的她怎麼也摸不著頭緒。該拿這個既像忠心的杜賓犬，又像可愛瑪爾濟斯的男人怎麼辦?時而輕柔、時而強烈地觸動人心的戀愛故事——《忠犬的行動準則》。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656589799/Woman%27sBestFriend/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656590753/Woman%27sBestFriend/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,6,28),ComicStatus=2},



                //星期列表與作品頁
                //星期二(屬於星期四)

                //星期二(屬於星期四)有影片
                new Comic {ComicChineseName="盜墓王",ComicEnglishName="TombRaiderKing"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607700/TombRaiderKing/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656572963/TombRaiderKing/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure =""
                           ,BgColor       ="#575a6f",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="Polarfox",Painter="Yooani",Author="Will Bright"
                           ,Introduction  ="「不但不是主角，還偏偏是書裡最惡毒的女人...」為了擺脫租屋生活而開始閱讀武俠小說《南宮世家少主》，卻穿越成為了小說裡最惡毒的女人——唐海媛。唐海媛這個天下第一惡女為了得到欽慕的男人，不惜毒殺思慕之人的情人、挑撥武林高手們、成為魔教的走狗並導致武林動盪。「絕不能和原本的故事內容一樣，白白送死!!」偶然吃了萬年參而變成小說世界裡的最強者，武俠小說最強惡女「唐海媛」的重生記!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656572710/TombRaiderKing/1.webm"
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656572903/TombRaiderKing/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

                new Comic {ComicChineseName="我成了反派的繼母",ComicEnglishName="IBecameTheVillain'sMother"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607155/IBecameTheVillain%27sMother/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584749/IBecameTheVillain%27sMother/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584432/IBecameTheVillain%27sMother/1.webp"
                           ,BgColor       ="#225040",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="DAON STUDIO",Painter="Iro",Author="Yulji"
                           ,Introduction  ="我成了小說裡最終的反派角色「艾因斯潘納」的繼母。而且還是小時候虐待他，長大後第一個被他殺害的壞心繼母。在我思考該如何逃離這悲慘命運時，仍一無所知、天真無邪的未來反派潛力股映入眼簾，但是...「等等，這孩子就連胖嘟嘟的小手都這麼可愛!誰捨得虐待他啊!」在我眼前的是個和反派完全沾不上邊的可愛小孩。好，我決定了，交給我吧!我會守護你!所以長大後拜託饒我一命吧!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656584573/IBecameTheVillain%27sMother/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656584694/IBecameTheVillain%27sMother/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,22),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

                new Comic {ComicChineseName="就離開我吧",ComicEnglishName="JustLeaveMe"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605448/JustLeaveMe/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597845/JustLeaveMe/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597626/JustLeaveMe/1.webp"
                           ,BgColor       ="#121212",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="Yeondam X DAON",Painter="chero",Author="JAEUNHYANG"
                           ,Introduction  ="因罕見疾病而死亡的公爵之女，阿黛兒成了她的替身，雖然用盡一切努力想得到家人們的愛，卻還是於妹妹一出生時就遭到拋棄，在前往政治聯姻的路途中被不明的刺客暗殺。「...難道這是夢?」但在她睜開眼後，卻發現自己回到了3年前!想著反正只要妹妹一出生就會遭到拋棄的自己，阿黛兒決定這次的人生要操之在己，可惜依舊不斷遭遇苦難。「難道您不是對我有興趣嗎?」再加上一個身分不明的黑色騎士老是接近她..."
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656597726/JustLeaveMe/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656597781/JustLeaveMe/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

                new Comic {ComicChineseName="千金大廚來上菜",ComicEnglishName="LadyChefRoyale"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605055/LadyChefRoyale/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656591172/LadyChefRoyale/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656590985/LadyChefRoyale/1.webp"
                           ,BgColor       ="#dd6b79",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="Dreamtoon",Painter="PAYA",Author="Lysha"
                           ,Introduction  ="我原是一位小餐廳的廚師，卻成為了一個連皇帝都害怕的貴族家——他們家的受氣包小女兒。本想存一些錢，然後逃跑的...真是奇怪。「跟你說對不起，是一件丟臉的事嗎?」「是啊，因為我是妳哥哥。」「妳不和我這個爺爺去散步嗎?」大家為什麼突然間對我這麼好?「為什麼我想要把那些看妳的人的眼睛挖出來?」試圖逃跑的我以及緊緊抓住我的人，只是做了料理而已，為什麼會這樣...「愛死她的家人們 / 想逃跑的她 / 她專屬的僕人們」即將登場!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656591037/LadyChefRoyale/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656591103/LadyChefRoyale/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

                new Comic {ComicChineseName="魔彈射手",ComicEnglishName="MadanNoShashu"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608240/MadanNoShashu/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582317/MadanNoShashu/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582133/MadanNoShashu/1.webp"
                           ,BgColor       ="#060b28",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="intime",Painter="GLPI",Author="Respect"
                           ,Introduction  ="「何中士，你又全中了啊!」即將成為軍官的神射手，何里夏中士，因一起意外事故，導致下半身癱瘓，成為了一個被世界遺棄的孤兒。在陷入絕望之際，虛擬實境遊戲「米德爾斯」橫空出世，賦予了他嶄新的人生。而在「米德爾斯」裡賺取的錢財，竟然可以成為現實世界中的財產!但因一開始的失誤，何里夏選擇了能力值最低的角色。眼看他就要被當成沙包打了!「我和你們不一樣，我已經無路可退了!」用火藥、鋼珠、推彈杆，讓你們看看什麼是真正的神槍手!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656582250/MadanNoShashu/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

                //88
                new Comic {ComicChineseName="墨劍留香",ComicEnglishName="MookHyangDarkLady"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605276/MookHyangDarkLady/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582961/MookHyangDarkLady/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,BgColor       ="#1a0c19",PublishDate=new DateTime(2021,9,2),LastPublishDate=new DateTime(2021,9,26),FinallyPublishDate= new DateTime(2021,9,20),UpdateWeek=4
                           ,Publisher     ="Polarfox",Painter="Yooani",Author="Will Bright"
                           ,Introduction  ="「不但不是主角，還偏偏是書裡最惡毒的女人...」為了擺脫租屋生活而開始閱讀武俠小說《南宮世家少主》，卻穿越成為了小說裡最惡毒的女人——唐海媛。唐海媛這個天下第一惡女為了得到欽慕的男人，不惜毒殺思慕之人的情人、挑撥武林高手們、成為魔教的走狗並導致武林動盪。「絕不能和原本的故事內容一樣，白白送死!!」偶然吃了萬年參而變成小說世界裡的最強者，武俠小說最強惡女「唐海媛」的重生記!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656594393/MasterVillainessTheInvincible/3.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656788146/MookHyangDarkLady/3MP4.mp4"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},



                //星期列表與作品頁
                //星期五
                new Comic {

                            ComicChineseName="再次我的生活",ComicEnglishName="AgainMyLife"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604668/AgainMyLife/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656571331/AgainMyLife/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656570608/AgainMyLife/1.webp"
                           ,BgColor       ="#1b2260",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="YJ Comics",Painter="SUN YONG MIN",Author="Lee hae nal"
                           ,Introduction  ="重生的熱血檢察官，審判絕對之惡!韓民國的熱血檢察官金熙宇，在調查凌駕於法律之上、玩弄著大韓民國的絕對權力者趙泰燮的貪汙案時，慘遭趙泰燮的同夥殺害並丟入海中。但金熙宇在黃泉路上遇見的陰間使者給了他重生的機會，於是他帶著前世的記憶回到了18歲的膽小鬼時期。重新變成高中生的熙宇利用前世得知的未來事件，開始為制裁趙泰燮做準備...!「比惡魔更過分的怪物才能抓到惡魔。」"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656571157/AgainMyLife/2.webm"
                           ,HotVideo = ""
                           ,AuditType =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=2},


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
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=2},


                new Comic {ComicChineseName="嗜血暴君的初戀",ComicEnglishName="ATyrant'sFirstLove"
                           ,ComicNameImage ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605209/ATyrant%27sFirstLove/5.png"
                           ,BgCover        ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576002/ATyrant%27sFirstLove/4.webp"
                           ,HotComicNameImage = ""
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure =""
                           ,BgColor       ="#310a0b",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="DAON STUDIO",Painter="CHIWA",Author="KIM SUO"
                           ,Introduction  ="喪失記憶的少女「迪雅」，原本在諾斯男爵府擔任女傭，日復一日地受盡折磨。沒想到，出了名殘酷的皇帝「凱勒」，竟在某天強行將迪雅帶至皇宮中，並詢問她認不認得自己。那天之後，迪雅便待在皇宮中，熟悉皇室的日常...某個月圓之夜，迪雅被一股神祕的力量牽引至城外，並撞見了渾身浴血的凱勒..."
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656575874/ATyrant%27sFirstLove/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656575948/ATyrant%27sFirstLove/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=2},

                //星期五有影片
                new Comic {ComicChineseName="留級玩家",ComicEnglishName="Recording Hall"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607506/ThePlayerWhoCan%27tLevelUp/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656581295/ThePlayerWhoCan%27tLevelUp/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580998/ThePlayerWhoCan%27tLevelUp/2.webp"
                           ,ComicWeekFigure =""
                           ,BgColor       ="#351f29",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="DAON STUDIO",Painter="binu",Author="Siya"
                           ,Introduction  ="因為穿越進自己寫的小說，我成了欺負男主角的繼姐!別擔心，我一定會讓你變得幸福。因為這本小說的作者就是我!「我從來都沒把姐姐當成是我的家人。」雖然我覺得自己很認真在實踐讓男主角幸福的計畫，但為什麼他沒把我當成家人看呢?在他成為公爵前，我真的能順利活下來嗎?"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656580720/ThePlayerWhoCan%27tLevelUp/1.webm"
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=2},

                new Comic {ComicChineseName="足跡消融之前",ComicEnglishName="BeforeFootprintAblation"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608041/BeforeFootprintAblation/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656599274/BeforeFootprintAblation/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
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
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587574/BlackWinter/1.webp"
                           ,BgColor       ="#1a151e",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Tess",Author="Tess"
                           ,Introduction  ="在假想的朝鮮時代，因世間種種而懷抱傷痛的人們交織而成的愛情故事。"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656587749/BlackWinter/2.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,30),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=2},

                new Comic {ComicChineseName="爸爸，請跟我結婚!",ComicEnglishName="DadPleaseMarryMe"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656784815/DadPleaseMarryMe/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656598156/DadPleaseMarryMe/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597992/DadPleaseMarryMe/1.webp"
                           ,BgColor       ="#2c3846",PublishDate=new DateTime(2021,10,30),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="Yeondam X DAON",Painter="via",Author="dalseul"
                           ,Introduction  ="車禍之後睜眼一看，才發現自己身在喜歡的網路小說世界裡，而且還是在原著主角們出生前——他們的父母世代。為了阻止一連串的悲劇發生，原本是想保護懷孕的姐姐被綁架，沒想到卻代替她遭到綁架了?!被綁走已經夠悲慘了，還因為不適應魔力，導致隨時可能喪命。但是...只要待在綁匪皇帝身邊，便會恢復元氣!對了!要想拯救那個和惡女結婚又慘遭親生兒子殺害的男人，以及對魔力毫無抵抗力的自己...只能我們結婚了!「爸爸，請和我結婚!」「公主，我還未婚，也沒有子嗣，為什麼老是喊我爸爸...」敬請期待直直砸向鐵壁皇帝的甜蜜求婚計畫!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656598086/DadPleaseMarryMe/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,30),ComicStatus=2},

                new Comic {ComicChineseName="琉璃之壁",ComicEnglishName="GlassBlock"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607414/GlassBlock/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574627/GlassBlock/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574474/GlassBlock/1.webp"
                           ,BgColor       ="#283e36",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Joho",Author="Joho"
                           ,Introduction  ="富裕的貴族莉莉遇見他的那一刻，是一切的開端。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656574550/GlassBlock/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=2},
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
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=2},


                //星期列表與作品頁
                //星期三(屬於星期五)

                //星期三(屬於星期五)有影片
                new Comic {ComicChineseName="今生我來當家主",ComicEnglishName="TodayIWillBeTheHeadOfTheHouse"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656998366/TodayIWillBeTheHeadOfTheHouse/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582961/MookHyangDarkLady/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,BgColor       ="#418ab3",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="D&C WEBTOON Biz",Painter="Mon(Antstudio)",Author="Kim Roah"
                           ,Introduction  ="「...就試試吧，由我來當家主。」我轉世成了帝國第一大家族——倫巴第家的私生女費蓮緹雅。這個家族不但富甲天下，而且從外交到文化無一不精，堪稱帝國歷史的象徵!含著金湯匙中的金湯匙出生，簡直太幸運了!還以為將來等著我的是康莊大道...沒想到父親過世後，我被親戚趕出家門，最後連曾經鼎鼎有名的家族都毀於一旦!!悲憤交加的我小酌(?)幾杯後走在回家的路上，居然還被馬車撞上!「這也太過分了吧...」含冤而死的我一睜開眼卻回到了七歲的時候?!光是親愛的父親出現在眼前就已經令人難以置信，我竟然還有機會拯救父親與家族?連重生前的家族仇人——二皇子都像隻大型犬似地成天追著我跑?!好吧，既然如此，二皇子和家族都是我的了!轉世加重生，面對第三次人生的費蓮緹雅，為了當上家主而展開行動!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656594393/MasterVillainessTheInvincible/3.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1657034039/TodayIWillBeTheHeadOfTheHouse/2.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=2},



                new Comic {ComicChineseName="我有三個暴君哥哥",ComicEnglishName="MyThreeTyrantBrothers"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607226/MyThreeTyrantBrothers/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582063/MyThreeTyrantBrothers/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656581853/MyThreeTyrantBrothers/1.webp"
                           ,BgColor       ="#9fa925",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="DAON STUDIO",Painter="Parkha, Eun Du",Author="jomil​"
                           ,Introduction  ="我是個連名字都沒有的星期奴隸，代號「星期三」，當我因為反抗主人，性命不保的時候...「——終於找到妳了。」一夕之間多了三個哥哥，他們還說我是解除亞斯卡尼爾皇室詛咒的唯一鑰匙?!「妳一定要健健康康地長大，長到現在身上的衣服緊到再也穿不下，這是妳的第一項課題。」「別擔心，小不點。那些壞人，哥哥會幫妳狠狠教訓他們一頓。」「這孩子像隻小雞一樣，既嬌小又柔弱。我想要守護她，我會守護她。」被大家稱作暴君的哥哥們，怎麼只對我這麼溫柔!?從天而降的寵妹狂魔哥哥們和我的故事——《我有三個暴君哥哥》!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656581977/MyThreeTyrantBrothers/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=2},



                new Comic {ComicChineseName="廢墟中的皇女",ComicEnglishName="PrincessInTheRough"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605651/PrincessInTheRough/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577313/PrincessInTheRough/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576943/PrincessInTheRough/1.webp"
                           ,BgColor       ="#605342",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="Mstoryhub",Painter="HAERUA",Author="HARASYO"
                           ,Introduction  ="被皇帝遺忘的孩子，獨自一人生活在森林裡的廢棄城堡。「我討厭說謊的騙子，就算是一個人，我也可以過得好好的。」她經過漫長的等待，終於盼到皇帝來，但孩子的心扉早已緊緊關上了。「我來為妳取個名字。」「名字?」「艾斯特蕾拉，這就是妳的名字了...很抱歉讓妳久等了，孩子。」艾斯特蕾拉是一個擁有著特別能力的孩子，她的家人該如何療癒那顆破碎的心呢?"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656577015/PrincessInTheRough/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656577184/PrincessInTheRough/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=2},


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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=2},


                new Comic {ComicChineseName="婚禮復仇記",ComicEnglishName="RevengeWedding"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605358/RevengeWedding/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575576/RevengeWedding/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575339/RevengeWedding/1.webp"
                           ,BgColor       ="#28202b",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="DAON STUDIO",Painter="SaRyong​",Author="ByulSatangYang"
                           ,Introduction  ="集外貌、財富、地位於一身的完美女子——梅勒凱蒂亞．沙夏，暈倒後醒來發現自己位在一艘巨大的船上，身上還穿著婚紗。「蛤?我要結婚了嗎?是誰這麼大膽敢打我的主意?我一定要讓你打消結婚的念頭!」但沒想到...我的丈夫初次見面竟然就拿劍抵著我的脖子?他是帝國最偉大的戰爭英雄——戴枚德利奧．吉普洛沙。可是，他看起來一點都不像來結婚的啊?「我還想說是誰把我帶到這裡來的...只要殺了妳，我就可以回去了嗎?」「真是不好意思，我也是被綁架的好嗎?」我們兩人被綁架來結婚，甚至還要一起在無人島上求生存?!眼前的首要任務，就是逃出這座荒島!終極任務，要跟這個仇人離婚!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656575410/RevengeWedding/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656575490/RevengeWedding/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=2},


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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=2},

                new Comic {ComicChineseName="SSS級死而復生的獵人",ComicEnglishName="SSS-ClassRevivalHunter"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604749/SSS-ClassRevivalHunter/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580517/SSS-ClassRevivalHunter/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580224/SSS-ClassRevivalHunter/1.png"
                           ,BgColor       ="#1c1f26",PublishDate=new DateTime(2021,10,28),LastPublishDate=new DateTime(2022,11,14),FinallyPublishDate=new DateTime(2022,11,10),UpdateWeek=5
                           ,Publisher     ="Fansia",Painter="Bill K",Author="Sinnoa"
                           ,Introduction  ="身處F級底層的獵人「金孔子」長久以來一直羨慕著排行第一的獵人「炎帝」。某天，他竟突然獲得了S+級的技能。不料，短暫開心過後，他發現這個技能有些古怪?!「複製對方的其中一種技能」到這裡都還不錯...「什麼?竟然要我死了才能發動?!」重生獵人的人生樂章——《SSS級死而復生的獵人》"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656580385/SSS-ClassRevivalHunter/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656580450/SSS-ClassRevivalHunter/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,10,28),ComicStatus=2},




                //星期列表與作品頁
                //星期六

                //星期六有影片
                new Comic {ComicChineseName="盜墓王",ComicEnglishName="TombRaiderKing"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607700/TombRaiderKing/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656572963/TombRaiderKing/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure =""
                           ,BgColor       ="#575a6f",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="Polarfox",Painter="Yooani",Author="Will Bright"
                           ,Introduction  ="「不但不是主角，還偏偏是書裡最惡毒的女人...」為了擺脫租屋生活而開始閱讀武俠小說《南宮世家少主》，卻穿越成為了小說裡最惡毒的女人——唐海媛。唐海媛這個天下第一惡女為了得到欽慕的男人，不惜毒殺思慕之人的情人、挑撥武林高手們、成為魔教的走狗並導致武林動盪。「絕不能和原本的故事內容一樣，白白送死!!」偶然吃了萬年參而變成小說世界裡的最強者，武俠小說最強惡女「唐海媛」的重生記!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656572710/TombRaiderKing/1.webm"
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656572903/TombRaiderKing/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=2},

                new Comic {ComicChineseName="我成了反派的繼母",ComicEnglishName="IBecameTheVillain'sMother"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607155/IBecameTheVillain%27sMother/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584749/IBecameTheVillain%27sMother/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584432/IBecameTheVillain%27sMother/1.webp"
                           ,BgColor       ="#225040",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="DAON STUDIO",Painter="Iro",Author="Yulji"
                           ,Introduction  ="我成了小說裡最終的反派角色「艾因斯潘納」的繼母。而且還是小時候虐待他，長大後第一個被他殺害的壞心繼母。在我思考該如何逃離這悲慘命運時，仍一無所知、天真無邪的未來反派潛力股映入眼簾，但是...「等等，這孩子就連胖嘟嘟的小手都這麼可愛!誰捨得虐待他啊!」在我眼前的是個和反派完全沾不上邊的可愛小孩。好，我決定了，交給我吧!我會守護你!所以長大後拜託饒我一命吧!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656584573/IBecameTheVillain%27sMother/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656584694/IBecameTheVillain%27sMother/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=2},

                new Comic {ComicChineseName="就離開我吧",ComicEnglishName="JustLeaveMe"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605448/JustLeaveMe/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597845/JustLeaveMe/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597626/JustLeaveMe/1.webp"
                           ,BgColor       ="#121212",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="Yeondam X DAON",Painter="chero",Author="JAEUNHYANG"
                           ,Introduction  ="因罕見疾病而死亡的公爵之女，阿黛兒成了她的替身，雖然用盡一切努力想得到家人們的愛，卻還是於妹妹一出生時就遭到拋棄，在前往政治聯姻的路途中被不明的刺客暗殺。「...難道這是夢?」但在她睜開眼後，卻發現自己回到了3年前!想著反正只要妹妹一出生就會遭到拋棄的自己，阿黛兒決定這次的人生要操之在己，可惜依舊不斷遭遇苦難。「難道您不是對我有興趣嗎?」再加上一個身分不明的黑色騎士老是接近她..."
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656597726/JustLeaveMe/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656597781/JustLeaveMe/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=2},

                new Comic {ComicChineseName="千金大廚來上菜",ComicEnglishName="LadyChefRoyale"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605055/LadyChefRoyale/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656591172/LadyChefRoyale/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656590985/LadyChefRoyale/1.webp"
                           ,BgColor       ="#dd6b79",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="Dreamtoon",Painter="PAYA",Author="Lysha"
                           ,Introduction  ="我原是一位小餐廳的廚師，卻成為了一個連皇帝都害怕的貴族家——他們家的受氣包小女兒。本想存一些錢，然後逃跑的...真是奇怪。「跟你說對不起，是一件丟臉的事嗎?」「是啊，因為我是妳哥哥。」「妳不和我這個爺爺去散步嗎?」大家為什麼突然間對我這麼好?「為什麼我想要把那些看妳的人的眼睛挖出來?」試圖逃跑的我以及緊緊抓住我的人，只是做了料理而已，為什麼會這樣...「愛死她的家人們 / 想逃跑的她 / 她專屬的僕人們」即將登場!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656591037/LadyChefRoyale/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656591103/LadyChefRoyale/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=2},

                new Comic {ComicChineseName="魔彈射手",ComicEnglishName="MadanNoShashu"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608240/MadanNoShashu/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582317/MadanNoShashu/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582133/MadanNoShashu/1.webp"
                           ,BgColor       ="#060b28",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="intime",Painter="GLPI",Author="Respect"
                           ,Introduction  ="「何中士，你又全中了啊!」即將成為軍官的神射手，何里夏中士，因一起意外事故，導致下半身癱瘓，成為了一個被世界遺棄的孤兒。在陷入絕望之際，虛擬實境遊戲「米德爾斯」橫空出世，賦予了他嶄新的人生。而在「米德爾斯」裡賺取的錢財，竟然可以成為現實世界中的財產!但因一開始的失誤，何里夏選擇了能力值最低的角色。眼看他就要被當成沙包打了!「我和你們不一樣，我已經無路可退了!」用火藥、鋼珠、推彈杆，讓你們看看什麼是真正的神槍手!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656582250/MadanNoShashu/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=2},

                //121
                new Comic {ComicChineseName="墨劍留香",ComicEnglishName="MookHyangDarkLady"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605276/MookHyangDarkLady/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582961/MookHyangDarkLady/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,BgColor       ="#1a0c19",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="Polarfox",Painter="Yooani",Author="Will Bright"
                           ,Introduction  ="「不但不是主角，還偏偏是書裡最惡毒的女人...」為了擺脫租屋生活而開始閱讀武俠小說《南宮世家少主》，卻穿越成為了小說裡最惡毒的女人——唐海媛。唐海媛這個天下第一惡女為了得到欽慕的男人，不惜毒殺思慕之人的情人、挑撥武林高手們、成為魔教的走狗並導致武林動盪。「絕不能和原本的故事內容一樣，白白送死!!」偶然吃了萬年參而變成小說世界裡的最強者，武俠小說最強惡女「唐海媛」的重生記!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656594393/MasterVillainessTheInvincible/3.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656788146/MookHyangDarkLady/3MP4.mp4"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=2},



                //星期列表與作品頁
                //星期四(屬於星期六)

                //星期四(屬於星期六)有影片
                new Comic {ComicChineseName="短命媳婦的逃跑計畫",ComicEnglishName="ShortLivedDaughterInLaw'sEscapePlan"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656999779/ShortLivedDaughterInLaw%27sEscapePlan/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656999287/ShortLivedDaughterInLaw%27sEscapePlan/4.jpg"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656999028/ShortLivedDaughterInLaw%27sEscapePlan/1.webm"
                           ,BgColor       ="#3a6052",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="Yeondam",Painter="BASAK",Author="Yunajin"
                           ,Introduction  ="為什麼偏偏穿越到這種小說裡啊?!我就是小說中那位父母留下繁重債務後就死於事故，並且還注定在成年時便因病身亡的可憐少女——拉莉亞。這部小說的幕後黑手依卡勒德公爵為了欺瞞那些牽制自己的勢力，將我帶回家當他媳婦。我還是在偷偷存錢之後，找機會逃跑吧!可是治病的方法找到了、逃跑的資金也準備充足了...我的丈夫卻不知為何對我超執著?!他不是對誰都毫無感情的冷血之人嗎?而且我不是公公手上用完就丟的牌嗎?他為什麼會突然想救活我?!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656999981/ShortLivedDaughterInLaw%27sEscapePlan/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=2},

                new Comic {ComicChineseName="偉大的夙願",ComicEnglishName="TheGreatWish"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656606723/TheGreatWish/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587434/TheGreatWish/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656587082/TheGreatWish/1.webp"
                           ,BgColor       ="#11242e",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="Dreamtoon",Painter="Skye",Author="Skye"
                           ,Introduction  ="詩埃娜．阿爾傑特是神聖帝國唯一的皇女，從出生那一刻起便擁有了一切，智慧、美貌、才能，甚至是皇位繼承人的身分，無所不有。二十歲生日前夕，她開始夢見數十年後的自己，並認為這是神賜予她的預知能力而雀躍不已，為此向神致上謝意。但是在夢中預見的未來愈來愈奇怪，跟詩埃娜憧憬的未來大相逕庭。過去視為半吊子而瞧不起的同父異母兄長，展開了反擊；曾經以為會永遠站在自己這一方的母親，露出了隱藏的面目；還有，無論在現實或夢境中，都帶給詩埃娜巨大影響的男人，出現在眼前...詩埃娜周遭的一切，急速發生巨變，而她身上，也逐漸產生變化。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656587202/TheGreatWish/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656587373/TheGreatWish/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=2},

                new Comic {ComicChineseName="魔咒情人",ComicEnglishName="TheJinx'sLover"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608208/TheJinx%27sLover/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588311/TheJinx%27sLover/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588126/TheJinx%27sLover/1.webp"
                           ,BgColor       ="#ab9a9f",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Koo seul",Author="Koo seul"
                           ,Introduction  ="被有錢人家藏匿的幸運女神來到了窮困潦倒又倒楣透頂的我身邊。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656588228/TheJinx%27sLover/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=2},

                new Comic {ComicChineseName="英雄大人滿級回歸",ComicEnglishName="TheMaxLeveHeroStrikesBack"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608010/TheMaxLeveHeroStrikesBack/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656574093/TheMaxLeveHeroStrikesBack/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656573894/TheMaxLeveHeroStrikesBack/1.webp"
                           ,BgColor       ="#394b78",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="golemfactory",Painter="Yudo",Author="Devil's tail"
                           ,Introduction  ="無權無勢、被打入冷宮的王子戴伊比，在他陷入昏迷後靈魂出竅，來到了充滿各個英雄之靈的巨大迴廊。經過千年的洗禮，他成為滿級的英雄大人回歸了!所有人，給我等著吧，我一定會給你們好看!戴伊比的復仇記和宮廷生活，即將開始!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656574015/TheMaxLeveHeroStrikesBack/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=2},

                new Comic {ComicChineseName="永恆世界歸還者",ComicEnglishName="TheMaxLevelReturner"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607372/TheMaxLevelReturner/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593728/TheMaxLevelReturner/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656593513/TheMaxLevelReturner/1.webp"
                           ,BgColor       ="#273961",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="golemfactory",Painter="Vertwo",Author="Honey"
                           ,Introduction  ="全世界有1億2千萬人消失了。「開始執行完成最終任務的獎勵『回歸』。」睽違22年，尹尚赫結束了一場最爛的生存遊戲。被稱為一人軍團、最強玩家的他，帶著任何人都沒能得到的獎勵回歸了。「假面君主，回歸。」我獨自滿等、獨自通關、獨自暗爽!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656593634/TheMaxLevelReturner/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,9,2),ComicStatus=2},

                new Comic {ComicChineseName="星隕之地的守候",ComicEnglishName="WaitWhereTheShootingStarFalls"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607267/WaitWhereTheShootingStarFalls/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656589140/WaitWhereTheShootingStarFalls/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656588444/WaitWhereTheShootingStarFalls/1.webp"
                           ,BgColor       ="#171918",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="KAKAO WEBTOON Studio",Painter="Mr.General Store",Author="Mr.General Store"
                           ,Introduction  ="尋覓流星蹤跡的魔女與貓咪的故事。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656588686/WaitWhereTheShootingStarFalls/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=2},

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
                            ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=2},

                //132
                new Comic {ComicChineseName="忠犬的行動準則",ComicEnglishName="Woman'sBestFriend"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656606868/Woman%27sBestFriend/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656590842/Woman%27sBestFriend/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656589219/Woman%27sBestFriend/1.webp"
                            ,BgColor       ="#e45850",PublishDate=new DateTime(2021,11,2),LastPublishDate=new DateTime(2021,11,26),FinallyPublishDate= new DateTime(2022,11,20),UpdateWeek=6
                           ,Publisher     ="Dreamtoon",Painter="Dodam",Author="Hyun Sung Lee"
                           ,Introduction  ="在城云出版社裡，有個名為「瘋狗」的存在。他是徐禹俊，毫無變化的表情、沒有抑揚頓挫的語調、冰冷銳利的眼神，以及挑剔的個性是他的標誌。但是這男人，真的是瘋狗沒錯嗎?「別熄滅妳內在的光芒，也別輕易讓任何人熄滅它，妳可以再更有自信一點。」比起瘋狗，禹俊更像是忠犬般溫柔地對待泰齡，讓在情場上失利、工作不順，甚至連家庭都不溫暖的她怎麼也摸不著頭緒。該拿這個既像忠心的杜賓犬，又像可愛瑪爾濟斯的男人怎麼辦?時而輕柔、時而強烈地觸動人心的戀愛故事——《忠犬的行動準則》。"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656589799/Woman%27sBestFriend/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656590753/Woman%27sBestFriend/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=1,AuditFailReason="NULL",AuditTime=new DateTime(2021,11,2),ComicStatus=2},




                //星期列表與作品頁
                //星期日

                //星期日有影片
                new Comic {ComicChineseName="今生我來當家主",ComicEnglishName="TodayIWillBeTheHeadOfTheHouse"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656998366/TodayIWillBeTheHeadOfTheHouse/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582961/MookHyangDarkLady/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,BgColor       ="#418ab3",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="D&C WEBTOON Biz",Painter="Mon(Antstudio)",Author="Kim Roah"
                           ,Introduction  ="「...就試試吧，由我來當家主。」我轉世成了帝國第一大家族——倫巴第家的私生女費蓮緹雅。這個家族不但富甲天下，而且從外交到文化無一不精，堪稱帝國歷史的象徵!含著金湯匙中的金湯匙出生，簡直太幸運了!還以為將來等著我的是康莊大道...沒想到父親過世後，我被親戚趕出家門，最後連曾經鼎鼎有名的家族都毀於一旦!!悲憤交加的我小酌(?)幾杯後走在回家的路上，居然還被馬車撞上!「這也太過分了吧...」含冤而死的我一睜開眼卻回到了七歲的時候?!光是親愛的父親出現在眼前就已經令人難以置信，我竟然還有機會拯救父親與家族?連重生前的家族仇人——二皇子都像隻大型犬似地成天追著我跑?!好吧，既然如此，二皇子和家族都是我的了!轉世加重生，面對第三次人生的費蓮緹雅，為了當上家主而展開行動!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656594393/MasterVillainessTheInvincible/3.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1657034039/TodayIWillBeTheHeadOfTheHouse/2.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},



                new Comic {ComicChineseName="我有三個暴君哥哥",ComicEnglishName="MyThreeTyrantBrothers"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607226/MyThreeTyrantBrothers/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582063/MyThreeTyrantBrothers/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656581853/MyThreeTyrantBrothers/1.webp"
                           ,BgColor       ="#9fa925",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="DAON STUDIO",Painter="Parkha, Eun Du",Author="jomil​"
                           ,Introduction  ="我是個連名字都沒有的星期奴隸，代號「星期三」，當我因為反抗主人，性命不保的時候...「——終於找到妳了。」一夕之間多了三個哥哥，他們還說我是解除亞斯卡尼爾皇室詛咒的唯一鑰匙?!「妳一定要健健康康地長大，長到現在身上的衣服緊到再也穿不下，這是妳的第一項課題。」「別擔心，小不點。那些壞人，哥哥會幫妳狠狠教訓他們一頓。」「這孩子像隻小雞一樣，既嬌小又柔弱。我想要守護她，我會守護她。」被大家稱作暴君的哥哥們，怎麼只對我這麼溫柔!?從天而降的寵妹狂魔哥哥們和我的故事——《我有三個暴君哥哥》!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656581977/MyThreeTyrantBrothers/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},



                new Comic {ComicChineseName="廢墟中的皇女",ComicEnglishName="PrincessInTheRough"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605651/PrincessInTheRough/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656577313/PrincessInTheRough/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656576943/PrincessInTheRough/1.webp"
                           ,BgColor       ="#605342",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="Mstoryhub",Painter="HAERUA",Author="HARASYO"
                           ,Introduction  ="被皇帝遺忘的孩子，獨自一人生活在森林裡的廢棄城堡。「我討厭說謊的騙子，就算是一個人，我也可以過得好好的。」她經過漫長的等待，終於盼到皇帝來，但孩子的心扉早已緊緊關上了。「我來為妳取個名字。」「名字?」「艾斯特蕾拉，這就是妳的名字了...很抱歉讓妳久等了，孩子。」艾斯特蕾拉是一個擁有著特別能力的孩子，她的家人該如何療癒那顆破碎的心呢?"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656577015/PrincessInTheRough/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656577184/PrincessInTheRough/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},


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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},



                new Comic {ComicChineseName="婚禮復仇記",ComicEnglishName="RevengeWedding"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605358/RevengeWedding/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575576/RevengeWedding/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656575339/RevengeWedding/1.webp"
                           ,BgColor       ="#28202b",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="DAON STUDIO",Painter="SaRyong​",Author="ByulSatangYang"
                           ,Introduction  ="集外貌、財富、地位於一身的完美女子——梅勒凱蒂亞．沙夏，暈倒後醒來發現自己位在一艘巨大的船上，身上還穿著婚紗。「蛤?我要結婚了嗎?是誰這麼大膽敢打我的主意?我一定要讓你打消結婚的念頭!」但沒想到...我的丈夫初次見面竟然就拿劍抵著我的脖子?他是帝國最偉大的戰爭英雄——戴枚德利奧．吉普洛沙。可是，他看起來一點都不像來結婚的啊?「我還想說是誰把我帶到這裡來的...只要殺了妳，我就可以回去了嗎?」「真是不好意思，我也是被綁架的好嗎?」我們兩人被綁架來結婚，甚至還要一起在無人島上求生存?!眼前的首要任務，就是逃出這座荒島!終極任務，要跟這個仇人離婚!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656575410/RevengeWedding/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656575490/RevengeWedding/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},



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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},

                new Comic {ComicChineseName="SSS級死而復生的獵人",ComicEnglishName="SSS-ClassRevivalHunter"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656604749/SSS-ClassRevivalHunter/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580517/SSS-ClassRevivalHunter/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656580224/SSS-ClassRevivalHunter/1.png"
                           ,BgColor       ="#1c1f26",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="Fansia",Painter="Bill K",Author="Sinnoa"
                           ,Introduction  ="身處F級底層的獵人「金孔子」長久以來一直羨慕著排行第一的獵人「炎帝」。某天，他竟突然獲得了S+級的技能。不料，短暫開心過後，他發現這個技能有些古怪?!「複製對方的其中一種技能」到這裡都還不錯...「什麼?竟然要我死了才能發動?!」重生獵人的人生樂章——《SSS級死而復生的獵人》"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656580385/SSS-ClassRevivalHunter/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656580450/SSS-ClassRevivalHunter/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},

                //71
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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},



                //星期列表與作品頁
                //星期二

                //星期二有影片
                new Comic {ComicChineseName="盜墓王",ComicEnglishName="TombRaiderKing"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607700/TombRaiderKing/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656572963/TombRaiderKing/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure =""
                           ,BgColor       ="#575a6f",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="Polarfox",Painter="Yooani",Author="Will Bright"
                           ,Introduction  ="「不但不是主角，還偏偏是書裡最惡毒的女人...」為了擺脫租屋生活而開始閱讀武俠小說《南宮世家少主》，卻穿越成為了小說裡最惡毒的女人——唐海媛。唐海媛這個天下第一惡女為了得到欽慕的男人，不惜毒殺思慕之人的情人、挑撥武林高手們、成為魔教的走狗並導致武林動盪。「絕不能和原本的故事內容一樣，白白送死!!」偶然吃了萬年參而變成小說世界裡的最強者，武俠小說最強惡女「唐海媛」的重生記!"
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656572710/TombRaiderKing/1.webm"
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656572903/TombRaiderKing/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},

                new Comic {ComicChineseName="我成了反派的繼母",ComicEnglishName="IBecameTheVillain'sMother"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656607155/IBecameTheVillain%27sMother/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584749/IBecameTheVillain%27sMother/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656584432/IBecameTheVillain%27sMother/1.webp"
                           ,BgColor       ="#225040",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="DAON STUDIO",Painter="Iro",Author="Yulji"
                           ,Introduction  ="我成了小說裡最終的反派角色「艾因斯潘納」的繼母。而且還是小時候虐待他，長大後第一個被他殺害的壞心繼母。在我思考該如何逃離這悲慘命運時，仍一無所知、天真無邪的未來反派潛力股映入眼簾，但是...「等等，這孩子就連胖嘟嘟的小手都這麼可愛!誰捨得虐待他啊!」在我眼前的是個和反派完全沾不上邊的可愛小孩。好，我決定了，交給我吧!我會守護你!所以長大後拜託饒我一命吧!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656584573/IBecameTheVillain%27sMother/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656584694/IBecameTheVillain%27sMother/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},

                new Comic {ComicChineseName="就離開我吧",ComicEnglishName="JustLeaveMe"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605448/JustLeaveMe/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597845/JustLeaveMe/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656597626/JustLeaveMe/1.webp"
                           ,BgColor       ="#121212",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="Yeondam X DAON",Painter="chero",Author="JAEUNHYANG"
                           ,Introduction  ="因罕見疾病而死亡的公爵之女，阿黛兒成了她的替身，雖然用盡一切努力想得到家人們的愛，卻還是於妹妹一出生時就遭到拋棄，在前往政治聯姻的路途中被不明的刺客暗殺。「...難道這是夢?」但在她睜開眼後，卻發現自己回到了3年前!想著反正只要妹妹一出生就會遭到拋棄的自己，阿黛兒決定這次的人生要操之在己，可惜依舊不斷遭遇苦難。「難道您不是對我有興趣嗎?」再加上一個身分不明的黑色騎士老是接近她..."
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656597726/JustLeaveMe/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656597781/JustLeaveMe/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},

                new Comic {ComicChineseName="千金大廚來上菜",ComicEnglishName="LadyChefRoyale"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605055/LadyChefRoyale/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656591172/LadyChefRoyale/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656590985/LadyChefRoyale/1.webp"
                           ,BgColor       ="#dd6b79",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="Dreamtoon",Painter="PAYA",Author="Lysha"
                           ,Introduction  ="我原是一位小餐廳的廚師，卻成為了一個連皇帝都害怕的貴族家——他們家的受氣包小女兒。本想存一些錢，然後逃跑的...真是奇怪。「跟你說對不起，是一件丟臉的事嗎?」「是啊，因為我是妳哥哥。」「妳不和我這個爺爺去散步嗎?」大家為什麼突然間對我這麼好?「為什麼我想要把那些看妳的人的眼睛挖出來?」試圖逃跑的我以及緊緊抓住我的人，只是做了料理而已，為什麼會這樣...「愛死她的家人們 / 想逃跑的她 / 她專屬的僕人們」即將登場!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656591037/LadyChefRoyale/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656591103/LadyChefRoyale/3.webm"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},

                new Comic {ComicChineseName="魔彈射手",ComicEnglishName="MadanNoShashu"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656608240/MadanNoShashu/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582317/MadanNoShashu/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582133/MadanNoShashu/1.webp"
                           ,BgColor       ="#060b28",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="intime",Painter="GLPI",Author="Respect"
                           ,Introduction  ="「何中士，你又全中了啊!」即將成為軍官的神射手，何里夏中士，因一起意外事故，導致下半身癱瘓，成為了一個被世界遺棄的孤兒。在陷入絕望之際，虛擬實境遊戲「米德爾斯」橫空出世，賦予了他嶄新的人生。而在「米德爾斯」裡賺取的錢財，竟然可以成為現實世界中的財產!但因一開始的失誤，何里夏選擇了能力值最低的角色。眼看他就要被當成沙包打了!「我和你們不一樣，我已經無路可退了!」用火藥、鋼珠、推彈杆，讓你們看看什麼是真正的神槍手!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656582250/MadanNoShashu/2.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},

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
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},

                //33
                new Comic {ComicChineseName="墨劍留香",ComicEnglishName="MookHyangDarkLady"
                           ,ComicNameImage="https://res.cloudinary.com/dmns6twmt/image/upload/v1656605276/MookHyangDarkLady/5.png"
                           ,HotComicNameImage = ""
                           ,BgCover       ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582961/MookHyangDarkLady/4.webp"
                           ,HotBgCover = ""
                           ,ComicFigure   =""
                           ,ComicWeekFigure ="https://res.cloudinary.com/dmns6twmt/image/upload/v1656582728/MookHyangDarkLady/1.webp"
                           ,BgColor       ="#1a0c19",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="Polarfox",Painter="Yooani",Author="Will Bright"
                           ,Introduction  ="「不但不是主角，還偏偏是書裡最惡毒的女人...」為了擺脫租屋生活而開始閱讀武俠小說《南宮世家少主》，卻穿越成為了小說裡最惡毒的女人——唐海媛。唐海媛這個天下第一惡女為了得到欽慕的男人，不惜毒殺思慕之人的情人、挑撥武林高手們、成為魔教的走狗並導致武林動盪。「絕不能和原本的故事內容一樣，白白送死!!」偶然吃了萬年參而變成小說世界裡的最強者，武俠小說最強惡女「唐海媛」的重生記!"
                           ,BannerVideoWeb = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656594393/MasterVillainessTheInvincible/3.webm"
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb ="https://res.cloudinary.com/dmns6twmt/video/upload/v1656788146/MookHyangDarkLady/3MP4.mp4"
                           ,HotVideo = ""
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},





                //強檔鉅獻 5部

                new Comic {ComicChineseName="綠蔭之冠SFO",ComicEnglishName="TheViridescentTiaraSFO"
                           ,ComicNameImage=""
                           ,HotComicNameImage = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656961104/TheViridescentTiaraSFO/6.png"
                           ,BgCover       =""
                           ,HotBgCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656961288/TheViridescentTiaraSFO/8.jpg"
                           ,ComicFigure   =""
                           ,ComicWeekFigure =""
                           ,BgColor       ="",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="",Painter="",Author=""
                           ,Introduction  =""
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656961155/TheViridescentTiaraSFO/7.webm"
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},


                new Comic {ComicChineseName="綠蔭之冠SFO",ComicEnglishName="TheViridescentTiaraSFO"
                           ,ComicNameImage=""
                           ,HotComicNameImage = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656961104/TheViridescentTiaraSFO/6.png"
                           ,BgCover       =""
                           ,HotBgCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656961288/TheViridescentTiaraSFO/8.jpg"
                           ,ComicFigure   =""
                           ,ComicWeekFigure =""
                           ,BgColor       ="",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=3

                           ,Publisher     ="",Painter="",Author=""
                           ,Introduction  =""
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656961155/TheViridescentTiaraSFO/7.webm"
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},


                new Comic {ComicChineseName="我獨自升級",ComicEnglishName="IUpgradeAlone"
                           ,ComicNameImage=""
                           ,HotComicNameImage = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656961648/IUpgradeAlone/6.png"
                           ,BgCover       =""
                           ,HotBgCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656961763/IUpgradeAlone/8.jpg"
                           ,ComicFigure   =""
                           ,ComicWeekFigure =""
                           ,BgColor       ="",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=7
                           ,Publisher     ="",Painter="",Author=""
                           ,Introduction  =""
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656961724/IUpgradeAlone/7.webm"
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},


                new Comic {ComicChineseName="驅魔麵館",ComicEnglishName="ExorcismNoodleShop"
                           ,ComicNameImage=""
                           ,HotComicNameImage = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656961381/ExorcismNoodleShop/6.png"
                           ,BgCover       =""
                           ,HotBgCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656961476/ExorcismNoodleShop/8.jpg"
                           ,ComicFigure   =""
                           ,ComicWeekFigure =""
                           ,BgColor       ="",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=4
                           ,Publisher     ="",Painter="",Author=""
                           ,Introduction  =""
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656961436/ExorcismNoodleShop/7.webm"
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},

                //5
                new Comic {ComicChineseName="我的社長相親相愛SFO",ComicEnglishName="I'mLoveBossSFO"
                           ,ComicNameImage=""
                           ,HotComicNameImage = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656960212/I%27mLoveBossSFO/6.png"
                           ,BgCover       =""
                           ,HotBgCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656960525/I%27mLoveBossSFO/8.jpg"
                           ,ComicFigure   =""
                           ,ComicWeekFigure =""
                           ,BgColor       ="",PublishDate=new DateTime(2021,12,2),LastPublishDate=new DateTime(2021,12,26),FinallyPublishDate= new DateTime(2021,12,20),UpdateWeek=5
                           ,Publisher     ="",Painter="",Author=""
                           ,Introduction  =""
                           ,BannerVideoWeb = ""
                           ,WeekVideoWrb = ""
                           ,ComicVideoWeb =""
                           ,HotVideo = "https://res.cloudinary.com/dmns6twmt/video/upload/v1656960333/I%27mLoveBossSFO/7.webm"
                           ,AuditType     =1,AuditEmployeeId=2,AuditFailReason="NULL",AuditTime=new DateTime(2021,12,2),ComicStatus=2},

                
                


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
                new ComicTagList {TagId=1,ComicId=2},
                new ComicTagList {TagId=1,ComicId=3},
                new ComicTagList {TagId=1,ComicId=4},

                new ComicTagList {TagId=2,ComicId=5},
                new ComicTagList {TagId=2,ComicId=6},
                new ComicTagList {TagId=2,ComicId=7},
                new ComicTagList {TagId=2,ComicId=8},

                new ComicTagList {TagId=3,ComicId=9},
                new ComicTagList {TagId=3,ComicId=10},
                new ComicTagList {TagId=3,ComicId=11},
                new ComicTagList {TagId=3,ComicId=12},

                new ComicTagList {TagId=4,ComicId=13},
                new ComicTagList {TagId=4,ComicId=14},
                new ComicTagList {TagId=4,ComicId=15},
                new ComicTagList {TagId=4,ComicId=16},

                new ComicTagList {TagId=5,ComicId=17},
                new ComicTagList {TagId=5,ComicId=18},

                new ComicTagList {TagId=6,ComicId=19},
                new ComicTagList {TagId=7,ComicId=20},


            };

            foreach (var list in comictaglists)
            {
                _repository.Create(list);
            }
            _repository.SaveChange();

        }
        public void EpCreate()
        {
            var epList = new List<Episode>
            {
                new Episode(){ ComicId = 1, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 1, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 1, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 1, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 1, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 1, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 1, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 1, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 1, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 1, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 2, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 2, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 2, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 2, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 2, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 2, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 2, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 2, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 2, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 2, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 3, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 3, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 3, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 3, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 3, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 3, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 3, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 3, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 3, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 3, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 4, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 4, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 4, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 4, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 4, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 4, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 4, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 4, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 4, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 4, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},


                new Episode(){ ComicId = 5, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 5, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 5, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 5, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 5, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 5, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 5, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 5, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 5, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 5, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 6, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 6, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 6, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 6, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 6, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 6, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 6, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 6, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 6, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 6, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 7, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 7, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 7, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 7, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 7, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 7, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 7, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 7, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 7, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 7, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 8, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 8, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 8, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 8, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 8, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 8, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 8, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 8, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 8, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 8, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 9, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 9, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 9, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 9, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 9, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 9, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 9, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 9, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 9, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 9, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 10, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 10, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 10, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 10, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 10, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 10, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 10, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 10, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 10, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 10, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 11, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 11, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 11, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 11, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 11, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 11, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 11, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 11, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 11, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 11, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 12, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 12, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 12, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 12, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 12, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 12, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 12, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 12, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 12, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 12, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 13, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 13, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 13, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 13, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 13, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 13, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 13, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 13, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 13, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 13, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 14, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 14, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 14, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 14, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 14, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 14, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 14, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 14, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 14, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 14, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 15, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 15, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 15, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 15, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 15, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 15, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 15, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 15, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 15, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 15, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 16, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 16, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 16, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 16, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 16, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 16, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 16, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 16, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 16, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 16, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 17, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 17, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 17, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 17, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 17, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 17, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 17, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 17, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 17, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 17, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 18, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 18, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 18, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 18, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 18, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 18, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 18, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 18, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 18, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 18, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 19, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 19, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 19, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 19, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 19, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 19, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 19, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 19, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 19, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 19, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},


                new Episode(){ ComicId = 20, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 20, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 20, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 20, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 20, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 20, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 20, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 20, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 20, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 20, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                //21
                new Episode(){ ComicId = 21, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 21, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 21, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 21, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 21, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 21, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 21, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 21, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 21, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 21, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 22, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 22, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 22, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 22, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 22, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 22, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 22, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 22, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 22, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 22, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 23, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 23, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 23, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 23, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 23, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 23, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 23, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 23, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 23, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 23, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 24, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 24, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 24, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 24, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 24, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 24, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 24, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 24, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 24, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 24, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},


                new Episode(){ ComicId = 25, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 25, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 25, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 25, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 25, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 25, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 25, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 25, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 25, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 25, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 26, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 26, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 26, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 26, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 26, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 26, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 26, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 26, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 26, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 26, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},



                new Episode(){ ComicId = 27, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 27, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 27, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 27, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 27, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 27, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 27, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 27, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 27, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 27, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},


                new Episode(){ ComicId = 28, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 28, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 28, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 28, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 28, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 28, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 28, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 28, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 28, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 28, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},


                new Episode(){ ComicId = 29, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 29, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 29, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 29, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 29, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 29, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 29, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 29, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 29, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 29, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                //30
                new Episode(){ ComicId = 30, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 30, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 30, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 30, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 30, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 30, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 30, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 30, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 30, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 30, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},


                new Episode(){ ComicId = 31, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 31, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 31, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 31, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 31, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 31, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 31, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 31, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 31, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 31, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 32, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 32, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 32, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 32, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 32, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 32, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 32, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 32, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 32, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 32, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 33, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 33, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 33, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 33, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 33, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 33, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 33, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 33, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 33, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 33, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 34, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 34, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 34, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 34, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 34, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 34, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 34, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 34, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 34, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 34, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                //35
                new Episode(){ ComicId = 35, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 35, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 35, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 35, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 35, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 35, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 35, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 35, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 35, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 35, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},


                new Episode(){ ComicId = 36, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 36, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 36, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 36, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 36, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 36, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 36, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 36, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 36, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 36, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 37, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 37, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 37, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 37, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 37, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 37, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 37, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 37, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 37, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 37, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},


                new Episode(){ ComicId = 38, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 38, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 38, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 38, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 38, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 38, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 38, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 38, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 38, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 38, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                new Episode(){ ComicId = 39, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 39, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 39, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 39, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 39, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 39, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 39, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 39, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 39, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 39, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                //40
                new Episode(){ ComicId = 40, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 40, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 40, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 40, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 40, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 40, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 40, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 40, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 40, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                new Episode(){ ComicId = 40, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                //////41
                ////new Episode(){ ComicId = 41, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 41, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 41, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 41, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 41, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 41, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 41, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 41, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 41, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 41, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},

                //// //42
                ////new Episode(){ ComicId = 42, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600076/WornAndTornNewbie/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 42, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600157/WornAndTornNewbie/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 42, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600190/WornAndTornNewbie/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 42, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600227/WornAndTornNewbie/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 42, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600266/WornAndTornNewbie/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 42, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600303/WornAndTornNewbie/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 42, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600383/WornAndTornNewbie/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 42, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600421/WornAndTornNewbie/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 42, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600458/WornAndTornNewbie/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 42, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656600499/WornAndTornNewbie/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},


                //// //43
                ////new Episode(){ ComicId = 43, EpTitle = "第1話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599552/TombRaiderKing/EP01.jpg", UpdateTime=new DateTime(2021,05,05),UploadTime=new DateTime(2021,06,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,05,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 43, EpTitle = "第2話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599661/TombRaiderKing/EP02.jpg", UpdateTime=new DateTime(2021,06,05),UploadTime=new DateTime(2021,07,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,06,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 43, EpTitle = "第3話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599713/TombRaiderKing/EP03.jpg", UpdateTime=new DateTime(2021,07,05),UploadTime=new DateTime(2021,08,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,07,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 43, EpTitle = "第4話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599753/TombRaiderKing/EP04.jpg", UpdateTime=new DateTime(2021,08,05),UploadTime=new DateTime(2021,09,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,08,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 43, EpTitle = "第5話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599785/TombRaiderKing/EP05.jpg", UpdateTime=new DateTime(2021,09,05),UploadTime=new DateTime(2021,10,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,09,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 43, EpTitle = "第6話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599819/TombRaiderKing/EP06.jpg", UpdateTime=new DateTime(2021,10,05),UploadTime=new DateTime(2021,11,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,10,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 43, EpTitle = "第7話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599847/TombRaiderKing/EP07.jpg", UpdateTime=new DateTime(2021,11,05),UploadTime=new DateTime(2021,12,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2021,11,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 43, EpTitle = "第8話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599877/TombRaiderKing/EP08.jpg", UpdateTime=new DateTime(2021,12,05),UploadTime=new DateTime(2022,01,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,12,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 43, EpTitle = "第9話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599936/TombRaiderKing/EP09.jpg", UpdateTime=new DateTime(2022,01,05),UploadTime=new DateTime(2022,02,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,01,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},
                ////new Episode(){ ComicId = 43, EpTitle = "第10話", EpCover = "https://res.cloudinary.com/dmns6twmt/image/upload/v1656599964/TombRaiderKing/EP10.jpg", UpdateTime=new DateTime(2022,02,05),UploadTime=new DateTime(2022,03,01),AuditTypeId=1,AuditEmployeeId=1,AuditTime=new DateTime(2022,02,05),AuditFailReason="",IsCountdownCoupon=false,IsFree=true},



            };
            foreach (var episode in epList)
            {
                _repository.Create(episode);
            }
            _repository.SaveChange();
        }


        //阿傑的
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
