using MudBlazorAdminPanel.Interfaces;
using MudBlazorAdminPanel.Models;
using EComersObjectLib;
using EComersObjectLib.Objects;
using EComersObjectLib.SapObjects;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MudBlazorAdminPanel.Services
{
    public class OinvService : PageModel, IOinvService
    {
        private readonly HttpClient httpClient;
        private OHEM Employe;
        private List<EmployeRoot> EmployeRoots;

        public OinvService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> GetEmployeName(string empID)
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/SapEmploye/getsapemployebycode?code={empID}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                Employe = JsonConvert.DeserializeObject<OHEM>(apiResponse) ?? new OHEM();
                return $"{Employe.firstName} {Employe.lastName}";
            }
        }

        public async Task<string> GetEmployeRoot(string empID)
        {
            string employeRoots = "";
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/SapEmploye/getsapemployrootebycode?code={empID}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                EmployeRoots = JsonConvert.DeserializeObject<List<EmployeRoot>>(apiResponse) ?? new List<EmployeRoot>();
                foreach (var element in EmployeRoots)
                {
                    employeRoots += element.Root + " ";
                }
                return employeRoots;
            }

        }

        public async Task PostCreatePay(List<OINV> listOinv)
        {
            foreach (var invoice in listOinv)
            {
                HttpContent body = new StringContent(JsonConvert.SerializeObject(invoice), Encoding.UTF8, "application/json");

                using (var httpClient = new HttpClient())
                {

                    using (HttpResponseMessage response = await httpClient.PostAsync($"http://192.168.0.141:5093/api/Invoice/createpayment", body))

                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                    }
                }
            }
        }


        public async Task<ListOINV> GetInvoices()
        {
            using (HttpResponseMessage response = await httpClient.GetAsync("/api/Invoice/getinvoicebyexpeditor?uAgent=885"))
            {
                ListOINV listOINV = new ListOINV();
                string apiResponse = await response.Content.ReadAsStringAsync();
                listOINV.ListOinvs = JsonConvert.DeserializeObject<List<OINV>>(apiResponse) ?? new List<OINV>(); ;
                return listOINV;
            }
        }
        public async Task<ListOINV> GetInvoices(string empID)
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Invoice/getinvoicebyexpeditor?uAgent={empID}"))
            {
                ListOINV listOINV = new ListOINV();
                string apiResponse = await response.Content.ReadAsStringAsync();
                listOINV.ListOinvs = JsonConvert.DeserializeObject<List<OINV>>(apiResponse) ?? new List<OINV>(); ;
                return listOINV;
            }

        }
    

        private string EmpId;
        private List<MerchVisit> MerchVisits;

        public async Task<List<MerchVisit>> GetAllMerchVisits()
        {
            List<MerchVisit> TempMerchVisitList = new List<MerchVisit>();
            using (var httpClient = new HttpClient())
            {



                using (HttpResponseMessage response = await httpClient.GetAsync("http://192.168.0.141:5093/api/merch/getallmerchvisit"))

                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    TempMerchVisitList = JsonConvert.DeserializeObject<List<MerchVisit>>(apiResponse) ?? new List<MerchVisit>();
                }
            }
            return TempMerchVisitList;
        }

        public async Task<List<MerchVisit>> GetAllMerchVisits(string employeId)
        {
            EmpId = employeId;
            if (EmpId != string.Empty)
            {
                if (int.TryParse(EmpId, out int id))
                {
                    if (id > 0)
                    {

                        using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Merch/getmerchvisitbyempid?empId={EmpId}"))

                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            MerchVisits = JsonConvert.DeserializeObject<List<MerchVisit>>(apiResponse) ?? new List<MerchVisit>();
                            return MerchVisits;
                        }
                    }
                }

            }
            return MerchVisits;
        }
        
        private List<MerchProductSoldStat> SoldStat;
        public async Task<List<MerchProductSoldStat>> GetMerchReport(int id)
        {
            {
                

                using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Merch/getmerchproductsoldstat?visitId={id}"))

                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    SoldStat = JsonConvert.DeserializeObject<List<MerchProductSoldStat>>(apiResponse) ?? new List<MerchProductSoldStat>();
                }
            }
            return SoldStat;
        }

        public async Task<List<ORDR>> GetSapOrders()
        {
            List<ORDR> tempOrderList;

            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/saporder/getallopensaporder"))

            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                tempOrderList = JsonConvert.DeserializeObject <List<ORDR>> (apiResponse) ?? new List<ORDR>();
            }
            return tempOrderList;
        }

        public async Task OnPostCreateDelivery(List<int> selectedOrders)
        {
            foreach (int orderId in selectedOrders)
            {
                Console.WriteLine(orderId);
                using (var httpClient = new HttpClient())
                {
                    HttpContent body = new StringContent(JsonConvert.SerializeObject(orderId), Encoding.UTF8, "application/json");

                    using (HttpResponseMessage response = await httpClient.PostAsync("/api/Delivery/createdelivery", body))

                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                    }
                   
                }
            }
        }

        public async Task<List<RDR1>> GetSapOrderLines(int docEntry)
        {
            List<RDR1> tempRdrList = new List<RDR1>();
            
            using (HttpResponseMessage response = await httpClient.GetAsync(string.Concat($"/api/saporder/getsaporderlines?docEntry={docEntry}")))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                tempRdrList = JsonConvert.DeserializeObject<List<RDR1>>(apiResponse) ?? new List<RDR1>();
            }
            
            return tempRdrList;
        }


        public async Task<List<MerchPlan>>  MerchPlansAll()
        {
            List<MerchPlan> merchPlansAll = new List<MerchPlan>();
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/MerchPlan/getallmerchplans"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                merchPlansAll = JsonConvert.DeserializeObject<List<MerchPlan>>(apiResponse) ?? new List<MerchPlan>();
            }
            return merchPlansAll;
        }
        public async Task PostAllMerchPlan(MerchPlan merchPlan)
        {
            HttpContent body = new StringContent(JsonConvert.SerializeObject(merchPlan), Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = await httpClient.PostAsync("/api/MerchPlan/postmerchplan", body))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
            }
        }

        public async Task<List<Customer>> GetAllCustomers(string empId)
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/Customer/getsapcustomersbyemp?empId={empId}"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<Customer>>(apiResponse) ?? new List<Customer>();
            }
        }

        public async Task<List<EmployeView>> GetAllEmployesAsync()
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"https://192.168.0.141:7093/employe/getemployes"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<EmployeView>>(apiResponse) ?? new List<EmployeView>();
            }
        }

        public async Task<List<PlanReport>> GetAllPlanReportAsync() 
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/MerchPlan/getallplanreport"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<PlanReport>>(apiResponse) ?? new List<PlanReport>();
            }
        }

        public async Task<List<OHEM>> GetAllEmployesEkspeditorAsync()
        {
            using (HttpResponseMessage response = await httpClient.GetAsync($"/api/SapEmploye/getsapemployesbyjobtitle?jobTitle=Sürüji ekspeditor"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<List<OHEM>>(apiResponse) ?? new List<OHEM>();
            }
        }
    }
}

