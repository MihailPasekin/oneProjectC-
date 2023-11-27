using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Cod { get; set; }
        public int DescriptionId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public int? UpdatedUserId { get; set; }


        public User? CreatedUser { get; set; }
        public User? UpdatedUser { get; set; }
        public List<User>? Users { get; set; }

        public Role()
        {
            Cod = "";
        }

        public Role(string cod )
        {
            Cod = cod;
            
        }

        public Role(int roleId, string cod)
        {
            RoleId = roleId;
            Cod = cod;
           
        }

       
    }
}
