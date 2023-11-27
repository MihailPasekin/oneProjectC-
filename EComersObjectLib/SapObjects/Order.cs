using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EComersObjectLib.SapObjects
{
    public class Order
    {
        private DateTime? created;

        public int? OrderId { get; set; }
        public string OrderCode { get; set; }
        public string OrderDate { get; set; }
        public string OrderClient { get; set; }
        public string OrderSeller { get; set; }
        public int GroupNum { get; set; }
        public List<OITM> OrderItems { get; set; }
        public string Comment { get; set; }
        public DateTime? Created { get { return DateTimeUtils.ConvertDateTimeFromUtc(created??DateTime.MinValue); } set { created = value; } }
        public string? ErrorMessage { get; set; }
    }
}
