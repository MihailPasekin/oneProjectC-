using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class DaylyReportKassaLines
    {
        public string AccountablePerson { get; set; }
        public double Coming { get; set; }
        public double Expense { get; set; }
        public double Credits { get; set; }
        public double Refund { get; set; }
        public double Total { get; set; }
        public double Transfer { get; set; }
        public double Bank { get; set; }
        public double Consignment { get; set; }
    }
}
