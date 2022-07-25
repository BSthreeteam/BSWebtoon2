using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using System;
using System.Collections.Generic;

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
                new CashPlan(){CashPlanContent = "3600",Price=90,Sort=1,IsEnable=true},
                new CashPlan(){CashPlanContent = "6000",Price=150,Sort=2,IsEnable=true},
                new CashPlan(){CashPlanContent = "12000",Price=300,Sort=3,IsEnable=true},
                new CashPlan(){CashPlanContent = "18000",Price=450,Sort=4,IsEnable=true},
                new CashPlan(){CashPlanContent = "28800",Price=720,Sort=5,IsEnable=true},
                new CashPlan(){CashPlanContent = "36000",Price=900,Sort=6,IsEnable=true},
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
                new Payment() {PaymentName = "CreditCard",IsEnable = true,Sort = 1},
                new Payment() {PaymentName = "Ez Pay",IsEnable = false,Sort = 2},
                new Payment() {PaymentName = "Line Pay",IsEnable = false,Sort = 3},
                new Payment() {PaymentName = "Taiwan Pay",IsEnable = true,Sort = 4},
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
                new RechargeRecord(){MemberId=1,CreateTime=new DateTime(2022, 07, 14, 05, 23, 40),PaymentId=1,CashPlanId=1,CashPlanContent=3600,Price=90},
                new RechargeRecord(){MemberId=2,CreateTime=new DateTime(2022, 10, 17, 19, 23, 00),PaymentId=1,CashPlanId=2,CashPlanContent=6000,Price=150},
                new RechargeRecord(){MemberId=3,CreateTime=new DateTime(2022, 08, 14, 23, 59, 59),PaymentId=2,CashPlanId=4,CashPlanContent=18000,Price=450},
                new RechargeRecord(){MemberId=5,CreateTime=new DateTime(2022, 07, 15, 18, 18, 23),PaymentId=4,CashPlanId=1,CashPlanContent=3600,Price=90},
                new RechargeRecord(){MemberId=6,CreateTime=new DateTime(2022, 07, 01, 04, 13, 06),PaymentId=2,CashPlanId=3,CashPlanContent=12000,Price=300},
                new RechargeRecord(){MemberId=2,CreateTime=new DateTime(2022, 07, 17, 10, 03, 27),PaymentId=4,CashPlanId=5,CashPlanContent=28800,Price=720},
                new RechargeRecord(){MemberId=1,CreateTime=new DateTime(2022, 07, 18, 01, 02, 03),PaymentId=3,CashPlanId=6,CashPlanContent=36000,Price=900},
                new RechargeRecord(){MemberId=14,CreateTime=new DateTime(2022, 06, 13, 09, 56, 50),PaymentId=1,CashPlanId=2,CashPlanContent=6000,Price=150},
                new RechargeRecord(){MemberId=8,CreateTime=new DateTime(2022, 07, 22, 12, 01, 07),PaymentId=3,CashPlanId=5,CashPlanContent=12000,Price=300},
                new RechargeRecord(){MemberId=18,CreateTime=new DateTime(2022, 09, 01, 03, 38, 05),PaymentId=4,CashPlanId=1,CashPlanContent=3600,Price=90},
                new RechargeRecord(){MemberId=16,CreateTime=new DateTime(2022, 04, 05, 15, 04, 52),PaymentId=1,CashPlanId=1,CashPlanContent=18000,Price=450},
                new RechargeRecord(){MemberId=20,CreateTime=new DateTime(2022, 08, 08, 08, 08, 08),PaymentId=1,CashPlanId=1,CashPlanContent=3600,Price=90},
                new RechargeRecord(){MemberId=13,CreateTime=new DateTime(2022, 07, 14, 22, 20, 56),PaymentId=1,CashPlanId=6,CashPlanContent=36000,Price=900},
                new RechargeRecord(){MemberId=20,CreateTime=new DateTime(2022, 08, 23, 10, 23, 30),PaymentId=2,CashPlanId=4,CashPlanContent=18000,Price=450},
                new RechargeRecord(){MemberId=3,CreateTime=new DateTime(2022, 05, 30, 17, 08, 23),PaymentId=3,CashPlanId=1,CashPlanContent=3600,Price=90},
                new RechargeRecord(){MemberId=7,CreateTime=new DateTime(2022, 05, 08, 22, 50, 49),PaymentId=1,CashPlanId=2,CashPlanContent=6000,Price=150},
                new RechargeRecord(){MemberId=11,CreateTime=new DateTime(2022, 07, 06, 06, 23, 55),PaymentId=2,CashPlanId=2,CashPlanContent=6000,Price=150},
                new RechargeRecord(){MemberId=3,CreateTime=new DateTime(2022, 06, 18, 23, 01, 52),PaymentId=3,CashPlanId=3,CashPlanContent=1200,Price=300},
                new RechargeRecord(){MemberId=19,CreateTime=new DateTime(2022, 07, 31, 18, 44, 10),PaymentId=1,CashPlanId=1,CashPlanContent=3600,Price=90},
                new RechargeRecord(){MemberId=10,CreateTime=new DateTime(2022, 10, 28, 15, 21, 50),PaymentId=1,CashPlanId=1,CashPlanContent=3600,Price=90},
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

    }
}
