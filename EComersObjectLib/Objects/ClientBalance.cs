using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class ClientBalance
    {

        public int ClientBalanceId { get; set; }
        public int ClientId { get; set; }
        public int? ClientBalanceTypeId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public int? UpdatedUserId { get; set; }

        public User? CreatedUser { get; set; }
        public User? UpdatedUser { get; set; }
        public ClientBalanceType ClientBalanceType { get; set; }
        public List<ClientBalanceHistory> ClientBalanceHistory { get; set; } 
        public Client Client { get; set; }
    }
}
