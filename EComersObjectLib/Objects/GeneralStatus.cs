using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class GeneralStatus: Status
    {
        public List<Region>? Region { get; set; }
        public List<Client>? Client { get; set; }
        public List<ClientBalanceType> ClientBalanceType { get; set; }

        public GeneralStatus()
        {

        }
    }
}
