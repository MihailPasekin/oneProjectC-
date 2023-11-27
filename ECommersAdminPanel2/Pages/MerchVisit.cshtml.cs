using EComersObjectLib.Objects;
using EComersObjectLib.SapObjects;
using ECommersAdminPanel2.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace ECommersAdminPanel2.Pages
{
    public class MerchVisitModel : PageModel
    {
        [BindProperty]
        public List<MerchVisit> MerchVisits { get; set; } = new List<MerchVisit>();
        
        [BindProperty]
        public string EmpId { get; set; }

        

        public void OnGet()
        {
            MerchVisits = GetAllMerchVisits().Result;
        }

        private async Task<List<MerchVisit>> GetAllMerchVisits()
        {
            List<MerchVisit> tempMerchVisitList = new List<MerchVisit>();
            using (var httpClient = new HttpClient())
            {
                using (HttpResponseMessage response = await httpClient.GetAsync(string.Concat(ApiOptions.GetServerIpAddress(), $"/api/merch/getallmerchvisit")))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    tempMerchVisitList = JsonConvert.DeserializeObject<List<MerchVisit>>(apiResponse) ?? new List<MerchVisit>();
                }
            }
            return tempMerchVisitList;
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
                            using (HttpResponseMessage response = await httpClient.GetAsync(string.Concat(ApiOptions.GetServerIpAddress(), $"/api/Merch/getmerchvisitbyempid?empId={EmpId}")))
                            {
                                string apiResponse = await response.Content.ReadAsStringAsync();
                                MerchVisits = JsonConvert.DeserializeObject<List<MerchVisit>>(apiResponse) ?? new List<MerchVisit>();
                            }
                        }
                    }
                }
            }
        }
        
        public async Task<IActionResult> OnPostVisitId(int visitId)
        {
            return RedirectToPage("./ProductReport/", new { id = visitId });
        }
    }
}
