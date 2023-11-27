using EComersObjectLib;
using System.Text.Json.Serialization;

namespace EComersObjectLib
{
    public class EmployeView
    {
        

        public int EmployeId { get; set; }
        public DateTime CreatedDate { get; set ; }
        public DateTime? UpdatedDate { get;  set ; }
        public int CreatedUserId { get; set; }
        public int? UpdatedUserId { get; set; }
        public string? CreatedUserName { get; set; }
        public string? CreatedUserSecondName { get; set; }
        public string? CreatedUserMiddleName { get; set; }
        public string? CreatedUserLogin { get; set; }
        public string? UpdatedUserName { get; set; }
        public string? UpdatedUserSecondName { get; set; }
        public string? UpdatedUserMiddleName { get; set; }
        public string? UpdatedUserLogin { get; set; }
     
        public int RoleId { get; set; }
        public int StatusId { get; set; }
        public int EmployeHistoryId { get; set; }
        
        public string EmployeName { get; set; }
      
        public string EmployeSecondName { get; set; }
     
        public string? EmployeMiddleName { get; set; }
        public int? GenderId { get; set; }
        public int? Age { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PhoneNumberSecond { get; set; }
        public string? Email { get; set; }
        public int? FuncTypeId { get; set; }
        public int? DepartmentId { get; set; }
        public int? BranchId { get; set; }
        public int? WorkStreetId { get; set; }
        public int? WorkCityId { get; set; }
        public int NumHistory { get; set; }
        public int SapEmployeId { get; set; }
     
        public string? StatusDescription { get; set; }

        public string? FuncTypeDescription { get; set; }

        public string? GenderDescription { get; set; }

        public EmployeView()
        {

        }

        public EmployeView(Employe employe)
        {
            DateTime curentDate = DateTime.Now;
            EmployeHistory actualEmployeHistory = employe.EmployeHistory.SingleOrDefault(p => p.StartDate <= curentDate && p.EndDate > curentDate);
            if (actualEmployeHistory != null)
            {
                EmployeId = actualEmployeHistory.EmployeId;
                EmployeName = actualEmployeHistory.Name;
                EmployeSecondName = actualEmployeHistory.SecondName;
                EmployeMiddleName = actualEmployeHistory.MiddleName;
                StatusDescription = actualEmployeHistory.EmployeStatus.DefaultDescription;
                FuncTypeDescription = actualEmployeHistory.FunctionsType?.DefaultDescription;
                GenderDescription = actualEmployeHistory.Gender.DefaultGenderDescription;
                CreatedDate = employe.CreatedDate;
                SapEmployeId = employe.EmployeSapId;
            }
            
        }

        
    }
}
