using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class RatingStatus : Status
    {
        public List<RatingHistory> RatingHistory { get; set; }

        public RatingStatus()
        {

        }
        public RatingStatus(int descriptionId, string cod, string defaultDescription) : base(descriptionId, cod, defaultDescription )
        {

        }

        public RatingStatus(int statusId, int descriptionId, string cod, string defaultDescription) : base(statusId, descriptionId, cod, defaultDescription)
        {

        }

    }
}
