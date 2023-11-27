using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib.SapObjects
{
    public class OHEM
    {
        public int empId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string sex { get; set; }
        public string jobTitle { get; set; }
        public int dept { get; set; }
        public DateTime birthDay { get; set; }
        public string mobile { get; set; }
        public string homeTel { get; set; }
        public string email { get; set; }
        public string workStreet { get; set; }
        public string workCity { get; set; }
        public string password { get; set; } = "";
        public string password2 { get; set; } = "";
        public string photo { get; set; } = "";
        public string U_RouteID { get; set; }
    }
}
