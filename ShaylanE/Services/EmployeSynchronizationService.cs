using EComersDBworkerLib;
using EComersObjectLib;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using SAPbobsCOM;
using SapDBWorkerLib;
using EComersObjectLib.SapObjects;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Xml.Linq;

namespace EComersWebApiEmploe.Services
{
    public class EmployeSynchronizationService
    {
        private EComersDBWorker dBWorker;
        private SapDBWorker sapDBWorker;

        public EmployeSynchronizationService(EComersDBWorker eComersDBWorker, SapDBWorker _sapDBWorker) 
        {
            dBWorker = eComersDBWorker;
            sapDBWorker = _sapDBWorker;
        }

        public void StartSinhronization()
        {
            List<OHEM> SapEmploye = new List<OHEM>();

            List<Employe> employes= new List<Employe>();

            SapEmploye = sapDBWorker.GetListSapEmploye();

            SapEmploye.ForEach(p  =>
            {
                 CreateNewEmploye(p);
            });

        }

        private void CreateNewEmploye(OHEM sapEmploye)
        {
            if (sapEmploye == null) { return; }

            List<string> exceptionMessages = new List<string>();

            try
            {
                Employe employe = dBWorker.GetEmployeByEmpIdAsync(sapEmploye.empId);

                if (employe.EmployeId == 0) 
                {
                    employe = new Employe()
                    {
                        CreatedUserId = 1,
                        EmployeSapId = sapEmploye.empId,
                    };

                    employe.EmployeHistory = new List<EmployeHistory>()
                    {
                        new EmployeHistory()
                        {
                        Name = sapEmploye.firstName ?? "?",
                        SecondName = sapEmploye.lastName,
                        MiddleName = sapEmploye.middleName,
                        GenderId = 1,
                        BirthDay = sapEmploye.birthDay.Date,
                        PhoneNumber = sapEmploye.mobile,
                        PhoneNumberSecond = sapEmploye.homeTel,
                        Email = sapEmploye.email,
                        UserId = 1,
                        }
                    };
                    

                    dBWorker.CreateEmploye(employe);
                }
                else
                {
                    DateTime requestDate = DateTime.Now;
                    //EmployeHistory? lastEmployeHistory = employe.EmployeHistory.Where(p => p.StartDate < requestDate && requestDate < DateTime.MaxValue).FirstOrDefault();
                    EmployeHistory? lastEmployeHistory = employe.GetActualEmployeHistory();
                    if (lastEmployeHistory != null)
                    {
                        if (lastEmployeHistory.Name != sapEmploye.firstName ||
                           lastEmployeHistory.SecondName != sapEmploye.lastName ||
                           lastEmployeHistory.MiddleName != sapEmploye.middleName ||
                           lastEmployeHistory.GenderId != 1 ||
                           lastEmployeHistory.BirthDay.Date != sapEmploye.birthDay.Date ||
                           lastEmployeHistory.PhoneNumber != sapEmploye.mobile ||
                           lastEmployeHistory.PhoneNumberSecond != sapEmploye.homeTel ||
                           lastEmployeHistory.Email != sapEmploye.email)
                        {
                            EmployeHistory employeHistory = new EmployeHistory(sapEmploye);
                            employeHistory.EmployeId = lastEmployeHistory.EmployeId;
                            employeHistory.FuncTypeId = lastEmployeHistory.FuncTypeId;
                            employeHistory.DepartmentId = lastEmployeHistory.DepartmentId;
                            employeHistory.BranchId = lastEmployeHistory.BranchId;
                            employeHistory.WorkStreetId = lastEmployeHistory.WorkStreetId;
                            employeHistory.WorkCityId = lastEmployeHistory.WorkCityId;
                            employeHistory.UserId = lastEmployeHistory.UserId;
                            employeHistory.NumHistory = lastEmployeHistory.NumHistory + 1;

                            dBWorker.UpdateEmploye(employe, employeHistory);

                            //string errorMessage = dBWorker.CreateEmployeHistory(newEmployeHistory);
                        }
                    }
                   

                }

            }
            catch (Exception ex)
            {
                exceptionMessages.Add(ex.Message);
            }

        }
    }
}
