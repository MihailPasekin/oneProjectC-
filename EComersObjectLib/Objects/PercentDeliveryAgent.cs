using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public  class PercentDeliveryAgent
    {
        public int DocEntry { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Sum { get; set; }
        public DateTime DocDate { get; set; }
        public string CardCode { get; set; }
        public int DocNum { get; set; }
    }
}
