using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.SapObjects
{
    public class DeliveryForInvoice
    {
        private DateTime? created;

        public int? DeliveryForInvoiceId {  get; set; }
        public DateTime? Created { get { return DateTimeUtils.ConvertDateTimeFromUtc(created ?? DateTime.MinValue); } set { created = value; } }
        public string? ErrorMessage { get; set; }

        public ODLN ODLN { get; set; }
        public List<DeliveryItem> DeliveryItems { get; set; }
        //public DateTime DocDueDate { get; set; }
    }
}
