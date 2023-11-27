using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.SapObjects
{
    public class CustomMerch
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public int VisitId { get; set; }
        public int EmpID { get; set; }
        public string Created { get; set; }
        public string CardCode { get; set; }
        public string Comment { get; set; }
        public List<SkuScore>? SkuScoreList { get; set;}
        public List<GroupScore>? GroupScoreList { get; set; }
    }
}
