using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.Objects
{
    public class Telemetry
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public DateTime CreateDate { get; set; }
        public int BatteryLevel { get; set; }
    }
}
