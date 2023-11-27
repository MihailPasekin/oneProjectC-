using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientSecondName { get; set; }
        public string ClientMiddleName { get; set; }
        public string ClientLogin { get; set; }
        public string ClientHeshPas { get; set; }
        public string ClientPhone { get; set; }
        public string ClientEmail { get; set; }
        public string ClientAddress { get; set; }
        public int ClientBalanceId { get; set; }
        public int ClientStatusId { get; set; }
        public int ClientGenderId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UserId { get; set; }
        public int UpdatedUserId { get; set; }

        public User CreatedUser { get; set; }
        public User UpdatedUser { get; set; }
        public GeneralStatus GeneralStatus { get; set; }
        public Gender Gender { get; set; }
        public List<ClientBalance> ClientBalances { get; set; } 
        
        
    }
}
