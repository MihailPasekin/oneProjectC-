using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class OkReportDetals
    {
        public int DocEntry { get; set; }
        public int DocNum { get; set; }
        public DateTime DocDate { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public double SumZakaza { get; set; }
        public double SumProdaji { get; set; }
        public double SumOplaty { get; set; }
        public double SumVozvrat { get; set; }
    }
}
