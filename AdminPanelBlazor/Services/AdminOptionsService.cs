using AdminPanelBlazor.Interfaces;
using EcomersCryptoLib;
using EComersObjectLib;
using Newtonsoft.Json;
using System.Text;

namespace AdminPanelBlazor.Services
{
    public class AdminOptionsService : IAdminOptions
    {
        private readonly HttpClient httpClient;


        public AdminOptionsService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> CreateUser(User user)
        {
           user.PasswordHash = EcomersCrypto.GetHashPassword(user.PasswordHash);
            HttpContent body = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await httpClient.PostAsync("http://192.168.0.141:5093/api/User/createuser", body))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                return apiResponse;
            }
            
        }
    }
}
