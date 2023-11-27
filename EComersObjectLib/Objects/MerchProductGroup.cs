using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class MerchProductGroup
    {
        public int MerchGroupId { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
        public string Cod { get; set; }

        //public List<MerchProductSoldStat>? MerchProductSoldStat { get; set; }
        //public List<MerchProduct>? MerchProducts { get; set; }
    }
}
