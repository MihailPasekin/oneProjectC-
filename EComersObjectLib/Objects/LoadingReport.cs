using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class LoadingReport
    {
        public string CardCode { get; set; }
        public string Description { get; set; }
        public string CodeBars { get; set; }
        public int Quantity { get; set; }
        public DateTime ShipDate { get; set; }
        public double Price { get; set; }
        public int? U_Agent { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime DocDueDate { get; set; }
    }
}
