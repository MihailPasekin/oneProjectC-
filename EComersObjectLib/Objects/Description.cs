using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class Description
    {
        public int DescId { get; set; }
        public int DescriptionId { get; set; }
        public string? DescriptionText { get; set; }
        public string? LangCod { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CeratedUserId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedUserId { get; set; }


        public User? CreatedUser { get; set; }
        public User? UpdatedUser { get; set; }
        
    }
}
