using EComersObjectLib.SapObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class PrepaymentReport
    {
        public int DocNum { get; set; }
		public DateTime DocDate { get; set; }
		public string CardCode { get; set; }
		public string CardName { get; set; }
		public double DocTotal { get; set; }
		public string Name { get; set; }
    }
}
