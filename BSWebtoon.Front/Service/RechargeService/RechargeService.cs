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
                new CashPlan(){CashPlanContent = "3600",Price=90,IsEnable=true,Sort=1},
                new CashPlan(){CashPlanContent = "6300",Price=150,IsEnable=true,Sort=2}
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
                new Payment() {PaymentName = "ECPay",IsEnable = true,Sort = 1},
                new Payment() {PaymentName = "LinePay",IsEnable = false,Sort = 2}
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
                new RechargeRecord(){MemberId=1,CashPlanId=1,CreateTime=new DateTime(2022, 7, 14, 14, 23, 40),PaymentId=1,CashPlanContent=3600,Price=90 },
                new RechargeRecord(){MemberId=2,CashPlanId=1,CreateTime=new DateTime(2022, 10, 14, 14, 23, 30),PaymentId=1,CashPlanContent=3600,Price=90}
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
        //    };

        //    _repository.SaveChange();

        //}

    }
}
