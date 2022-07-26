using BSWebtoon.Front.Models.DTO.CashPlan;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BSWebtoon.Front.Service.RechargeService
{
    public class RechargeService : IRechargeService
    {

        private readonly BSRepository _repository;

        public RechargeService(BSRepository repository)
        {
            _repository = repository;
        }

        public void CashPlanCreate()
        {
            List<CashPlan> cashPlans = new List<CashPlan>
            {
                new CashPlan(){/*CashPlanId=1,*/CashPlanContent = "3600",Price=90,Sort=1,IsEnable=true},
                new CashPlan(){/*CashPlanId=2,*/CashPlanContent = "6000",Price=150,Sort=2,IsEnable=true},
                new CashPlan(){/*CashPlanId=3,*/CashPlanContent = "12000",Price=300,Sort=3,IsEnable=true},
                new CashPlan(){/*CashPlanId=4,*/CashPlanContent = "18000",Price=450,Sort=4,IsEnable=true},
                new CashPlan(){/*CashPlanId=5,*/CashPlanContent = "28800",Price=720,Sort=5,IsEnable=true},
                new CashPlan(){/*CashPlanId=6,*/CashPlanContent = "36000",Price=900,Sort=6,IsEnable=true},
            };

            foreach (var cashPlan in cashPlans)
            {
                _repository.Create(cashPlan);
            };

            _repository.SaveChange();
        }

        public void PaymentCreate()
        {
            List<Payment> payments = new List<Payment>
            {
                new Payment() {/*PaymentId=1,*/PaymentName = "CreditCard",IsEnable = true,Sort = 1},
                new Payment() {/*PaymentId=2,*/PaymentName = "Ez Pay",IsEnable = false,Sort = 2},
                new Payment() {/*PaymentId=3,*/PaymentName = "Line Pay",IsEnable = false,Sort = 3},
                new Payment() {/*PaymentId=4,*/PaymentName = "Taiwan Pay",IsEnable = true,Sort = 4},
            };

            foreach (var payment in payments)
            {
                _repository.Create(payment);
            };

            _repository.SaveChange();
        }

        public void RechargeRecordCreate()
        {
            List<RechargeRecord> rechargeRecords = new List<RechargeRecord>
            {
                new RechargeRecord(){/*RechargeRecordId=1, */MemberId=1,CreateTime=new DateTime(2022, 07, 14, 05, 23, 40),PaymentId=1,CashPlanId=1,CashPlanContent=3600,Price=90},
                new RechargeRecord(){/*RechargeRecordId=2, */MemberId=2,CreateTime=new DateTime(2022, 10, 17, 19, 23, 00),PaymentId=1,CashPlanId=2,CashPlanContent=6000,Price=150},
                new RechargeRecord(){/*RechargeRecordId=3, */MemberId=3,CreateTime=new DateTime(2022, 08, 14, 23, 59, 59),PaymentId=2,CashPlanId=4,CashPlanContent=18000,Price=450},
                new RechargeRecord(){/*RechargeRecordId=4, */MemberId=5,CreateTime=new DateTime(2022, 07, 15, 18, 18, 23),PaymentId=4,CashPlanId=1,CashPlanContent=3600,Price=90},
                new RechargeRecord(){/*RechargeRecordId=5, */MemberId=6,CreateTime=new DateTime(2022, 07, 01, 04, 13, 06),PaymentId=2,CashPlanId=3,CashPlanContent=12000,Price=300},
                new RechargeRecord(){/*RechargeRecordId=6, */MemberId=2,CreateTime=new DateTime(2022, 07, 17, 10, 03, 27),PaymentId=4,CashPlanId=5,CashPlanContent=28800,Price=720},
                new RechargeRecord(){/*RechargeRecordId=7, */MemberId=1,CreateTime=new DateTime(2022, 07, 18, 01, 02, 03),PaymentId=3,CashPlanId=6,CashPlanContent=36000,Price=900},
                new RechargeRecord(){/*RechargeRecordId=8, */MemberId=14,CreateTime=new DateTime(2022, 06, 13, 09, 56, 50),PaymentId=1,CashPlanId=2,CashPlanContent=6000,Price=150},
                new RechargeRecord(){/*RechargeRecordId=9, */MemberId=8,CreateTime=new DateTime(2022, 07, 22, 12, 01, 07),PaymentId=3,CashPlanId=5,CashPlanContent=12000,Price=300},
                new RechargeRecord(){/*RechargeRecordId=10,*/MemberId=18,CreateTime=new DateTime(2022, 09, 01, 03, 38, 05),PaymentId=4,CashPlanId=1,CashPlanContent=3600,Price=90},
                new RechargeRecord(){/*RechargeRecordId=11,*/MemberId=16,CreateTime=new DateTime(2022, 04, 05, 15, 04, 52),PaymentId=1,CashPlanId=1,CashPlanContent=18000,Price=450},
                new RechargeRecord(){/*RechargeRecordId=12,*/MemberId=20,CreateTime=new DateTime(2022, 08, 08, 08, 08, 08),PaymentId=1,CashPlanId=1,CashPlanContent=3600,Price=90},
                new RechargeRecord(){/*RechargeRecordId=13,*/MemberId=13,CreateTime=new DateTime(2022, 07, 14, 22, 20, 56),PaymentId=1,CashPlanId=6,CashPlanContent=36000,Price=900},
                new RechargeRecord(){/*RechargeRecordId=14,*/MemberId=20,CreateTime=new DateTime(2022, 08, 23, 10, 23, 30),PaymentId=2,CashPlanId=4,CashPlanContent=18000,Price=450},
                new RechargeRecord(){/*RechargeRecordId=15,*/MemberId=3,CreateTime=new DateTime(2022, 05, 30, 17, 08, 23),PaymentId=3,CashPlanId=1,CashPlanContent=3600,Price=90},
                new RechargeRecord(){/*RechargeRecordId=16,*/MemberId=7,CreateTime=new DateTime(2022, 05, 08, 22, 50, 49),PaymentId=1,CashPlanId=2,CashPlanContent=6000,Price=150},
                new RechargeRecord(){/*RechargeRecordId=17,*/MemberId=11,CreateTime=new DateTime(2022, 07, 06, 06, 23, 55),PaymentId=2,CashPlanId=2,CashPlanContent=6000,Price=150},
                new RechargeRecord(){/*RechargeRecordId=18,*/MemberId=3,CreateTime=new DateTime(2022, 06, 18, 23, 01, 52),PaymentId=3,CashPlanId=3,CashPlanContent=1200,Price=300},
                new RechargeRecord(){/*RechargeRecordId=19,*/MemberId=19,CreateTime=new DateTime(2022, 07, 31, 18, 44, 10),PaymentId=1,CashPlanId=1,CashPlanContent=3600,Price=90},
                new RechargeRecord(){/*RechargeRecordId=20,*/MemberId=10,CreateTime=new DateTime(2022, 10, 28, 15, 21, 50),PaymentId=1,CashPlanId=1,CashPlanContent=3600,Price=90},
            };

            foreach (var rechargeRecord in rechargeRecords)
            {
                _repository.Create(rechargeRecord);
            };

            _repository.SaveChange();

        }
        //hana
        public void RechargeRecordCreateNew(RechargeRecord input_RechargeRecord)
        {
            List<RechargeRecord> rechargeRecords = new List<RechargeRecord>
            {
                new RechargeRecord(){/*RechargeRecordId=1, */
                    MemberId=input_RechargeRecord.MemberId,
                    CreateTime=input_RechargeRecord.CreateTime,
                    PaymentId=input_RechargeRecord.PaymentId,
                    CashPlanId=input_RechargeRecord.CashPlanId,
                    CashPlanContent=input_RechargeRecord.CashPlanContent,
                    Price=input_RechargeRecord.Price
                    },
            };

            foreach (var rechargeRecord in rechargeRecords)
            {
                _repository.Create(rechargeRecord);
            };
            _repository.SaveChange();

        }

        //public void RechargeSaveChange(List<RechargeRecord> datas)
        //{
        //    foreach (var data in datas)
        //    {
        //        _repository.Create(data);
        //};

        //    _repository.SaveChange();

        //}
        public List<CashPlanDTO> ReadCashPlan(string username)
        {
            var usernameBalance = _repository.GetAll<Member>().Where(x => x.AccountName == username).Select(x => x.Balance).First();

            var CashPlanList = _repository.GetAll<CashPlan>().ToList();
            var result = new List<CashPlanDTO>();

            result = CashPlanList.Select(x => new CashPlanDTO
            {
               CashPlanId = x.CashPlanId,
               CashPlanContent = x.CashPlanContent,
               Price = x.Price,
               Sort = x.Sort,
               IsEnable = x.IsEnable,
               Balance = (decimal)usernameBalance
            }).ToList();
            return result;
        }
        


    }
}
