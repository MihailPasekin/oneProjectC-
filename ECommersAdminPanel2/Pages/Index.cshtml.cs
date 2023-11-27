using EComersObjectLib.Objects;
using EComersObjectLib.SapObjects;
using EComersWebApiEmploe.AditionalModels;
using ECommersAdminPanel2.Options;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Security.AccessControl;
using System.Text;

namespace ECommersAdminPanel2.Pages
{
    //[Authorize]
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<OINV> Invoicelist { get; set; } = new List<OINV>();
        [BindProperty]
        public OHEM Employe { get; set; } = new OHEM();
        [BindProperty]
        public List<EmployeRoot> EmployeRoots { get; set; } = new List<EmployeRoot>();

        public List<OINV> SelectedListOINV { get; set; } = new List<OINV>();
        [BindProperty]
        public string EmpId { get; set; }
        [BindProperty]
        public string EmployeName { get; set; }
        [BindProperty]
        public string Root { get; set; }

        /*
        [BindProperty]
        public double SelectedSum { get { return Invoicelist.Where(p=>p.Confirm == true).Sum(p=>p.DocTotal); } set { } }
        */

        public void OnGet()
        {
            //SelectedSum = Invoicelist.Where(p => p.Confirm == true).Sum(p => p.PaySum);
        }
        public void OnPostCountPay()
        {
           
        }
       
        public async Task OnPostCreatePay(int empId)
        {
            //SelectedSum = Invoicelist.Where(p => p.Confirm == true).Sum(p => p.PaySum);
            List<OINV> selectedlist = Invoicelist.Where(p => p.Confirm == true).ToList();
            foreach (var invoice in selectedlist)
            {
                HttpContent body = new StringContent(JsonConvert.SerializeObject(invoice), Encoding.UTF8, "application/json");
                
                using (var httpClient = new HttpClient())
                {
                    using (HttpResponseMessage response = await httpClient.GetAsync(string.Concat(ApiOptions.GetServerIpAddress(), $"/api/SapEmploye/getsapemployebycode?code={empId}")))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        Employe = JsonConvert.DeserializeObject<OHEM>(apiResponse) ?? new OHEM();

                    }
                    using (HttpResponseMessage response = await httpClient.GetAsync(string.Concat(ApiOptions.GetServerIpAddress(), $"/api/SapEmploye/getsapemployrootebycode?code={empId}")))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        EmployeRoots = JsonConvert.DeserializeObject<List<EmployeRoot>>(apiResponse) ?? new List<EmployeRoot>();

                    }
#if DEBUG
                    Console.WriteLine(JsonConvert.SerializeObject(invoice));
#else
                    using (HttpResponseMessage response = await httpClient.PostAsync(string.Concat(ApiOptions.GetServerIpAddress(),"/api/Invoice/createpayment"), body))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                    }
#endif
                }
            }
            
            foreach (OINV item in selectedlist)
            {
                Invoicelist.Remove(item);
            }
        }

        public async Task OnPostByEmpId(string employeId)
        {
            EmpId = employeId;

            if (EmpId != string.Empty)
            {
                if (int.TryParse(EmpId, out int id))
                {
                    if (id > 0)
                    {
                        using (var httpClient = new HttpClient())
                        {
                            using (HttpResponseMessage response = await httpClient.GetAsync(string.Concat(ApiOptions.GetServerIpAddress(), $"/api/SapEmploye/getsapemployebycode?code={EmpId}")))
                            {
                                string apiResponse = await response.Content.ReadAsStringAsync();
                                Employe = JsonConvert.DeserializeObject<OHEM>(apiResponse) ?? new OHEM();

                            }
                            using (HttpResponseMessage response = await httpClient.GetAsync(string.Concat(ApiOptions.GetServerIpAddress(), $"/api/SapEmploye/getsapemployrootebycode?code={EmpId}")))
                            {
                                string apiResponse = await response.Content.ReadAsStringAsync();
                                EmployeRoots = JsonConvert.DeserializeObject<List<EmployeRoot>>(apiResponse) ?? new List<EmployeRoot>();

                            }
                            using (HttpResponseMessage response = await httpClient.GetAsync(string.Concat(ApiOptions.GetServerIpAddress(), $"/api/Invoice/getinvoicebyexpeditor?uAgent={EmpId}")))
                            {
                                string apiResponse = await response.Content.ReadAsStringAsync();
                                Invoicelist = JsonConvert.DeserializeObject<List<OINV>>(apiResponse) ?? new List<OINV>();
                            }
                        }
                    }
                }
            }
        }
    }
}
