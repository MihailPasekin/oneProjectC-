using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class Сonsignment
    {
        public int IdReceipts { get; set; }
        public int ReceiptNumber { get; set; }
        public DateTime ReceiptDate { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int QuantityAtStart { get; set; }
        public int ReceiptsPeriod { get; set; }
        public int ReturnsPeriod { get; set; }
        public int QuantityAtEnd { get; set; }
        public int Sales { get; set; }
        public double RecPrice { get; set; }
        public double CommissionRemuneration { get; set; }
        public double PaymentPrincipal { get; set; }
        public double AdmissionPrice { get; set; }
        public double StartingAmountArrivalPrice { get; set; }
        public double StartingAmountPriceDetails { get; set; }
        public double ReceiptAmountArrivalPrice { get; set; }
        public double ReceiptAmountRecommendedPrice { get; set; }
        public double AmountEndEntryPrice { get; set; }
        public double AmountEndSellingPrice { get; set; }
    }
}
