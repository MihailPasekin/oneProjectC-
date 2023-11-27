using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class MerchProductSoldStat
    {
        public int GroupStateId { get; set; }
        public int MerchVisitId { get; set; }
        public int MerchGroupId { get; set; }
        public int MerchProductId { get; set; }
        public string MerchProdyctComment { get; set; }
        public string SoldStatusCod { get; set; }

        public MerchVisit? MerchVisit { get; set; }
        public MerchProductGroup? MerchProductGroup { get; set; }
        public MerchProduct? MerchProduct { get; set; }
    }
}
