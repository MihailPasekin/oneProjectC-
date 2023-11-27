using AdminPanelBlazor.Interfaces;
using EComersObjectLib.Objects;
using EComersObjectLib.SapObjects;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdminPanelBlazor.Services
{
    public class AccountingDetailService: IAccountingDetail
    {
        private readonly HttpClient httpClient;

        public AccountingDetailService (HttpClient client)
        {
            httpClient = client;
        }

        public async Task<List<RDR1>> GetInvoiceItem(int docEntry)
        {
            List<RDR1> tempRdrList = new List<RDR1>();

            using (HttpResponseMessage response = await httpClient.GetAsync(string.Concat($"/api/Invoice/getsapinvoicelines?docEntry={docEntry}")))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                tempRdrList = JsonConvert.DeserializeObject<List<RDR1>>(apiResponse) ?? new List<RDR1>();
            }

            return tempRdrList;
        }

        public async Task<List<PercentDeliveryAgent>> GetPercentDetailsAgent(string fromDate, string toDate, string code)
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Accounting/getpercentdetailsagent?fromDate={fromDate}&toDate={toDate}&code={code}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<PercentDeliveryAgent>>(apiResponse) ?? new List<PercentDeliveryAgent>();
            }
        }

        public async Task<List<PercentDeliveryAgent>> GetPercentDetailsDelivery(string fromDate, string toDate, string code)
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Accounting/getpercentdetailsdeliver?fromDate={fromDate}&toDate={toDate}&code={code}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<PercentDeliveryAgent>>(apiResponse) ?? new List<PercentDeliveryAgent>();
            }
        }

        public async Task<List<PercentDeliveryAgent>> GetPercentDetailsSupervisor(string fromDate, string toDate, string code)
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Accounting/getpercentdetailssupervisor?fromDate={fromDate}&toDate={toDate}&code={code}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<PercentDeliveryAgent>>(apiResponse) ?? new List<PercentDeliveryAgent>();
            }
        }
    }
}
