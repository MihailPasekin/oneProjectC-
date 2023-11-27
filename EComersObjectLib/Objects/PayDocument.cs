namespace EComersObjectLib
{
    public class PayDocument
    {
        public int PayDocId { get; set; }
        public int BalanceId { get; set; }
        public string PayDocName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CeatedUserId { get; set; }
        public decimal Summ { get; set; }

        public ClientBalanceHistory ClientBalanceHistory { get; set; }
        public User CreatedUser { get; set; }
    }
}