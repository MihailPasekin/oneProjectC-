using EComersObjectLib;
using EComersObjectLib.Objects;
using EComersObjectLib.SapObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable CS8602

namespace EComersDBworkerLib
{
    public class EComersDBWorker
    {
        EComersContext eComersContext;

        public EComersDBWorker(EComersContext _eComersContext)
        {
            eComersContext = _eComersContext;
        }

        public string CreateEmploye(Employe employe)
        {
            DateTime curentDate = DateTime.UtcNow;
            try
            {
                employe.EmployeHistory[0].EmployeId = employe.EmployeId;
                employe.EmployeHistory[0].StartDate = curentDate;
                employe.EmployeHistory[0].EndDate = DateTime.MaxValue;
                employe.EmployeHistory[0].StatusId = 1;
                employe.EmployeHistory[0].NumHistory = 1;

                employe.CreatedDate = curentDate;
                eComersContext.Employe.Add(employe);
                eComersContext.SaveChanges();


                /*
                                eComersContext.EmployeHistory.Add(employeHistory);
                                eComersContext.SaveChanges();*/
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "0";
        }

        public string UpdateEmploye(Employe employe, EmployeHistory employeHistory)
        {
            DateTime curentDate = DateTime.Now;
            try
            {
                DateTime endDate = DateTime.UtcNow;
                employe.UpdatedDate = DateTime.UtcNow;
                employe.EmployeHistory.Where(p => p.StartDate < curentDate && curentDate < p.EndDate).FirstOrDefault().EndDate = endDate;

                eComersContext.Entry(employe).State = EntityState.Modified;
                //eComersContext.Entry(employeHistory).State = EntityState.Modified;
                eComersContext.SaveChanges();

                employeHistory.StartDate = endDate;
                employeHistory.EndDate = DateTime.MaxValue;

                eComersContext.EmployeHistory.Add(employeHistory);
                int rowCount = eComersContext.SaveChanges();
                return rowCount.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> DelleteEmploye(int id)
        {

            try
            {
                DateTime curDate = DateTime.Now;
                Employe? employe = await eComersContext.Employe.FirstOrDefaultAsync(p => p.EmployeId == id);
                EmployeHistory? employeHistory = await eComersContext.EmployeHistory.FirstOrDefaultAsync(p => p.EmployeId == employe.EmployeId && p.StartDate < curDate && p.EndDate > curDate);

                if (employeHistory == null || employe == null) throw new ArgumentException(nameof(employe));

                employeHistory.StatusId = 2;
                return UpdateEmploye(employe, employeHistory);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<List<Employe>> GetEmployeListAsync()
        {
            if (eComersContext == null)
            {
                return new List<Employe>();
            }

            var employeList = await eComersContext.Employe
                .Include(p => p.EmployeHistory).ThenInclude(p => p.EmployeStatus)
                .Include(p => p.EmployeHistory).ThenInclude(p => p.FunctionsType)
                .Include(p => p.EmployeHistory).ThenInclude(p => p.Gender)
                .ToListAsync();

            return employeList;
        }

        public async Task<Employe?> GetEmployeByIdAsync(int id)
        {
            if (eComersContext == null)
            {
                return new Employe();
            }

            var employe = await eComersContext.Employe
                .Include(p => p.EmployeHistory).ThenInclude(p => p.EmployeStatus)
                .Include(p => p.EmployeHistory).ThenInclude(p => p.FunctionsType)
                .Include(p => p.EmployeHistory).ThenInclude(p => p.Gender)
                .Where(p => p.EmployeId == id)
                .FirstOrDefaultAsync();

            return employe;
        }

        public string CreateParametr(Parameter parameter)
        {
            try
            {
                if (parameter == null) throw new ArgumentNullException(nameof(parameter));

                eComersContext.Parameters.Add(parameter);
                eComersContext.SaveChanges();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "0";
        }



        public async Task<Parameter> GetParameterByName(string paramName)
        {
            Parameter parameter = new Parameter();

            if (eComersContext == null)
            {
                return new Parameter();
            }

            return await eComersContext.Parameters.Where(p => p.ParamName == paramName).FirstOrDefaultAsync() ?? parameter;
        }

        public async Task<string> UpdateParameter(Parameter parameter)
        {
            try
            {
                if (parameter == null) throw new ArgumentNullException(nameof(parameter));

                eComersContext.Entry(parameter).State = EntityState.Modified;
                int rowCount = await eComersContext.SaveChangesAsync();
                return rowCount.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string CreateCustomer(Customer customer)
        {
            try
            {
                if (customer == null) throw new ArgumentNullException(nameof(customer));

                eComersContext.Customer.Add(customer);
                eComersContext.SaveChanges();

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "0";
        }



        public string RemoveAllCustomers()
        {
            int rowCount;
            try
            {
                rowCount = eComersContext.Database.ExecuteSqlRaw("DELETE FROM ecomers.\"Customer\" WHERE 1=1;");
                eComersContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return rowCount.ToString();
        }

        public async Task<List<Customer>> GetCustomersAsync() {
            List<Customer> listCustomers = new List<Customer>();
            try
            {
                listCustomers = await eComersContext.Customer.ToListAsync();
            }
            catch
            {
                //TO DO SAVE LOG MESSAGE
            }

            return listCustomers;
        }

        public async Task<List<Customer>> GetCustomersByRootAsync(List<EmployeRoot> root)
        {
            List<Customer> listCustomers = new List<Customer>();
            try
            {
                listCustomers = await eComersContext.Customer.Where(p => root.Select(p => p.Root).Contains(p.U_RouteID)).ToListAsync();
            }
            catch
            {
                //TO DO SAVE LOG MESSAGE
            }

            return listCustomers;
        }

        public async Task SaveOrderForSapServer(Order order)
        {
            try
            {
                if (order == null)
                {
                    //TO DO SAVE LOG MESSAGE
                    return;
                };
                eComersContext.Order.Add(order);
                await eComersContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                var error = e.Message;
                //TO DO SAVE LOG MESSAGE
            }
        }

        public async Task SaveDeliveryForInvoice(DeliveryForInvoice deliveryForInvoice)
        {
            try
            {
                if (deliveryForInvoice == null)
                {
                    //TO DO SAVE LOG MESSAGE
                    return;
                };
                eComersContext.DeliveryForInvoice.Add(deliveryForInvoice);
                await eComersContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                var error = e.Message;
                //TO DO SAVE LOG MESSAGE
            }
        }

        public async Task<List<MerchProductGroup>> GetMerchProductGroupAsync()
        {
            List<MerchProductGroup> listMerchGroup = new List<MerchProductGroup>();
            try
            {
                listMerchGroup = await eComersContext.MerchProductGroup.ToListAsync();
            }
            catch
            {
                //TO DO SAVE LOG MESSAGE
            }

            return listMerchGroup;
        }

        public async Task<List<MerchProduct>> GetMerchProductAllAsync()
        {
            List<MerchProduct> listMerchProduct = new List<MerchProduct>();
            try
            {
                listMerchProduct = await eComersContext.MerchProduct.ToListAsync();
            }
            catch
            {
                //TO DO SAVE LOG MESSAGE
            }

            return listMerchProduct;
        }

        public async Task<List<MerchProduct>> GetMerchProductAsync(int groupId)
        {
            List<MerchProduct> listMerchProduct = new List<MerchProduct>();
            try
            {
                listMerchProduct = await eComersContext.MerchProduct.Where(p => p.MerchProductGroupId == groupId).ToListAsync();
            }
            catch
            {
                //TO DO SAVE LOG MESSAGE
            }

            return listMerchProduct;
        }

        public async Task CreateMerchVisit(MerchVisit merchVisit)
        {
            try
            {
                if (merchVisit == null)
                {
                    //TO DO SAVE LOG MESSAGE
                    return;
                };
                eComersContext.MerchVisit.Add(merchVisit);
                await eComersContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                var error = e.Message;
            }
        }

        public async Task<List<MerchVisit>> GetMerchVisitByEmpIdAsync(int empId)
        {
            DateTime dateTime = DateTime.UtcNow;
            List<MerchVisit> listMerchVisit = new List<MerchVisit>();
            try
            {
                listMerchVisit = await eComersContext.MerchVisit.Where(p => p.EmpId == empId)
                    .Include(p => p.Customer)
                    .Include(p => p.Employe).ThenInclude(p => p.EmployeHistory.Where(p => p.StartDate < dateTime && dateTime < p.EndDate))
                    .ToListAsync();
            }
            catch
            {
                //TO DO SAVE LOG MESSAGE
            }

            return listMerchVisit;
        }

        public async Task<List<MerchProductSoldStat>> GetMerchProductSoldStatByVisitIdAsync(int visitId)
        {
            DateTime dateTime = DateTime.UtcNow;
            List<MerchProductSoldStat> listMerchProductSoldStat = new List<MerchProductSoldStat>();
            try
            {
                listMerchProductSoldStat = await eComersContext.MerchGroupState.Where(p => p.MerchVisitId == visitId)
                    .Include(p => p.MerchProduct).ThenInclude(p => p.MerchProductGroup)

                    .ToListAsync();
            }
            catch
            {
                //TO DO SAVE LOG MESSAGE
            }

            return listMerchProductSoldStat;
        }

        public Employe GetEmployeByEmpIdAsync(int empId)
        {
            try
            {
                Employe employe = eComersContext.Employe.Where(p => p.EmployeSapId == empId).Include(p => p.EmployeHistory).SingleOrDefault() ?? new Employe();
                return employe;
            }
            catch (Exception ex)
            {
                //TO DO SAVE LOG
            }

            return new Employe();
        }

        public EmployeHistory GetEmployeHistoryById(int employeId)
        {
            DateTime requestDate = DateTime.UtcNow;
            try
            {
                EmployeHistory employeHistory = eComersContext.EmployeHistory.Where(p => p.EmployeId == employeId && p.StartDate < requestDate && requestDate < DateTime.MaxValue)
                    .SingleOrDefault() ?? new EmployeHistory();
                return employeHistory;
            }
            catch (Exception ex)
            {
                //TO DO SAVE LOG
            }

            return new EmployeHistory();
        }

        public string CreateEmployeHistory(EmployeHistory newEmployeHistory)
        {
            try
            {
                eComersContext.EmployeHistory.Add(newEmployeHistory);
                int rowCount = eComersContext.SaveChanges();
                return rowCount.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Customer GetCustomerBuCardCode(string cardCode)
        {
            Customer customer = new Customer();
            try
            {
                customer = eComersContext.Customer.Where(p => p.CardCode == cardCode).FirstOrDefault() ?? new Customer();
            }
            catch
            {
                //TO DO SAVE LOG MESSAGE
            }

            return customer;
        }

        public string UpdateCustomer(Customer customer)
        {
            try
            {
                eComersContext.Entry(customer).State = EntityState.Modified;
                int rowCount = eComersContext.SaveChanges();
                return rowCount.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<List<MerchVisit>> GetAllMerchVisitAsync()
        {
            DateTime dateTime = DateTime.UtcNow;
            List<MerchVisit> listMerchVisit = new List<MerchVisit>();
            try
            {
                listMerchVisit = await eComersContext.MerchVisit
                    .Include(p => p.Customer)
                    .Include(p => p.Employe).ThenInclude(p => p.EmployeHistory.Where(p => p.StartDate < dateTime && dateTime < p.EndDate))
                    .ToListAsync();
            }
            catch
            {
                //TO DO SAVE LOG MESSAGE
            }
            return listMerchVisit;
        }

        public async Task<string> CreateMerchPlanAsync(MerchPlan merchPlan)
        {
            try
            {
                merchPlan.CreatedAt = DateTime.UtcNow;
               // merchPlan.PlanDate = merchPlan.PlanDate.ToUniversalTime();
                eComersContext.MerchPlan.Add(merchPlan);
                int rowCount = await eComersContext.SaveChangesAsync();
                return rowCount.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> UpdateMrechPlanAsyncI(MerchPlan merchPlan)
        {
            try
            {
                eComersContext.Entry(merchPlan).State = EntityState.Modified;
                int rowCount = await eComersContext.SaveChangesAsync();
                return rowCount.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public async Task<List<MerchPlan>> GetAllMerchPlansAsync()
        {
            List<MerchPlan> listMerchPlan = new List<MerchPlan>();
            try
            {
                listMerchPlan = await eComersContext.MerchPlan
                    .Include(p => p.PlanDetails)
                    .ToListAsync();
            }
            catch
            {
                //TO DO SAVE LOG MESSAGE
            }

            return listMerchPlan;
        }

        public async Task<List<MerchPlan>> GetEmpIdMerchPlansAsync(int empId)
        {
            List<MerchPlan> listMerchPlan = new List<MerchPlan>();
            try
            {
                listMerchPlan = await eComersContext.MerchPlan
                    .Include(p => p.PlanDetails).Where(p => p.EmpId == empId)
                    .ToListAsync();
            }
            catch
            {
                //TO DO SAVE LOG MESSAGE
            }

            return listMerchPlan;
        }

        public async Task<string> CreatedPlanReportAsync(PlanReport planReport)
        {
            try
            {
                eComersContext.PlanReport.Add(planReport);
                int rowCount = await eComersContext.SaveChangesAsync();
                return rowCount.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> CreatedPhotoAsync(Photo photo)
        {
            try
            {
                eComersContext.Photo.Add(photo);
                int rowCount = await eComersContext.SaveChangesAsync();
                return rowCount.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public async Task<List<PlanReport>> GetPlanReportAsync() 
        {
            DateTime dateTime = DateTime.UtcNow;
            List<PlanReport> listPlanReport = new List<PlanReport>();
            try
            {
                listPlanReport = await eComersContext.PlanReport
                    .Include(p => p.Photos)
                    .Include(p => p.Employe).ThenInclude(p=> p.EmployeHistory.Where(p => p.StartDate < dateTime && dateTime < p.EndDate))
                    .Include(p => p.MerchPlan)
                    .Include(p => p.PlanDetail)
                    .ToListAsync();
            }
            catch
            {
                //TO DO SAVE LOG MESSAGE
            }
            return listPlanReport;
        }

        public async Task<string> CreatedTelemetryAsync(Telemetry telemetry)
        {
            try
            {
                eComersContext.Telemetry.Add(telemetry);
                int rowCount = await eComersContext.SaveChangesAsync();
                return rowCount.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> CreateUserAsync(User user)
        {
            try
            {
                eComersContext.User.Add(user);
                int rowCount = await eComersContext.SaveChangesAsync();
                return rowCount.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public async Task<List<Telemetry>> GetTelemetryAsync(DateTime fromDate, DateTime toDate)
        {
            List<Telemetry> listTelemetry = new List<Telemetry>();
            try
            {
                listTelemetry = await eComersContext.Telemetry.Where(p => p.CreateDate >= fromDate && p.CreateDate <= toDate)
                    .ToListAsync();
            }
            catch
            {
                //TO DO SAVE LOG MESSAGE
            }

            return listTelemetry;
        }

        public async Task<List<Telemetry>> GetTelemetryIdAsync(int empId)
        {
            List<Telemetry> listTelemetry = new List<Telemetry>();
            try
            {
                listTelemetry = await eComersContext.Telemetry.Where(p => p.EmpId == empId)
                    .ToListAsync();
            }
            catch
            {
                //TO DO SAVE LOG MESSAGE
            }

            return listTelemetry;
        }

        public Task<List<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
