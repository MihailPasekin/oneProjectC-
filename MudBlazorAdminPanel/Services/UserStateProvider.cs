using EComersObjectLib;
using EComersWebApiEmploe.AditionalModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Authentication;
using MudBlazorAdminPanel.Interfaces;
using MudBlazorAdminPanel.Models;
using Newtonsoft.Json;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;


namespace MudBlazorAdminPanel.Services
{
    public class UserStateProvider : AuthenticationStateProvider
    {
        private readonly IAuthenticationCustom api;
        private CurrentUser user;
        public UserStateProvider(IAuthenticationCustom api)
        {
            this.api = api;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            try
            {
                var userInfo = await GetCurrentUser();
                if (userInfo.IsAuthenticated)
                {
                    var claims = new[] { new Claim(ClaimTypes.Name, user.User.Name), new Claim(ClaimTypes.Role, user.User.RoleId.ToString()) };
                    identity = new ClaimsIdentity(claims, "Server authentication");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("Request failed:" + ex.ToString());
            }

            return new AuthenticationState(new ClaimsPrincipal(identity));
            /*
            string apiResponse;
            string errorMessage = "0";

            if (login == string.Empty || password == string.Empty)
            {
                errorMessage = "login и/или пароль не установлены";
                return new User();
            }

            AuthenticationParams authenticationParams = new AuthenticationParams()
            {
                Login = login,
                Password = password
            };

            HttpContent body = new StringContent(JsonConvert.SerializeObject(authenticationParams), Encoding.UTF8, "application/json");

            using (var httpClient = new HttpClient())
            {


                using (HttpResponseMessage response = await httpClient.PostAsync("http://192.168.0.141:5093/Authentication/loginadminpanel", body))

                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        apiResponse = await response.Content.ReadAsStringAsync();
                        User? dbuser = JsonConvert.DeserializeObject<User>(apiResponse);

                        if (dbuser != null)
                        {
                            /*
                            var claims = new List<Claim> { new Claim(ClaimTypes.Name, string.Concat(dbuser.Name, " ", dbuser.SecondName) ?? ""), new Claim("Login", dbuser.Login ?? "") };

                            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Cookies");

                            var properties = new AuthenticationProperties();
                            */


            //await _accessor.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), properties);
            /*
            return dbuser;
        }
    }
    else
    {
        apiResponse = await response.Content.ReadAsStringAsync();
        errorMessage = apiResponse;
        return new User();
    }
}
}
return new User();
*/
        }

        private async Task<CurrentUser> GetCurrentUser()
        {
            if (user != null && user.IsAuthenticated) return user;
            user = await api.CurrentUserInfo();
            return user;
        }
        public async Task Logout()
        {
            await api.Logout();
            user = null;
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        public async Task Login(string login, string password )
        {
            await api.Login(login, password);
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
    }
}
