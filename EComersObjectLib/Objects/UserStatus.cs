using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class UserStatus: Status
    {
        public List<User> Users { get; set; }

        public UserStatus()
        {

        }

        public UserStatus(int descriptionId, string cod, string defaultDescription) : base(descriptionId, cod, defaultDescription)
        {

        }

        public UserStatus(int statusId, int descriptionId, string cod, string defaultDescription) : base(statusId,descriptionId, cod, defaultDescription)
        {

        }
    }
}
