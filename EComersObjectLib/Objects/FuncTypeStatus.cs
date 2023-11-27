using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class FuncTypeStatus : Status
    {
        public List<FunctionsType> FunctionsTypes { get; set; }

        public FuncTypeStatus()
        {

        }
        public FuncTypeStatus(int descriptionId, string cod, string defaultDescription) : base(descriptionId, cod, defaultDescription)
        {

        }

        public FuncTypeStatus(int statusId, int descriptionId, string cod, string defaultDescription) : base(statusId, descriptionId, cod, defaultDescription)
        {

        }

    }
}
