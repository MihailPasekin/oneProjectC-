using MudBlazorAdminPanel.Interfaces;
using MudBlazorAdminPanel.Models;
using Newtonsoft.Json;
using EComersObjectLib.Objects;
using System.Net.Http;
using EComersObjectLib.SapObjects;
using System.Text;

namespace MudBlazorAdminPanel.Services
{
    public class WarehouseService : IWarehouse
    {
        private readonly HttpClient httpClient;

        public WarehouseService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<LoadingReport>> GetLoadingReport(string docDate, string empID)
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Warehouse/getsaploadingitems?docDate={docDate}&empID={empID}"))
            {
                List<LoadingReport> loadingReport = new List<LoadingReport>();
                string apiResponse = await response.Content.ReadAsStringAsync();
                loadingReport = JsonConvert.DeserializeObject<List<LoadingReport>>(apiResponse) ?? new List<LoadingReport>(); ;
                return loadingReport;
            }
        }

    }
}