using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class PlanDetail
    {
        public int PlanDetailId { get; set; }
        public int PlanId { get; set; }
        public int CastomerId { get; set; }
        public string PlanDeteilStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedUserId { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public MerchPlan? MerchPlan { get; set; }
        public PlanReport? PlanReport { get; set; }
    }
}
