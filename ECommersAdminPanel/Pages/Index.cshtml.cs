using EComersObjectLib.Objects;
using EComersObjectLib.SapObjects;
using EComersWebApiEmploe.AditionalModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Security.AccessControl;
using System.Text;

namespace ECommersAdminPanel.Pages
{
    //[Authorize]
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<OINV> Invoicelist { get; set; }


        public List<OINV> SelectedListOINV { get; set; } = new List<OINV>();
        [BindProperty]
        public string EmpId { get; set; }

       
        public void OnGet()
        {
           
        }

        public async Task OnPostCreatePay()
        {
            List<OINV> selectedlist = Invoicelist.Where(p => p.Confirm == true).ToList();
            foreach (var invoice in selectedlist)
            {
                HttpContent body = new StringContent(JsonConvert.SerializeObject(invoice), Encoding.UTF8, "application/json");
                
                using (var httpClient = new HttpClient())
                {
                    using (HttpResponseMessage response = await httpClient.PostAsync("http://192.168.0.70:5093/api/Invoice/createpayment", body))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                    }
                }
            }
            foreach(OINV item in selectedlist)
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
                            using (HttpResponseMessage response = await httpClient.GetAsync($"http://192.168.0.70:5093/api/Invoice/getinvoicebyexpeditor?uAgent={EmpId}"))
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
