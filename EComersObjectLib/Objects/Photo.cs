using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public int PlanReportId { get; set; }
        public int PlanId { get; set; }
        public int PlanDetailId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string PhotoName { get; set; }
        public string FullFileName { get; set; }
        public string Period { get; set; }

        public PlanReport? PlanReport { get; set; }

    }
}
