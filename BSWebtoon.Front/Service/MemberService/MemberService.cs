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
                new Member {AccountName ="劉水浩",NickName ="浩哥",Balance =0,LoginTypeId =1,IsDarkTheme =true,CreateTime =new DateTime(2022,03,21),Email ="ake4876@gmail.com",AccessToken ="Iphone12" },
                new Member {AccountName ="廖不到",NickName ="廖廖",Balance =1000,LoginTypeId =1,IsDarkTheme =false,CreateTime =new DateTime(2022,05,20),Email ="jkl2345@gmail.com",AccessToken ="Iphone11"}
            };
            foreach(Member member in memberList)
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

            foreach(LoginType logintype in logintypeList)
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
