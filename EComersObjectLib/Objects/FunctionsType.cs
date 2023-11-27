using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class FunctionsType
    {
        public int FuncTypeId { get; set; }
        public string? Cod { get; set; }
        public int FuncTypeDescriptionId { get; set; }
        public string DefaultDescription { get; set; }  
        public int UserId { get; set; }
        public int StatusId { get; set; }
        public int? OwnerFuncTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedUserId { get; set; }

        public FuncTypeStatus StatusType { get; set; }
        public FunctionsType OwnerFunctionType { get; set; }
        public User CreatedUser { get; set; }
        public User UpdatedUser { get; set; }
        public List<EmployeHistory> EmployeHistory { get; set;}
    }
}
