using EComersObjectLib.SapObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.AditionalModels
{
    public class RequestResultOrder:RequestResult
    {
        public List<OITM> ErrorOitmList { get; set; }
    }
}
