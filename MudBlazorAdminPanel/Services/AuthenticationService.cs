using MudBlazorAdminPanel.Interfaces;
using EComersObjectLib;
using EComersWebApiEmploe.AditionalModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Newtonsoft.Json;
using System.Net;
using System.Security.Claims;
using System.Text;
using MudBlazorAdminPanel.Models;
using System.Net.Http;

namespace MudBlazorAdminPanel.Services
{
    public class AuthenticationService : IAuthenticationCustom
    {
        private readonly IHttpContextAccessor _accessor;
        private readonly HttpClient _httpClient;
        private CurrentUser _currentUser;

        public AuthenticationService (IHttpContextAccessor accessor, HttpClient httpClient)
        {
            _accessor = accessor;
            _httpClient = httpClient;
        }

        public async Task<CurrentUser> CurrentUserInfo()
        {
            return _currentUser ?? new CurrentUser() { IsAuthenticated = false} ;
        }

        public async Task Login(string login, string password)
        {
            AuthenticationParams authenticationParams = new AuthenticationParams()
            {
                Login = login,
                Password = password
            };

            HttpContent body = new StringContent(JsonConvert.SerializeObject(authenticationParams), Encoding.UTF8, "application/json");

            var result = await _httpClient.PostAsync("http://192.168.0.141:5093/Authentication/loginadminpanel", body);

            if (result.StatusCode == HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            var apiResponse = await result.Content.ReadAsStringAsync();
            _currentUser = new CurrentUser() { IsAuthenticated = true, User = JsonConvert.DeserializeObject<User>(apiResponse) };
            result.EnsureSuccessStatusCode();
        }

        public async Task Logout()
        {

            var result = await _httpClient.PostAsync("http://192.168.0.141:5093/Authentication/logout", null);

            if (_currentUser != null)
            {
                _currentUser.IsAuthenticated = false;
            }
            result.EnsureSuccessStatusCode();
        }
    }
}
