using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class User
    {
        public int? UserId { get; set; }
        public string? Name { get; set; }
        public string? SecondName { get; set; }
        public string? MiddleName { get; set; }
        public int RoleId { get; set; }
        public int StatusId { get; set; }
        public string? Login { get; set; }
        public string? PasswordHash { get; set; }
        public DateTime? CreatedDate { get; set;}
        public DateTime? UpdatedDate { get;set;}
        public int CreatedUserId { get; set; }
        public string? CashAccount { get; set; }
        public string? Region { get; set; } 
        

        public Role? Role { get; set; }
        public UserStatus? UserStatus { get; set; }
        public List<Role>? CreatedRoles { get; set; }
        public List<Role>? UpdatedRoles { get; set; }
        public List<Employe>? CreatedEmployesUser { get; set; }
        public List<Employe>? UpdatedEmployesUser { get; set; }
        public List<ClientBalance>? CreatedClntBalUser { get; set; }
        public List<ClientBalance>? UpdatedClntBalUser { get; set; }
        public List<PayDocument>? CreatedPayDocumentUser { get;set; }
        public List<IncomeDocument>? CreatedIncomeDocumentUser { get; set; }
        public List<Region>? CreatedRegions { get; set; }
        public List<Region>? UpdatedRegions { get; set; }
        public List<FunctionsType>? CreatedFunctionsType { get; set; }
        public List<FunctionsType>? UpdatedFunctionsType { get; set; }
    }
}
