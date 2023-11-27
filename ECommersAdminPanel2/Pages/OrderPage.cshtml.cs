using EComersObjectLib.Objects;
using EComersObjectLib;
using EComersObjectLib.SapObjects;
using ECommersAdminPanel2.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace ECommersAdminPanel2.Pages
{
    [IgnoreAntiforgeryToken]
    public class OrderPageModel : PageModel
    {
        public List<ORDR> Orders { get; set; } = new ();
      
        public void OnGet()
        {
            Orders = GetSapOrders().Result;
        }

        private async Task<List<ORDR>> GetSapOrders()
        {
            List<ORDR> tempOrderList = new List<ORDR> ();
            using (var httpClient = new HttpClient())
            {
                using (HttpResponseMessage response = await httpClient.GetAsync(string.Concat(ApiOptions.GetServerIpAddress(), $"/api/saporder/getallopensaporder")))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    tempOrderList = JsonConvert.DeserializeObject<List<ORDR>>(apiResponse) ?? new List<ORDR>();
                }
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
                    using (HttpResponseMessage response = await httpClient.PostAsync(string.Concat(ApiOptions.GetServerIpAddress(), "/api/Delivery/createdelivery"), body))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                    }
                    
                    using (HttpResponseMessage response = await httpClient.GetAsync(string.Concat(ApiOptions.GetServerIpAddress(), $"/api/saporder/getallopensaporder")))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();

                        Orders = JsonConvert.DeserializeObject<List<ORDR>>(apiResponse) ?? new List<ORDR>();
                    }
                }
            }
        }
        public async Task<IActionResult> OnPostDocEntry(int docEntry)
        {
            return RedirectToPage("./OrderItemPage/", new { id = docEntry });
        }
    }
}
