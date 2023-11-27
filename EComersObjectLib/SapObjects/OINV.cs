using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.SapObjects
{
    public class OINV
    {
		public int DocEntry { get; set; }
        public int DocNum { get; set; }
		public DateTime DocDate { get; set; }
		public string CardCode { get; set; }
		public string CardName { get; set; }
		public double DocTotal { get; set; }
		public int OwnerCode { get; set; }
		public string DocStatus { get; set; }
		public int GroupNum { get; set; }
		public double PaySum { get; set; }
		public bool Confirm { get; set; }
		public string CashAccount { get; set; }
    }
}
