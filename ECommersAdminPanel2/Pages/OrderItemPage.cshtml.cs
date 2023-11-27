using EComersObjectLib.SapObjects;
using ECommersAdminPanel2.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace ECommersAdminPanel2.Pages
{
    public class OrderItemPageModel : PageModel
    {
        public List<RDR1> ListRdr { get; set; } = new List<RDR1>();
        public void OnGet(int id)
        {
            ListRdr = GetSapOrderLines(id).Result;
        }
        private async Task<List<RDR1>> GetSapOrderLines(int docEntry)
        {
            List<RDR1> tempRdrList = new List<RDR1>();
            using (var httpClient = new HttpClient())
            {
                using (HttpResponseMessage response = await httpClient.GetAsync(string.Concat(ApiOptions.GetServerIpAddress(), $"/api/saporder/getsaporderlines?docEntry={docEntry}")))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();

                    tempRdrList = JsonConvert.DeserializeObject<List<RDR1>>(apiResponse) ?? new List<RDR1>();
                }
            }
            return tempRdrList;
        }
    }
}
