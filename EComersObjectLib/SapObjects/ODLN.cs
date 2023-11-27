using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.SapObjects
{
    public class ODLN
    {
        
        public int OdlnId { get; set; }
        public int DocEntry { get; set; }
        public int DocNum { get; set; }
        public string DocStatus { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public double DocTotal { get; set; }
        public DateTime DocDate { get; set; }
        public string PayType { get; set; }

        public int? DeliveryForInvoiceId { get; set; }
        public DeliveryForInvoice? DeliveryForInvoice { get; set;}
    }
}
