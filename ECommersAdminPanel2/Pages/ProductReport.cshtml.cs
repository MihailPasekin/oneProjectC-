using EComersObjectLib;
using EComersObjectLib.Objects;
using ECommersAdminPanel2.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace ECommersAdminPanel2.Pages
{
    public class ProductReportModel : PageModel
    {
        [BindProperty]
        public List<MerchProductSoldStat> SoldStat { get; set; } = new List<MerchProductSoldStat>();

        public async Task OnGet(int id)
        {
            SoldStat.Clear();
                
            if (id > 0)
            {
                using (var httpClient = new HttpClient())
                {
                    using (HttpResponseMessage response = await httpClient.GetAsync(string.Concat(ApiOptions.GetServerIpAddress(), $"/api/Merch/getmerchproductsoldstat?visitId={id}")))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        SoldStat = JsonConvert.DeserializeObject<List<MerchProductSoldStat>>(apiResponse) ?? new List<MerchProductSoldStat>();

                    }
                }
            }
        }
    }
}
