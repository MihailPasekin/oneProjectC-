using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class MerchVisit
    {
        public int MerchVisitId { get; set; }
        public int EmpId { get; set; }
        public string CardCode { get; set; }
        public string ManagerName { get; set; }
        public string ManagerPhone { get; set; }
        public string JobTitle { get; set; }
        public string Comment { get; set; }
        public string Merch { get; set; }
        public DateTime VisitDateTime { get; set; }
        
        public List<MerchProductSoldStat> ProductSoldStat { get; set; }
        public Customer? Customer { get; set; }
        public Employe? Employe { get; set; }
    }
}
