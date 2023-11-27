using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class WarehouseWithdrawal
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public double OnHand { get; set; }
        public double IsCommited { get; set; }
        public double OnOrder { get; set; }
    }
}
