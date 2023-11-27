using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.SapObjects
{
    public class GroupScore
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public int? GroupScoreId { get; set; }
        public int GroupId { get; set; }
        public int VisitId { get; set; }

    }
}
