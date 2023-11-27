using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class CreditReportLines
    {
        public string Route { get; set; }
        public string Agent { get; set; }
        public int DocNum { get; set; }
        public DateTime DeliveriDate { get; set; }
        public string Client { get; set; }
        public double Credit7 { get; set; }
        public double Credit14 { get; set; }
        public double Credit30 { get; set; }
        public int Ostalos { get; set; }
        public int Expired { get; set; }
        public double Balance { get; set; }
        public double Transfer { get; set; }
        public double CreditSum { get; set; }
        public double ConsignmentTotal { get; set; }
        public double SumOplaty { get; set; }
        public double SumVozvrat { get; set; }
        public double OrderSum { get; set; }
    }
}
