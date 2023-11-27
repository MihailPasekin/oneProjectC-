using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class ErrorOrct
    {
        public int DocNum { get; set; }
        public DateTime DocDate { get; set; }
        public string CardName { get; set; }
        public string CashAcct { get; set; }
        public double Cashsum { get; set; }
    }
}
