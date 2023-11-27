using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class EmployeStatus : Status
    {   
        public List<EmployeHistory>? EmployeHistory { get; set; }

        public EmployeStatus()
        {

        }

        public EmployeStatus(int descriptionId, string cod, string defaultDescription) : base(descriptionId, cod, defaultDescription)
        {

        }

        public EmployeStatus(int statusId, int descriptionId, string cod, string defaultDescription) : base(statusId, descriptionId, cod, defaultDescription)
        {

        }
    }
}
