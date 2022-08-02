using BSWebtoon.Front.Models.DTO.CashPlan;
using System.Collections.Generic;
using BSWebtoon.Model.Models;

namespace BSWebtoon.Front.Service.RechargeService
{
    public interface IRechargeService
    {
        void PaymentCreate();
        void CashPlanCreate();
        void RechargeRecordCreate();
        void RechargeRecordCreateNew(RechargeRecord input_RechargeRecord);
        List<CashPlanDTO> ReadCashPlan(string username);
    }
}
