namespace EComersObjectLib
{
    public class IncomeDocument
    {
        public int IncomeDocId { get; set; }
        public int BalanceId { get; set; }
        public string IncomeDocName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CeatedUserId { get; set; }
        public decimal Summ { get; set; }
        public int ClntBalHistoryId { get; set; }

        
        public ClientBalanceHistory ClientBalanceHistory { get; set; }
        public User CreatedUser { get; set; }
    }
}