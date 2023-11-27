using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class DaylyReportKassa
    {
        public double KassaStartDay { get; set; }
        public double KassaEndDay { get; set; }
        public double KassaComming { get; set; }
        public double KassaExpense { get; set; }
        public double KassaTransactions { get; set; }
        public List<DaylyReportKassaLines> KassaLines { get; set;}
    }
}
