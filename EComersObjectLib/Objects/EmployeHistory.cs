using EComersObjectLib.SapObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersObjectLib
{
    public class EmployeHistory
    {
        private DateTime startDate;
        private DateTime endDate;
        private DateTime birthDay;

        public EmployeHistory() 
        {
        
        }

        public EmployeHistory(OHEM sapEmploye)
        {
            Name = sapEmploye.firstName;
            SecondName = sapEmploye.lastName;
            MiddleName = sapEmploye.middleName;
            GenderId = 1;
            BirthDay = sapEmploye.birthDay.Date;
            PhoneNumber = sapEmploye.mobile;
            PhoneNumberSecond = sapEmploye.homeTel;
            Email = sapEmploye.email;
            StatusId = 1;
        }

        public EmployeHistory(EmployeHistory employeHistory)
        {
            Name = employeHistory.Name;
            SecondName = employeHistory.SecondName;
            MiddleName = employeHistory.MiddleName;
            EmployeId = employeHistory.EmployeId;
            GenderId = employeHistory.GenderId;
            BirthDay = employeHistory.BirthDay;
            PhoneNumber = employeHistory.PhoneNumber;
            PhoneNumberSecond = employeHistory.PhoneNumberSecond;
            Email = employeHistory.Email;
            FuncTypeId = employeHistory.FuncTypeId;
            DepartmentId = employeHistory.DepartmentId;
            BranchId = employeHistory.BranchId;
            WorkStreetId = employeHistory.WorkStreetId;
            WorkCityId = employeHistory.WorkCityId;
            StatusId = employeHistory.StatusId;
            NumHistory = employeHistory.NumHistory + 1;
            //StartDate = DateTime.UtcNow;
            //EndDate = DateTime.MaxValue;
            UserId = employeHistory.UserId;
        }

        public int EmployeHistoryId { get; set; }
        public int EmployeId { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string? MiddleName { get; set; }
        public int? GenderId { get; set; }
        public DateTime BirthDay { get { return DateTimeUtils.ConvertDateTimeFromUtc(birthDay); } set { birthDay = value; } }
        public string? PhoneNumber { get; set; }
        public string? PhoneNumberSecond { get; set; }
        public string? Email { get; set; }
        public int? FuncTypeId { get; set; }
        public int? DepartmentId { get; set; }
        public int? BranchId { get; set; }
        public int? WorkStreetId { get; set; }
        public int? WorkCityId { get; set; }
        public int StatusId { get; set; }
        public int NumHistory { get; set; }
        public DateTime StartDate { get { return DateTimeUtils.ConvertDateTimeFromUtc(startDate); } set { startDate = value; } }
        public DateTime EndDate { get { return DateTimeUtils.ConvertDateTimeFromUtc(endDate); } set { endDate = value; } }
        public int UserId { get; set; }
        public string? U_RouteID { get; set; }

        public User? CreatedUser { get; set; }
        public EmployeStatus EmployeStatus { get; set; }
        public Employe Employe { get; set; }
        public FunctionsType FunctionsType { get; set; }
        public Gender Gender { get; set; }


        public EmployeHistory GetNewEmoloyeHistrory()
        {
            EmployeHistory newEmployeHostory = new EmployeHistory()
            {
                Name = Name,
                SecondName = SecondName,
                MiddleName = MiddleName,
                EmployeId = EmployeId,
                GenderId = GenderId,
                BirthDay = BirthDay,
                PhoneNumber = PhoneNumber,
                PhoneNumberSecond = PhoneNumberSecond,
                Email = Email,
                FuncTypeId = FuncTypeId,
                DepartmentId = DepartmentId,
                BranchId = BranchId,
                WorkStreetId = WorkStreetId,
                WorkCityId = WorkCityId,
                StatusId = StatusId,
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.MaxValue,
                UserId = UserId
            };

            return newEmployeHostory;
        }

        
    }
}
