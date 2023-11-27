using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class ForwarderDocList
    {
        public int DocNum { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string RouteID { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public double DocTotal { get; set; }
        public string PayType { get; set; }
        public string PayTypeForSum { get; set; }
    }
}
