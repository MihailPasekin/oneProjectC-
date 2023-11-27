using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class DeliveryForReportLens
    {
        public int DocEntry { get; set; }
        public string CodeBars { get; set; }
        public string ItemCode { get; set; }
        public string Dscription { get; set; }
        public double Quantity { get; set; }
        public string unitMsr { get; set; }
        public double Price { get; set; }
        public double LineTotal { get; set; }
        public double OpenSum { get; set; }
    }
}
