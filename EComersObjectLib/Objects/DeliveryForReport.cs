using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class DeliveryForReport
    {
        public int DocEntry { get; set; }
        public int DocNum { get; set; }
        public string CardCode { get; set; }
        public DateTime DocDate { get; set; }
        public string CardName { get; set; }
        public double DocTotal { get; set; }
        public string Comments { get; set; }
        public int U_Agent { get; set; }
        public int U_Supervisor { get; set; }
        public string PymntGroup { get; set; }
        public string NameAgent { get; set; }
        public string NameSupervisor { get; set; }
        public DeliveryForReportLens[] deliveryForReportLens { get; set; }
    }
}
