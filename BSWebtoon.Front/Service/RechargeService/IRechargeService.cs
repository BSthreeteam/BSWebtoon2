using BSWebtoon.Front.Models.DTO.CashPlan;
using System.Collections.Generic;

namespace BSWebtoon.Front.Service.RechargeService
{
    public interface IRechargeService
    {
        void PaymentCreate();
        void CashPlanCreate();
        void RechargeRecordCreate();
        List<CashPlanDTO> ReadCashPlan(string username);
    }
}
