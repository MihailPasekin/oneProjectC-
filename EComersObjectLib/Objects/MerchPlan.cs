using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class MerchPlan
    {
        public int PlanId { get; set; }
        public int EmpId { get; set; }
        public DateTime PlanDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string PlanStatus { get; set; }
        public string? Coment { get; set; }
        public int CreatedUserId { get; set; }
        public List<PlanDetail>? PlanDetails { get; set; }
        public List<PlanReport>? PlanReports { get; set; }
    }
}
