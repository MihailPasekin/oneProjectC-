using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class DepartmentStatus: Status
    {
        public List<Department> Departments { get; set; }

        public DepartmentStatus()
        {

        }

        public DepartmentStatus(int descriptionId, string cod, string descriptionDefault):base(descriptionId, cod, descriptionDefault)
        {
            
        }

        public DepartmentStatus(int statusId, int descriptionId,  string cod, string descriptionDefault) :base(statusId, descriptionId, cod, descriptionDefault )
        {
            
        }
    }
}
