using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class CommissionReport
    {
        public List<CommissionReportLines> CommissionReportLines { get; set; } = new List<CommissionReportLines>();
        public int SumOnHand { get { return CommissionReportLines.Sum(p => p.OnHand); }}
        public int SumGoodsReceipt { get { return CommissionReportLines.Sum(p => p.GoodsReceipt); } }
        public int SumProductsSold { get { return CommissionReportLines.Sum(p => p.ProductsSold); } }
        public int SumReturnSupplier { get { return CommissionReportLines.Sum(p => p.ReturnSupplier); } }
        public double SumCommissionAgentRemunAmount { get { return CommissionReportLines.Sum(p => p.CommissionAgentRemunAmount); } }
        public double SumAmountPaymentPrincipal { get { return CommissionReportLines.Sum(p => p.AmountPaymentPrincipal); } }
        public double SumReceiptAmountStartPeriod { get { return CommissionReportLines.Sum(p => p.ReceiptAmountStartPeriod); } }
        public double SumAmountStartPeriod { get { return CommissionReportLines.Sum(p => p.AmountStartPeriod); } }
        public double SumReceiptAmountEndPeriod { get { return CommissionReportLines.Sum(p => p.ReceiptAmountEndPeriod); } }
        public double SumAmountEndPeriodRecom { get { return CommissionReportLines.Sum(p => p.AmountEndPeriodRecom); } }
    }
}
