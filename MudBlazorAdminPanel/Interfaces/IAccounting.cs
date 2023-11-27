using EComersObjectLib;
using EComersObjectLib.Objects;
using System.Runtime.ConstrainedExecution;

namespace MudBlazorAdminPanel.Interfaces
{
    public interface IAccounting
    {
        Task<DaylyReportKassa> GetDaylyKassaReport(string fromDate, string toDate, string kassa);
        Task<List<CashAccount>> GetListCashAccount();
        Task<List<ErrorOrct>> GetListErrorOrctsAsync();
        Task<List<OkReportLines>> GetOkReportListAsync(string fromDate, string toDate);
        Task<List<OkReportDetals>> GetOkReportDetailsAsync(string fromDate);
        Task<List<CreditReportLines>> GetCerditReportListAsync(string fromDate, string toDate, string root);
        Task<List<URouteID>> GetURouteIDAsync();
        Task<List<List<Percent>>> GetPercentAsync(string fromDate, string toDate);
        Task<List<PrepaymentReport>> GetPrepaymentReportAsync(string fromDate, string toDate);
        Task<List<Сonsignment>> GetСonsignmentAsync(string fromDate, string toDate, string vendorCode);
        Task<List<ConsigmentClient>> GetConsigmentClientsAsync();

    }
}
