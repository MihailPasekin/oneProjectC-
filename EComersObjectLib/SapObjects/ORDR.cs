using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.SapObjects
{
    public class ORDR
    {
        public int DocEntry { get; set; }
        public int DocNum { get; set; }
        public string DocStatus { get; set; }
        public DateTime DocDate { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public double DocTotal { get; set; }
        public double GrosProfit { get; set; }
        public int OwnerCode { get; set; }
        public int GroupNum { get; set; }
        public string PayType { get; set; }
        public int U_Agent { get; set; }
        public int U_Supervisor { get; set; }
        public string Comments { get; set; }
    }
}
