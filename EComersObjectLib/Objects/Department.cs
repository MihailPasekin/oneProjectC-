using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string? Cod { get; set; }
        public int DescriptionId { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UserId { get; set; }
        public int UpdatedUserId { get; set; }

        public DepartmentStatus DepartmentStatus { get; set; }
        public User CreatedUser { get; set; }
        public User UpdatedUser { get; set; }
    }
}
