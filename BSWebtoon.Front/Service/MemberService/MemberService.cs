using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BSWebtoon.Front.Service.MemberService
{
    public class MemberService : IMemberService
    {
        private readonly BSRepository _repository;

        public MemberService(BSRepository repository)
        {
            _repository = repository;
        }


        public void MemberCreate()
        {
            var memberList = new List<Member>
            {
                new Member {MemberId = 1,AccountName ="梅欣云",NickName ="欣云",Balance =500,LoginTypeId =1,IsDarkTheme =true,CreateTime =new DateTime(2022,03,21),Email ="ake4876@gmail.com",AccessToken ="Iphone12" },
                new Member {MemberId = 2,AccountName ="胡志明",NickName ="阿明",Balance =3000,LoginTypeId =1,IsDarkTheme =true,CreateTime =new DateTime(2022,05,20),Email ="jkl2345@gmail.com",AccessToken ="Iphone11"},
                new Member {MemberId = 3,AccountName ="林淑芬",NickName ="淑女",Balance =0,LoginTypeId =2,IsDarkTheme =true,CreateTime =new DateTime(2022,04,23),Email ="api6650@gmail.com",AccessToken ="Galaxy Z Flip3" },
                new Member {MemberId = 4,AccountName ="陳美玲",NickName ="小玲",Balance =4000,LoginTypeId =1,IsDarkTheme =true,CreateTime =new DateTime(2022,05,20),Email ="bramb@gmail.com",AccessToken ="Iphone6s"},
                new Member {MemberId = 5,AccountName ="孫國寧",NickName ="寧寧",Balance =1000,LoginTypeId =2,IsDarkTheme =true,CreateTime =new DateTime(2022,04,26),Email ="b1075566@gmail.com",AccessToken ="OPPO A55" },
                new Member {MemberId = 6,AccountName ="王世豪",NickName ="大豪",Balance =2500,LoginTypeId =1,IsDarkTheme =false,CreateTime =new DateTime(2022,01,04),Email ="a0912239516@gmail.com",AccessToken ="Samsung A52s"},
                new Member {MemberId = 7,AccountName ="莊寶玉",NickName ="玉姐",Balance =0,LoginTypeId =3,IsDarkTheme =true,CreateTime =new DateTime(2022,03,21),Email ="bbb951hgh@gmail.com",AccessToken ="Redmi Note 10" },
                new Member {MemberId = 8,AccountName ="楊佳穎",NickName ="佳穎",Balance =1000,LoginTypeId =3,IsDarkTheme =false,CreateTime =new DateTime(2021,12,06),Email ="mmbc4558@gmail.com",AccessToken ="Iphone11"},
                new Member {MemberId = 9,AccountName ="歐陽愛珊",NickName ="創作大師",Balance =4500,LoginTypeId =3,IsDarkTheme =true,CreateTime =new DateTime(2022,02,05),Email ="uihio@gmail.com",AccessToken ="Sony Xperia 10 III" },
                new Member {MemberId = 10,AccountName ="于耀成",NickName ="閃耀",Balance =1000,LoginTypeId =1,IsDarkTheme =true,CreateTime =new DateTime(2022,03,18),Email ="trcil432@gmail.com",AccessToken ="Iphone11"},

                new Member {MemberId = 11,AccountName ="林宗揚",NickName ="宗師",Balance =0,LoginTypeId =2,IsDarkTheme =true,CreateTime =new DateTime(2022,04,11),Email ="tometo871@gmail.com",AccessToken ="Iphone12" },
                new Member {MemberId = 12,AccountName ="林美玉",NickName ="美玉",Balance =300,LoginTypeId =1,IsDarkTheme =true,CreateTime =new DateTime(2022,02,02),Email ="apled23@gmail.com",AccessToken ="vivo Y55 5G"},
                new Member {MemberId = 13,AccountName ="王閣炎",NickName ="小炎",Balance =0,LoginTypeId =1,IsDarkTheme =true,CreateTime =new DateTime(2021,03,21),Email ="ppoppo00@gmail.com",AccessToken ="OPPO A55" },
                new Member {MemberId = 14,AccountName ="陳亮瑋",NickName ="阿亮",Balance =1000,LoginTypeId =1,IsDarkTheme =false,CreateTime =new DateTime(2022,05,22),Email ="qrqae02311@gmail.com",AccessToken ="Moto Edge 20 Pro"},
                new Member {MemberId = 15,AccountName ="吳秉喆",NickName ="小喆",Balance =500,LoginTypeId =3,IsDarkTheme =true,CreateTime =new DateTime(2022,06,11),Email ="illibaa31@gmail.com",AccessToken ="Samsung Galaxy S21" },
                new Member {MemberId = 16,AccountName ="陳柏翰",NickName ="小柏",Balance =1000,LoginTypeId =2,IsDarkTheme =true,CreateTime =new DateTime(2022,03,20),Email ="qwq11@gmail.com",AccessToken ="Iphone8"},
                new Member {MemberId = 17,AccountName ="李瑩居",NickName ="鄰居",Balance =200,LoginTypeId =3,IsDarkTheme =true,CreateTime =new DateTime(2022,01,18),Email ="mmyvc893222@gmail.com",AccessToken ="realme C21" },
                new Member {MemberId = 18,AccountName ="陳于瑄",NickName ="小瑄",Balance =1000,LoginTypeId =2,IsDarkTheme =true,CreateTime =new DateTime(2022,04,10),Email ="uouqq9651@gmail.com",AccessToken ="ASUS ROG Phone 5 Pro"},
                new Member {MemberId = 19,AccountName ="范偉軒",NickName ="大軒",Balance =2300,LoginTypeId =1,IsDarkTheme =true,CreateTime =new DateTime(2022,03,21),Email ="zabcvv31564@gmail.com",AccessToken ="ASUS zenfone 7" },
                new Member {MemberId = 20,AccountName ="劉秉成",NickName ="supermen",Balance =3000,LoginTypeId =1,IsDarkTheme =false,CreateTime =new DateTime(2022,04,01),Email ="chulove9@gmail.com",AccessToken ="Iphone13"},            };
            foreach (Member member in memberList)
            {
                _repository.Create(member);
                //_repository.Delete(member);
            }
            _repository.SaveChange();
        }


        public void LoginTypeCreate()
        {
            var logintypeList = new List<LoginType>
            {
                new LoginType {LoginTypeId=1,LoginTypeName ="Google"},
                new LoginType {LoginTypeId=2,LoginTypeName ="Line"},
                new LoginType {LoginTypeId=3,LoginTypeName ="Facebook"}
            };

            foreach (LoginType logintype in logintypeList)
            {
                _repository.Create(logintype);
                //_repository.Delete(logintype);
            }
            _repository.SaveChange();
        }
        public void MemberUpdateData()
        {
            var p1 = _repository.GetAll<Member>().Where(x => x.MemberId == 1).FirstOrDefault();
            p1.LoginTypeId = 1;
            //_repository.Update(p1);

            _repository.SaveChange();
        }
    }
}
