using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class Parameter
    {
        public int ParamId { get; set; }
        public string ParamName { get; set; } = string.Empty;
        public string StringVal { get; set; } = string.Empty;
        public int IntVal { get; set; }
        public bool BoolVal { get; set; }
        public DateTime DateTimeVal { get; set; } = DateTime.MinValue;
        public string Description { get; set; } = string.Empty;
    }
}
