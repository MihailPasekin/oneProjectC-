using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class PlanReport
    {
        public int PlanReportId { get; set; }
        public int EmpId { get; set; }
        public int PlanId { get; set; }
        public int PlanDetailId { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Photo>? Photos { get; set; }
        public MerchPlan? MerchPlan { get; set; }
        public PlanDetail? PlanDetail { get; set; }
        public Employe? Employe { get; set; }

       
    }
}
