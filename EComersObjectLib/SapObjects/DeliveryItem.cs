using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.SapObjects
{
    public class DeliveryItem
    {
        public int DeliveryItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string PicturName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int DocNum { get; set; }
        public string BaseRef { get; set; }
        public int BaseEntry { get; set; }
        public int DocEntry { get; set; }
        public int? DeliveryForInvoiceId { get; set; }
        public DeliveryForInvoice? DeliveryForInvoice { get; set; }
    }
}
