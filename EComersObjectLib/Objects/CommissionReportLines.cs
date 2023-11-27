using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class CommissionReportLines
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public int OnHand { get; set; }
        public double PriceBuy { get; set; }
        public double PriceSale { get; set; }
        public int GoodsReceipt { get; set;}
        public int ProductsSold { get; set; }
        public int ReturnSupplier { get; set; }
        public double CommissionAgentRemunAmount { get; set; }
        public double AmountPaymentPrincipal { get; set; }
        public double ReceiptAmountStartPeriod { get; set; }
        public double AmountStartPeriod { get; set; }
        public double ReceiptAmountEndPeriod { get; set; }
        public double AmountEndPeriodRecom { get; set; }
    }
}
