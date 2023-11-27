using AdminPanelBlazor.Interfaces;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.VariantTypes;
using EComersObjectLib;
using EComersObjectLib.Objects;
using EComersObjectLib.SapObjects;
using Newtonsoft.Json;
using System.Net.Http;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdminPanelBlazor.Services
{
    public class AccountingService: IAccounting
    {
        private readonly HttpClient httpClient;
       

        public AccountingService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<DaylyReportKassa> GetDaylyKassaReport(string fromDate, string toDate, string kassa)
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Accounting/getdaylykassareport?fromDate={fromDate}&toDate={toDate}&kassa={kassa}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<DaylyReportKassa>(apiResponse) ?? new DaylyReportKassa();
            }
        }

        public async Task<List<CashAccount>> GetListCashAccount()
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Accounting/getlistcashaccounts"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<CashAccount>>(apiResponse) ?? new List<CashAccount>();
            }
        }

        public async Task<List<ErrorOrct>> GetListErrorOrctsAsync()
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Accounting/geterrorpayments"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<ErrorOrct>>(apiResponse) ?? new List<ErrorOrct>();
            }
        }

        public async Task<List<OkReportLines>> GetOkReportListAsync(string fromDate, string toDate)
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Accounting/getokreportlist?fromDate={fromDate}&toDate={toDate}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<OkReportLines>>(apiResponse) ?? new List<OkReportLines>();
            }
        }
                                
        public async Task<List<OkReportDetals>> GetOkReportDetailsAsync(string fromDate)
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Accounting/getokreportdetails?fromDate={fromDate}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<OkReportDetals>>(apiResponse) ?? new List<OkReportDetals>();
            }
        }

        public async Task<List<CreditReportLines>> GetCerditReportListAsync(string fromDate, string toDate, string root)
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Accounting/getcreditreportlist?fromDate={fromDate}&toDate={toDate}&root={root}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<CreditReportLines>>(apiResponse) ?? new List<CreditReportLines>();
            }
        }

        public async Task<List<URouteID>> GetURouteIDAsync(string region)
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Accounting/geturouteid?region={region}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<URouteID>>(apiResponse) ?? new List<URouteID>();
            }
        }
        public async Task<List<List<Percent>>> GetPercentAsync(string fromDate, string toDate )
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Accounting/getpercent?fromDate={fromDate}&toDate={toDate}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<List<Percent>>>(apiResponse) ?? new List<List<Percent>>();
            }
        }

        public async Task<List<Сonsignment>> GetСonsignmentAsync(string fromDate, string toDate, string vendorCode)
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Accounting/getconsignment?fromDate={fromDate}&toDate={toDate}&code={vendorCode}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<Сonsignment>>(apiResponse) ?? new List<Сonsignment>();
            }
        }

        public async Task<List<PrepaymentReport>> GetPrepaymentReportAsync(string fromDate, string toDate)
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Accounting/prepaymentrepor?fromDate={fromDate}&toDate={toDate}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<PrepaymentReport>>(apiResponse) ?? new List<PrepaymentReport>();
            }
        }

        public async Task<List<ConsigmentClient>> GetConsigmentClientsAsync()
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Accounting/consigmentclient"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<ConsigmentClient>>(apiResponse) ?? new List<ConsigmentClient>();
            }
        }
    }
}
