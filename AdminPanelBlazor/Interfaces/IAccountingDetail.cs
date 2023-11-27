using EComersObjectLib.Objects;
using EComersObjectLib.SapObjects;

namespace AdminPanelBlazor.Interfaces
{
    public interface IAccountingDetail
    {
        Task<List<PercentDeliveryAgent>> GetPercentDetailsAgent(string fromDate, string toDate, string code);
        Task<List<PercentDeliveryAgent>> GetPercentDetailsDelivery(string fromDate, string toDate, string code);
        Task<List<PercentDeliveryAgent>> GetPercentDetailsSupervisor(string fromDate, string toDate, string code);
        Task<List<RDR1>> GetInvoiceItem(int docEntry);
    }
}
