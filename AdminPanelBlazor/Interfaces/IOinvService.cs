using AdminPanelBlazor.Models;
using EComersObjectLib;
using EComersObjectLib.Objects;
using EComersObjectLib.SapObjects;

namespace AdminPanelBlazor.Interfaces
{
    public interface IOinvService
    {
        Task<ListOINV> GetInvoices();
        Task<ListOINV> GetInvoices(string empID);
        Task<ListOINV> GetInvoiceByDocNumber(string docNumber);
        Task<string> GetEmployeName(string empID);
        Task<string> GetEmployeRoot(string empID);
        Task PostCreatePay(List<OINV> listOinv);
        Task<List<MerchVisit>> GetAllMerchVisits();
        Task<List<MerchVisit>> GetAllMerchVisits(string employeId);
        Task<List<MerchProductSoldStat>> GetMerchReport(int id);
        Task<List<ORDR>> GetSapOrders();
        Task<List<ORDR>> GetSapOrdersByRegion(string region);
        Task<List<MerchPlan>> MerchPlansAll();
        Task PostAllMerchPlan(MerchPlan merchPlan);
        Task<List<Customer>> GetAllCustomers(string empId);
        Task<List<EmployeView>> GetAllEmployesAsync();
        Task<List<OHEM>> GetAllEmployesEkspeditorAsync();
        Task<List<OHEM>> GetAllEmployesEkspeditorAsync(string region);
        Task<List<RDR1>> GetSapOrderLines(int docEntry);
        Task<List<PlanReport>> GetAllPlanReportAsync();
        Task OnPostCreateDelivery(List<int> selectedOrders);
    }
    
}
