using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class Status
    {
        public int StatusId { get; set; }
        public string? Cod { get; set; }
        public int? DescriptionId { get; set; }
        public string? DefaultDescription { get; set; }

        public Status()
        {
                     
        }
        public Status(int statusId, int descriptionId, string cod, string defaultDesctiprion)
        {
            StatusId = statusId;
            DescriptionId = descriptionId;
            Cod = cod;
            DefaultDescription = defaultDesctiprion;
            
        }
        public Status(int descriptionId, string cod, string defaultDesctiprion)
        {
            DescriptionId = descriptionId;
            Cod = cod;
            DefaultDescription = defaultDesctiprion;
        }
           
    }
}
