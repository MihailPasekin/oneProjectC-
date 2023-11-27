using EComersObjectLib.Objects;

namespace MudBlazorAdminPanel.Interfaces
{
    public interface IWarehouse
    {
        public Task<List<LoadingReport>> GetLoadingReport(string docDate, string empID);       
    }
}
