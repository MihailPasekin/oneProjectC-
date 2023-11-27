using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class ClientBalanceHistory
    {
        public int ClntBalHistoryId { get; set; }
        public int ClientBalanceId { get; set; }
        public decimal Balance { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public int PayDocId { get; set; }
        public int IncomeDocId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumHistory { get; set; }
        public int CreatedUserId { get; set; }
        public int ClntBalStatusId { get; set; }
        
        public BalanceStatus BalanceStatus { get; set; }
        public PayDocument PayDocument { get; set; }
        public IncomeDocument IncomeDocument { get; set; }
        public ClientBalance ClientBalance { get; set; }
        public User CreatedUser { get; set; }
        
    }
}
