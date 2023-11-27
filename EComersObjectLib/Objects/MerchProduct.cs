using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class MerchProduct
    {
        public int MerchProductId { get; set; }
        public int MerchProductGroupId { get; set; }
        public string MerchProductName { get; set; }

        public MerchProductGroup MerchProductGroup { get; set; }
        //public List<MerchProductSoldStat>? MerchProductSotdStats { get; set; }
    }
}
