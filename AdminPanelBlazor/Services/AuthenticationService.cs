using AdminPanelBlazor.Interfaces;
using EComersObjectLib;
using EComersWebApiEmploe.AditionalModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Newtonsoft.Json;
using System.Net;
using System.Security.Claims;
using System.Text;
using AdminPanelBlazor.Pages;

namespace AdminPanelBlazor.Services
{
    public class AuthenticationService : IAuthenticationCustom
    {

        private readonly HttpClient httpClient;

        public event Action<ClaimsPrincipal>? UserChanged;
        private ClaimsPrincipal? currentUser;

        public ClaimsPrincipal CurrentUser
        {
            get { return currentUser ?? new(); }
            set
            {
                currentUser = value;

                if (UserChanged is not null)
                {
                    UserChanged(currentUser);
                }
            }
        }
        

        public AuthenticationService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> TryAuthenticateUserAsync(string login, string password)
        {
            string apiResponse;
            string errorMessage = "0";

            if (login == string.Empty || password == string.Empty)
            {
                errorMessage = "login и/или пароль не установлены";
                return errorMessage;
            }
                
            AuthenticationParams authenticationParams = new AuthenticationParams()
            {
                Login = login,
                Password = password
            };

            HttpContent body = new StringContent(JsonConvert.SerializeObject(authenticationParams), Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await httpClient.PostAsync($"http://192.168.0.141:5093/Authentication/loginadminpanel/", body))
            {
                apiResponse = await response.Content.ReadAsStringAsync();
                User? dbuser = JsonConvert.DeserializeObject<User>(apiResponse);

                if (dbuser != null)
                {
                            
                    var claims = new List<Claim> 
                    { 
                        new Claim(ClaimTypes.Name, string.Concat(dbuser.Name, " ", dbuser.SecondName??"") ?? ""), 
                        new Claim("Login", dbuser.Login ?? ""), 
                        new Claim(ClaimTypes.Role, dbuser.Role.Cod), 
                        new Claim("CashAccount", dbuser.CashAccount ?? ""),
                        new Claim("Region", dbuser.Region ?? "")
                    };

                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Cookies");

                    CurrentUser = new ClaimsPrincipal(claimsIdentity);
                    var properties = new AuthenticationProperties();

                    return "ok";
            }
                else
                {
                    apiResponse = await response.Content.ReadAsStringAsync();
                    errorMessage = apiResponse;
                    return errorMessage;
                }
            }
           
            return errorMessage;
        }

    }
}
