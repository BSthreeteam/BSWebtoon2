using System.Collections.Generic;

namespace BSWebtoon.Front.Models.ViewModel.CashPlan
{
    public class CashPlanViewModel
    {
        public string Balance { get; set; }
        public List<CashPlanVM> AllCashPlan { get; set; }

        public class CashPlanVM
        {

            public int CashPlanId { get; set; }
            public string CashPlanContent { get; set; }
            public string Price { get; set; }
        }
    }
}
