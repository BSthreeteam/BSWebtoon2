namespace BSWebtoon.Front.Models.DTO.CashPlan
{
    public class CashPlanDTO
    {
        public int MemberId { get; set; }
        public decimal Balance { get; set; }
        public int CashPlanId { get; set; }
        public string CashPlanContent { get; set; }
        public decimal Price { get; set; }
        public int Sort { get; set; }
        public bool IsEnable { get; set; }

    }
}
