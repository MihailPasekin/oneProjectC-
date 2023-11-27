using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class Gender
    {
        public int GenderId { get; set; }
        public string GenderCod { get; set; }
        public int DescriptionId { get; set; }
        public string DefaultGenderDescription { get; set; }

        public List<Client> Clients { get; set; }
        public List<EmployeHistory> EmployeHistoryes { get; set; }

        public Gender()
        {

        }
        public Gender(int genderId, string genderCod, int genderDesc)
        {
            GenderId = genderId;
            GenderCod = genderCod;
            DescriptionId = genderDesc;
        }
    }
}
