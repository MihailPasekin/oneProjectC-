using AdminPanelBlazor.Interfaces;
using AdminPanelBlazor.Models;
using Newtonsoft.Json;
using EComersObjectLib.Objects;
using System.Net.Http;
using EComersObjectLib.SapObjects;
using System.Text;

namespace AdminPanelBlazor.Services
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
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<LoadingReport>>(apiResponse) ?? new List<LoadingReport>();
            }
        }
        public async Task<List<ForwarderDocList>> GetsForwarderDocList(string docDate, string empID)
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Warehouse/getsapforwarderdocs?docDate={docDate}&empID={empID}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<ForwarderDocList>>(apiResponse) ?? new List<ForwarderDocList>();
            }
        }
        public async Task<List<WarehousesSapGet>> GetWarehousessap()
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Warehouse/getwarehousessap"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<WarehousesSapGet>>(apiResponse) ?? new List<WarehousesSapGet>();
            }
        }

        public async Task<List<SqlProductGroup>> GetProductGroup()
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Warehouse/getproductgroupsap"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<SqlProductGroup>>(apiResponse) ?? new List<SqlProductGroup>();
            }
        }
      
        public async Task<List<WarehouseWithdrawal>> GetWarehouseWithdrawal(string? stock, string? idProductGroup, string? listgroupprodukt)
        {                                                                     
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Warehouse/getwarehousewithdrawal?stock={stock}&idProductGroup={idProductGroup}&response={listgroupprodukt}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<WarehouseWithdrawal>>(apiResponse) ?? new List<WarehouseWithdrawal>();
            }
        }
        public async Task<List<ProductGroupsPropertiesSql>> GetProductGroupsPropertiesSql()
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Warehouse/getproductgroupsproperties"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<ProductGroupsPropertiesSql>>(apiResponse) ?? new List<ProductGroupsPropertiesSql>();
            }
        }
        public async Task<List<DeliveryForReport>> GetDeliveryForReport()
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Warehouse/getdeliveryforreportsql"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<DeliveryForReport>>(apiResponse) ?? new List<DeliveryForReport>();
            }
        }

        public async Task<List<DeliveryForReport>> GetDeliveryForReportByRegion(string region)
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Warehouse/getdeliveryreportbyregion?region={region}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<DeliveryForReport>>(apiResponse) ?? new List<DeliveryForReport>();
            }
        }
    }
}
