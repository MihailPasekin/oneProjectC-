using EComersObjectLib;
using EComersObjectLib.Objects;
using System.Runtime.ConstrainedExecution;

namespace AdminPanelBlazor.Interfaces
{
    public interface IAccounting
    {
        Task<DaylyReportKassa> GetDaylyKassaReport(string fromDate, string toDate, string kassa);
        Task<List<CashAccount>> GetListCashAccount();
        Task<List<ErrorOrct>> GetListErrorOrctsAsync();
        Task<List<OkReportLines>> GetOkReportListAsync(string fromDate, string toDate);
        Task<List<OkReportDetals>> GetOkReportDetailsAsync(string fromDate);
        Task<List<CreditReportLines>> GetCerditReportListAsync(string fromDate, string toDate, string root);
        Task<List<URouteID>> GetURouteIDAsync(string region);
        Task<List<List<Percent>>> GetPercentAsync(string fromDate, string toDate);
        Task<List<Сonsignment>> GetСonsignmentAsync(string fromDate, string toDate, string vendorCode);
        Task<List<PrepaymentReport>> GetPrepaymentReportAsync(string fromDate, string toDate);
        Task<List<ConsigmentClient>> GetConsigmentClientsAsync();
    }
}
