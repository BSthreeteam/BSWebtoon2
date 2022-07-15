using BSWebtoon.Front.Models.ViewModel.Loginoption;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using static BSWebtoon.Front.Models.DTO.Login.LoginAccountDTO;

namespace BSWebtoon.Front.Service.MemberService
{
    public class MemberService : IMemberService
    {
        private readonly BSRepository _repository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public MemberService(BSRepository repository, IHttpContextAccessor httpContextAccessor)
        {
            _repository = repository;
            _httpContextAccessor = httpContextAccessor;
        }


        public void MemberCreate()
        {
            var memberList = new List<Member>
            {
                new Member {AccountName ="梅欣欣",NickName ="欣云",Balance =500,LoginTypeId =1,IsDarkTheme =true,CreateTime =new DateTime(2022,03,21),Email ="ake4876@gmail.com",AccessToken ="Iphone12" },
                new Member {AccountName ="胡志至",NickName ="阿明",Balance =3000,LoginTypeId =1,IsDarkTheme =true,CreateTime =new DateTime(2022,05,20),Email ="jkl2345@gmail.com",AccessToken ="Iphone11"},
                //new Member {AccountName ="林淑芬",NickName ="淑女",Balance =0,LoginTypeId =2,IsDarkTheme =true,CreateTime =new DateTime(2022,04,23),Email ="api6650@gmail.com",AccessToken ="Galaxy Z Flip3" },
                //new Member {AccountName ="陳美玲",NickName ="小玲",Balance =4000,LoginTypeId =1,IsDarkTheme =true,CreateTime =new DateTime(2022,05,20),Email ="bramb@gmail.com",AccessToken ="Iphone6s"},
                //new Member {AccountName ="孫國寧",NickName ="寧寧",Balance =1000,LoginTypeId =2,IsDarkTheme =true,CreateTime =new DateTime(2022,04,26),Email ="b1075566@gmail.com",AccessToken ="OPPO A55" },
                //new Member {AccountName ="王世豪",NickName ="大豪",Balance =2500,LoginTypeId =1,IsDarkTheme =false,CreateTime =new DateTime(2022,01,04),Email ="a0912239516@gmail.com",AccessToken ="Samsung A52s"},
                //new Member {AccountName ="莊寶玉",NickName ="玉姐",Balance =0,LoginTypeId =3,IsDarkTheme =true,CreateTime =new DateTime(2022,03,21),Email ="bbb951hgh@gmail.com",AccessToken ="Redmi Note 10" },
                //new Member {AccountName ="楊佳穎",NickName ="佳穎",Balance =1000,LoginTypeId =3,IsDarkTheme =false,CreateTime =new DateTime(2021,12,06),Email ="mmbc4558@gmail.com",AccessToken ="Iphone11"},
                //new Member {AccountName ="歐陽愛珊",NickName ="創作大師",Balance =4500,LoginTypeId =3,IsDarkTheme =true,CreateTime =new DateTime(2022,02,05),Email ="uihio@gmail.com",AccessToken ="Sony Xperia 10 III" },
                //new Member {AccountName ="于耀成",NickName ="閃耀",Balance =1000,LoginTypeId =1,IsDarkTheme =true,CreateTime =new DateTime(2022,03,18),Email ="trcil432@gmail.com",AccessToken ="Iphone11"},

                //new Member {AccountName ="林宗揚",NickName ="一代宗師",Balance =0,LoginTypeId =2,IsDarkTheme =true,CreateTime =new DateTime(2022,04,11),Email ="tometo871@gmail.com",AccessToken ="Iphone12" },
                //new Member {AccountName ="林美玉",NickName ="美玉",Balance =300,LoginTypeId =1,IsDarkTheme =true,CreateTime =new DateTime(2022,02,02),Email ="apled23@gmail.com",AccessToken ="vivo Y55 5G"},
                //new Member {AccountName ="王閣彥",NickName ="小彥",Balance =0,LoginTypeId =1,IsDarkTheme =true,CreateTime =new DateTime(2021,03,21),Email ="ppoppo00@gmail.com",AccessToken ="OPPO A55" },
                //new Member {AccountName ="陳亮瑋",NickName ="阿亮",Balance =1000,LoginTypeId =1,IsDarkTheme =false,CreateTime =new DateTime(2022,05,22),Email ="qrqae02311@gmail.com",AccessToken ="Moto Edge 20 Pro"},
                //new Member {AccountName ="吳秉翰",NickName ="小翰",Balance =500,LoginTypeId =3,IsDarkTheme =true,CreateTime =new DateTime(2022,06,11),Email ="illibaa31@gmail.com",AccessToken ="Samsung Galaxy S21" },
                //new Member {AccountName ="陳建宏",NickName ="五菱宏光",Balance =1000,LoginTypeId =2,IsDarkTheme =true,CreateTime =new DateTime(2022,03,20),Email ="qwq11@gmail.com",AccessToken ="Iphone8"},
                //new Member {AccountName ="李文樂",NickName ="樂樂",Balance =200,LoginTypeId =3,IsDarkTheme =true,CreateTime =new DateTime(2022,01,18),Email ="mmyvc893222@gmail.com",AccessToken ="realme C21" },
                //new Member {AccountName ="陳欣妤",NickName ="小妤",Balance =1000,LoginTypeId =2,IsDarkTheme =true,CreateTime =new DateTime(2022,04,10),Email ="uouqq9651@gmail.com",AccessToken ="ASUS ROG Phone 5 Pro"},
                //new Member {AccountName ="范禹彤",NickName ="大禹",Balance =2300,LoginTypeId =1,IsDarkTheme =true,CreateTime =new DateTime(2022,03,21),Email ="zabcvv31564@gmail.com",AccessToken ="ASUS zenfone 7" },
                //new Member {AccountName ="劉子晴",NickName ="晴天霹靂",Balance =3000,LoginTypeId =1,IsDarkTheme =false,CreateTime =new DateTime(2022,04,01),Email ="chulove9@gmail.com",AccessToken ="Iphone13"},
                };
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
                new LoginType {LoginTypeName ="Google"},
                new LoginType {LoginTypeName ="Line"},
                new LoginType {LoginTypeName ="Facebook"}
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
            _repository.Update(p1);

            _repository.SaveChange();
        }
        public void LogoutAccount()
        {
            //基本上就是把cookie刪除
            _httpContextAccessor.
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }
        public enum LoginTypes
        {
            google = 1, line = 2, facebook = 3
        }
        public async Task<Login3rdOutputDTO> LoginAccount(Login3rdInputDTO input)
        {
            var result = new Login3rdOutputDTO
            {
                IsSuccess = false
            };
            //確認member資料裡是否有紀錄
            var memberFound = _repository.GetAll<Member>().Where(x => x.AccountName.Contains($"{input.NameIdentifier}") && x.NickName.Contains($"{input.AccountName}")).Select(x => x.MemberId).FirstOrDefault().ToString();
            
            if (memberFound == "0")//如果沒有就添加資料到資料庫
            {
                var provider = (int)Enum.Parse(typeof(LoginTypes), input.Provider);

                var newmember = new Member
                {
                    LoginTypeId = provider,
                    AccountName = input.NameIdentifier,
                    NickName = input.AccountName,
                    Email = input.Email,
                    CreateTime = DateTime.UtcNow,
                    IsDarkTheme = true
                };
                _repository.Create(newmember);
                _repository.SaveChange();


            }

            result.IsSuccess = true;


            return result;
        }

    }
}
 