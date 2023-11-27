using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class ClientBalanceType
    {
        public int BalanceTypeId { get; set; }
        public string? BalanceName { get; set; }
        public string BalanceDescription { get; set; }
        public int StatusId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public int UpdatedUserId { get; set; }

        public User CreatedUser { get; set; }
        public User UpdateUser { get; set; }
        public GeneralStatus GeneralStatus { get; set; }
        public List<ClientBalance> ClientBalances { get; set; }
    }
}
