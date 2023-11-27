using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class Region
    {
        public int RegionId { get; set; }
        public string? RegionCod { get; set; }
        public int? DescriptionId { get; set; }
        public int? StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public int? UpdatedUserId { get; set; }

        
        public User? CreatedUser { get; set; }
        public User? UpdatedUser { get; set; }
        public GeneralStatus? GeneralStatus { get; set; }

    }
}
